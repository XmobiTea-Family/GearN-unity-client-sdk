# Ví dụ: Rate Limit — giới hạn N action / khoảng thời gian (gacha free, watch-ad reward)

Tính năng: giới hạn tần suất 1 action server-side (gacha free, nhận thưởng xem quảng cáo, gửi quà). Mỗi `actionKey` có cấu hình `limit` lần / `windowMs`. Server dùng fixed-window counter trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`, atomic CAS chống vượt hạn khi request song song.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("RateLimit.Window", gameId)`
- Full name (index): `"Runtime." + gameId + ".RateLimit.Window"`

Document shape (1 doc / (user, action)):

```ts
type RateLimitWindow = {
    userId: string;
    actionKey: string;     // key trong bảng RATE_LIMITS
    windowStart: number;   // Date.now() mốc bắt đầu cửa sổ hiện tại
    count: number;         // số lần đã dùng trong cửa sổ này
};
```

Index: `{ userId: 1, actionKey: 1 }` **unique** — 1 doc / cặp, cho atomic upsert + CAS theo `windowStart`.

Cấu hình `RATE_LIMITS`: mỗi `actionKey` → `{ limit, windowMs }`. Ví dụ: `gacha-free` = 1 lần / 24h; `watch-ad-reward` = 5 lần / 24h.

> Fixed-window: cửa sổ bắt đầu khi action đầu tiên rơi vào → reset khi `now - windowStart >= windowMs`. Đơn giản, đủ tốt cho gacha/ad. Nếu cần chống burst ở ranh giới cửa sổ, dùng sliding-window (lưu mảng timestamp) — phức tạp hơn, xem §5.

---

## 2. Script TypeScript

```ts
const RL_COLLECTION = "RateLimit.Window";

type RateLimitDef = { limit: number; windowMs: number };
const RATE_LIMITS: Record<string, RateLimitDef> = {
    "gacha-free":      { limit: 1, windowMs: 24 * 60 * 60 * 1000 },
    "watch-ad-reward": { limit: 5, windowMs: 24 * 60 * 60 * 1000 },
    "send-gift":       { limit: 10, windowMs: 60 * 60 * 1000 },
};

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const requireRateLimitDef = (actionKey: string): RateLimitDef => {
    const def = RATE_LIMITS[actionKey];
    if (def == null) {
        throw new Error("unknown_action: " + actionKey);
    }
    return def;
};

// Tính trạng thái cửa sổ hiện tại từ doc + now
const evalWindow = (doc: any, def: RateLimitDef, now: number) => {
    const windowStart = doc?.windowStart ?? 0;
    const count = doc?.count ?? 0;
    const expired = windowStart === 0 || now - windowStart >= def.windowMs;
    return {
        expired: expired,
        usedCount: expired ? 0 : count,
        remaining: expired ? def.limit : Math.max(0, def.limit - count),
        resetAt: expired ? now + def.windowMs : windowStart + def.windowMs,
    };
};

// Xem còn được làm action không, KHÔNG tiêu lượt
handlers["rateLimitCheck"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const actionKey = requireString(args?.actionKey, "actionKey");
    const def = requireRateLimitDef(actionKey);

    const collection = database.runtimeGameCollection(RL_COLLECTION, gameId);
    const doc = await collection.findOne({ userId: userId, actionKey: actionKey }, { projection: { _id: 0 } });
    const w = evalWindow(doc, def, Date.now());

    return {
        actionKey: actionKey,
        allowed: w.remaining > 0,
        limit: def.limit,
        remaining: w.remaining,
        resetAt: w.resetAt,
    };
};

// Tiêu 1 lượt. Throw "rate_limited" nếu hết hạn mức.
handlers["rateLimitConsume"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const actionKey = requireString(args?.actionKey, "actionKey");
    const def = requireRateLimitDef(actionKey);

    const collection = database.runtimeGameCollection(RL_COLLECTION, gameId);
    const now = Date.now();

    const doc = await collection.findOne({ userId: userId, actionKey: actionKey }, { projection: { _id: 0 } });
    const w = evalWindow(doc, def, now);

    if (w.remaining <= 0) {
        throw new Error("rate_limited: resetAt=" + w.resetAt);
    }

    if (w.expired) {
        // Mở cửa sổ mới. CAS theo windowStart cũ để 2 request song song không cùng reset.
        const filter = doc == null
            ? { userId: userId, actionKey: actionKey, windowStart: { $exists: false } }
            : { userId: userId, actionKey: actionKey, windowStart: doc.windowStart };
        const result = await collection.updateOne(
            filter,
            { $set: { userId: userId, actionKey: actionKey, windowStart: now, count: 1 } },
            { upsert: doc == null },
        );
        if ((result.modifiedCount ?? 0) === 0 && (result.upsertedCount ?? 0) === 0) {
            throw new Error("race_lost: thử lại");
        }
    } else {
        // Cửa sổ còn hiệu lực: $inc count, CAS để không vượt limit khi song song.
        const result = await collection.updateOne(
            { userId: userId, actionKey: actionKey, windowStart: doc.windowStart, count: { $lt: def.limit } },
            { $inc: { count: 1 } },
        );
        if ((result.modifiedCount ?? 0) === 0) {
            // Hoặc đã đủ limit (request khác chen vào), hoặc windowStart vừa đổi
            throw new Error("rate_limited: resetAt=" + w.resetAt);
        }
    }

    const after = await collection.findOne({ userId: userId, actionKey: actionKey }, { projection: { _id: 0 } });
    const wAfter = evalWindow(after, def, now);

    return {
        actionKey: actionKey,
        consumed: true,
        limit: def.limit,
        remaining: wAfter.remaining,
        resetAt: wAfter.resetAt,
    };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initRateLimit"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + RL_COLLECTION;
    await database.createIndex(fullName, { userId: 1, actionKey: 1 }, { unique: true });
    return { ok: true };
};
```

> Cách ghép với action thật: handler gacha/ad gọi `rateLimitConsume` ở bước ĐẦU TIÊN; nếu throw `rate_limited` thì dừng, không chạy logic reward. Có thể inline logic này vào chính handler reward thay vì handler riêng — đặt riêng để ví dụ rõ ràng.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = rateLimitScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initRateLimit` 1 lần để tạo index, rồi promote live:

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

public System.Threading.Tasks.Task<object> RateLimitCheckAsync(string actionKey)
    => ExecuteAsync("rateLimitCheck", GNHashtable.builder().add("actionKey", actionKey).build());

public System.Threading.Tasks.Task<object> RateLimitConsumeAsync(string actionKey)
    => ExecuteAsync("rateLimitConsume", GNHashtable.builder().add("actionKey", actionKey).build());
```

UI flow:

1. Mở screen → `RateLimitCheckAsync("gacha-free")` → render nút Gacha bật/tắt theo `allowed`, countdown tới `resetAt` nếu hết lượt.
2. User bấm → handler reward thật gọi `rateLimitConsume` trước; throw `rate_limited` → UI báo "hết lượt, quay lại sau", refresh check.
3. `remaining` trong response cho phép UI cập nhật ngay không cần gọi lại `rateLimitCheck`.

---

## 5. Cảnh báo

- KHÔNG gate bằng client (cache `resetAt`, đếm lượt local) — client clock skew / cache cũ. Server `rateLimitConsume` là nguồn quyết định duy nhất.
- KHÔNG thay CAS bằng đọc-rồi-`$set count` — 2 request song song cùng đọc `count=4`, cùng set `count=5`, vượt limit. Phải `$inc` với filter `count: { $lt: limit }`.
- Fixed-window cho phép burst ở ranh giới: limit 5/24h → user có thể dùng 5 lần cuối cửa sổ A + 5 lần đầu cửa sổ B = 10 lần trong khoảng ngắn. Nếu không chấp nhận, đổi sang sliding-window: lưu `timestamps: number[]`, mỗi lần consume lọc bỏ ts cũ hơn `now - windowMs` rồi check `length < limit`.
- `rateLimitConsume` chỉ tiêu lượt — KHÔNG tự payout reward. Logic reward nằm ở handler khác, gọi `rateLimitConsume` thành công rồi mới grant. Nếu reward fail sau khi đã consume, user mất 1 lượt: cân nhắc consume SAU khi reward thành công nếu reward hiếm khi fail, hoặc hoàn lượt thủ công.
- Doc `RateLimit.Window` không tự xóa. Số doc = số (user × action) từng dùng. Thêm field `tsExpire` + index TTL `{ tsExpire: 1 }` `{ expireAfterSeconds: 0 }` nếu muốn dọn doc cũ.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
