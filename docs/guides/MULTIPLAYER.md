# MultiplayerApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.multiplayer*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, và chỉ mở đúng row trong [API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho `GNNetwork.multiplayer`, `GNNetwork.multiplayer.server`, và `GNNetwork.multiplayer.admin`.
- Tất cả method hiện tại của `MultiplayerApi` đi qua HTTP; không dùng socket.
- `MultiplayerApi` có 3 role thật:
    - `GNNetwork.multiplayer` -> `RequestRole.Client`
    - `GNNetwork.multiplayer.server` -> `RequestRole.Server`
    - `GNNetwork.multiplayer.admin` -> `RequestRole.Admin`
- Domain này xử lý matchmaking ticket lifecycle, queue statistics, và match query. Nó không thay thế socket realtime của SDK.
- Với `MultiplayerApi`, backend không ép self/other-self theo ownership rõ ràng; chọn route theo actor thật và permission rule. Xem [RULES.md route rules](/docs/RULES.md).

## 2. Hard Rules

- Ưu tiên `async/await`; mặc định dùng `*Async()`.
- Bắt buộc đã có `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket để tạo, join, cancel, poll, hoặc query matchmaking ticket.
- Chọn namespace theo nơi code chạy: Unity client, trusted backend/worker, hay dashboard/admin tool.
- Chỉ dùng `.server` khi code chạy trong trusted backend/worker và secret có permission `serverSelfEnable` phù hợp.
- Chỉ dùng `.admin` khi code chạy trong dashboard/backoffice/admin tool và secret có permission `adminSelfEnable` phù hợp.
- Với `server` và `admin`, các operation thao tác ticket theo player thường dùng request DTO variant có `userId`; không bỏ qua field này nếu DTO yêu cầu.
- `createMatchmakingTicketAsync` chỉ trả `ticketId`, không trả match ngay.
- `joinMatchmakingTicketAsync` và `cancelMatchmakingTicketAsync` trả `EmptyResponseData`; nếu cần state mới, query tiếp.
- Không giả định `GetMatchResponseData` có IP/port server. Model hiện tại không expose server endpoint.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.multiplayer` | `Client` | Unity client/player app thao tác bằng auth token hiện tại |
| `GNNetwork.multiplayer.server` | `Server` | Backend service, worker, CloudScript runtime, internal service |
| `GNNetwork.multiplayer.admin` | `Admin` | Dashboard, GM tool, backoffice, tooling vận hành |

Rule nhanh:

- Code chạy trong game client: ưu tiên `GNNetwork.multiplayer`.
- Code chạy ở trusted backend hoặc worker: ưu tiên `GNNetwork.multiplayer.server`.
- Code chạy ở dashboard/tool vận hành: ưu tiên `GNNetwork.multiplayer.admin`.
- Cần thao tác cùng operation nhưng khác quyền: giữ nguyên method, đổi namespace cho đúng role.
- Chỉ dùng `overrideSecretKey` khi có chủ đích override secret mặc định theo role cho một request.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_MULTIPLAYER.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client`, `server` và `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `createMatchmakingTicketAsync` | Tạo ticket mới để bắt đầu matchmaking | `giveUpAfterSeconds`, `queueName`, `attribute?`, `members?`; `server/admin` thêm `userId` | `responseData.ticketId` | [client:18-18](/docs/reference/API_MULTIPLAYER.md) / [server:34-34](/docs/reference/API_MULTIPLAYER.md) / [admin:50-50](/docs/reference/API_MULTIPLAYER.md) |
| `joinMatchmakingTicketAsync` | Thêm player vào ticket đã tồn tại | `ticketId`, `attribute?`; `server/admin` thêm `userId` | `EmptyResponseData` | [client:22-22](/docs/reference/API_MULTIPLAYER.md) / [server:38-38](/docs/reference/API_MULTIPLAYER.md) / [admin:54-54](/docs/reference/API_MULTIPLAYER.md) |
| `cancelMatchmakingTicketAsync` | Hủy một ticket cụ thể | `ticketId`; `server/admin` thêm `userId` | `EmptyResponseData` | [client:17-17](/docs/reference/API_MULTIPLAYER.md) / [server:33-33](/docs/reference/API_MULTIPLAYER.md) / [admin:49-49](/docs/reference/API_MULTIPLAYER.md) |
| `cancelAllMatchmakingTicketAsync` | Hủy toàn bộ ticket của player trong một queue | `queueName`; `server/admin` thêm `userId` | `responseData.ticketIds` | [client:16-16](/docs/reference/API_MULTIPLAYER.md) / [server:32-32](/docs/reference/API_MULTIPLAYER.md) / [admin:48-48](/docs/reference/API_MULTIPLAYER.md) |
| `getMatchmakingTicketAsync` | Poll trạng thái ticket cụ thể | `ticketId`, `returnMember?` | `responseData.matchmakingTicket` | [client:19-19](/docs/reference/API_MULTIPLAYER.md) / [server:35-35](/docs/reference/API_MULTIPLAYER.md) / [admin:51-51](/docs/reference/API_MULTIPLAYER.md) |
| `listMatchmakingTicketsForPlayerAsync` | Liệt kê ticket của player trong một queue | `queueName`; `server/admin` thêm `userId` | `responseData.results` | [client:23-23](/docs/reference/API_MULTIPLAYER.md) / [server:39-39](/docs/reference/API_MULTIPLAYER.md) / [admin:55-55](/docs/reference/API_MULTIPLAYER.md) |
| `getMatchAsync` | Lấy chi tiết một match theo `matchId` | `matchId`, `returnMember?` | `responseData.match` | [client:20-20](/docs/reference/API_MULTIPLAYER.md) / [server:36-36](/docs/reference/API_MULTIPLAYER.md) / [admin:52-52](/docs/reference/API_MULTIPLAYER.md) |
| `getAllMatchAsync` | Liệt kê match hiện có | `returnMember?`, `skip?`, `limit?` | `responseData.results` | [client:24-24](/docs/reference/API_MULTIPLAYER.md) / [server:40-40](/docs/reference/API_MULTIPLAYER.md) / [admin:56-56](/docs/reference/API_MULTIPLAYER.md) |
| `getAllMatchmakingTicketAsync` | Liệt kê ticket hiện có, thường cho vận hành/debug | `status?`, `returnMember?`, `skip?`, `limit?` | `responseData.results` | [client:25-25](/docs/reference/API_MULTIPLAYER.md) / [server:41-41](/docs/reference/API_MULTIPLAYER.md) / [admin:57-57](/docs/reference/API_MULTIPLAYER.md) |
| `getQueueStatisticsAsync` | Lấy thống kê queue trong một time window | `queueName`, `timeInSeconds` | `pendingMemberCount`, `pendingTicketCount`, `averageMatchmakingTimeInSeconds` | [client:21-21](/docs/reference/API_MULTIPLAYER.md) / [server:37-37](/docs/reference/API_MULTIPLAYER.md) / [admin:53-53](/docs/reference/API_MULTIPLAYER.md) |

Decision rules:

- Muốn bắt đầu tìm trận: dùng `createMatchmakingTicketAsync`.
- Muốn ghép thêm player vào ticket đang có: dùng `joinMatchmakingTicketAsync`.
- Muốn xem ticket đã matched chưa: dùng `getMatchmakingTicketAsync`.
- Đã có `matchId` và muốn lấy match detail: dùng `getMatchAsync`.
- Muốn xem ticket của current player trong queue: dùng `listMatchmakingTicketsForPlayerAsync`.
- Muốn xem snapshot queue hiện tại: dùng `getQueueStatisticsAsync`.
- Muốn duyệt toàn bộ ticket hoặc match để vận hành: dùng `getAllMatchmakingTicketAsync` hoặc `getAllMatchAsync`.
- Muốn hủy ticket: dùng `cancelMatchmakingTicketAsync`; muốn hủy hàng loạt trong queue: dùng `cancelAllMatchmakingTicketAsync`.

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.multiplayer.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.multiplayer.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new MultiplayerModels.<Method>RequestData()` hoặc role variant |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/MULTIPLAYER.md](/docs/reference/dto/MULTIPLAYER.md).
- Contract table: [reference/API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md).
- Enums: [MatchmakingTicketStatus](/docs/reference/ENUMS.md#matchmakingticketstatus), [MatchmakingMemberStatus](/docs/reference/ENUMS.md#matchmakingmemberstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Multiplayer*.cs`.

<!-- prettier-ignore -->
| DTO / field | Quick rule | DTO link |
| --- | --- | --- |
| `CreateMatchmakingTicketRequestData.giveUpAfterSeconds` | required, min `20`; không dùng để đoán thời điểm match chắc chắn | [MultiplayerModels.CreateMatchmakingTicketRequestData:77-88](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#creatematchmakingticketrequestdata) |
| `queueName` | required trong create/list/cancelAll/statistics; min `6`, max `32` | [create:77-88](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#creatematchmakingticketrequestdata) / [list:330-338](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#listmatchmakingticketsforplayerrequestdata) / [stats:257-266](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getqueuestatisticsrequestdata) |
| `ticketId` | required trong join/cancel/get ticket; length `10` | [join:291-300](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#joinmatchmakingticketrequestdata) / [cancel:39-47](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#cancelmatchmakingticketrequestdata) / [get:118-127](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchmakingticketrequestdata) |
| `matchId` | required trong get match; length `15` | [MultiplayerModels.GetMatchRequestData:152-161](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchrequestdata) |
| `GetQueueStatisticsRequestData.timeInSeconds` | required, min `20` | [MultiplayerModels.GetQueueStatisticsRequestData:257-266](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getqueuestatisticsrequestdata) |
| `GetAllMatchmakingTicketRequestData.status` | optional numeric field; map bằng `MatchmakingTicketStatus`, không hardcode số | [MultiplayerModels.GetAllMatchmakingTicketRequestData:221-232](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getallmatchmakingticketrequestdata) |
| `returnMember` | optional, default `false`; chỉ bật khi thật sự cần member list | [get ticket:118-127](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchmakingticketrequestdata) / [get match:152-161](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#getmatchrequestdata) |
| `Server*RequestData.userId` / `Admin*RequestData.userId` | required với các role variant thao tác theo player cụ thể | [server create:77-105](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#servercreatematchmakingticketrequestdata) / [admin create:77-117](/docs/reference/dto/multiplayer/MULTIPLAYER_MODELS.md#admincreatematchmakingticketrequestdata) |

## 7. Matchmaking Sequence

### Client tạo ticket mới

1. Gọi `createMatchmakingTicketAsync(...)`.
2. Lấy `ticketId` từ `createResponse.responseData.ticketId`.
3. Poll `getMatchmakingTicketAsync(...)` bằng `ticketId`.
4. Khi `matchmakingTicket.status == MatchmakingTicketStatus.Matched` và có `matchId`, gọi `getMatchAsync(...)`.

### Join ticket đã có

1. Gọi `joinMatchmakingTicketAsync(...)`.
2. Poll `getMatchmakingTicketAsync(...)`.
3. Khi có `matchId`, gọi `getMatchAsync(...)`.

### Hủy

1. Gọi `cancelMatchmakingTicketAsync(...)` hoặc `cancelAllMatchmakingTicketAsync(...)`.
2. Nếu cần xác nhận state hiện tại, gọi `getMatchmakingTicketAsync(...)` hoặc `listMatchmakingTicketsForPlayerAsync(...)`.

Rule cứng:

- Không chờ `createMatchmakingTicketAsync` trả match data.
- Không chờ `joinMatchmakingTicketAsync` trả ticket state mới.
- Không bỏ bước poll nếu flow cần biết đã match hay chưa.
- Poll với nhịp hợp lý; không spam request dày.

## 8. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new MultiplayerModels.CreateMatchmakingTicketRequestData();
requestData.giveUpAfterSeconds = 60;
requestData.queueName = "ranked01";

var response = await GNNetwork.multiplayer.createMatchmakingTicketAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var ticketId = response.responseData.ticketId;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

## 9. Ví dụ Khuyến Nghị

### Client tạo ticket rồi poll tới khi có match

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequestData = new MultiplayerModels.CreateMatchmakingTicketRequestData();
createRequestData.giveUpAfterSeconds = 60;
createRequestData.queueName = "ranked01";

var createResponse = await GNNetwork.multiplayer.createMatchmakingTicketAsync(createRequestData);

if (createResponse.returnCode != ReturnCode.Ok) return;
if (createResponse.errorCode != ErrorCode.Ok) return;

var ticketId = createResponse.responseData.ticketId;

var ticketRequestData = new MultiplayerModels.GetMatchmakingTicketRequestData();
ticketRequestData.ticketId = ticketId;

var ticketResponse = await GNNetwork.multiplayer.getMatchmakingTicketAsync(ticketRequestData);

if (ticketResponse.returnCode != ReturnCode.Ok) return;
if (ticketResponse.errorCode != ErrorCode.Ok) return;

var ticket = ticketResponse.responseData.matchmakingTicket;
if (ticket.status == MatchmakingTicketStatus.Matched && !string.IsNullOrEmpty(ticket.matchId)) {
    var matchRequestData = new MultiplayerModels.GetMatchRequestData();
    matchRequestData.matchId = ticket.matchId;

    var matchResponse = await GNNetwork.multiplayer.getMatchAsync(matchRequestData);

    if (matchResponse.returnCode != ReturnCode.Ok) return;
    if (matchResponse.errorCode != ErrorCode.Ok) return;

    var match = matchResponse.responseData.match;
}
```

### Server tạo ticket cho user cụ thể

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new MultiplayerModels.ServerCreateMatchmakingTicketRequestData();
requestData.userId = "1234567890";
requestData.giveUpAfterSeconds = 60;
requestData.queueName = "ranked01";

var response = await GNNetwork.multiplayer.server.createMatchmakingTicketAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var ticketId = response.responseData.ticketId;
```

### Admin list ticket theo status

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new MultiplayerModels.AdminGetAllMatchmakingTicketRequestData();
requestData.status = MatchmakingTicketStatus.WaitingForMatch;
requestData.limit = 20;
requestData.returnMember = false;

var response = await GNNetwork.multiplayer.admin.getAllMatchmakingTicketAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var tickets = response.responseData.results;
```

## 10. Anti-Patterns

- Không dùng socket để tạo hoặc query matchmaking ticket.
- Không chờ `createMatchmakingTicketAsync` trả match object.
- Không chờ `joinMatchmakingTicketAsync` hoặc `cancelMatchmakingTicketAsync` trả state mới.
- Không hardcode numeric status nếu enum đã có.
- Không giả định `GetMatchResponseData` có IP/port server.
- Không bỏ qua `userId` ở namespace `server/admin` khi model yêu cầu.
- Không bật `returnMember` cho mọi request nếu không cần.
- Không bỏ qua check `returnCode` và `errorCode`.
- Không dùng callback style mặc định khi codebase đã support `async/await`.

## 11. AI Checklist

- Đã có `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `multiplayer` / `multiplayer.server` / `multiplayer.admin` chưa.
- Có nhớ `MultiplayerApi` chỉ đi qua HTTP không.
- Nếu đang tạo ticket, có hiểu response chỉ trả `ticketId` không.
- Nếu cần biết đã matched chưa, có poll `getMatchmakingTicketAsync` chưa.
- Nếu đang ở `server/admin`, DTO hiện tại có yêu cầu `userId` không.
- Nếu đang lọc status, có dùng enum `MatchmakingTicketStatus` không.
- Có tránh giả định response match sẽ trả server endpoint không.
- Có check `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 29-44 |
| §4 Chọn Method (bảng 10 method + decision rules) | 46-78 |
| §7 Matchmaking Sequence | 126-151 |
| §8 Minimal Pattern | 153-172 |
| §9 Ví Dụ Khuyến Nghị | 174-254 |
