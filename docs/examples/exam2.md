# Ví dụ: Key-Value Store cho mỗi user (CloudScript + raw MongoDB)

Tính năng: mỗi user có một bộ key-value tự định nghĩa (settings UI, progress flag, draft state). 4 handler: `kvGet`, `kvSet`, `kvList`, `kvDelete`. Persistence trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`, không động đến GamePlayer custom data (tránh phình profile, tránh đụng InfoRequestParam).

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("UserKV.Entries", gameId)`
- Full name (tạo index): `"Runtime." + gameId + ".UserKV.Entries"`

Document shape:

```ts
type KvEntry = {
    userId: string;       // context.userId tại thời điểm ghi
    key: string;          // key namespace của user (vd "ui.theme")
    value: unknown;       // payload JSON-serializable: string, number, boolean, object, array, null
    tsUpdate: number;     // Date.now() khi ghi gần nhất
};
```

Index khuyến nghị:

- `{ userId: 1, key: 1 }` **unique** — guarantee 1 doc cho 1 (user,key); cho phép `updateOne(..., { upsert: true })` an toàn.
- `{ userId: 1, tsUpdate: -1 }` — cho `kvList` sort theo gần nhất.

---

## 2. Script TypeScript

```ts
const KV_COLLECTION = "UserKV.Entries";
const KV_KEY_MAX = 100;
const KV_VALUE_MAX_BYTES = 16 * 1024; // 16KB / entry
const KV_LIST_LIMIT_DEFAULT = 50;
const KV_LIST_LIMIT_MAX = 200;

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const requireKvKey = (raw: unknown): string => {
    const key = requireString(raw, "key");
    if (key.length > KV_KEY_MAX) {
        throw new Error("key_too_long: max=" + KV_KEY_MAX);
    }
    return key;
};

handlers["kvGet"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const key = requireKvKey(args?.key);

    const collection = database.runtimeGameCollection(KV_COLLECTION, gameId);
    const doc = await collection.findOne({ userId: userId, key: key }, { projection: { _id: 0 } });

    return {
        key: key,
        found: doc !== null,
        value: doc?.value ?? null,
        tsUpdate: doc?.tsUpdate ?? null,
    };
};

handlers["kvSet"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const key = requireKvKey(args?.key);
    const value = args?.value ?? null;

    // Soft size check — JSON.stringify đủ cho payload thường
    const approxBytes = JSON.stringify(value).length;
    if (approxBytes > KV_VALUE_MAX_BYTES) {
        throw new Error("value_too_large: bytes=" + approxBytes + " max=" + KV_VALUE_MAX_BYTES);
    }

    const tsUpdate = Date.now();
    const collection = database.runtimeGameCollection(KV_COLLECTION, gameId);

    await collection.updateOne(
        { userId: userId, key: key },
        {
            $set: {
                userId: userId,
                key: key,
                value: value,
                tsUpdate: tsUpdate,
            },
        },
        { upsert: true },
    );

    return { key: key, value: value, tsUpdate: tsUpdate };
};

handlers["kvList"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const prefix = typeof args?.prefix === "string" ? args.prefix : null;

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : KV_LIST_LIMIT_DEFAULT;
    const limit = Math.max(1, Math.min(KV_LIST_LIMIT_MAX, limitRaw));

    const filter: { [k: string]: any } = { userId: userId };
    if (prefix !== null && prefix.length > 0) {
        // Escape regex meta-chars để tránh user truyền "^" / ".*" gây load nặng
        const escaped = prefix.replace(/[.*+?^${}()|[\]\\]/g, "\\$&");
        filter.key = { $regex: "^" + escaped };
    }

    const collection = database.runtimeGameCollection(KV_COLLECTION, gameId);
    const docs = await collection
        .find(filter, { projection: { _id: 0, userId: 0 } })
        .sort({ tsUpdate: -1 })
        .limit(limit)
        .toArray();

    return { count: docs.length, entries: docs };
};

handlers["kvDelete"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const key = requireKvKey(args?.key);

    const collection = database.runtimeGameCollection(KV_COLLECTION, gameId);
    const result = await collection.deleteOne({ userId: userId, key: key });

    return { key: key, deletedCount: result.deletedCount ?? 0 };
};
```

Tạo index 1 lần (handler ad-hoc, gọi 1 lần sau khi publish live):

```ts
handlers["initUserKV"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + KV_COLLECTION;
    await database.createIndex(fullName, { userId: 1, key: 1 }, { unique: true });
    await database.createIndex(fullName, { userId: 1, tsUpdate: -1 });
    return { ok: true };
};
```

> Vì sao không lưu vào `GamePlayer.customData`: customData được pull theo `InfoRequestParam`; payload kv lớn sẽ phình mọi response `getPlayerInformation`. Raw collection cho phép query theo `userId+prefix`, có TTL tùy chỉnh nếu cần, và không chiếm slot custom data.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = userKvScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initUserKV` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` là `string`, không phải bool — xem [guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md).

---

## 4. Unity client

Pattern 3-tier check (`returnCode` → `errorCode` → `ExecuteResponseStatus`) — [guides/CLOUDSCRIPT.md:162-185](/docs/guides/CLOUDSCRIPT.md).

### 4.1 Get / Set / Delete

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

public System.Threading.Tasks.Task<object> KvGetAsync(string key)
    => ExecuteAsync("kvGet", GNHashtable.builder().add("key", key).build());

public System.Threading.Tasks.Task<object> KvSetAsync(string key, object value)
    => ExecuteAsync("kvSet", GNHashtable.builder().add("key", key).add("value", value).build());

public System.Threading.Tasks.Task<object> KvDeleteAsync(string key)
    => ExecuteAsync("kvDelete", GNHashtable.builder().add("key", key).build());
```

### 4.2 List theo prefix

```csharp
public System.Threading.Tasks.Task<object> KvListAsync(string prefix = null, int limit = 50)
{
    var builder = GNHashtable.builder().add("limit", limit);
    if (!string.IsNullOrEmpty(prefix)) builder.add("prefix", prefix);
    return ExecuteAsync("kvList", builder.build());
}
```

Return shape: `{ count: int, entries: [{ key, value, tsUpdate }] }`. Cast `exec.functionResult` qua `GNHashtable` rồi đọc `entries` như `IList`.

---

## 5. Cảnh báo

- `value` JSON-serializable: không truyền object vòng tham chiếu, không truyền `Date` raw — convert sang số `Date.now()`.
- `KV_VALUE_MAX_BYTES` là soft cap; nếu nâng cao hơn 100KB phải đánh giá lại Mongo doc size limit (16MB) và RAM khi cursor list nhiều entry.
- Regex prefix đã escape meta-chars; **không** xóa bước escape để cho phép user truyền regex tự do — sẽ thành DoS vector.
- KHÔNG dùng namespace key trùng với GearN reserved field (vd `displayName`, `email`) — đây là collection riêng nên không xung đột, nhưng tránh confuse review code.
- KHÔNG gọi `executeFunctionAsync` qua `.server` / `.admin` từ Unity client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
- TTL: nếu kv là draft/cache tạm, thêm `tsExpire` field + index `{ tsExpire: 1 }` với `{ expireAfterSeconds: 0 }` thay vì cron xóa.
