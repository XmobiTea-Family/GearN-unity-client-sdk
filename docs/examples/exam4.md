# Ví dụ: Currency-Cost Flow — action tốn N gem, atomic trừ, rollback khi fail

Tính năng tổng quát: action gameplay tốn currency (đổi tên displayName, mở rương, fast-forward, ...). Server check số dư → trừ atomic → thực thi side-effect → rollback nếu side-effect fail. Mọi mutation currency đi qua `admin.gamePlayer.changePlayerCurrencyAsync` (giữ audit log). Áp dụng cho ví dụ cụ thể: **đổi displayName tốn 50 gem**.

> Đọc trước: [docs/AI_CHEATSHEET.md](/docs/AI_CHEATSHEET.md), [docs/guides/GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md), [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md), [docs/cloudScript/CLOUDSCRIPT_admin.md](/docs/cloudScript/CLOUDSCRIPT_admin.md), [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md).

---

## 1. Mô hình dữ liệu

Không cần collection mới — toàn bộ state đã nằm trên GamePlayer:

- Số dư đọc bằng `admin.gamePlayer.getPlayerInformationAsync` với `infoRequestParam.playerCurrencies = true; playerCurrencyKeys = ["gem"]`.
- Trừ/cộng bằng `admin.gamePlayer.changePlayerCurrencyAsync` (delta change, value âm = trừ).
- DisplayName set bằng `admin.gamePlayer.setDisplayNameAsync`.

Optional audit collection cho fail case (nếu muốn dashboard query nhanh):

- `database.runtimeGameCollection("CurrencyCost.FailLog", gameId)` — chỉ insert khi side-effect fail và đã rollback. SDK audit log đã ghi đủ pair trừ/cộng vào `gamePlayerCurrencyLogs`, nên collection này thuần ops monitoring.

---

## 2. Script TypeScript

```ts
const CURRENCY_KEY = "gem";
const COST_RENAME_DISPLAY_NAME = 50;
const FAIL_LOG_COLLECTION = "CurrencyCost.FailLog";

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

// Helper: lấy số dư currency hiện tại của 1 user/1 key
const getBalance = async (userId: string, currencyKey: string): Promise<number> => {
    const infoRequestParam = new GamePlayerModels.InfoRequestParam();
    infoRequestParam.playerCurrencies = true;
    infoRequestParam.playerCurrencyKeys = [currencyKey];

    const requestData = new GamePlayerModels.AdminGetPlayerInformationRequestData();
    requestData.userId = userId;
    requestData.infoRequestParam = infoRequestParam;

    const response = await admin.gamePlayer.getPlayerInformationAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.getPlayerInformationAsync");

    const currencies = response.responseData.infoResponseParameters.playerCurrencies ?? [];
    const entry = currencies.find((c: any) => c.key === currencyKey);
    return entry?.value ?? 0;
};

// Helper: cộng/trừ currency. `delta` âm = trừ, dương = cộng.
const changeBalance = async (userId: string, currencyKey: string, delta: number, logMessage: string): Promise<void> => {
    const param = new GamePlayerModels.PlayerCurrencyParam();
    param.key = currencyKey;
    param.value = delta;

    const requestData = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
    requestData.userId = userId;
    requestData.playerCurrencies = [param];
    requestData.log = logMessage;

    const response = await admin.gamePlayer.changePlayerCurrencyAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.changePlayerCurrencyAsync");
};

handlers["renameDisplayName"] = async (args: Record<string, unknown>, context, log) => {
    const userId = context.userId;
    const newDisplayName = requireString(args?.displayName, "displayName");
    if (newDisplayName.length > 32) {
        throw new Error("displayName_too_long: max=32");
    }

    const cost = COST_RENAME_DISPLAY_NAME;
    const txnId = userId + ":" + Date.now();

    // 1) Đọc số dư
    const balance = await getBalance(userId, CURRENCY_KEY);
    if (balance < cost) {
        throw new Error("insufficient_balance: have=" + balance + " need=" + cost);
    }

    // 2) Trừ trước (audit log: "renameDisplayName cost txnId=...")
    await changeBalance(userId, CURRENCY_KEY, -cost, "renameDisplayName.cost txnId=" + txnId);

    // 3) Thực thi side-effect: setDisplayName
    try {
        const setRequest = new GamePlayerModels.AdminSetDisplayNameRequestData();
        setRequest.userId = userId;
        setRequest.displayName = newDisplayName;

        const setResponse = await admin.gamePlayer.setDisplayNameAsync(setRequest);
        assertResponseOk(setResponse, "admin.gamePlayer.setDisplayNameAsync");
    } catch (sideEffectError) {
        // 4) Rollback: cộng lại cost. Nếu rollback cũng fail → ghi failLog để ops xử lý tay.
        try {
            await changeBalance(userId, CURRENCY_KEY, cost, "renameDisplayName.rollback txnId=" + txnId);
        } catch (rollbackError) {
            const failLog = database.runtimeGameCollection(FAIL_LOG_COLLECTION, gameId);
            await failLog.insertOne({
                txnId: txnId,
                userId: userId,
                currencyKey: CURRENCY_KEY,
                cost: cost,
                sideEffectError: String(sideEffectError),
                rollbackError: String(rollbackError),
                tsCreate: Date.now(),
            });
        }
        throw sideEffectError;
    }

    // 5) Đọc lại số dư cho client refresh UI
    const newBalance = await getBalance(userId, CURRENCY_KEY);

    return {
        txnId: txnId,
        displayName: newDisplayName,
        cost: cost,
        currencyKey: CURRENCY_KEY,
        balance: newBalance,
    };
};
```

> Vì sao thứ tự "trừ trước → side-effect → rollback nếu fail" mà không phải "side-effect trước → trừ sau": nếu side-effect commit nhưng trừ fail (network hiccup), user nhận lợi ích free. Ngược lại, trừ trước rồi side-effect fail → ta có khả năng rollback nội bộ; trường hợp xấu nhất rollback cũng fail thì còn `FAIL_LOG_COLLECTION` để ops cấp lại.

---

## 3. Publish version

Lần đầu publish — pattern chuẩn từ [cloudScript/CLOUDSCRIPT_USAGE.md:464-516](/docs/cloudScript/CLOUDSCRIPT_USAGE.md):

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var addRequestData = new CloudScriptModels.AdminAddFunctionRequestData();
addRequestData.script = currencyCostScript;
addRequestData.canExecute = true;
addRequestData.isLive = false;

var addResponse = await GNNetwork.cloudScript.admin.addFunctionAsync(addRequestData);
if (addResponse.returnCode != ReturnCode.Ok) return;
if (addResponse.errorCode != ErrorCode.Ok) return;
if (!string.IsNullOrEmpty(addResponse.responseData.errorMessage)) return;

var version = addResponse.responseData.version;
```

Không cần tạo index (`FAIL_LOG_COLLECTION` chỉ insert khi rollback fail, không query nóng). Sau khi test pass, promote live:

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

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Common;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

public async System.Threading.Tasks.Task<object> RenameDisplayNameAsync(string newDisplayName)
{
    var requestData = new CloudScriptModels.ExecuteFunctionRequestData();
    requestData.functionName = "renameDisplayName";
    requestData.functionParameters = GNHashtable.builder()
        .add("displayName", newDisplayName)
        .build();

    var response = await GNNetwork.cloudScript.executeFunctionAsync(requestData);
    if (response.returnCode != ReturnCode.Ok) throw new System.Exception("transport: " + response.returnCode);
    if (response.errorCode != ErrorCode.Ok) throw new System.Exception("business: " + response.errorCode);

    var exec = response.responseData;
    var status = (ExecuteResponseStatus)exec.status;
    if (status != ExecuteResponseStatus.Ok)
    {
        // exec.errorMessage chứa "insufficient_balance: have=X need=Y" hoặc "displayName_too_long: ..." 
        // để UI hiển thị mapped message
        throw new System.Exception("execute: " + exec.errorMessage);
    }

    return exec.functionResult; // { txnId, displayName, cost, currencyKey, balance }
}
```

UI flow:

1. User nhập tên mới → confirm dialog "Tốn 50 gem, tiếp tục?".
2. Gọi `RenameDisplayNameAsync` → parse `exec.errorMessage` để map insufficient/too-long sang text bản địa.
3. Success → refresh UI với `balance` mới từ response.

---

## 5. Cảnh báo

- **KHÔNG** check số dư ở client rồi mới gọi cloud — client có thể bị clock skew / cache cũ. Server vẫn phải `getBalance` + check lại.
- **KHÔNG** đảo thứ tự thành "set displayName trước, trừ gem sau". Side-effect đã commit không phải lúc nào cũng rollback được (vd unique constraint trên displayName).
- **KHÔNG** trừ currency bằng `database.gamePlayerRepository.loadGamePlayerAsync(...)` rồi `gamePlayer.setPlayerCurrency(...).saveAsync()` — bỏ qua audit log của SDK; sau này khó debug "ai trừ gem của user này".
- Pattern get-then-change KHÔNG atomic về mặt currency: 2 request song song của cùng user có thể cùng đọc `balance=100`, cùng pass check, cùng trừ → balance âm. Để chống điều này:
  - Áp dụng rate-limit / single-flight ở handler (vd lock theo `userId` qua `database.runtimeGameCollection("Lock.<action>", gameId).insertOne({ _id: userId })` với unique constraint, xóa cuối handler).
  - Hoặc chấp nhận race nếu giá trị nhỏ + SDK audit log đủ để ops phát hiện balance âm.
- `FAIL_LOG_COLLECTION` chỉ insert khi rollback ALSO fail — không log mọi side-effect fail (đã có pair audit log của SDK). Đừng biến nó thành noise channel.
- KHÔNG gọi `.server`/`.admin` của CloudScript từ client ([AI_CHEATSHEET.md:155-163](/docs/AI_CHEATSHEET.md) §6).
- Currency key (`gem`) phải đã được khai báo trong dashboard config trước đó; nếu chưa, `changePlayerCurrencyAsync` sẽ trả lỗi business code, không silently no-op.
