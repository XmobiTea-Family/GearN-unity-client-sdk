# Ví dụ: Quest Progress — track tiến độ nhiệm vụ, check milestone, payout reward

Tính năng: theo dõi tiến độ quest (kill X quái, login N ngày, thu thập M item). Server cộng dồn tiến độ, tự đánh dấu hoàn thành khi đạt mốc, user claim reward 1 lần. Persistence trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; payout currency qua `admin.gamePlayer.changePlayerCurrencyAsync` (giữ audit log SDK).

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Quest.Progress", gameId)`
- Full name (index): `"Runtime." + gameId + ".Quest.Progress"`

Document shape (1 doc / (user, quest)):

```ts
type QuestProgress = {
    userId: string;
    questId: string;       // key trong bảng QUEST_DEFS
    progress: number;      // tiến độ đã cộng dồn
    completed: boolean;    // progress >= target
    claimed: boolean;      // reward đã nhận chưa
    tsUpdate: number;
};
```

Index: `{ userId: 1, questId: 1 }` **unique** — 1 doc / quest / user, cho atomic `$inc` upsert + CAS claim.

Định nghĩa quest cứng trong script (`QUEST_DEFS`): mỗi quest có `target`, `rewardCurrencyKey`, `rewardAmount`.

---

## 2. Script TypeScript

```ts
const QUEST_COLLECTION = "Quest.Progress";

type QuestDef = { target: number; rewardCurrencyKey: string; rewardAmount: number };
const QUEST_DEFS: Record<string, QuestDef> = {
    "kill-100-slime": { target: 100, rewardCurrencyKey: "gold", rewardAmount: 500 },
    "login-7-days":   { target: 7,   rewardCurrencyKey: "gem",  rewardAmount: 50 },
    "collect-20-ore": { target: 20,  rewardCurrencyKey: "gold", rewardAmount: 200 },
};

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

const requireQuestDef = (questId: string): QuestDef => {
    const def = QUEST_DEFS[questId];
    if (def == null) {
        throw new Error("unknown_quest: " + questId);
    }
    return def;
};

// Cộng tiến độ. delta > 0. Tự set completed khi đạt target.
handlers["questAddProgress"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const questId = requireString(args?.questId, "questId");
    const def = requireQuestDef(questId);

    const deltaRaw = typeof args?.delta === "number" ? Math.floor(args.delta) : 1;
    if (deltaRaw <= 0) {
        throw new Error("delta must be > 0");
    }

    const collection = database.runtimeGameCollection(QUEST_COLLECTION, gameId);
    const now = Date.now();

    // $inc atomic + upsert: nhiều event progress song song cộng dồn an toàn
    await collection.updateOne(
        { userId: userId, questId: questId },
        {
            $inc: { progress: deltaRaw },
            $set: { tsUpdate: now },
            $setOnInsert: { userId: userId, questId: questId, completed: false, claimed: false },
        },
        { upsert: true },
    );

    const doc = await collection.findOne({ userId: userId, questId: questId }, { projection: { _id: 0 } });
    const progress = doc?.progress ?? deltaRaw;

    // Đánh dấu completed nếu vừa vượt mốc (idempotent — filter completed:false)
    if (progress >= def.target && doc?.completed !== true) {
        await collection.updateOne(
            { userId: userId, questId: questId, completed: false },
            { $set: { completed: true } },
        );
    }

    return {
        questId: questId,
        progress: Math.min(progress, def.target),
        target: def.target,
        completed: progress >= def.target,
    };
};

handlers["questList"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const collection = database.runtimeGameCollection(QUEST_COLLECTION, gameId);
    const docs = await collection.find({ userId: userId }, { projection: { _id: 0, userId: 0 } }).toArray();

    const byId: Record<string, any> = {};
    docs.forEach((d: any) => { byId[d.questId] = d; });

    // Trả mọi quest trong QUEST_DEFS, kể cả quest user chưa động tới
    const quests = Object.keys(QUEST_DEFS).map((questId) => {
        const def = QUEST_DEFS[questId];
        const d = byId[questId];
        const progress = Math.min(d?.progress ?? 0, def.target);
        return {
            questId: questId,
            progress: progress,
            target: def.target,
            completed: d?.completed === true,
            claimed: d?.claimed === true,
            rewardCurrencyKey: def.rewardCurrencyKey,
            rewardAmount: def.rewardAmount,
        };
    });

    return { quests: quests };
};

handlers["questClaim"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const questId = requireString(args?.questId, "questId");
    const def = requireQuestDef(questId);

    const collection = database.runtimeGameCollection(QUEST_COLLECTION, gameId);
    const doc = await collection.findOne({ userId: userId, questId: questId }, { projection: { _id: 0 } });
    if (doc === null || doc.completed !== true) {
        throw new Error("quest_not_completed");
    }

    // CAS: chỉ claim được khi claimed đang false → chống double-claim concurrent
    const claimResult = await collection.updateOne(
        { userId: userId, questId: questId, claimed: false },
        { $set: { claimed: true } },
    );
    if ((claimResult.modifiedCount ?? 0) === 0) {
        throw new Error("already_claimed");
    }

    try {
        const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
        currencyParam.key = def.rewardCurrencyKey;
        currencyParam.value = def.rewardAmount;

        const payoutRequest = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
        payoutRequest.userId = userId;
        payoutRequest.playerCurrencies = [currencyParam];
        payoutRequest.log = "quest claim questId=" + questId;

        const payoutResponse = await admin.gamePlayer.changePlayerCurrencyAsync(payoutRequest);
        assertResponseOk(payoutResponse, "admin.gamePlayer.changePlayerCurrencyAsync");
    } catch (payoutError) {
        // Rollback cờ claim để user thử lại
        await collection.updateOne({ userId: userId, questId: questId }, { $set: { claimed: false } });
        throw payoutError;
    }

    return {
        questId: questId,
        claimed: true,
        rewardCurrencyKey: def.rewardCurrencyKey,
        rewardAmount: def.rewardAmount,
    };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initQuest"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + QUEST_COLLECTION;
    await database.createIndex(fullName, { userId: 1, questId: 1 }, { unique: true });
    return { ok: true };
};
```

> Vì sao tách `completed` và `claimed` thành 2 cờ: `completed` do progress quyết định (tự động), `claimed` do user bấm nút (thủ công). Gộp 1 cờ sẽ không phân biệt được "đã đủ mốc nhưng chưa nhận" với "đã nhận xong".

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = questScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initQuest` 1 lần để tạo index, rồi promote live:

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

public System.Threading.Tasks.Task<object> QuestAddProgressAsync(string questId, int delta = 1)
    => ExecuteAsync("questAddProgress", GNHashtable.builder().add("questId", questId).add("delta", delta).build());

public System.Threading.Tasks.Task<object> QuestListAsync()
    => ExecuteAsync("questList", GNHashtable.builder().build());

public System.Threading.Tasks.Task<object> QuestClaimAsync(string questId)
    => ExecuteAsync("questClaim", GNHashtable.builder().add("questId", questId).build());
```

UI flow:

1. Mở screen quest → `QuestListAsync` render từng quest với thanh progress `progress/target` + nút Claim khi `completed && !claimed`.
2. Trong gameplay, khi có event milestone (giết quái, nhặt item) → `QuestAddProgressAsync(questId, delta)`.
3. User bấm Claim → `QuestClaimAsync`. Throw `already_claimed` → refresh list.

---

## 5. Cảnh báo

- `questAddProgress` gọi từ client = client tự khai báo tiến độ → user có thể gian lận (spam "giết 100 quái" tức thì). Với quest nhạy cảm, đừng cho client gọi trực tiếp: cộng progress từ logic server đã validate (vd handler xử lý kết quả trận, server-authoritative event), hoặc kiểm tra `delta` hợp lý + rate-limit theo `userId`.
- KHÔNG thay `$inc` bằng đọc-rồi-`$set` cho `progress` — 2 event song song sẽ ghi đè nhau, mất tiến độ. `$inc` là atomic.
- `completed` được tính lại mỗi lần `questAddProgress`; nếu chỉnh tăng `target` trong `QUEST_DEFS` sau khi user đã completed, quest cũ vẫn giữ `completed:true` cho tới khi có lý do reset. Cân nhắc versioning quest nếu hay đổi mốc.
- Payout fail thì handler rollback `claimed`. Nếu rollback CŨNG fail, quest kẹt claimed-nhưng-chưa-trả — thêm fail-log collection nếu reward lớn.
- KHÔNG payout bằng `database.gamePlayerRepository.loadGamePlayerAsync(...)` + `saveAsync()` — bỏ qua audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- `rewardCurrencyKey` phải đã khai báo trong dashboard config, nếu chưa `changePlayerCurrencyAsync` trả lỗi business.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
