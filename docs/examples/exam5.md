# Ví dụ: Leaderboard tự định nghĩa — event tuần / season pass (ngoài SDK statistics)

Tính năng: bảng xếp hạng theo "kỳ" (mỗi tuần, mỗi season) mà SDK statistics leaderboard không phủ — score reset theo kỳ, mỗi kỳ là 1 bảng riêng, giữ điểm cao nhất, query top N + rank của chính user. Toàn bộ persistence nằm trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; rank tính bằng `countDocuments` trên index `score`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Leaderboard.Scores", gameId)`
- Full name (index): `"Runtime." + gameId + ".Leaderboard.Scores"`

Document shape (1 doc / (board, user)):

```ts
type LeaderboardScore = {
    boardId: string;       // id của kỳ, vd "weekly:2832" — server tự tính, KHÔNG nhận từ client
    userId: string;        // context.userId
    displayName: string;   // snapshot tên lúc submit, để render bảng không cần join
    score: number;         // điểm cao nhất trong kỳ
    tsUpdate: number;      // Date.now() lần cập nhật score gần nhất
};
```

Index:

- `{ boardId: 1, userId: 1 }` **unique** — 1 doc cho 1 user/kỳ, cho upsert an toàn.
- `{ boardId: 1, score: -1 }` — sort top N + đếm rank.

Constants — `boardId` của kỳ tuần được tính từ epoch cố định:

- `LB_EPOCH_MS` = mốc 0 (vd `1704067200000` = 2024-01-01 UTC).
- `LB_PERIOD_MS` = `7 * 24 * 60 * 60 * 1000` (1 tuần). Đổi sang season thì chỉnh hằng số này.
- `boardId = "weekly:" + Math.floor((Date.now() - LB_EPOCH_MS) / LB_PERIOD_MS)`.

> Vì sao kỳ do server tính, không nhận từ client: nếu client truyền `boardId` thì user có thể submit vào kỳ cũ/kỳ tương lai để farm hạng. Server tính từ `Date.now()` → mọi submit luôn rơi đúng kỳ hiện tại.

---

## 2. Script TypeScript

```ts
const LB_COLLECTION = "Leaderboard.Scores";
const LB_EPOCH_MS = 1704067200000;            // 2024-01-01T00:00:00Z
const LB_PERIOD_MS = 7 * 24 * 60 * 60 * 1000; // 1 tuần / kỳ
const LB_TOP_DEFAULT = 50;
const LB_TOP_MAX = 200;

const requireNumber = (value: unknown, fieldName: string): number => {
    if (typeof value !== "number" || !isFinite(value)) {
        throw new Error(fieldName + " must be a finite number");
    }
    return value;
};

// boardId kỳ hiện tại — luôn tính server-side
const currentBoardId = (now: number): string => {
    return "weekly:" + Math.floor((now - LB_EPOCH_MS) / LB_PERIOD_MS);
};

handlers["lbSubmitScore"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const score = requireNumber(args?.score, "score");
    if (score < 0) {
        throw new Error("score_negative");
    }

    const now = Date.now();
    const boardId = currentBoardId(now);
    const collection = database.runtimeGameCollection(LB_COLLECTION, gameId);

    // displayName snapshot từ GamePlayer — render bảng không cần join lại
    const gamePlayer = await database.gamePlayerRepository.loadGamePlayerAsync(userId, gameId);
    const displayName = gamePlayer?.getDisplayName() ?? userId;

    // Chỉ ghi đè khi điểm mới cao hơn: $max giữ score đỉnh, $set cập nhật phần còn lại.
    const updateResult = await collection.updateOne(
        { boardId: boardId, userId: userId },
        {
            $max: { score: score },
            $set: { boardId: boardId, userId: userId, displayName: displayName, tsUpdate: now },
            $setOnInsert: {},
        },
        { upsert: true },
    );

    const doc = await collection.findOne({ boardId: boardId, userId: userId }, { projection: { _id: 0 } });
    const bestScore = doc?.score ?? score;

    // Rank = số doc cùng board có score CAO HƠN, + 1.
    const higher = await collection.countDocuments({ boardId: boardId, score: { $gt: bestScore } });

    return {
        boardId: boardId,
        submittedScore: score,
        bestScore: bestScore,
        improved: (updateResult.modifiedCount ?? 0) > 0 || (updateResult.upsertedCount ?? 0) > 0,
        rank: higher + 1,
    };
};

handlers["lbGetTop"] = async (args: Record<string, unknown>, context, log) => {
    const now = Date.now();
    const boardId = currentBoardId(now);
    const collection = database.runtimeGameCollection(LB_COLLECTION, gameId);

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : LB_TOP_DEFAULT;
    const limit = Math.max(1, Math.min(LB_TOP_MAX, limitRaw));

    const docs = await collection
        .find({ boardId: boardId }, { projection: { _id: 0, boardId: 0 } })
        .sort({ score: -1, tsUpdate: 1 }) // tie-break: ai đạt mốc trước xếp trên
        .limit(limit)
        .toArray();

    // Gán rank tuần tự — docs đã sort giảm dần
    const entries = docs.map((d: any, i: number) => ({
        rank: i + 1,
        userId: d.userId,
        displayName: d.displayName,
        score: d.score,
    }));

    return { boardId: boardId, count: entries.length, entries: entries };
};

handlers["lbGetMyRank"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const now = Date.now();
    const boardId = currentBoardId(now);
    const collection = database.runtimeGameCollection(LB_COLLECTION, gameId);

    const doc = await collection.findOne({ boardId: boardId, userId: userId }, { projection: { _id: 0 } });
    if (doc === null) {
        return { boardId: boardId, ranked: false, score: 0, rank: null };
    }

    const higher = await collection.countDocuments({ boardId: boardId, score: { $gt: doc.score } });
    const total = await collection.countDocuments({ boardId: boardId });

    return {
        boardId: boardId,
        ranked: true,
        score: doc.score,
        rank: higher + 1,
        total: total,
    };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initLeaderboard"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + LB_COLLECTION;
    await database.createIndex(fullName, { boardId: 1, userId: 1 }, { unique: true });
    await database.createIndex(fullName, { boardId: 1, score: -1 });
    return { ok: true };
};
```

> Vì sao không dùng SDK statistics leaderboard (`getStatisticsLeaderboardAsync`): statistics leaderboard sống xuyên suốt vòng đời player, không có khái niệm "kỳ" reset hàng tuần. Tách kỳ bằng `boardId` cho phép mỗi tuần/season là bảng độc lập, kỳ cũ vẫn query lại được để trao thưởng. `countDocuments` trên index `{ boardId, score }` cho rank chính xác mà không cần load cả bảng.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = leaderboardScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initLeaderboard` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)).

---

## 4. Unity client

Pattern 3-tier check (`returnCode` → `errorCode` → `ExecuteResponseStatus`) — [guides/CLOUDSCRIPT.md:162-185](/docs/guides/CLOUDSCRIPT.md).

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

private async System.Threading.Tasks.Task<object> ExecuteAsync(string functionName, GNHashtable parameters)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = functionName;
    requestData.functionParameters = parameters;

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);
    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok) throw new System.Exception("execute: " + exec.errorMessage);

    return exec.functionResult;
}

// Submit điểm sau khi kết thúc 1 màn chơi
public System.Threading.Tasks.Task<object> SubmitScoreAsync(long score)
    => ExecuteAsync("lbSubmitScore", GNHashtable.builder().add("score", score).build());

// Lấy top N của kỳ hiện tại
public System.Threading.Tasks.Task<object> GetLeaderboardTopAsync(int limit = 50)
    => ExecuteAsync("lbGetTop", GNHashtable.builder().add("limit", limit).build());

// Lấy rank của chính user
public System.Threading.Tasks.Task<object> GetMyRankAsync()
    => ExecuteAsync("lbGetMyRank", GNHashtable.builder().build());
```

UI flow:

1. Cuối màn chơi → `SubmitScoreAsync(score)` → response cho biết `improved` (có phá kỷ lục kỳ này không) + `rank` mới.
2. Mở screen leaderboard → `GetLeaderboardTopAsync` render danh sách `entries` (mỗi entry có `rank`, `displayName`, `score`).
3. Nếu user không nằm trong top hiển thị → `GetMyRankAsync` render dòng "hạng của bạn" riêng. `ranked = false` nghĩa là user chưa submit kỳ này.

Cast `exec.functionResult` qua `GNHashtable`; `entries` đọc như `IList` các `GNHashtable`.

---

## 5. Cảnh báo

- KHÔNG nhận `boardId` từ client. Kỳ phải do server tính từ `Date.now()`, nếu không user submit vào kỳ tùy ý để farm hạng.
- KHÔNG thay `$max` bằng `$set` cho field `score` — sẽ ghi đè cả khi điểm mới THẤP hơn, mất điểm đỉnh. `$max` chỉ nâng, không hạ.
- `lbSubmitScore` đọc-rồi-đếm KHÔNG atomic tuyệt đối: 2 submit song song của cùng user vẫn an toàn (cùng `$max` upsert, kết quả hội tụ về max), nhưng `rank` trả về có thể lệch 1-2 bậc nếu user khác submit xen giữa. Rank chỉ để hiển thị, đừng dùng để gate phần thưởng tại thời điểm submit.
- Trao thưởng cuối kỳ: chạy 1 handler admin riêng quét `boardId` của kỳ ĐÃ ĐÓNG (`currentBoardId(now) - 1`), KHÔNG trao ngay trong `lbSubmitScore`. Payout currency đi qua `admin.gamePlayer.changePlayerCurrencyAsync` để giữ audit log của SDK.
- `displayName` là snapshot lúc submit — nếu user đổi tên giữa kỳ, bảng vẫn hiện tên cũ tới lần submit kế. Chấp nhận được cho leaderboard; muốn luôn mới thì bỏ field này và join `loadGamePlayerAsync` khi render top (tốn hơn).
- Dữ liệu kỳ cũ không tự xóa. Nếu cần dọn, thêm field `tsExpire` + index `{ tsExpire: 1 }` với `{ expireAfterSeconds: 0 }`, hoặc `deleteMany({ boardId })` sau khi đã trao thưởng xong.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
