# CLOUDSCRIPT ADMIN

> Links dạng `[file:N-M](path)` là range-line convention (xem [AGENTS.md:22-40](/AGENTS.md)). Không normalize sang anchor `#section` khi edit.

## 1. Mục đích

File này chỉ tập trung vào `admin` trong cloud script.

Nếu bạn cần tài liệu tổng quan cloud script, xem:

- [docs/cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md)

## 2. `admin` thực chất là gì

Trong cloud script, `admin` là CloudScript-safe wrapper cho public SDK `GNNetwork`.

Lý do tồn tại:

- Submitted script không được chứa literal `GNNetwork`.
- Nhưng runtime vẫn cần một cách gọi lại official GearN API.
- `CloudScriptAdmin.ts` bọc lại các API cần dùng để script gọi được mà không đụng trực tiếp `GNNetwork`.
- Không cần gọi `GNNetwork.init()` vì khi cloudScript đã chạy thì đã bootstrap hàm này rồi.
- Không cần truyền `secretKey` từ phía client vì `cloudScript` đã có đầy đủ quyền để gọi bất kỳ hàm nào phía `GearN Server`.

### Mapping chính:

- `admin.characterPlayer` → `GNNetwork.characterPlayer.admin`
- `admin.content` → `GNNetwork.content.admin`
- `admin.gamePlayer` → `GNNetwork.gamePlayer.admin`
- `admin.group` → `GNNetwork.group.admin`
- `admin.inventory` → `GNNetwork.inventory.admin`
- `admin.masterPlayer` → `GNNetwork.masterPlayer.admin`
- `admin.storeInventory` → `GNNetwork.storeInventory.admin`
- `admin.multiplayer` → `GNNetwork.multiplayer.admin`
- `admin.cloudScript` → `GNNetwork.cloudScript.admin`, chỉ expose:
    - `executeFunction`, `executeFunctionAsync`
- `admin.dashboard` → map thủ công từ top-level `GNNetwork.dashboard` (xem §6), chỉ expose:
    - `getAdminAccountList` / `getAdminAccountListAsync`
    - `getGameInformation` / `getGameInformationAsync`
    - `getGameList` / `getGameListAsync`
    - `getMasterGameSettings` / `getMasterGameSettingsAsync`
    - `getSecretInfoInformation` / `getSecretInfoInformationAsync`
    - `getSecretInfoList` / `getSecretInfoListAsync`
    - `getServerLog` / `getServerLogAsync`
    - `setGameInformation` / `setGameInformationAsync`
    - `getUsernameAdminAccount` / `getUsernameAdminAccountAsync`
    - `getAnalytics` / `getAnalyticsAsync`
    - `resetStatisticsLeaderboard` / `resetStatisticsLeaderboardAsync`
    - `getBackupStatisticsLeaderboardVersion` / `getBackupStatisticsLeaderboardVersionAsync`
    - `getServerGameData` / `getServerGameDataAsync`
    - `deleteInDatabase` / `deleteInDatabaseAsync`

Cách tra method khi viết script (đọc theo range dòng — xem [AGENTS.md:22-40](/AGENTS.md#2-đọc-link-theo-range-line)):

1. Mở [AI_CHEATSHEET.md:37-68](/docs/AI_CHEATSHEET.md#2-decision-tree-what-i-need-do) để chọn domain và action cần làm.
2. Đọc chi tiết method trong `docs/guides/<DOMAIN>.md` theo `range line` được cheatsheet trỏ tới.
3. Tra `API contract rows` (route `admin`) trong `docs/reference/API_<DOMAIN>.md` theo dạng `[admin:startLine-endLine](...)`. Nếu route `admin` không có method tương ứng, fallback sang `API contract rows` (route `client`).

Ngoài ra còn có nhưng ít khi dùng:

- `admin.send(...)`
- `admin.sendAsync(...)`

<!-- prettier-ignore -->
| Hàm gốc | Code trong cloudScript như thế nào |
| --- | --- |
| `send(requestType: RequestType, role: RequestRole, request: OperationRequest, onResponse: Action1<OperationResponse>, overrideAuthToken: string, overrideSecretKey: string, customTags: GNHashtable): void` | `admin.send(requestType, role, request, onResponse, overrideAuthToken, overrideSecretKey, customTags)` |
| `sendAsync(requestType: RequestType, role: RequestRole, request: OperationRequest, overrideAuthToken: string, overrideSecretKey: string, customTags: GNHashtable): Promise<OperationResponse>` | `admin.sendAsync(requestType, role, request, overrideAuthToken, overrideSecretKey, customTags)` |

## 3. Khi nào dùng `admin`

Dùng `admin` khi:

- Behavior bạn cần đã tồn tại trong official GearN API.
- Bạn muốn reuse validation, permission flow, request/response model, business rule có sẵn.
- Bạn đang làm việc theo mindset backoffice/GM/tooling/migration, không phải raw database patch.
- Bạn đang thao tác với domain như `gamePlayer`, `characterPlayer`, `group`, `inventory`, `masterPlayer`, `storeInventory`, `multiplayer`, `cloudScript`, `content`, `dashboard`.

Không nên dùng `admin` khi:

- Official API không cover behavior bạn cần và bạn cố ý thao tác raw DB.
- Bạn chỉ cần gọi API ngoài hệ thống → dùng `http`.
- Bạn chỉ cần side effect delivery như socket, mail, push → dùng helper tương ứng.

## 4. Signature pattern (dùng cho tất cả domain)

```ts
// Preferred (async)
const response = await admin.<domain>.<method>Async(requestData);

// Full signature (optional params hiếm khi cần)
const response = await admin.<domain>.<method>Async(requestData, overrideAuthToken?, overrideSecretKey?, customTags?, timeout?);
```

Rule:

- Trong đa số case bạn chỉ cần truyền `requestData`.
- Chỉ truyền optional params khi thật sự cần override context hoặc tracing.
- Luôn check `response.hasReturnCodeError()` trước, rồi kiểm tra `response.errorCode === ErrorCode.Ok`.
- Với route `admin`, phần lớn method yêu cầu `userId` (hoặc entity id) rõ ràng — không bỏ trống như route `client`.
- Khi bạn gọi `admin.*`, bạn đang chọn privileged route có chủ đích. Đừng dùng `admin` chỉ để "đi đường tắt" nếu `database` hoặc helper khác mới là abstraction đúng.
- **KHÔNG dùng `any` cho `response` / item array / `args`** — base type cho helper là `CustomOperationResponse`; item array dùng `GenericModels.CurrencyItem[]` / `StatisticsItem[]` / `DataItem[]` …; `args` dùng `Record<string, unknown>` rồi narrow bằng `typeof` check hoặc helper `requireString`. Đầy đủ pattern + bảng mapping: [CLOUDSCRIPT_USAGE.md § 5](/docs/cloudScript/CLOUDSCRIPT_USAGE.md#5-typing--không-lạm-dụng-any).

Lưu ý ngôn ngữ:

- Code trong `CloudScript` bắt buộc viết bằng `typescript`.
- File mô tả / giải thích / spec: có thể dùng `csharp`-style pseudo/code để dễ đọc.
- Nhưng khi triển khai thật, toàn bộ cấu trúc hàm và cách gọi sẽ được chuyển tương đương sang `typescript`, giữ logic giống `csharp` (`int`/`long`/`double`/`float` → `number`, `bool` → `boolean`, `object` → `unknown`, `List<>` → `Array<>`).

Helper chuẩn `assertResponseOk` được dùng xuyên suốt các ví dụ — xem định nghĩa ở §8.

## 5. Rule request model rất quan trọng

Từ SDK runtime và model:

- Nhiều `Admin*RequestData` kế thừa từ `Server*RequestData`.
- Vì vậy field optional ở route `client` thường trở thành bắt buộc ở route `admin`.

Ví dụ thực tế từ `GamePlayerModels`:

- `AdminGetDisplayNameRequestData` yêu cầu `userId`
- `AdminGetPlayerInformationRequestData` yêu cầu `userId`
- `AdminGetPlayerInformationRequestData` còn yêu cầu `infoRequestParam`

Kết luận:

- Khi AI thấy một method `admin.<domain>.*Async(...)`, đừng copy payload từ ví dụ `client` một cách máy móc.
- Luôn kiểm tra request model tương ứng nếu method có vẻ “self route” ở client nhưng “explicit target” ở admin.

## 6. `dashboard` là case đặc biệt

Đây là điểm dễ gây hiểu nhầm nhất.

Theo SDK README và source SDK:

- `GNNetwork.dashboard` có method public ở top-level.
- `GNNetwork.dashboard.server` và `GNNetwork.dashboard.admin` hiện tồn tại như class nhưng không expose operation public hữu ích.
- Vì vậy trong `CloudScriptAdmin.ts`, `admin.dashboard` không map tới `GNNetwork.dashboard.admin`.
- Nó map thủ công từng method từ top-level `GNNetwork.dashboard`.

Điều này kéo theo 2 rule:

- Không suy luận `admin.dashboard` giống hệt các namespace `.admin` khác.
- Nếu đụng `dashboard`, hãy verify kỹ auth/secret flow bằng SDK docs trước khi viết logic nhạy cảm.

Khi dùng `admin.dashboard`, ưu tiên:

- đọc lại [README.md của SDK](/README.md)
- đọc lại [DASHBOARD guide của SDK](/docs/guides/DASHBOARD.md)
- tra thêm [API_DASHBOARD.md của SDK](/docs/reference/API_DASHBOARD.md)

## 7. `admin` hiện có những domain nào

- `admin.characterPlayer`: social/gameplay theo character, thường cần `characterId` rõ ràng
- `admin.content`: content config, upload metadata, file info
- `admin.gamePlayer`: gameplay/profile/player data ở cấp game player
- `admin.group`: group metadata, member, message, currency, statistics
- `admin.inventory`: inventory/item metadata và log
- `admin.masterPlayer`: account/profile/identity ở cấp master player
- `admin.storeInventory`: store/ecommerce, receipt, used/remove state
- `admin.multiplayer`: matchmaking, ticket, match query
- `admin.cloudScript`: publish/edit/execute/list version cloud script
- `admin.dashboard`: dashboard/maintenance/admin account/game settings/analytics

Nếu cần hiểu semantics sâu hơn từng domain, đọc doc tương ứng trong SDK repo:

- [MASTER_PLAYER guide](/docs/guides/MASTER_PLAYER.md)
- [GAME_PLAYER guide](/docs/guides/GAME_PLAYER.md)
- [CHARACTER_PLAYER guide](/docs/guides/CHARACTER_PLAYER.md)
- [INVENTORY guide](/docs/guides/INVENTORY.md)
- [GROUP guide](/docs/guides/GROUP.md)
- [STORE_INVENTORY guide](/docs/guides/STORE_INVENTORY.md)
- [MULTIPLAYER guide](/docs/guides/MULTIPLAYER.md)
- [CLOUDSCRIPT guide](/docs/guides/CLOUDSCRIPT.md)
- [API index](/docs/reference/API_INDEX.md)

## 8. Pattern chung cho ví dụ

Các ví dụ dưới đây giả sử script đang chạy trong template CloudScript hiện tại, nên bạn có sẵn:

- `GamePlayerModels`
- `MasterPlayerModels`
- `GroupModels`
- `DashboardModels`
- `CloudScriptModels`
- `GNHashtable`
- `OwnerType`
- `ErrorCode`
- `gameId` — biến global (string) chứa id của game hiện tại, do template CloudScript inject sẵn vào scope. Dùng trực tiếp ở các method dashboard cần `gameId`.

Nên chuẩn bị 2 helper nhỏ để ví dụ ngắn mà vẫn an toàn:

```ts
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
        throw new Error(actionName + " business error: " + response.errorCode + (response.debugMessage ? " - " + response.debugMessage : ""));
    }
};
```

## 9. Nhiều ví dụ thực chiến

### 9.1. Đọc game info qua `admin.dashboard.getGameInformationAsync`

```ts
handlers["adminGetGameInfo"] = async (args: Record<string, unknown>, context, log) => {
    const requestData = new DashboardModels.GetGameInformationRequestData();
    requestData.gameId = gameId;

    const response = await admin.dashboard.getGameInformationAsync(requestData);

    assertResponseOk(response, "admin.dashboard.getGameInformationAsync");

    return response.responseData;
};
```

Điểm chính:

- Build request bằng `new DashboardModels.GetGameInformationRequestData()` rồi set field — giống mọi domain khác (xem §5.3 trong USAGE).
- `dashboard` là case đặc biệt về mapping (xem §6), nhưng **không** phải exception về cách build request DTO.

### 9.2. Đọc snapshot game player và tự tạo nếu chưa có

```ts
handlers["adminGetOrCreateGamePlayerProfile"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");

    const infoRequestParam = new GamePlayerModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.playerCurrencies = true;
    infoRequestParam.playerCurrencyKeys = ["gold", "gem"];
    infoRequestParam.playerInventories = true;
    infoRequestParam.itemCatalogIds = ["weapon", "consumable"];
    infoRequestParam.playerStatistics = true;
    infoRequestParam.playerStatisticsKeys = ["rankScore"];

    const requestData = new GamePlayerModels.AdminGetPlayerInformationRequestData();
    requestData.userId = targetUserId;
    requestData.infoRequestParam = infoRequestParam;
    requestData.createPlayerIfNotExists = true;

    const response = await admin.gamePlayer.getPlayerInformationAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.getPlayerInformationAsync");

    return response.responseData.infoResponseParameters;
};
```

Điểm chính:

- Route `admin` phải truyền `userId` rõ ràng.
- `createPlayerIfNotExists` phù hợp cho backend provisioning, không nên bật một cách vô thức.

### 9.3. Cộng hoặc trừ currency cho game player

```ts
handlers["adminAdjustGamePlayerCurrency"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");

    const gold = new GamePlayerModels.PlayerCurrencyParam();
    gold.key = "gold";
    gold.value = typeof args?.goldDelta === "number" ? args.goldDelta : 100;

    const gem = new GamePlayerModels.PlayerCurrencyParam();
    gem.key = "gem";
    gem.value = typeof args?.gemDelta === "number" ? args.gemDelta : 0;

    const requestData = new GamePlayerModels.AdminChangePlayerCurrencyRequestData();
    requestData.userId = targetUserId;
    requestData.playerCurrencies = [gold, gem];
    requestData.log = "cloudscript adminAdjustGamePlayerCurrency, requestedBy=" + (context.userId ?? "system");

    const response = await admin.gamePlayer.changePlayerCurrencyAsync(requestData);
    assertResponseOk(response, "admin.gamePlayer.changePlayerCurrencyAsync");

    return response.responseData.infoResponseParameters;
};
```

Điểm chính:

- Đây là delta change, không phải set tuyệt đối.
- `request.log` là field audit của operation, khác với callback `log(value)` của CloudScript handler.

### 9.4. Tạo item cho player rồi re-query inventory relation

```ts
handlers["adminGrantStarterSword"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");

    const createRequestData = new GamePlayerModels.AdminCreatePlayerItemRequestData();
    createRequestData.userId = targetUserId;
    createRequestData.catalogId = "weapon";
    createRequestData.classId = "sword";
    createRequestData.displayName = "Starter Sword";
    createRequestData.amount = 1;

    const createResponse = await admin.gamePlayer.createPlayerItemAsync(createRequestData);
    assertResponseOk(createResponse, "admin.gamePlayer.createPlayerItemAsync");

    const inventoryRequestData = new GamePlayerModels.AdminGetPlayerInventoryRequestData();
    inventoryRequestData.userId = targetUserId;
    inventoryRequestData.itemCatalogIds = ["weapon"];

    const inventoryResponse = await admin.gamePlayer.getPlayerInventoryAsync(inventoryRequestData);
    assertResponseOk(inventoryResponse, "admin.gamePlayer.getPlayerInventoryAsync");

    return {
        createResponseData: createResponse.responseData,
        playerInventories: inventoryResponse.responseData.infoResponseParameters.playerInventories,
    };
};
```

Điểm chính:

- Đừng giả định `createPlayerItemAsync` luôn trả thẳng `itemId` vừa tạo.
- Nếu flow cần relation item sau khi grant, re-query là cách rõ ràng hơn.

### 9.5. Đọc profile account-level qua `admin.masterPlayer`

```ts
handlers["adminGetMasterPlayerProfile"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");

    const infoRequestParam = new MasterPlayerModels.InfoRequestParam();
    infoRequestParam.displayName = true;
    infoRequestParam.email = true;
    infoRequestParam.playerCurrencies = true;
    infoRequestParam.playerCurrencyKeys = ["gold"];
    infoRequestParam.tags = true;
    infoRequestParam.tagKeys = ["vipTier", "region"];

    const requestData = new MasterPlayerModels.AdminGetPlayerInformationRequestData();
    requestData.userId = targetUserId;
    requestData.infoRequestParam = infoRequestParam;

    const response = await admin.masterPlayer.getPlayerInformationAsync(requestData);
    assertResponseOk(response, "admin.masterPlayer.getPlayerInformationAsync");

    return response.responseData.infoResponseParameters;
};
```

Điểm chính:

- `masterPlayer` là account/profile level.
- Nếu bạn đang thao tác dữ liệu gameplay trong từng game, `gamePlayer` mới là domain đúng.

### 9.6. Gắn tag cho group qua `admin.group.setTagAsync`

```ts
handlers["adminMarkGroupQueue"] = async (args: Record<string, unknown>, context, log) => {
    const groupId = requireString(args?.groupId, "groupId");

    const requestData = new GroupModels.AdminSetTagRequestData();
    requestData.groupId = groupId;
    requestData.key = "queue";
    requestData.value = "ranked";

    const response = await admin.group.setTagAsync(requestData);
    assertResponseOk(response, "admin.group.setTagAsync");

    return {
        groupId: groupId,
        tag: {
            key: requestData.key,
            value: requestData.value,
        },
    };
};
```

Điểm chính:

- `groupId` là bắt buộc và là explicit target.
- `setTagAsync` là upsert một cặp `key/value`, không phải merge cả object tags lớn.

### 9.7. Gọi một CloudScript function khác bằng `admin.cloudScript.executeFunctionAsync`

```ts
handlers["adminExecuteAnotherCloudScript"] = async (args: Record<string, unknown>, context, log) => {
    const targetUserId = requireString(args?.userId, "userId");
    const functionName = requireString(args?.functionName, "functionName");

    const requestData = new CloudScriptModels.AdminExecuteFunctionRequestData();
    requestData.userId = targetUserId;
    requestData.functionName = functionName;
    requestData.version = typeof args?.version === "string" ? args.version : undefined;
    requestData.functionParameters = args?.functionParameters ?? {
        source: "adminExecuteAnotherCloudScript",
        requestedBy: context.userId,
    };

    const customTags = GNHashtable.builder()
        .add("traceId", args?.traceId ?? "cloudscript-admin-chain")
        .add("source", "admin.cloudScript.executeFunctionAsync")
        .build();

    const response = await admin.cloudScript.executeFunctionAsync(requestData, undefined, undefined, customTags);

    assertResponseOk(response, "admin.cloudScript.executeFunctionAsync");

    return {
        status: response.responseData.status,
        functionResult: response.responseData.functionResult,
        functionLogs: response.responseData.functionLogs,
        errorMessage: response.responseData.errorMessage,
    };
};
```

Điểm chính:

- Nếu không truyền `version`, runtime sẽ chạy theo rule live version hiện tại.
- `customTags` ở đây sẽ đi tiếp xuống function được execute, phù hợp cho trace và correlation id.

### 9.8. Lấy analytics với payload tối giản

```ts
handlers["adminGetLeanAnalytics"] = async (args: Record<string, unknown>, context, log) => {
    const requestData = new DashboardModels.GetAnalyticsRequestData();
    requestData.timestamp = typeof args?.timestamp === "number" ? args.timestamp : undefined;
    requestData.country = true;
    requestData.requestComplete = true;
    requestData.monthlyCost = true;

    const response = await admin.dashboard.getAnalyticsAsync(requestData);

    assertResponseOk(response, "admin.dashboard.getAnalyticsAsync");

    return response.responseData;
};
```

Điểm chính:

- Chỉ bật đúng các flag cần lấy.
- Với analytics/snapshot lớn, payload tối giản giúp giảm noise và cost đọc dữ liệu.

### 9.9. Hard delete trực tiếp trong DB qua `admin.dashboard.deleteInDatabaseAsync`

```ts
handlers["adminDeleteInventoryRow"] = async (args: Record<string, unknown>, context, log) => {
    const itemId = requireString(args?.itemId, "itemId");

    const requestData = new DashboardModels.DeleteInDatabaseRequestData();
    requestData.gameId = gameId;
    requestData.type = OwnerType.Inventory as number;
    requestData.id = itemId;
    requestData.log = "manual cleanup from cloudscript, requestedBy=" + (context.userId ?? "system");

    const response = await admin.dashboard.deleteInDatabaseAsync(requestData);

    assertResponseOk(response, "admin.dashboard.deleteInDatabaseAsync");

    return {
        deleted: true,
        type: requestData.type,
        id: requestData.id,
    };
};
```

Điểm chính:

- Đây là operation phá hủy dữ liệu thật, không phải soft remove.
- Chỉ dùng khi đã có xác nhận vận hành rõ ràng.
- Nên luôn đi kèm `request.log` để giữ dấu vết audit.

## 10. Khi nào dùng `admin.sendAsync(...)`

Chỉ dùng `admin.sendAsync(...)` khi:

- Bạn biết rất rõ `RequestType`, `RequestRole`, request model và payload wire format.
- Typed facade method bạn cần chưa được expose thuận tiện.

Không nên ưu tiên `admin.sendAsync(...)` nếu:

- `admin.<domain>.<method>Async(...)` đã có sẵn.
- Bạn chưa chắc request model nào cần dùng.
- Bạn mới chỉ suy đoán operation code từ tên handler phía server.

Với CloudScript, đây là low-level escape hatch. AI không nên chọn đường này trước.

## 11. Reference source

Source trong GearN-Server repo:

1. [@GearN-Server/CloudScriptAdmin.ts](@GearN-Server/dist/GN-startup/cloudScript/CloudScriptAdmin.ts)
2. [@GearN-Server/templateCloudScript.ts](@GearN-Server/dist/GN-startup/cloudScript/templateCloudScript.ts)
3. [@GearN-Server/AddFunctionRequestHandler.ts](@GearN-Server/src/GN-app-api/handler/controller/handler/cloudScript/AddFunctionRequestHandler.ts)
4. [@GearN-Server/ExecuteFunctionRequestHandler.ts](@GearN-Server/src/GN-app-api/handler/controller/handler/cloudScript/ExecuteFunctionRequestHandler.ts)

Source trong repo này:

1. [docs/guides/DASHBOARD.md](/docs/guides/DASHBOARD.md) · [docs/reference/API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md)
2. [docs/guides/MASTER_PLAYER.md](/docs/guides/MASTER_PLAYER.md) · [docs/reference/API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md)
3. [docs/guides/GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md) · [docs/reference/API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md)
4. [docs/guides/CHARACTER_PLAYER.md](/docs/guides/CHARACTER_PLAYER.md) · [docs/reference/API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md)
5. [docs/guides/GROUP.md](/docs/guides/GROUP.md) · [docs/reference/API_GROUP.md](/docs/reference/API_GROUP.md)
6. [docs/guides/INVENTORY.md](/docs/guides/INVENTORY.md) · [docs/reference/API_INVENTORY.md](/docs/reference/API_INVENTORY.md)
7. [docs/guides/STORE_INVENTORY.md](/docs/guides/STORE_INVENTORY.md) · [docs/reference/API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md)
8. [docs/guides/CONTENT.md](/docs/guides/CONTENT.md) · [docs/reference/API_CONTENT.md](/docs/reference/API_CONTENT.md)
9. [docs/guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) · [docs/reference/API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md)
10. [docs/guides/MULTIPLAYER.md](/docs/guides/MULTIPLAYER.md) · [docs/reference/API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md)

## 12. Kết luận ngắn

Muốn AI dùng `admin` đúng, chỉ cần nhớ 6 ý:

1. `admin` là wrapper an toàn cho official SDK API, không phải raw DB.
2. Route `admin` là privileged caller boundary, không phải “target là user khác”.
3. Với nhiều domain, payload `admin` yêu cầu field rõ ràng hơn route `client`, đặc biệt là `userId`.
4. `dashboard` là ngoại lệ tương đối lớn; khi đụng nó hãy đọc semantics riêng trước.
5. `request.log` của operation và callback `log(value)` của CloudScript là hai thứ khác nhau.
6. Nếu flow cần audit, provisioning, hoặc destructive operation, hãy viết ví dụ theo hướng explicit và traceable thay vì “đoán là backend sẽ tự hiểu”.
