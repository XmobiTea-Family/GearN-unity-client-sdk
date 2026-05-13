# MultiplayerApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, gọi đúng sequence matchmaking, và không nhầm `MultiplayerApi` với flow socket realtime.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.multiplayer`
    - `GNNetwork.multiplayer.server`
    - `GNNetwork.multiplayer.admin`
- Toàn bộ method hiện tại của `MultiplayerApi` đều gửi qua HTTP.
- `MultiplayerApi` có đủ 3 role thật:
    - `GNNetwork.multiplayer` -> `RequestRole.Client`
    - `GNNetwork.multiplayer.server` -> `RequestRole.Server`
    - `GNNetwork.multiplayer.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu semantics permission xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Với nhóm này, không tự suy diễn route chỉ từ target ownership.
- `MultiplayerApi` xử lý matchmaking ticket, queue statistics và dữ liệu match. Nó không thay thế socket transport của SDK.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket để tạo, join, cancel hay query matchmaking ticket. Tất cả wrapper hiện tại đều là HTTP.
- Nếu code chạy trong game client, ưu tiên `GNNetwork.multiplayer`.
- Nếu code chạy ở trusted backend/worker, ưu tiên `GNNetwork.multiplayer.server`.
- Nếu code chạy ở dashboard/tool vận hành, ưu tiên `GNNetwork.multiplayer.admin`.
- Với `server` và `admin`, một số operation thao tác theo user khác bắt buộc có `userId`.
- `createMatchmakingTicketAsync` không trả match ngay; nó chỉ trả `ticketId`.
- `joinMatchmakingTicketAsync` và `cancelMatchmakingTicketAsync` trả `EmptyResponseData`; muốn biết state mới phải gọi API query tiếp.
- Không giả định `GetMatchResponseData` có IP/port server. Model hiện tại của response không expose `ServerDetail`.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.multiplayer` | `Client` | player app tự thao tác ticket của chính user hiện tại |
| `GNNetwork.multiplayer.server` | `Server` | backend service thao tác ticket/match của user cụ thể |
| `GNNetwork.multiplayer.admin` | `Admin` | dashboard, GM tool, vận hành |

Rule nhanh:

- Nếu thao tác gắn với auth token hiện tại của player: dùng `GNNetwork.multiplayer`.
- Nếu backend/admin cần thao tác ticket của user khác: dùng `server` hoặc `admin`.
- Với `server/admin`, nếu model có thêm `userId` thì phải truyền.

## 4. Chọn Method

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `createMatchmakingTicketAsync` | Tạo ticket mới để bắt đầu matchmaking | `giveUpAfterSeconds`, `queueName`, `attribute?`, `members?` | `CreateMatchmakingTicketResponseData` | Trả `ticketId`; với `server/admin` cần thêm `userId` | `Ok`, `MatchmakingPlayerJoinedOtherTicket`, `MatchmakingQueueNotFound`, `TicketSizeError` |
| `joinMatchmakingTicketAsync` | Thêm user vào ticket đã tồn tại | `ticketId`, `attribute?` | `EmptyResponseData` | Với `server/admin` cần thêm `userId` | `Ok`, `MatchmakingTicketNotFound`, `MatchmakingTicketAlreadyCompleted`, `MatchmakingPlayerJoinedOtherTicket`, `MatchmakingQueueNotFound` |
| `cancelMatchmakingTicketAsync` | Hủy 1 ticket cụ thể | `ticketId` | `EmptyResponseData` | Với `server/admin` cần thêm `userId` | `Ok`, `MatchmakingTicketNotFound`, `MatchmakingTicketAlreadyCompleted`, `MatchmakingPlayerNotJoinedTicket` |
| `cancelAllMatchmakingTicketAsync` | Hủy toàn bộ ticket của 1 queue | `queueName` | `CancelAllMatchmakingTicketResponseData` | Với `server/admin` cần thêm `userId`; response trả `ticketIds` | `Ok`, `MatchmakingQueueNotFound` |
| `getMatchmakingTicketAsync` | Poll trạng thái ticket cụ thể | `ticketId`, `returnMember?` | `GetMatchmakingTicketResponseData` | Khi `status` đổi sang matched có thể có `matchId` | `Ok`, `MatchmakingTicketNotFound` |
| `listMatchmakingTicketsForPlayerAsync` | Liệt kê ticket của user trong một queue | `queueName` | `ListMatchmakingTicketsForPlayerResponseData` | Với `server/admin` cần thêm `userId` | `Ok`, `MatchmakingQueueNotFound` |
| `getMatchAsync` | Lấy chi tiết 1 match theo `matchId` | `matchId`, `returnMember?` | `GetMatchResponseData` | Không giả định có server endpoint | `Ok`, `MatchNotFound` |
| `getAllMatchAsync` | Liệt kê match hiện có | `returnMember?`, `skip?`, `limit?` | `GetAllMatchResponseData` | Dùng cho admin/ops/listing | `Ok` |
| `getAllMatchmakingTicketAsync` | Liệt kê ticket hiện có | `status?`, `returnMember?`, `skip?`, `limit?` | `GetAllMatchmakingTicketResponseData` | `status` nên map bằng enum | `Ok` |
| `getQueueStatisticsAsync` | Lấy thống kê queue trong một time window | `queueName`, `timeInSeconds` | `GetQueueStatisticsResponseData` | `timeInSeconds >= 20` | `Ok`, `MatchmakingQueueNotFound` |

## 5. Matchmaking Sequence

### Flow chuẩn cho client

1. `createMatchmakingTicketAsync(...)`
2. Lấy `ticketId`
3. Poll `getMatchmakingTicketAsync(...)`
4. Khi `status` cho biết đã match và response có `matchId`, gọi `getMatchAsync(...)`

### Flow join ticket đã có

1. `joinMatchmakingTicketAsync(...)`
2. Poll `getMatchmakingTicketAsync(...)`
3. Khi có `matchId`, gọi `getMatchAsync(...)`

### Flow hủy

1. `cancelMatchmakingTicketAsync(...)` hoặc `cancelAllMatchmakingTicketAsync(...)`
2. Nếu cần xác nhận state hiện tại, gọi `getMatchmakingTicketAsync(...)` hoặc `listMatchmakingTicketsForPlayerAsync(...)`

Rule cứng:

- Không chờ `createMatchmakingTicketAsync` trả match data.
- Không chờ `joinMatchmakingTicketAsync` trả ticket state mới.
- Không bỏ bước poll nếu flow của bạn cần biết đã match hay chưa.

## 6. Request Rules và Reference

- DTO fields: [reference/dto/MULTIPLAYER.md](/docs/reference/dto/MULTIPLAYER.md). Method table: [reference/API_MULTIPLAYER.md](/docs/reference/API_MULTIPLAYER.md).
- Enums: [MatchmakingTicketStatus](/docs/reference/ENUMS.md#matchmakingticketstatus), [MatchmakingMemberStatus](/docs/reference/ENUMS.md#matchmakingmemberstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/Multiplayer*.cs`.
- `CreateMatchmakingTicketRequestData.giveUpAfterSeconds` có min `20`.
- `GetQueueStatisticsRequestData.timeInSeconds` có min `20`.
- `queueName` có min `6`, max `32`.
- `ticketId` có độ dài `10`.
- `matchId` có độ dài `15`.
- `GetAllMatchmakingTicketRequestData.status` là numeric field tùy chọn; nên map bằng `MatchmakingTicketStatus`, không đoán số bừa.
- `returnMember` mặc định là `false`; chỉ bật khi thật sự cần member list.
- Với `server/admin`, các model sau có thêm `userId`:
    - `createMatchmakingTicket`
    - `joinMatchmakingTicket`
    - `cancelMatchmakingTicket`
    - `cancelAllMatchmakingTicket`
    - `listMatchmakingTicketsForPlayer`

## 7. Response Rules

Tất cả typed response của `MultiplayerApi` đều có:

- `returnCode`
- `debugMessage`
- `invalidMembers`
- `errorCode`
- `responseData`

Rule kiểm tra response:

```csharp
if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

Những response chính AI cần nhớ:

- `createMatchmakingTicketAsync` trả `responseData.ticketId`.
- `cancelAllMatchmakingTicketAsync` trả `responseData.ticketIds`.
- `getMatchmakingTicketAsync` trả `responseData.matchmakingTicket`.
- `getMatchAsync` trả `responseData.match`.
- `getQueueStatisticsAsync` trả `pendingMemberCount`, `pendingTicketCount`, `averageMatchmakingTimeInSeconds`.
- `getAllMatchAsync` trả `results`.
- `getAllMatchmakingTicketAsync` trả `results`.
- `cancelMatchmakingTicketAsync` và `joinMatchmakingTicketAsync` trả `EmptyResponseData`.

Ghi chú quan trọng:

- `MatchmakingTicketResponseData.status` nên đọc bằng enum `MatchmakingTicketStatus`.
- `MatchmakingTicketMember.status` nên đọc bằng enum `MatchmakingMemberStatus`.
- `GetMatchResponseData.match` hiện chỉ có `tsCreate`, `queueName`, `members?`, `timeToMatchInSeconds`; không có server IP/port trong response model hiện tại.

## 8. Decision Rules

- Muốn bắt đầu tìm trận: dùng `createMatchmakingTicketAsync`.
- Muốn ghép thêm player vào ticket đang có: dùng `joinMatchmakingTicketAsync`.
- Muốn xem ticket đã matched chưa: dùng `getMatchmakingTicketAsync`.
- Đã có `matchId` và muốn lấy match detail: dùng `getMatchAsync`.
- Muốn xem tất cả ticket của current player trong queue: dùng `listMatchmakingTicketsForPlayerAsync`.
- Muốn xem snapshot queue hiện tại: dùng `getQueueStatisticsAsync`.
- Muốn duyệt toàn bộ ticket hoặc match để vận hành: dùng `getAllMatchmakingTicketAsync` hoặc `getAllMatchAsync`.
- Muốn hủy một ticket: dùng `cancelMatchmakingTicketAsync`.
- Muốn hủy hàng loạt ticket trong queue: dùng `cancelAllMatchmakingTicketAsync`.

## 9. Best Practices

- Giữ `returnMember = false` nếu bạn chỉ cần status hoặc id.
- Chỉ truyền `members` khi bạn thật sự tạo ticket cho nhiều member ngay từ đầu.
- Với `server/admin`, truyền `userId` rõ ràng thay vì kỳ vọng auth token ngầm chỉ tới user đích.
- Poll `getMatchmakingTicketAsync` với nhịp hợp lý, không spam quá dày.
- Khi cần filter ticket theo status, dùng enum `MatchmakingTicketStatus` thay vì hardcode số.
- Không suy diễn `GetMatchResponseData` là đủ để connect game server. Nếu bạn cần endpoint runtime, phải xác minh từ API/flow khác.

## 10. Ví dụ Khuyến Nghị

### Client tạo ticket rồi poll tới khi có match

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequest = new MultiplayerModels.CreateMatchmakingTicketRequestData();
createRequest.giveUpAfterSeconds = 60;
createRequest.queueName = "ranked01";

var createResponse = await GNNetwork.multiplayer.createMatchmakingTicketAsync(createRequest);

if (createResponse.hasReturnCodeError()) {
    throw new System.Exception(createResponse.debugMessage);
}

if (createResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + createResponse.errorCode);
}

var ticketId = createResponse.responseData.ticketId;

var ticketRequest = new MultiplayerModels.GetMatchmakingTicketRequestData();
ticketRequest.ticketId = ticketId;

var ticketResponse = await GNNetwork.multiplayer.getMatchmakingTicketAsync(ticketRequest);

if (ticketResponse.hasReturnCodeError()) {
    throw new System.Exception(ticketResponse.debugMessage);
}

if (ticketResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + ticketResponse.errorCode);
}

var ticket = ticketResponse.responseData.matchmakingTicket;
if (ticket.status == MatchmakingTicketStatus.Matched && !string.IsNullOrEmpty(ticket.matchId)) {
    var matchRequest = new MultiplayerModels.GetMatchRequestData();
    matchRequest.matchId = ticket.matchId;

    var matchResponse = await GNNetwork.multiplayer.getMatchAsync(matchRequest);

    if (matchResponse.hasReturnCodeError()) {
        throw new System.Exception(matchResponse.debugMessage);
    }

    if (matchResponse.errorCode != ErrorCode.Ok) {
        throw new System.Exception("Business error: " + matchResponse.errorCode);
    }

    var match = matchResponse.responseData.match;
}
```

### Server tạo ticket cho user cụ thể

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new MultiplayerModels.ServerCreateMatchmakingTicketRequestData();
request.userId = "1234567890";
request.giveUpAfterSeconds = 60;
request.queueName = "ranked01";

var response = await GNNetwork.multiplayer.server.createMatchmakingTicketAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var ticketId = response.responseData.ticketId;
```

### Admin list ticket theo status

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var request = new MultiplayerModels.AdminGetAllMatchmakingTicketRequestData();
request.status = MatchmakingTicketStatus.WaitingForMatch;
request.limit = 20;
request.returnMember = false;

var response = await GNNetwork.multiplayer.admin.getAllMatchmakingTicketAsync(request);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

var tickets = response.responseData.results;
```

## 11. Anti-Patterns

- Không dùng socket để tạo hoặc query matchmaking ticket.
- Không chờ `createMatchmakingTicketAsync` trả match object.
- Không hardcode numeric status nếu enum đã có.
- Không giả định `GetMatchResponseData` có IP/port server.
- Không bỏ qua `userId` ở namespace `server/admin` khi model yêu cầu.
- Không bật `returnMember` cho mọi request nếu không cần.
- Không bỏ qua kiểm tra `returnCode` và `errorCode`.

## 12. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Có chọn đúng namespace `multiplayer` / `multiplayer.server` / `multiplayer.admin` chưa.
- Có nhớ rằng `MultiplayerApi` hiện chỉ đi qua HTTP không.
- Nếu đang tạo ticket, có hiểu rằng response chỉ trả `ticketId` không.
- Nếu cần biết đã matched chưa, có poll `getMatchmakingTicketAsync` chưa.
- Nếu đang ở `server/admin`, model hiện tại có yêu cầu `userId` không.
- Nếu đang lọc status, có dùng enum `MatchmakingTicketStatus` không.
- Có tránh giả định response match sẽ trả server endpoint không.
