# AI Cheatsheet

One-page reference cho AI agent / code assistant. Đọc file này trước, đào sâu khi cần.

> Package: `com.xmobitea.changx.gearn-unity-client-sdk` · Entry point: `GNNetwork` (static class) · Stack: Unity/C#, HTTP + socket io realtime.

---

## 1. Mandatory pattern (sao chép & dùng)

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

// Yêu cầu trước khi chạy:
// - Đã có asset Resources/GNServerSettings.
// - Asset đã cấu hình serverAddress, ports, secretKey, messageType, logType.
// - Nếu cần chọn game context runtime, gọi GNNetwork.gnServerSettings.setGameId("<game-id>").

var requestData = new AuthenticateModels.LoginByAccountRequestData();
requestData.username = username;
requestData.password = password;

var res = await GNNetwork.authenticate.loginByAccountAsync(requestData);

if (res.returnCode != ReturnCode.Ok) return; // transport / permission
if (res.errorCode != ErrorCode.Ok) return;   // business

UseResult(res.responseData);
```

`Ok == 1` ở **cả** `ReturnCode` và `ErrorCode`. **KHÔNG** giả định `Ok == 0`.

---

## 2. Decision tree: tôi cần làm gì?

<!-- prettier-ignore -->
| Tôi muốn... | Mở file |
| --- | --- |
| Login / register / refresh token | [guides/AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md) · [reference/API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md) |
| MasterPlayer account chung nhiều game: identity, external link/unlink, profile, statistics, currencies, player data, email/push, segment/tag/ban | [guides/MASTER_PLAYER.md](/docs/guides/MASTER_PLAYER.md) · [reference/API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md) |
| GamePlayer account theo game environment: profile, friends, groups, inventory owner, online status, statistics/currencies/data | [guides/GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md) · [reference/API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md) |
| CharacterPlayer nhân vật thuộc GamePlayer: profile riêng, statistics/currencies/data, friends/groups/inventory owner theo character | [guides/CHARACTER_PLAYER.md](/docs/guides/CHARACTER_PLAYER.md) · [reference/API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md) |
| Inventory item: query, owner, amount, statistics | [guides/INVENTORY.md](/docs/guides/INVENTORY.md) · [reference/API_INVENTORY.md](/docs/reference/API_INVENTORY.md) |
| Group metadata, member, message, group inventory | [guides/GROUP.md](/docs/guides/GROUP.md) · [reference/API_GROUP.md](/docs/reference/API_GROUP.md) |
| Store catalog, buy, present, validate receipt | [guides/STORE_INVENTORY.md](/docs/guides/STORE_INVENTORY.md) · [reference/API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md) |
| Matchmaking ticket / queue / match query | [guides/MULTIPLAYER.md](/docs/guides/MULTIPLAYER.md) · [reference/API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md) |
| Content config + upload/download file metadata | [guides/CONTENT.md](/docs/guides/CONTENT.md) · [reference/API_CONTENT.md](/docs/reference/API_CONTENT.md) |
| CloudScript: viết script, publish version, execute function | [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) · [guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) · [reference/API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md) |
| Admin login, secret/maintenance/analytics | [guides/DASHBOARD.md](/docs/guides/DASHBOARD.md) · [reference/API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md) |
| Realtime event (friend, group, message) | [reference/EVENTS.md](/docs/reference/EVENTS.md) |
| Viết custom DTO / payload event bằng `[DataMember]`, `[StringDataMember]`, `[NumberDataMember]`, `[BooleanDataMember]`, `[GNHashtableDataMember]`, `[GNArrayDataMember]` | [reference/DATAMEMBER.md](/docs/reference/DATAMEMBER.md) |
| Gặp `CustomOperationRequestAbstract<T>` / `CustomOperationResponseAbstract<T>` trong DTO reference | [reference/OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) |
| Tra DTO field theo class | [reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md) hoặc [reference/dto/](/docs/reference/dto/) |
| Enum value numeric | [reference/ENUMS.md](/docs/reference/ENUMS.md) |
| Config field của `GNServerSettings` | [reference/CONFIG.md](/docs/reference/CONFIG.md) |
| Permission flag / `OperationNotAllow` | [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md) · [RULES.md § 6](/docs/RULES.md#6-permission-flags) |
| Cách check error / retry / debug | [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md) |
| Scenario end-to-end | [COOKBOOK.md](/docs/COOKBOOK.md) |
| Rule chung (route, permission, self/other-self, socket) | [RULES.md](/docs/RULES.md) |
| Machine-readable manifest cho tooling | [ai-manifest.json](/docs/ai-manifest.json) |

---

## Glossary bắt buộc

<!-- prettier-ignore -->
| Thuật ngữ | Nghĩa |
| --- | --- |
| `route` | Trust boundary của caller: client, server, hoặc admin. |
| `self` | Target thuộc user đang authenticate. |
| `other-self` | Target không thuộc user đang authenticate nhưng vẫn gọi qua route client. |
| `otherSelfEnable` | Tên permission flag trong backend config. Dùng spelling này trong code/docs. |
| `secretKey` | Key cấu hình permission per operation. Sai/thiếu secret trả `SecretInvalid`; secret đúng nhưng thiếu flag trả `OperationNotAllow`. |

---

## 3. Route decision (1 phút)

Route = **trust boundary của caller**, KHÔNG phải target ownership.

```text
Code chạy ở đâu?
├─ Unity app của player               → GNNetwork.<group>           (Client)
├─ Trusted backend / CloudScript       → GNNetwork.<group>.server    (Server)
└─ Backoffice / GM tool / dashboard    → GNNetwork.<group>.admin     (Admin)

Ngoại lệ: DashboardApi public wrapper vẫn đi RequestRole.Client; backend resolve admin từ authToken sau loginByAdminAccountAsync.
```

`self / other-self` chỉ áp dụng trên route `client`.

---

## 4. Method signature mọi API

```csharp
// Callback form
GNNetwork.authenticate.loginByAccount(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async form (preferred)
var res = await GNNetwork.authenticate.loginByAccountAsync(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

<!-- prettier-ignore -->
| Param | Khi nào cần |
| --- | --- |
| `overrideAuthToken` | Impersonate / multi-session / admin gọi trên user khác |
| `overrideSecretKey` | Override secret cho 1 request, ví dụ tool migration |
| `customTags` | Trace id, build version, A/B tag — backend có thể log/route |
| `timeout` | Override default per-request (giây) |

Trong code copy-paste, build `requestData` bằng DTO class public:

```csharp
var requestData = new GamePlayerModels.GetPlayerInformationRequestData();
var res = await GNNetwork.gamePlayer.getPlayerInformationAsync(requestData);
```

Response field public: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`.

Nếu DTO reference ghi `Extends: CustomOperationRequestAbstract<TRequestData>`, `TRequestData` là payload được serialize vào request. Nếu ghi `Extends: CustomOperationResponseAbstract<TResponseData>`, `TResponseData` là kiểu của `responseData`. Xem [reference/OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md).

---

## 5. Socket flow

```text
1. Login HTTP (`loginByAccountAsync`, `loginByCustomIdAsync`, ...) — SDK cache authToken vào StorageService
2. Subscribe event/connect/disconnect handler
3. GNNetwork.connectSocket()                — SDK auto-auth socket nếu authToken đã có
4. (chỉ khi socket connect TRƯỚC token, hoặc token vừa đổi)
   GNNetwork.sendRequestAuthSocket()        — re-auth thủ công, không reconnect
```

```csharp
GNNetwork.subscriberOnConnectHandler(() => { /* socket up */ });
GNNetwork.subscriberOnDisconnectHandler(() => { /* socket down */ });
GNNetwork.setOnEventHandler(operationEvent => { /* raw event */ });

OnGroupMessageUpdateEventHandler.onUpdate = payload => { /* handle */ };

GNNetwork.connectSocket();
```

Realtime KHÔNG tự chạy chỉ vì đã gọi HTTP. Phải subscribe handler liệt kê trong [reference/EVENTS.md](/docs/reference/EVENTS.md).

---

## 6. Top 5 pitfalls

1. **Tưởng success là `0`** → `Ok == 1` cả 2 tầng.
2. **Skip tầng `returnCode`, đọc thẳng `errorCode`** → khi `returnCode != Ok`, `errorCode` + `responseData` không đáng tin.
3. **Dùng getter `res.getReturnCode()`** → typed response dùng PUBLIC FIELDS.
4. **Dùng `.server` / `.admin` từ Unity client để vượt permission** → trust boundary leak.
5. **`OperationNotAllow` = thiếu secret** → SAI. Secret hợp lệ nhưng permission rule cấm.

Anti-patterns đầy đủ: [RULES.md § 10](/docs/RULES.md#10-anti-patterns--pitfalls).

---

## 7. Khi nào ĐƯỢC đọc `Runtime/`

- Đang sửa chính SDK.
- Verify behavior nội bộ chưa được docs cover.
- Tích hợp package: ưu tiên `AGENTS.md + docs`; chỉ đọc `Runtime/**/*.cs` khi cần xác nhận public C# type.

---

## 8. Liên kết quan trọng

- Single-source-of-truth rules: [RULES.md](/docs/RULES.md)
- AI entry guide chi tiết: [../AGENTS.md](/AGENTS.md)
- Machine manifest: [ai-manifest.json](/docs/ai-manifest.json)
- llmstxt.org index: [llms.txt](/llms.txt)
