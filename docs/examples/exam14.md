# Ví dụ: Audit Log — ghi log nghiệp vụ bền vững, query lại cho admin

Tính năng: ghi log nghiệp vụ bền vững (ai mua gì, ai gửi gì, ai bị ban) vào **log database** riêng qua `database.logRuntimeGameCollection(...)`, tách khỏi runtime data. Admin query lại theo category / actor / khoảng thời gian. Log database là nơi đúng cho dữ liệu append-only, query thưa, giữ lâu.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.logRuntimeGameCollection("Audit.Business", gameId)` — **log database**, không phải runtime DB thường.
- Full name (index): `"Runtime." + gameId + ".Audit.Business"`, tạo index bằng `database.logCreateIndex(...)`.

Document shape (append-only, 1 doc / sự kiện):

```ts
type AuditEntry = {
    category: string;      // nhóm sự kiện: "purchase" | "gift" | "ban" | "currency" ...
    action: string;        // hành động cụ thể: "buyItem" | "sendGift" ...
    actorId: string;       // user gây ra sự kiện
    targetId: string;      // đối tượng bị tác động (có thể trùng actorId)
    detail: Record<string, unknown>; // payload chi tiết, JSON gọn
    tsCreate: number;
};
```

Index (trên log DB):

- `{ tsCreate: -1 }` — query mới nhất trước.
- `{ category: 1, tsCreate: -1 }` — lọc theo category.
- `{ actorId: 1, tsCreate: -1 }` — tra theo user.

> Vì sao dùng `logRuntimeGameCollection` chứ không `runtimeGameCollection`: log database tách riêng khỏi runtime data nóng. Audit log là append-only, đọc thưa, giữ lâu — để chung runtime DB sẽ làm phình collection nghiệp vụ và đụng I/O với data nóng. Xem [cloudScript/CLOUDSCRIPT_database.md:57-67](/docs/cloudScript/CLOUDSCRIPT_database.md) (log collection) + [cloudScript/CLOUDSCRIPT_database.md:81-97](/docs/cloudScript/CLOUDSCRIPT_database.md) (naming).

---

## 2. Script TypeScript

```ts
const AUDIT_COLLECTION = "Audit.Business";
const AUDIT_QUERY_LIMIT_MAX = 200;
// Whitelist user được phép query audit. Thực tế nên đọc từ config/dashboard.
const AUDIT_ADMIN_USER_IDS: string[] = ["REPLACE_WITH_ADMIN_USER_ID"];

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

// Helper tái dùng: gọi từ BẤT KỲ handler nghiệp vụ nào cần ghi audit.
const writeAudit = async (
    category: string,
    action: string,
    actorId: string,
    targetId: string,
    detail: Record<string, unknown>,
): Promise<void> => {
    const collection = database.logRuntimeGameCollection(AUDIT_COLLECTION, gameId);
    await collection.insertOne({
        category: category,
        action: action,
        actorId: actorId,
        targetId: targetId,
        detail: detail,
        tsCreate: Date.now(),
    });
};

// Ví dụ: 1 handler nghiệp vụ tự ghi audit ngay trong flow của nó.
handlers["auditDemoBuyItem"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const itemId = requireString(args?.itemId, "itemId");
    const price = typeof args?.price === "number" ? args.price : 0;

    // ... ở đây là logic mua item thật ...

    await writeAudit("purchase", "buyItem", userId, userId, {
        itemId: itemId,
        price: price,
    });

    return { bought: true, itemId: itemId };
};

// Query audit — CHỈ cho admin (xem §5).
handlers["auditQuery"] = async (args: Record<string, unknown>, context, log) => {
    if (AUDIT_ADMIN_USER_IDS.indexOf(context.userId) < 0) {
        throw new Error("forbidden: not an audit admin");
    }

    const collection = database.logRuntimeGameCollection(AUDIT_COLLECTION, gameId);

    const filter: Record<string, unknown> = {};
    if (typeof args?.category === "string" && args.category.length > 0) {
        filter.category = args.category;
    }
    if (typeof args?.actorId === "string" && args.actorId.length > 0) {
        filter.actorId = args.actorId;
    }
    // Khoảng thời gian: from/to là epoch ms
    const tsRange: Record<string, number> = {};
    if (typeof args?.from === "number") tsRange.$gte = args.from;
    if (typeof args?.to === "number") tsRange.$lte = args.to;
    if (Object.keys(tsRange).length > 0) {
        filter.tsCreate = tsRange;
    }

    const limitRaw = typeof args?.limit === "number" ? Math.floor(args.limit) : 50;
    const limit = Math.max(1, Math.min(AUDIT_QUERY_LIMIT_MAX, limitRaw));
    const beforeTs = typeof args?.beforeTs === "number" ? args.beforeTs : null;
    if (beforeTs !== null) {
        // Phân trang: chỉ lấy doc cũ hơn beforeTs
        filter.tsCreate = Object.assign({}, filter.tsCreate as object, { $lt: beforeTs });
    }

    const docs = await collection
        .find(filter, { projection: { _id: 0 } })
        .sort({ tsCreate: -1 })
        .limit(limit)
        .toArray();

    return {
        count: docs.length,
        entries: docs,
        hasMore: docs.length === limit,
        oldestTsCreate: docs.length > 0 ? docs[docs.length - 1].tsCreate : null,
    };
};
```

Init index (chạy 1 lần sau khi publish live — chú ý `logCreateIndex`, không phải `createIndex`):

```ts
handlers["initAudit"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + AUDIT_COLLECTION;
    await database.logCreateIndex(fullName, { tsCreate: -1 });
    await database.logCreateIndex(fullName, { category: 1, tsCreate: -1 });
    await database.logCreateIndex(fullName, { actorId: 1, tsCreate: -1 });
    return { ok: true };
};
```

> Cách dùng `writeAudit` trong dự án thật: copy helper này vào bundle script, gọi nó ở cuối các handler nghiệp vụ quan trọng (mua bán, chuyển currency, ban, gửi quà). Không tạo collection audit riêng cho từng loại — 1 collection + field `category` đủ để lọc.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = auditScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initAudit` 1 lần để tạo index trên log DB, rồi promote live:

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

// Chỉ admin tool dùng. Game client thường KHÔNG gọi auditQuery.
public System.Threading.Tasks.Task<object> AuditQueryAsync(string category = null, string actorId = null, long? beforeTs = null, int limit = 50)
{
    var builder = GNHashtable.builder().add("limit", limit);
    if (!string.IsNullOrEmpty(category)) builder.add("category", category);
    if (!string.IsNullOrEmpty(actorId)) builder.add("actorId", actorId);
    if (beforeTs.HasValue) builder.add("beforeTs", beforeTs.Value);
    return ExecuteAsync("auditQuery", builder.build());
}
```

UI flow (admin tool):

1. Màn hình audit → `AuditQueryAsync(category: "purchase")` render bảng sự kiện.
2. Phân trang: lần sau truyền `beforeTs = oldestTsCreate` từ response trước.
3. Tra 1 user cụ thể → `AuditQueryAsync(actorId: "<userId>")`.

Game client thường KHÔNG gọi `auditQuery`; chỉ dùng các handler nghiệp vụ (như `auditDemoBuyItem`) — việc ghi audit là side-effect server-side, client không thấy.

---

## 5. Cảnh báo

- `auditQuery` check whitelist `AUDIT_ADMIN_USER_IDS` — audit log lộ hành vi mọi user, không cho user thường query. Whitelist hard-code chỉ là tối thiểu; thực tế đọc danh sách admin từ dashboard config hoặc tag trên MasterPlayer.
- KHÔNG ghi audit bằng `runtimeGameCollection` rồi mong "sau này chuyển sang log DB" — full name giống nhau nhưng nằm ở 2 database khác. Đọc/ghi và tạo index phải nhất quán: `logRuntimeGameCollection` đi với `logCreateIndex`.
- Audit là **append-only**: chỉ `insertOne`, không `updateOne`/`deleteOne`. Sửa được audit thì nó không còn là audit.
- KHÔNG nhét payload nặng / object vòng tham chiếu vào `detail` — giữ JSON gọn. Field nhạy cảm (token, password) tuyệt đối không ghi.
- `writeAudit` fail (lỗi DB) KHÔNG nên làm hỏng handler nghiệp vụ chính nếu nghiệp vụ đã commit — cân nhắc `try/catch` quanh `writeAudit` và nuốt lỗi (chấp nhận mất 1 dòng log) thay vì rollback cả giao dịch. Tùy mức quan trọng của log mà chọn.
- SDK đã có sẵn audit log cho currency/statistics (`gamePlayerCurrencyLogs`, `gamePlayerStatisticsLogs`) — đừng ghi trùng. `Audit.Business` chỉ cho sự kiện nghiệp vụ SDK không tự log.
- Log DB không tự dọn; nếu cần TTL, thêm index `{ tsExpire: 1 }` `{ expireAfterSeconds: 0 }` bằng `logCreateIndex` — nhưng audit thường giữ lâu, cân nhắc kỹ.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
