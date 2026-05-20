# AI Cheatsheet

One-page reference cho AI agent / code assistant. Đọc file này trước, đào sâu khi cần.

> Package: `com.xmobitea.changx.gearn-unity-client-sdk` · Entry point: `GNNetwork` (static class) · Stack: Unity/C#, HTTP + socket io realtime.

> **Điều hướng nhanh:** Biết task cụ thể → [AGENTS.md §6 Quick Task Map](/AGENTS.md#6-quick-task-map). Cần rule route/permission/socket → [RULES.md quick-jump](/docs/RULES.md#quick-jump). Cần scenario end-to-end → [COOKBOOK.md Index](/docs/COOKBOOK.md#index) (có range-line từng scenario).

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

var response = await GNNetwork.authenticate.loginByAccountAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return; // transport / permission
if (response.errorCode != ErrorCode.Ok) return;   // business

UseResult(response.responseData);
```

`Ok == 1` ở **cả** `ReturnCode` và `ErrorCode`. **KHÔNG** giả định `Ok == 0`. **KHÔNG** đọc `errorCode` / `responseData` khi `returnCode != Ok`.

**Throw vs early-return**: cả 2 style đều OK miễn giữ thứ tự `returnCode` → `errorCode`. KHÔNG dùng `try/catch` chung 1 lần cho cả 2 tầng (mất ngữ nghĩa transport vs business). KHÔNG gộp `if (returnCode != Ok || errorCode != Ok)` (mất khả năng log riêng từng tầng).

**CloudScript variant** (chỉ cho `cloudScript.executeFunctionAsync`): thêm 2 tầng sau khi pass 2-tier trên:

```csharp
if (!string.IsNullOrEmpty(response.responseData.errorMessage)) return;     // script throw
var status = (ExecuteResponseStatus)response.responseData.status;
if (status != ExecuteResponseStatus.Ok) return;                            // script trả status khác Ok
var result = response.responseData.functionResult;
```

---

## 2. Decision tree: What I need do?

<!-- prettier-ignore -->
| Tôi muốn... | Đọc nhanh (line range) | Full file |
| --- | --- | --- |
| Login / register / refresh token | [AUTHENTICATE.md:36-76](/docs/guides/AUTHENTICATE.md) — §4 Chọn Method | [guides/AUTHENTICATE.md](/docs/guides/AUTHENTICATE.md) · [API_AUTHENTICATE.md](/docs/reference/API_AUTHENTICATE.md) |
| Minimal login pattern + ví dụ | [AUTHENTICATE.md:139-241](/docs/guides/AUTHENTICATE.md) — §8-9 | — |
| MasterPlayer account chung nhiều game: identity, external link/unlink, profile, statistics, currencies, player data, email/push, segment/tag/ban | [MASTER_PLAYER.md:69-187](/docs/guides/MASTER_PLAYER.md) — §4 Chọn Method | [guides/MASTER_PLAYER.md](/docs/guides/MASTER_PLAYER.md) · [API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md) |
| GamePlayer đọc profile/field | [GAME_PLAYER.md:104-127](/docs/guides/GAME_PLAYER.md) — §5 bảng đọc 1 player | [guides/GAME_PLAYER.md](/docs/guides/GAME_PLAYER.md) · [API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md) |
| GamePlayer friend/group lifecycle | [GAME_PLAYER.md:146-159](/docs/guides/GAME_PLAYER.md) — §5 bảng lifecycle | — |
| GamePlayer mutation (currency, statistics, data) | [GAME_PLAYER.md:161-177](/docs/guides/GAME_PLAYER.md) — §5 bảng mutation | — |
| GamePlayer search / leaderboard | [GAME_PLAYER.md:128-144](/docs/guides/GAME_PLAYER.md) — §5 bảng search | — |
| CharacterPlayer nhân vật thuộc GamePlayer | [CHARACTER_PLAYER.md:79-229](/docs/guides/CHARACTER_PLAYER.md) — §4-5 (namespace + 4 method table) | [guides/CHARACTER_PLAYER.md](/docs/guides/CHARACTER_PLAYER.md) · [API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md) |
| Inventory item: query, owner, amount, statistics | [INVENTORY.md:36-123](/docs/guides/INVENTORY.md) — §3-4 | [guides/INVENTORY.md](/docs/guides/INVENTORY.md) · [API_INVENTORY.md](/docs/reference/API_INVENTORY.md) |
| Group metadata, member, message, group inventory | [GROUP.md:64-144](/docs/guides/GROUP.md) — §4-5 Chọn Method | [guides/GROUP.md](/docs/guides/GROUP.md) · [API_GROUP.md](/docs/reference/API_GROUP.md) |
| Store catalog, buy, present, validate receipt | [STORE_INVENTORY.md:30-97](/docs/guides/STORE_INVENTORY.md) — §3-4 | [guides/STORE_INVENTORY.md](/docs/guides/STORE_INVENTORY.md) · [API_STORE_INVENTORY.md](/docs/reference/API_STORE_INVENTORY.md) |
| Matchmaking ticket / queue / match query | [MULTIPLAYER.md:29-78](/docs/guides/MULTIPLAYER.md) — §3-4 | [guides/MULTIPLAYER.md](/docs/guides/MULTIPLAYER.md) · [API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md) |
| Content config + upload/download file metadata | [CONTENT.md:28-71](/docs/guides/CONTENT.md) — §3-4 | [guides/CONTENT.md](/docs/guides/CONTENT.md) · [API_CONTENT.md](/docs/reference/API_CONTENT.md) |
| CloudScript: viết script, publish version, execute function | [CLOUDSCRIPT.md:56-81](/docs/guides/CLOUDSCRIPT.md) — §4 Chọn Method | [cloudScript/CLOUDSCRIPT_USAGE.md](/docs/cloudScript/CLOUDSCRIPT_USAGE.md) · [guides/CLOUDSCRIPT.md](/docs/guides/CLOUDSCRIPT.md) · [API_CLOUDSCRIPT.md](/docs/reference/API_CLOUDSCRIPT.md) |
| Admin login, secret/maintenance/analytics | [DASHBOARD.md:39-113](/docs/guides/DASHBOARD.md) — §4 Chọn Method | [guides/DASHBOARD.md](/docs/guides/DASHBOARD.md) · [API_DASHBOARD.md](/docs/reference/API_DASHBOARD.md) |
| Realtime event (friend, group, message) | — | [reference/EVENTS.md](/docs/reference/EVENTS.md) |
| Viết custom DTO / payload event bằng `[DataMember]` | — | [reference/DATAMEMBER.md](/docs/reference/DATAMEMBER.md) |
| Gặp `CustomOperationRequestAbstract<T>` / `CustomOperationResponseAbstract<T>` | — | [reference/OPERATION_BASES.md](/docs/reference/OPERATION_BASES.md) |
| Tra DTO field theo class | — | [reference/DTO_INDEX.md](/docs/reference/DTO_INDEX.md) hoặc [reference/dto/](/docs/reference/dto/) |
| Enum value numeric | — | [reference/ENUMS.md](/docs/reference/ENUMS.md) |
| Config field của `GNServerSettings` | — | [reference/CONFIG.md](/docs/reference/CONFIG.md) |
| Permission flag / `OperationNotAllow` | — | [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md) · [RULES.md § 6](/docs/RULES.md#6-permission-flags) |
| Cách check error / retry / debug | — | [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md) |
| Scenario end-to-end (cookbook) | [COOKBOOK.md Index:7-29](/docs/COOKBOOK.md) — đọc Index để lấy range rồi nhảy thẳng | [COOKBOOK.md](/docs/COOKBOOK.md) |
| Rule chung (route, permission, self/other-self, socket) | [RULES.md quick-jump:9-27](/docs/RULES.md) — đọc bảng quick-jump rồi nhảy đúng section | [RULES.md](/docs/RULES.md) |

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
var response = await GNNetwork.authenticate.loginByAccountAsync(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
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
var response = await GNNetwork.gamePlayer.getPlayerInformationAsync(requestData);
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

- Single-source-of-truth rules: [RULES.md](/docs/RULES.md) · quick-jump: [RULES.md:9-27](/docs/RULES.md)
- AI entry guide + Quick Task Map: [AGENTS.md §6](/AGENTS.md#6-quick-task-map)
- Scenario end-to-end index (có range): [COOKBOOK.md Index:7-29](/docs/COOKBOOK.md)
- llmstxt.org index: [llms.txt](/llms.txt)
