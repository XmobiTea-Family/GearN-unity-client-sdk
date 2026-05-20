# Ví dụ: Webhook Callback — nhận callback third-party (payment gateway, anti-cheat)

Tính năng: xử lý callback từ dịch vụ thứ ba (payment gateway, anti-cheat). CloudScript **không phải** một HTTP endpoint công khai — third-party không POST thẳng vào được. Pattern đúng: trusted backend của bạn nhận webhook → gọi CloudScript handler → handler **tự verify lại** với third-party qua `http` (không tin payload) → ghi nhận idempotent vào MongoDB nội bộ → grant reward.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md), [docs/cloudScript/CLOUDSCRIPT_database.md](/docs/cloudScript/CLOUDSCRIPT_database.md), [docs/cloudScript/CLOUDSCRIPT_http.md](/docs/cloudScript/CLOUDSCRIPT_http.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md).

---

## 1. Mô hình dữ liệu

- Collection (đọc/ghi): `database.runtimeGameCollection("Webhook.Processed", gameId)`
- Full name (index): `"Runtime." + gameId + ".Webhook.Processed"`

Document shape (1 doc / sự kiện webhook — idempotency ledger):

```ts
type WebhookRecord = {
    provider: string;      // "stripe" | "anticheat" ...
    externalId: string;    // id giao dịch / sự kiện phía third-party — khóa idempotency
    userId: string;        // user được tác động
    status: "processing" | "completed" | "rejected";
    amount: number;        // số tiền/đơn vị đã verify (0 nếu reject)
    detail: Record<string, unknown>;
    tsCreate: number;
    tsProcessed: number;
};
```

Index: `{ provider: 1, externalId: 1 }` **unique** — chống xử lý 1 sự kiện 2 lần (webhook hay gửi lặp).

Luồng tổng thể:

```
[third-party]──webhook──▶[trusted backend của bạn]──verify chữ ký──▶
   GNNetwork.cloudScript.server.executeFunction("webhookProcess", ...) ──▶
      [CloudScript handler] ── http.get verify lại với third-party ──▶ grant
```

> Vì sao cần trusted backend ở giữa: CloudScript handler chỉ chạy khi được gọi qua API `executeFunction` của GearN (có auth/secret). Không có URL công khai để payment gateway POST vào. Backend của bạn là nơi tiếp nhận webhook thật, verify chữ ký HMAC của provider, rồi mới chuyển tiếp.

---

## 2. Script TypeScript

```ts
const WH_COLLECTION = "Webhook.Processed";
const WH_REWARD_CURRENCY_KEY = "gem";

// Cấu hình verify từng provider. Base URL công khai để ở đây được;
// secret/api-key NÊN đọc từ secure config, KHÔNG hard-code (xem §5).
type ProviderConfig = { verifyBaseUrl: string };
const WH_PROVIDERS: Record<string, ProviderConfig> = {
    "stripe": { verifyBaseUrl: "https://api.example-gateway.com/v1/transactions/" },
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

handlers["webhookProcess"] = async (args: Record<string, unknown>, context, log) => {
    const provider = requireString(args?.provider, "provider");
    const externalId = requireString(args?.externalId, "externalId");
    const userId = requireString(args?.userId, "userId");

    const providerConfig = WH_PROVIDERS[provider];
    if (providerConfig == null) {
        throw new Error("unknown_provider: " + provider);
    }

    const collection = database.runtimeGameCollection(WH_COLLECTION, gameId);
    const now = Date.now();

    // 1) Idempotency: insert ledger với unique index. Trùng → đã nhận trước đó.
    try {
        await collection.insertOne({
            provider: provider,
            externalId: externalId,
            userId: userId,
            status: "processing",
            amount: 0,
            detail: {},
            tsCreate: now,
            tsProcessed: 0,
        });
    } catch (insertError) {
        const existing = await collection.findOne({ provider: provider, externalId: externalId }, { projection: { _id: 0 } });
        return { duplicate: true, status: existing?.status ?? "unknown" };
    }

    // 2) Verify ĐỘC LẬP với third-party — KHÔNG tin payload webhook.
    let verified = false;
    let verifiedAmount = 0;
    try {
        const verifyResponse = await http.get(providerConfig.verifyBaseUrl + encodeURIComponent(externalId), {
            timeout: 8000,
        });
        const data = verifyResponse.data ?? {};
        // Hình dạng response tuỳ provider — ví dụ: { status: "paid", amount: 100 }
        verified = verifyResponse.status === 200 && data.status === "paid";
        verifiedAmount = typeof data.amount === "number" ? data.amount : 0;
    } catch (httpError) {
        // Verify fail → để status "processing", cho phép retry lần webhook sau
        await collection.updateOne(
            { provider: provider, externalId: externalId },
            { $set: { detail: { verifyError: String(httpError) } } },
        );
        throw new Error("verify_failed: " + String(httpError));
    }

    if (!verified || verifiedAmount <= 0) {
        await collection.updateOne(
            { provider: provider, externalId: externalId },
            { $set: { status: "rejected", tsProcessed: Date.now() } },
        );
        return { processed: true, status: "rejected" };
    }

    // 3) Grant reward. Chỉ tới đây khi đã verify thành công.
    try {
        const currencyParam = new GamePlayerModels.PlayerCurrencyParam();
        currencyParam.key = WH_REWARD_CURRENCY_KEY;
        currencyParam.value = verifiedAmount;

        const payoutRequest = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
        payoutRequest.userId = userId;
        payoutRequest.playerCurrencies = [currencyParam];
        payoutRequest.log = "webhook " + provider + " externalId=" + externalId;

        const payoutResponse = await admin.gamePlayer.changePlayerCurrencyAsync(payoutRequest);
        assertResponseOk(payoutResponse, "admin.gamePlayer.changePlayerCurrencyAsync");
    } catch (payoutError) {
        // Grant fail → KHÔNG đánh completed; giữ "processing" để webhook retry xử lý lại.
        await collection.updateOne(
            { provider: provider, externalId: externalId },
            { $set: { detail: { payoutError: String(payoutError) } } },
        );
        throw payoutError;
    }

    // 4) Đánh dấu completed — từ giờ webhook lặp lại sẽ rơi vào nhánh duplicate ở (1)
    await collection.updateOne(
        { provider: provider, externalId: externalId },
        { $set: { status: "completed", amount: verifiedAmount, tsProcessed: Date.now() } },
    );

    return { processed: true, status: "completed", amount: verifiedAmount };
};
```

Init index (chạy 1 lần sau khi publish live):

```ts
handlers["initWebhook"] = async (args: Record<string, unknown>, context, log) => {
    const fullName = "Runtime." + gameId + "." + WH_COLLECTION;
    await database.createIndex(fullName, { provider: 1, externalId: 1 }, { unique: true });
    return { ok: true };
};
```

> Vì sao verify lại bằng `http` thay vì tin payload backend chuyển sang: webhook payload có thể bị giả mạo nếu trusted backend bị xâm nhập, hoặc bị replay. Gọi thẳng API của provider bằng `externalId` để hỏi "giao dịch này có thật và đã thanh toán chưa" là kiểm chứng độc lập duy nhất đáng tin.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = webhookScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Sau khi test pass: gọi `initWebhook` 1 lần để tạo index, rồi promote live:

```csharp
var editRequestData = new CloudScriptModels.AdminEditFunctionRequestData();
editRequestData.version = version;
editRequestData.canExecute = "true";
editRequestData.isLive = "true";
await GNNetwork.cloudScript.admin.editFunctionAsync(editRequestData);
```

Lưu ý `canExecute`/`isLive` của `AdminEditFunctionRequestData` là `string` — phải truyền `"true"`/`"false"`, không phải bool literal ([guides/CLOUDSCRIPT.md:127-128](/docs/guides/CLOUDSCRIPT.md)).

---

## 4. Trusted backend / relay (C# call site)

> Đây **KHÔNG** phải code game client Unity. Đoạn này chạy ở backend bạn tự host — nơi tiếp nhận webhook thật từ third-party. Game client không bao giờ gọi `webhookProcess`.

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// Gọi sau khi backend đã: (1) nhận HTTP webhook từ payment gateway,
// (2) verify chữ ký HMAC của gateway, (3) parse được externalId + userId.
public async System.Threading.Tasks.Task<bool> ForwardWebhookAsync(string provider, string externalId, string userId)
{
    var requestData = new CloudScriptModels.ServerExecuteFunctionRequestData();
    requestData.userId = userId;                 // route server yêu cầu userId
    requestData.functionName = "webhookProcess";
    requestData.functionParameters = GNHashtable.builder()
        .add("provider", provider)
        .add("externalId", externalId)
        .add("userId", userId)
        .build();

    // Route .server — gọi từ trusted backend, KHÔNG phải client app
    var response = await GNNetwork.cloudScript.server.executeFunctionAsync(requestData);
    if (response.returnCode != ReturnCode.Ok) return false;
    if (response.errorCode != ErrorCode.Ok) return false;

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    return status == ExecuteResponseStatus.Ok;
}
```

Luồng backend:

1. Payment gateway POST webhook tới endpoint công khai của backend.
2. Backend verify chữ ký HMAC bằng secret của gateway → reject nếu sai.
3. Backend gọi `ForwardWebhookAsync(provider, externalId, userId)`.
4. CloudScript `webhookProcess` verify độc lập + idempotent + grant.
5. Backend trả `200 OK` cho gateway (sau khi `ForwardWebhookAsync` xong hoặc đã enqueue).

---

## 5. Cảnh báo

- CloudScript handler KHÔNG phải HTTP endpoint công khai — third-party không gọi thẳng được. Luôn cần trusted backend tiếp nhận webhook và verify chữ ký provider trước.
- KHÔNG tin payload webhook. Payment/anti-cheat callback bị giả mạo hoặc replay là rủi ro thật. `webhookProcess` phải `http.get` hỏi lại provider bằng `externalId` để xác nhận độc lập.
- Idempotency là bắt buộc: webhook gần như chắc chắn gửi lặp (provider retry khi không nhận `200`). Unique index `{ provider, externalId }` + insert-trước-rồi-xử-lý đảm bảo grant đúng 1 lần.
- Thứ tự: insert ledger (`processing`) → verify → grant → đánh `completed`. Nếu verify/grant fail, GIỮ `processing` (không đánh completed) để lần webhook retry sau xử lý lại; lần retry rơi vào nhánh duplicate chỉ khi đã `completed`/`rejected`.
- KHÔNG hard-code secret/api-key của provider trong script. Verify base URL công khai thì để được; key bí mật nên truyền qua header từ secure config server-side.
- `webhookProcess` chạy ở route `.server` — chỉ trusted backend có secret key gọi được. KHÔNG expose nó cho client app gọi qua `executeFunction` thường.
- Set `timeout` rõ ràng cho `http.get` ([cloudScript/CLOUDSCRIPT_http.md:52-57](/docs/cloudScript/CLOUDSCRIPT_http.md)) — provider chậm không được treo handler.
- KHÔNG payout bằng `loadGamePlayerAsync(...)` + `saveAsync()` — bỏ audit log SDK. Dùng `admin.gamePlayer.changePlayerCurrencyAsync`.
- Với IAP receipt của Apple/Google cụ thể, GearN có sẵn `admin.storeInventory.validateReceipt` — ưu tiên dùng nó thay vì tự verify qua `http` (đó là scenario riêng, không thuộc file này).
