# Ví dụ: Inventory Trade — giao dịch item giữa 2 user: lock, confirm 2 phía, atomic swap

Tính năng: 2 user trao đổi item. A tạo phiên trade với B, mỗi bên đặt danh sách item muốn đưa; khi CẢ HAI xác nhận, server đổi chủ sở hữu (`owner`) của item qua lại. Phiên trade (escrow) lưu trong MongoDB nội bộ qua `database.runtimeGameCollection(...)`; đổi owner qua `admin.inventory.setOwnerAsync`; báo realtime cho đối phương qua `socket`.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md), [docs/cloudScript/CLOUDSCRIPT_socket.md](/docs/cloudScript/CLOUDSCRIPT_socket.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Trade.Escrow", gameId)`
- Full name (index): `"Runtime." + gameId + ".Trade.Escrow"`

Document shape (1 doc / phiên trade):

```ts
type TradeEscrow = {
    tradeId: string;            // id duy nhất, server sinh
    fromUserId: string;         // người tạo phiên
    toUserId: string;           // đối phương
    fromItemIds: string[];      // item fromUser đưa
    toItemIds: string[];        // item toUser đưa
    fromConfirmed: boolean;     // fromUser đã bấm xác nhận
    toConfirmed: boolean;       // toUser đã bấm xác nhận
    status: "pending" | "completed" | "cancelled";
    tsCreate: number;
    tsExpire: number;           // index TTL tự dọn phiên treo
};
```

Index:

- `{ tradeId: 1 }` **unique** — khóa thao tác phiên.
- `{ tsExpire: 1 }` với `{ expireAfterSeconds: 0 }` — TTL tự dọn phiên `pending` bị bỏ.

Event code realtime: `"tradeUpdated"`.

> Vì sao cần escrow doc: trade là quy trình nhiều bước, 2 bên không bấm cùng lúc. Escrow doc giữ trạng thái trung gian (ai đưa gì, ai đã xác nhận) tới khi đủ điều kiện swap. Không thể làm bằng 1 request.

---

## 2. Script TypeScript

```ts
const TR_COLLECTION = "Trade.Escrow";
const TR_TTL_MS = 10 * 60 * 1000; // phiên treo 10 phút thì hết hạn
const TR_MAX_ITEMS = 9;           // tối đa 9 item / bên
const TR_EVENT = "tradeUpdated";

const requireString = (value: unknown, fieldName: string): string => {
    if (typeof value !== "string" || value.trim().length === 0) {
        throw new Error(fieldName + " is required");
    }
    return value.trim();
};

const requireItemIds = (value: unknown): string[] => {
    if (!Array.isArray(value)) {
        throw new Error("itemIds must be an array");
    }
    if (value.length > TR_MAX_ITEMS) {
        throw new Error("too_many_items: max=" + TR_MAX_ITEMS);
    }
    return value.map((v, i) => requireString(v, "itemIds[" + i + "]"));
};

const assertResponseOk = (response: CustomOperationResponse, actionName: string): void => {
    if (response.hasReturnCodeError()) {
        throw new Error(actionName + " return-code error: " + (response.debugMessage ?? response.toString()));
    }
    if (response.errorCode !== ErrorCode.Ok) {
        throw new Error(actionName + " business error: " + response.errorCode);
    }
};

const newTradeId = (fromUserId: string): string => {
    return fromUserId + ":" + Date.now() + ":" + Math.floor(Math.random() * 1e9);
};

// Lấy ownerId hiện tại của 1 item
const getItemOwnerId = async (itemId: string): Promise<string | null> => {
    const requestData = new InventoryModels.AdminGetOwnerRequestData();
    requestData.itemId = itemId;
    const response = await admin.inventory.getOwnerAsync(requestData);
    assertResponseOk(response, "admin.inventory.getOwnerAsync");
    const owner = response.responseData.owner;
    return owner != null ? owner.id : null;
};

// Verify mọi item trong list đang thuộc expectedOwnerId
const assertOwnsAll = async (itemIds: string[], expectedOwnerId: string): Promise<void> => {
    for (const itemId of itemIds) {
        const ownerId = await getItemOwnerId(itemId);
        if (ownerId !== expectedOwnerId) {
            throw new Error("not_owner: itemId=" + itemId + " expected=" + expectedOwnerId + " actual=" + ownerId);
        }
    }
};

// Đổi owner 1 item sang newOwnerId (game player)
const setItemOwner = async (itemId: string, newOwnerId: string): Promise<void> => {
    const requestData = new InventoryModels.AdminSetOwnerRequestData();
    requestData.itemId = itemId;
    requestData.newOwnerId = newOwnerId;
    requestData.newOwnerType = OwnerType.GamePlayer as number;
    const response = await admin.inventory.setOwnerAsync(requestData);
    assertResponseOk(response, "admin.inventory.setOwnerAsync");
};

const notifyTrade = async (userId: string, tradeId: string, state: string): Promise<void> => {
    const operationEvent = new OperationEvent(
        TR_EVENT,
        GNHashtable.builder().add("tradeId", tradeId).add("state", state).add("ts", Date.now()).build(),
    );
    await socket.sendEventTo(userId, operationEvent);
};

handlers["tradeCreate"] = async (args: Record<string, unknown>, context, log) => {
    const fromUserId = context.userId;
    const toUserId = requireString(args?.toUserId, "toUserId");
    if (toUserId === fromUserId) {
        throw new Error("cannot_trade_with_self");
    }
    const fromItemIds = requireItemIds(args?.itemIds);

    // Verify caller đang sở hữu mọi item mình đưa
    await assertOwnsAll(fromItemIds, fromUserId);

    const now = Date.now();
    const tradeId = newTradeId(fromUserId);
    const collection = database.runtimeGameCollection(TR_COLLECTION, gameId);

    await collection.insertOne({
        tradeId: tradeId,
        fromUserId: fromUserId,
        toUserId: toUserId,
        fromItemIds: fromItemIds,
        toItemIds: [],
        fromConfirmed: false,
        toConfirmed: false,
        status: "pending",
        tsCreate: now,
        tsExpire: now + TR_TTL_MS,
    });

    await notifyTrade(toUserId, tradeId, "created");
    return { tradeId: tradeId, status: "pending" };
};

// Mỗi bên đặt / cập nhật danh sách item mình đưa. Đổi offer → reset cả 2 confirm.
handlers["tradeSetOffer"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const tradeId = requireString(args?.tradeId, "tradeId");
    const itemIds = requireItemIds(args?.itemIds);

    const collection = database.runtimeGameCollection(TR_COLLECTION, gameId);
    const trade = await collection.findOne({ tradeId: tradeId }, { projection: { _id: 0 } });
    if (trade === null || trade.status !== "pending") {
        throw new Error("trade_not_pending");
    }
    if (userId !== trade.fromUserId && userId !== trade.toUserId) {
        throw new Error("not_a_participant");
    }

    await assertOwnsAll(itemIds, userId);

    const sideField = userId === trade.fromUserId ? "fromItemIds" : "toItemIds";
    await collection.updateOne(
        { tradeId: tradeId, status: "pending" },
        { $set: { [sideField]: itemIds, fromConfirmed: false, toConfirmed: false } },
    );

    const other = userId === trade.fromUserId ? trade.toUserId : trade.fromUserId;
    await notifyTrade(other, tradeId, "offerChanged");
    return { tradeId: tradeId, side: sideField, itemIds: itemIds };
};

handlers["tradeConfirm"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const tradeId = requireString(args?.tradeId, "tradeId");

    const collection = database.runtimeGameCollection(TR_COLLECTION, gameId);
    const trade = await collection.findOne({ tradeId: tradeId }, { projection: { _id: 0 } });
    if (trade === null || trade.status !== "pending") {
        throw new Error("trade_not_pending");
    }
    const isFrom = userId === trade.fromUserId;
    if (!isFrom && userId !== trade.toUserId) {
        throw new Error("not_a_participant");
    }

    const confirmField = isFrom ? "fromConfirmed" : "toConfirmed";
    await collection.updateOne({ tradeId: tradeId, status: "pending" }, { $set: { [confirmField]: true } });

    const after = await collection.findOne({ tradeId: tradeId }, { projection: { _id: 0 } });
    if (after.fromConfirmed !== true || after.toConfirmed !== true) {
        const other = isFrom ? trade.toUserId : trade.fromUserId;
        await notifyTrade(other, tradeId, "confirmed");
        return { tradeId: tradeId, status: "pending", bothConfirmed: false };
    }

    // CẢ HAI đã confirm → CAS chiếm quyền execute (chỉ 1 request thắng)
    const lockResult = await collection.updateOne(
        { tradeId: tradeId, status: "pending" },
        { $set: { status: "completed" } },
    );
    if ((lockResult.modifiedCount ?? 0) === 0) {
        throw new Error("trade_already_finalized");
    }

    // Re-verify ownership NGAY TRƯỚC swap — phòng item đã bị đổi chủ sau lần set offer
    try {
        await assertOwnsAll(after.fromItemIds, after.fromUserId);
        await assertOwnsAll(after.toItemIds, after.toUserId);
    } catch (verifyError) {
        await collection.updateOne({ tradeId: tradeId }, { $set: { status: "cancelled" } });
        await notifyTrade(trade.fromUserId, tradeId, "cancelled");
        await notifyTrade(trade.toUserId, tradeId, "cancelled");
        throw verifyError;
    }

    // Swap: đổi owner từng item. setOwner KHÔNG atomic across nhiều item → rollback thủ công khi fail.
    const moved: { itemId: string; backTo: string }[] = [];
    try {
        for (const itemId of after.fromItemIds) {
            await setItemOwner(itemId, after.toUserId);
            moved.push({ itemId: itemId, backTo: after.fromUserId });
        }
        for (const itemId of after.toItemIds) {
            await setItemOwner(itemId, after.fromUserId);
            moved.push({ itemId: itemId, backTo: after.toUserId });
        }
    } catch (swapError) {
        // Rollback các item đã đổi chủ
        for (const m of moved) {
            try {
                await setItemOwner(m.itemId, m.backTo);
            } catch (rollbackError) {
                log("trade rollback FAILED itemId=" + m.itemId + " err=" + String(rollbackError));
            }
        }
        await collection.updateOne({ tradeId: tradeId }, { $set: { status: "cancelled" } });
        await notifyTrade(trade.fromUserId, tradeId, "cancelled");
        await notifyTrade(trade.toUserId, tradeId, "cancelled");
        throw swapError;
    }

    await notifyTrade(trade.fromUserId, tradeId, "completed");
    await notifyTrade(trade.toUserId, tradeId, "completed");
    return { tradeId: tradeId, status: "completed", bothConfirmed: true };
};

handlers["tradeCancel"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const tradeId = requireString(args?.tradeId, "tradeId");

    const collection = database.runtimeGameCollection(TR_COLLECTION, gameId);
    const trade = await collection.findOne({ tradeId: tradeId }, { projection: { _id: 0 } });
    if (trade === null || trade.status !== "pending") {
        throw new Error("trade_not_pending");
    }
    if (userId !== trade.fromUserId && userId !== trade.toUserId) {
        throw new Error("not_a_participant");
    }

    const result = await collection.updateOne(
        { tradeId: tradeId, status: "pending" },
        { $set: { status: "cancelled" } },
    );
    if ((result.modifiedCount ?? 0) === 0) {
        throw new Error("trade_already_finalized");
    }

    const other = userId === trade.fromUserId ? trade.toUserId : trade.fromUserId;
    await notifyTrade(other, tradeId, "cancelled");
    return { tradeId: tradeId, status: "cancelled" };
};

handlers["tradeGet"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const tradeId = requireString(args?.tradeId, "tradeId");

    const collection = database.runtimeGameCollection(TR_COLLECTION, gameId);
    const trade = await collection.findOne({ tradeId: tradeId }, { projection: { _id: 0 } });
    if (trade === null) {
        throw new Error("trade_not_found");
    }
    if (userId !== trade.fromUserId && userId !== trade.toUserId) {
        throw new Error("not_a_participant");
    }
    return trade;
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initTrade"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + TR_COLLECTION;
    await database.createIndex(fullName, { tradeId: 1 }, { unique: true });
    await database.createIndex(fullName, { tsExpire: 1 }, { expireAfterSeconds: 0 });
    return { ok: true };
};
```

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = tradeScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initTrade` 1 lần để tạo index, rồi promote live:

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

### 4.1 Thao tác trade

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

public System.Threading.Tasks.Task<object> TradeCreateAsync(string toUserId, System.Collections.Generic.List<string> itemIds)
    => ExecuteAsync("tradeCreate", GNHashtable.builder().add("toUserId", toUserId).add("itemIds", itemIds).build());

public System.Threading.Tasks.Task<object> TradeSetOfferAsync(string tradeId, System.Collections.Generic.List<string> itemIds)
    => ExecuteAsync("tradeSetOffer", GNHashtable.builder().add("tradeId", tradeId).add("itemIds", itemIds).build());

public System.Threading.Tasks.Task<object> TradeConfirmAsync(string tradeId)
    => ExecuteAsync("tradeConfirm", GNHashtable.builder().add("tradeId", tradeId).build());

public System.Threading.Tasks.Task<object> TradeCancelAsync(string tradeId)
    => ExecuteAsync("tradeCancel", GNHashtable.builder().add("tradeId", tradeId).build());

public System.Threading.Tasks.Task<object> TradeGetAsync(string tradeId)
    => ExecuteAsync("tradeGet", GNHashtable.builder().add("tradeId", tradeId).build());
```

### 4.2 Nhận event cập nhật trade qua socket

Subscribe handler cho event code `"tradeUpdated"` để 2 màn hình trade đồng bộ realtime. Rule event custom: [cloudScript/CLOUDSCRIPT_socket.md:198-253](/docs/cloudScript/CLOUDSCRIPT_socket.md).

```csharp
using UnityEngine;
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity;
using XmobiTea.GearN.Helper;
using XmobiTea.GearN.Networking;

public class TradeUpdatedEvent
{
    [StringDataMember(code = "tradeId")]
    public string tradeId;

    [StringDataMember(code = "state")]
    public string state; // created | offerChanged | confirmed | completed | cancelled

    [NumberDataMember(code = ParameterCode.Ts)]
    public long ts;
}

public class TradeUpdatedEventHandler : IServerEventHandler
{
    private const string EVENT_TRADE_UPDATED = "tradeUpdated";

    public static Action1<TradeUpdatedEvent> onUpdate;

    public string getEventCode() => EVENT_TRADE_UPDATED;

    public void handle(OperationEvent operationEvent)
    {
        TradeUpdatedEventHandler.onUpdate?.Invoke(
            ConverterService.deserializeObject<TradeUpdatedEvent>(operationEvent.getParameters())
        );
    }
}

// Subscribe TRƯỚC GNNetwork.connectSocket()
GNNetwork.subscriberServerEventHandler(new TradeUpdatedEventHandler());

TradeUpdatedEventHandler.onUpdate = payload =>
{
    Debug.Log($"trade {payload.tradeId} -> {payload.state}");
    // gọi lại TradeGetAsync(payload.tradeId) để render trạng thái mới nhất
};
```

UI flow:

1. A chọn item + đối phương → `TradeCreateAsync`. B nhận event `created` → mở screen trade.
2. Hai bên `TradeSetOfferAsync` để đặt item; mỗi lần đổi offer, đối phương nhận event `offerChanged`, cả 2 confirm bị reset.
3. Hai bên `TradeConfirmAsync`. Khi cả 2 confirmed → server swap, cả 2 nhận event `completed`.
4. Bất kỳ bên nào `TradeCancelAsync` khi đang `pending`.

---

## 5. Cảnh báo

- Item swap KHÔNG atomic: `setOwner` chạy tuần tự từng item. Handler re-verify ownership ngay trước swap và rollback các item đã đổi khi 1 bước fail. Trường hợp xấu nhất rollback CŨNG fail → 1 item lệch chủ; `log(...)` ghi lại cho ops xử lý tay. Với item giá trị cao, cân nhắc thêm fail-log collection bền vững.
- `tradeConfirm` dùng CAS (`updateOne` filter `status: "pending"` → `"completed"`) để CHỈ 1 request thực thi swap. Không có bước này, 2 lần confirm gần như đồng thời có thể swap 2 lần.
- Re-verify ownership ngay trước swap là bắt buộc: giữa lúc set offer và lúc confirm, user có thể đã bán/trade item đó ở phiên khác. Bỏ bước này → trade item user không còn sở hữu.
- Đổi offer phải reset `fromConfirmed`/`toConfirmed` về false — nếu không, A confirm xong, B lén đổi item rồi A bị tính là vẫn đồng ý món mới.
- `socket` event chỉ là tín hiệu đồng bộ UI; trạng thái thật nằm trong escrow doc. Client luôn gọi `tradeGet` để lấy state chính xác, không tin payload event.
- Phiên `pending` bị bỏ sẽ tự hết hạn nhờ index TTL `tsExpire` — item không bị khóa vĩnh viễn (ví dụ này không "lock" item, chỉ verify lúc confirm; nếu cần lock thực sự, thêm cờ `lockedByTradeId` trên item data).
- `OwnerType.GamePlayer` dùng cho item thuộc game player; nếu hệ thống bạn trade item thuộc owner khác, map đúng `OwnerType`.
- KHÔNG gọi `executeFunctionAsync` qua `.server`/`.admin` từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
