# GamePlayerApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng HTTP operation với realtime event socket, và không sinh sai request ở các nhóm `infoRequestParam`, friend/group lifecycle, leaderboard bạn bè và relation item nhẹ.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.gamePlayer`
    - `GNNetwork.gamePlayer.server`
    - `GNNetwork.gamePlayer.admin`
- Toàn bộ method hiện tại của `GamePlayerApi` đều gửi qua HTTP.
- `GamePlayerApi` có đủ 3 role thật:
    - `GNNetwork.gamePlayer` -> `RequestRole.Client`
    - `GNNetwork.gamePlayer.server` -> `RequestRole.Server`
    - `GNNetwork.gamePlayer.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu `self/other-self` xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Không tự suy diễn route chỉ từ target ownership.
- Với hầu hết flow thao tác trên một player cụ thể:
    - `client` cho phép `userId?`
    - `server/admin` bắt buộc `userId`
- Rule thực tế:
    - ở `client`, bỏ `userId` sẽ target game player hiện đang auth
    - ở `server/admin`, phải truyền `userId` rõ ràng cho target player
- `GamePlayerApi` là nhóm gameplay/profile của game player:
    - đọc profile tổng hợp
    - đọc relation nhẹ tới character, inventory, group, friend
    - search player
    - leaderboard toàn cục hoặc leaderboard trong mạng bạn bè
    - create group, create character, create item
    - add/remove friend, join/leave group
- `GamePlayerApi` không thay thế `GroupApi`, `InventoryApi` hay `CharacterPlayerApi` cho các thao tác metadata chi tiết của entity con.
- Realtime update friend/group là luồng riêng qua socket event handler, không phải transport của các method `GamePlayerApi`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket transport cho các method của `GamePlayerApi`.
- Chọn namespace theo trust boundary:
    - app/player -> `GNNetwork.gamePlayer`
    - trusted backend/service -> `GNNetwork.gamePlayer.server`
    - dashboard/ops/tooling -> `GNNetwork.gamePlayer.admin`
- Với `client`, chỉ nên bỏ `userId` khi thao tác trên game player hiện tại.
- Với `server/admin`, mọi flow self-target có `userId` đều phải truyền giá trị này rõ ràng.
- `getPlayerInformationAsync`, `getFriendStatisticsLeaderboardAroundPlayerAsync`, `getFriendStatisticsLeaderboardAsync`, `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync`, `getStatisticsLeaderboardAroundPlayerAsync`, `getStatisticsLeaderboardAsync`, `getCurrencyLeaderboardAsync`, `getLastLoginLeaderboardAsync` và `getCreateLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getPlayerStatisticsAsync` dùng `statisticsKeys`, còn `infoRequestParam` dùng `playerStatisticsKeys`. Không được dùng lẫn hai field này.
- `getPlayerCharacterAsync` dùng `characterCatalogIds`, `getPlayerInventoryAsync` dùng `itemCatalogIds`, `getPlayerGroupAsync` dùng `groupCatalogIds`, `getPlayerFriendAsync` dùng `friendCatalogIds`.
- `InfoRequestParam` cũng có các field filter cùng tên để điều khiển payload của flow tổng hợp hoặc search; không được trộn lẫn getter chuyên biệt với `infoRequestParam`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` và các leaderboard dùng `skip/limit`.
- `getCurrencyLogAsync` và `getStatisticsLogAsync` phân trang bằng `token`, không dùng `skip`.
- `addPlayerFriendAsync` bắt buộc có cả `friendId` và `catalogId`.
- `ServerGetPlayerInformationRequestData` và `AdminGetPlayerInformationRequestData` có thêm `createPlayerIfNotExists`; `client` không có quyền này.
- `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync` không có contract public riêng để trả `groupId`, `characterId`, `itemId` vừa tạo.
- `setAvatarAsync` trả `EmptyResponseData`. `SetAvatarRequestData.type` hiện là số thô, package không export enum avatar public tương ứng.
- `playerGroups[].status` nên map bằng `GroupStatus`, `playerFriends[].status` nên map bằng `FriendStatus`.
- `playerCharacters`, `playerInventories`, `playerGroups`, `playerFriends` trong `GamePlayerApi` là relation item nhẹ; không được giả định chúng chứa full metadata chi tiết.

## 3. HTTP Và Socket

Rule cứng:

- Nếu cần đọc/ghi gameplay profile hoặc lifecycle friend/group từ phía player: dùng `GNNetwork.gamePlayer*` qua HTTP.
- Nếu cần realtime friend/group update: dùng socket event handler riêng.
- Không được giả định gọi `addPlayerFriendAsync`, `removePlayerFriendAsync`, `joinGroupAsync` hoặc `leaveGroupAsync` là đủ để UI tự nhận realtime nếu chưa auth socket.

Event handler public: xem [reference/EVENTS.md](/docs/reference/EVENTS.md#ongameplayerfriendupdateeventhandler) và [reference/EVENTS.md](/docs/reference/EVENTS.md#ongameplayergroupupdateeventhandler).

Realtime rule:

- Muốn nhận event realtime, tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow).
- `OnGamePlayerFriendUpdateEventHandler.onUpdate`:
    - payload có `playerFriends`
    - không có `userId`
- `OnGamePlayerGroupUpdateEventHandler.onUpdate`:
    - payload có `playerGroups`
    - không có `userId`

## 4. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | `userId` behavior | Dùng khi nào |
| --- | --- | --- | --- |
| `GNNetwork.gamePlayer` | `Client` | Có thể bỏ `userId` để target player hiện tại | player app thao tác trên game profile của chính user hiện tại |
| `GNNetwork.gamePlayer.server` | `Server` | Phải truyền `userId` ở các flow self-target | trusted backend, game server, worker xử lý lifecycle player |
| `GNNetwork.gamePlayer.admin` | `Admin` | Phải truyền `userId` ở các flow self-target | GM tool, dashboard, migration, vận hành dữ liệu game player |

Rule nhanh:

- Logic chạy trong app public: ưu tiên `GNNetwork.gamePlayer`.
- Logic chạy trong backend tin cậy: ưu tiên `GNNetwork.gamePlayer.server`.
- Logic quản trị hoặc vận hành dữ liệu: ưu tiên `GNNetwork.gamePlayer.admin`.
- Nếu cần `createPlayerIfNotExists`, phải dùng `server` hoặc `admin`.

## 5. Chọn Method

Đọc các bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_GAME_PLAYER.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp | Permission Rules khi truyền userId khác với gamePlayer đang authenticated |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Đọc 1 game player hoặc 1 phần hồ sơ

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar | `userId?` | `GamePlayerResponseData` | [client:17-17](/docs/reference/API_GAME_PLAYER.md) / [server:74-74](/docs/reference/API_GAME_PLAYER.md) / [admin:131-131](/docs/reference/API_GAME_PLAYER.md) |
| `getCountryCodeAsync` | Cần đọc quốc gia | `userId?` | `GamePlayerResponseData` | [client:18-18](/docs/reference/API_GAME_PLAYER.md) / [server:75-75](/docs/reference/API_GAME_PLAYER.md) / [admin:132-132](/docs/reference/API_GAME_PLAYER.md) |
| `getCustomDataAsync` | Cần đọc custom data | `userId?`, `customDataKeys?` | `GamePlayerResponseData` | [client:19-19](/docs/reference/API_GAME_PLAYER.md) / [server:76-76](/docs/reference/API_GAME_PLAYER.md) / [admin:133-133](/docs/reference/API_GAME_PLAYER.md) |
| `getDisplayNameAsync` | Cần đọc display name | `userId?` | `GamePlayerResponseData` | [client:20-20](/docs/reference/API_GAME_PLAYER.md) / [server:77-77](/docs/reference/API_GAME_PLAYER.md) / [admin:134-134](/docs/reference/API_GAME_PLAYER.md) |
| `getIpAddressCreateAsync` | Cần đọc IP lúc tạo player | `userId?` | `GamePlayerResponseData` | [client:23-23](/docs/reference/API_GAME_PLAYER.md) / [server:80-80](/docs/reference/API_GAME_PLAYER.md) / [admin:137-137](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerBanAsync` | Cần đọc trạng thái ban | `userId?` | `GamePlayerResponseData` | [client:24-24](/docs/reference/API_GAME_PLAYER.md) / [server:81-81](/docs/reference/API_GAME_PLAYER.md) / [admin:138-138](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerCharacterAsync` | Cần đọc relation character của player | `userId?`, `characterCatalogIds?` | `GamePlayerResponseData` | [client:25-25](/docs/reference/API_GAME_PLAYER.md) / [server:82-82](/docs/reference/API_GAME_PLAYER.md) / [admin:139-139](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerCurrencyAsync` | Cần đọc currency | `userId?`, `playerCurrencyKeys?` | `GamePlayerResponseData` | [client:26-26](/docs/reference/API_GAME_PLAYER.md) / [server:83-83](/docs/reference/API_GAME_PLAYER.md) / [admin:140-140](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerDataAsync` | Cần đọc player data | `userId?`, `playerDataKeys?` | `GamePlayerResponseData` | [client:27-27](/docs/reference/API_GAME_PLAYER.md) / [server:84-84](/docs/reference/API_GAME_PLAYER.md) / [admin:141-141](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerFriendAsync` | Cần đọc relation friend | `userId?`, `friendCatalogIds?` | `GamePlayerResponseData` | [client:28-28](/docs/reference/API_GAME_PLAYER.md) / [server:85-85](/docs/reference/API_GAME_PLAYER.md) / [admin:142-142](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerGroupAsync` | Cần đọc relation group | `userId?`, `groupCatalogIds?` | `GamePlayerResponseData` | [client:29-29](/docs/reference/API_GAME_PLAYER.md) / [server:86-86](/docs/reference/API_GAME_PLAYER.md) / [admin:143-143](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerInformationAsync` | Cần lấy snapshot tổng hợp của player | `userId?`, `infoRequestParam` | `GamePlayerResponseData` | [client:30-30](/docs/reference/API_GAME_PLAYER.md) / [server:87-87](/docs/reference/API_GAME_PLAYER.md) / [admin:144-144](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerInventoryAsync` | Cần đọc relation inventory | `userId?`, `itemCatalogIds?` | `GamePlayerResponseData` | [client:31-31](/docs/reference/API_GAME_PLAYER.md) / [server:88-88](/docs/reference/API_GAME_PLAYER.md) / [admin:145-145](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayerStatisticsAsync` | Cần đọc statistics theo key | `userId?`, `statisticsKeys?` | `GamePlayerResponseData` | [client:32-32](/docs/reference/API_GAME_PLAYER.md) / [server:89-89](/docs/reference/API_GAME_PLAYER.md) / [admin:146-146](/docs/reference/API_GAME_PLAYER.md) |
| `getSegmentAsync` | Cần đọc segment | `userId?` | `GamePlayerResponseData` | [client:36-36](/docs/reference/API_GAME_PLAYER.md) / [server:93-93](/docs/reference/API_GAME_PLAYER.md) / [admin:150-150](/docs/reference/API_GAME_PLAYER.md) |
| `getTagAsync` | Cần đọc tag theo key | `userId?`, `tagKeys` | `GamePlayerResponseData` | [client:39-39](/docs/reference/API_GAME_PLAYER.md) / [server:96-96](/docs/reference/API_GAME_PLAYER.md) / [admin:153-153](/docs/reference/API_GAME_PLAYER.md) |
| `getTsCreateAsync` | Cần đọc thời điểm tạo player | `userId?` | `GamePlayerResponseData` | [client:40-40](/docs/reference/API_GAME_PLAYER.md) / [server:97-97](/docs/reference/API_GAME_PLAYER.md) / [admin:154-154](/docs/reference/API_GAME_PLAYER.md) |
| `getTsLastLoginAsync` | Cần đọc lần login gần nhất | `userId?` | `GamePlayerResponseData` | [client:41-41](/docs/reference/API_GAME_PLAYER.md) / [server:98-98](/docs/reference/API_GAME_PLAYER.md) / [admin:155-155](/docs/reference/API_GAME_PLAYER.md) |

### Search, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `getPlayersWithDisplayNameAsync` | Tìm player theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | [client:33-33](/docs/reference/API_GAME_PLAYER.md) / [server:90-90](/docs/reference/API_GAME_PLAYER.md) / [admin:147-147](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayersWithSegmentAsync` | Tìm player theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | [client:34-34](/docs/reference/API_GAME_PLAYER.md) / [server:91-91](/docs/reference/API_GAME_PLAYER.md) / [admin:148-148](/docs/reference/API_GAME_PLAYER.md) |
| `getPlayersWithTagAsync` | Tìm player theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | [client:35-35](/docs/reference/API_GAME_PLAYER.md) / [server:92-92](/docs/reference/API_GAME_PLAYER.md) / [admin:149-149](/docs/reference/API_GAME_PLAYER.md) |
| `getFriendStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng quanh một player trong mạng bạn bè của player đó | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | [client:21-21](/docs/reference/API_GAME_PLAYER.md) / [server:78-78](/docs/reference/API_GAME_PLAYER.md) / [admin:135-135](/docs/reference/API_GAME_PLAYER.md) |
| `getFriendStatisticsLeaderboardAsync` | Cần bảng xếp hạng friend-only theo key | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | [client:22-22](/docs/reference/API_GAME_PLAYER.md) / [server:79-79](/docs/reference/API_GAME_PLAYER.md) / [admin:136-136](/docs/reference/API_GAME_PLAYER.md) |
| `getStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng toàn cục quanh một player | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | [client:37-37](/docs/reference/API_GAME_PLAYER.md) / [server:94-94](/docs/reference/API_GAME_PLAYER.md) / [admin:151-151](/docs/reference/API_GAME_PLAYER.md) |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?` | `GetStatisticsLeaderboardResponseData` | [client:38-38](/docs/reference/API_GAME_PLAYER.md) / [server:95-95](/docs/reference/API_GAME_PLAYER.md) / [admin:152-152](/docs/reference/API_GAME_PLAYER.md) |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCurrencyLeaderboardResponseData` | [client:61-61](/docs/reference/API_GAME_PLAYER.md) / [server:118-118](/docs/reference/API_GAME_PLAYER.md) / [admin:175-175](/docs/reference/API_GAME_PLAYER.md) |
| `getLastLoginLeaderboardAsync` | Cần bảng xếp hạng theo lần login gần nhất | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetLastLoginLeaderboardResponseData` | [client:62-62](/docs/reference/API_GAME_PLAYER.md) / [server:119-119](/docs/reference/API_GAME_PLAYER.md) / [admin:176-176](/docs/reference/API_GAME_PLAYER.md) |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo player | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | [client:63-63](/docs/reference/API_GAME_PLAYER.md) / [server:120-120](/docs/reference/API_GAME_PLAYER.md) / [admin:177-177](/docs/reference/API_GAME_PLAYER.md) |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `userId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | [client:64-64](/docs/reference/API_GAME_PLAYER.md) / [server:121-121](/docs/reference/API_GAME_PLAYER.md) / [admin:178-178](/docs/reference/API_GAME_PLAYER.md) |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `userId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | [client:65-65](/docs/reference/API_GAME_PLAYER.md) / [server:122-122](/docs/reference/API_GAME_PLAYER.md) / [admin:179-179](/docs/reference/API_GAME_PLAYER.md) |

### Friend, group, character và item lifecycle

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `addPlayerFriendAsync` | Thêm một quan hệ friend | `userId?`, `friendId`, `catalogId` | `EmptyResponseData` | [client:15-15](/docs/reference/API_GAME_PLAYER.md) / [server:72-72](/docs/reference/API_GAME_PLAYER.md) / [admin:129-129](/docs/reference/API_GAME_PLAYER.md) |
| `removePlayerFriendAsync` | Gỡ một quan hệ friend | `userId?`, `friendId` | `EmptyResponseData` | [client:48-48](/docs/reference/API_GAME_PLAYER.md) / [server:105-105](/docs/reference/API_GAME_PLAYER.md) / [admin:162-162](/docs/reference/API_GAME_PLAYER.md) |
| `createGroupAsync` | Tạo group từ phía player | `userId?`, `catalogId`, `groupMembers?`, `displayName?` | `GamePlayerResponseData` | [client:42-42](/docs/reference/API_GAME_PLAYER.md) / [server:99-99](/docs/reference/API_GAME_PLAYER.md) / [admin:156-156](/docs/reference/API_GAME_PLAYER.md) |
| `joinGroupAsync` | Cho player join vào một group đã tồn tại | `userId?`, `groupId` | `EmptyResponseData` | [client:45-45](/docs/reference/API_GAME_PLAYER.md) / [server:102-102](/docs/reference/API_GAME_PLAYER.md) / [admin:159-159](/docs/reference/API_GAME_PLAYER.md) |
| `leaveGroupAsync` | Cho player rời khỏi group | `userId?`, `groupId` | `EmptyResponseData` | [client:46-46](/docs/reference/API_GAME_PLAYER.md) / [server:103-103](/docs/reference/API_GAME_PLAYER.md) / [admin:160-160](/docs/reference/API_GAME_PLAYER.md) |
| `createPlayerCharacterAsync` | Tạo character mới cho player | `userId?`, `catalogId`, `displayName?`, `uniqueDisplayName?` | `GamePlayerResponseData` | [client:43-43](/docs/reference/API_GAME_PLAYER.md) / [server:100-100](/docs/reference/API_GAME_PLAYER.md) / [admin:157-157](/docs/reference/API_GAME_PLAYER.md) |
| `removePlayerCharacterAsync` | Xóa relation character khỏi player theo `characterId` | `userId?`, `characterId` | `EmptyResponseData` | [client:47-47](/docs/reference/API_GAME_PLAYER.md) / [server:104-104](/docs/reference/API_GAME_PLAYER.md) / [admin:161-161](/docs/reference/API_GAME_PLAYER.md) |
| `createPlayerItemAsync` | Tạo item mới cho player | `userId?`, `catalogId`, `classId`, `displayName?`, `amount?` | `GamePlayerResponseData` | [client:44-44](/docs/reference/API_GAME_PLAYER.md) / [server:101-101](/docs/reference/API_GAME_PLAYER.md) / [admin:158-158](/docs/reference/API_GAME_PLAYER.md) |
| `removePlayerItemAsync` | Xóa item khỏi player theo `itemId` | `userId?`, `itemId` | `EmptyResponseData` | [client:49-49](/docs/reference/API_GAME_PLAYER.md) / [server:106-106](/docs/reference/API_GAME_PLAYER.md) / [admin:163-163](/docs/reference/API_GAME_PLAYER.md) |

### Mutation profile

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | API contract rows |
| --- | --- | --- | --- | --- |
| `addSegmentAsync` | Gắn thêm segment | `userId?`, `value` | `EmptyResponseData` | [client:16-16](/docs/reference/API_GAME_PLAYER.md) / [server:73-73](/docs/reference/API_GAME_PLAYER.md) / [admin:130-130](/docs/reference/API_GAME_PLAYER.md) |
| `removeSegmentAsync` | Gỡ segment | `userId?`, `value` | `EmptyResponseData` | [client:50-50](/docs/reference/API_GAME_PLAYER.md) / [server:107-107](/docs/reference/API_GAME_PLAYER.md) / [admin:164-164](/docs/reference/API_GAME_PLAYER.md) |
| `setTagAsync` | Set hoặc upsert tag | `userId?`, `key`, `value` | `EmptyResponseData` | [client:60-60](/docs/reference/API_GAME_PLAYER.md) / [server:117-117](/docs/reference/API_GAME_PLAYER.md) / [admin:174-174](/docs/reference/API_GAME_PLAYER.md) |
| `removeTagAsync` | Xóa tag theo key | `userId?`, `key` | `EmptyResponseData` | [client:51-51](/docs/reference/API_GAME_PLAYER.md) / [server:108-108](/docs/reference/API_GAME_PLAYER.md) / [admin:165-165](/docs/reference/API_GAME_PLAYER.md) |
| `setAvatarAsync` | Set avatar | `userId?`, `type`, `value` | `EmptyResponseData` | [client:52-52](/docs/reference/API_GAME_PLAYER.md) / [server:109-109](/docs/reference/API_GAME_PLAYER.md) / [admin:166-166](/docs/reference/API_GAME_PLAYER.md) |
| `setCountryCodeAsync` | Set country code | `userId?`, `countryCode` | `EmptyResponseData` | [client:53-53](/docs/reference/API_GAME_PLAYER.md) / [server:110-110](/docs/reference/API_GAME_PLAYER.md) / [admin:167-167](/docs/reference/API_GAME_PLAYER.md) |
| `setCustomDataAsync` | Set custom data theo nhiều key | `userId?`, `customDatas[]` | `GamePlayerResponseData` | [client:54-54](/docs/reference/API_GAME_PLAYER.md) / [server:111-111](/docs/reference/API_GAME_PLAYER.md) / [admin:168-168](/docs/reference/API_GAME_PLAYER.md) |
| `setDisplayNameAsync` | Set display name | `userId?`, `displayName`, `uniqueDisplayName?` | `EmptyResponseData` | [client:55-55](/docs/reference/API_GAME_PLAYER.md) / [server:112-112](/docs/reference/API_GAME_PLAYER.md) / [admin:169-169](/docs/reference/API_GAME_PLAYER.md) |
| `setPlayerBanAsync` | Ban player đến thời điểm cụ thể | `userId?`, `tsExpire`, `reason` | `EmptyResponseData` | [client:56-56](/docs/reference/API_GAME_PLAYER.md) / [server:113-113](/docs/reference/API_GAME_PLAYER.md) / [admin:170-170](/docs/reference/API_GAME_PLAYER.md) |
| `changePlayerCurrencyAsync` | Cộng/trừ currency | `userId?`, `playerCurrencies[]`, `log?` | `GamePlayerResponseData` | [client:57-57](/docs/reference/API_GAME_PLAYER.md) / [server:114-114](/docs/reference/API_GAME_PLAYER.md) / [admin:171-171](/docs/reference/API_GAME_PLAYER.md) |
| `setPlayerDataAsync` | Set player data theo nhiều key | `userId?`, `playerDatas[]` | `GamePlayerResponseData` | [client:58-58](/docs/reference/API_GAME_PLAYER.md) / [server:115-115](/docs/reference/API_GAME_PLAYER.md) / [admin:172-172](/docs/reference/API_GAME_PLAYER.md) |
| `changePlayerStatisticsAsync` | Cộng/trừ statistics | `userId?`, `playerStatistics[]`, `log?` | `GamePlayerResponseData` | [client:59-59](/docs/reference/API_GAME_PLAYER.md) / [server:116-116](/docs/reference/API_GAME_PLAYER.md) / [admin:173-173](/docs/reference/API_GAME_PLAYER.md) |

## 6. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.gamePlayer.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.gamePlayer.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new GamePlayerModels.<Method>RequestData()` hoặc route variant `Server*` / `Admin*` |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / admin thao tác bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của route cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md#2-response-checking-2-tier).

## 7. Request Field Rules

- DTO fields: [reference/dto/GAME_PLAYER.md](/docs/reference/dto/GAME_PLAYER.md). Method table: [reference/API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md).
- Events: [reference/EVENTS.md](/docs/reference/EVENTS.md#ongameplayerfriendupdateeventhandler).
- Enums: [FriendStatus](/docs/reference/ENUMS.md#friendstatus), [GroupStatus](/docs/reference/ENUMS.md#groupstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/GamePlayer*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- `GenericModels.FriendItem.status` nên map bằng `FriendStatus`.
- `GenericModels.GroupItem.status` nên map bằng `GroupStatus`.
- `avatar.type` hiện chưa có enum public tương ứng.

## 8. InfoRequestParam Rules

`GamePlayerModels.InfoRequestParam` điều khiển payload trả về trong:

- `getPlayerInformationAsync`
- `getFriendStatisticsLeaderboardAroundPlayerAsync`
- `getFriendStatisticsLeaderboardAsync`
- `getPlayersWithDisplayNameAsync`
- `getPlayersWithSegmentAsync`
- `getPlayersWithTagAsync`
- `getStatisticsLeaderboardAroundPlayerAsync`
- `getStatisticsLeaderboardAsync`
- `getCurrencyLeaderboardAsync`
- `getLastLoginLeaderboardAsync`
- `getCreateLeaderboardAsync`

Rule cứng:

- Không truyền `null`.
- Không bật toàn bộ field một cách mù quáng.
- Chỉ bật field mà flow hiện tại thật sự cần.
- Nếu cần filter dữ liệu con, dùng đúng field filter:
    - `playerDataKeys`
    - `playerCurrencyKeys`
    - `playerStatisticsKeys`
    - `customDataKeys`
    - `tagKeys`
    - `characterCatalogIds`
    - `itemCatalogIds`
    - `groupCatalogIds`
    - `friendCatalogIds`
- Nếu chỉ cần relation nhẹ của một nhóm con, ưu tiên getter chuyên biệt như `getPlayerCharacterAsync`, `getPlayerInventoryAsync`, `getPlayerGroupAsync`, `getPlayerFriendAsync`.
- Nếu bạn cần full metadata của character, item hoặc group, không được dừng ở relation item của `GamePlayerApi`; phải gọi API chuyên biệt tương ứng.

Các field thường dùng:

- `segments`
- `customDatas`
- `displayName`
- `avatar`
- `tsCreate`
- `tags`
- `playerBan`
- `playerCurrencies`
- `playerStatistics`
- `playerDatas`
- `ipAddressCreate`
- `countryCode`
- `tsLastLogin`
- `playerCharacters`
- `playerInventories`
- `playerGroups`
- `playerFriends`
- `onlineStatus`

## 9. Decision Rules

- Cần đọc một field nhỏ: ưu tiên getter chuyên biệt.
- Cần lấy snapshot gameplay profile trong một lần gọi: dùng `getPlayerInformationAsync`.
- Cần relationship nhẹ tới characters/items/groups/friends: dùng getter chuyên biệt của `GamePlayerApi`.
- Cần full metadata của group: dùng `GroupApi`.
- Cần full metadata của item: dùng `InventoryApi`.
- Cần full metadata của character: dùng `CharacterPlayerApi`.
- Cần tạo hoặc join/leave group từ góc nhìn player: dùng `createGroupAsync`, `joinGroupAsync`, `leaveGroupAsync`, không dùng `GroupApi`.
- Cần quản lý member của một group đã tồn tại từ góc nhìn group: dùng `GroupApi`.
- Cần leaderboard trong mạng bạn bè: dùng `getFriendStatisticsLeaderboardAsync` hoặc `getFriendStatisticsLeaderboardAroundPlayerAsync`.
- Cần leaderboard toàn cục: dùng `getStatisticsLeaderboardAsync` hoặc `getStatisticsLeaderboardAroundPlayerAsync`.
- Cần auto-provision game player khi backend đọc profile: dùng `gamePlayer.server/admin.getPlayerInformationAsync` với `createPlayerIfNotExists`.
- Cần cập nhật UI friend/group realtime: dùng socket event handler sau khi đã auth socket.

## 10. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new GamePlayerModels.GetPlayerInformationRequestData();
requestData.infoRequestParam = new GamePlayerModels.InfoRequestParam();
requestData.infoRequestParam.displayName = true;

var response = await GNNetwork.gamePlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

Những response chính AI cần nhớ:

- Hầu hết getter đơn lẻ trả `GamePlayerResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` trả `GamePlayersWithUserIdResponseData`, mỗi phần tử có `userId` và `infoResponseParameters`.
- `getFriendStatisticsLeaderboard*Async` và `getStatisticsLeaderboard*Async` trả `GetStatisticsLeaderboardResponseData`.
- `getStatisticsLeaderboardAsync` còn có thêm `responseData.tsCreate`.
- `getCurrencyLeaderboardAsync`, `getLastLoginLeaderboardAsync`, `getCreateLeaderboardAsync` trả `results` theo leaderboard shape.
- `getStatisticsLogAsync` và `getCurrencyLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `addPlayerFriendAsync`, `addSegmentAsync`, `joinGroupAsync`, `leaveGroupAsync`, `removePlayerCharacterAsync`, `removePlayerFriendAsync`, `removePlayerItemAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setCountryCodeAsync`, `setDisplayNameAsync`, `setPlayerBanAsync`, `setTagAsync` trả `EmptyResponseData`.
- `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync`, `setCustomDataAsync`, `changePlayerCurrencyAsync`, `setPlayerDataAsync`, `changePlayerStatisticsAsync` trả `GamePlayerResponseData`.

## 11. Cảnh Báo Implementation Hiện Tại

- `CharacterItem`, `InventoryItem`, `GroupItem`, `FriendItem` trong `GamePlayerApi` là relation item nhẹ:
    - `CharacterItem` chỉ có `characterId`, `catalogId`
    - `InventoryItem` chỉ có `itemId`, `catalogId`, `classId`
    - `GroupItem` chỉ có `groupId`, `catalogId`, `status`, `tsLastStatusUpdate`
    - `FriendItem` chỉ có `friendId`, `catalogId`, `status`, `tsLastStatusUpdate`
- Nếu bạn cần display name, amount, statistics, owner hoặc metadata sâu hơn, phải gọi API chuyên biệt tương ứng.
- `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync` hiện không có response field public riêng cho id vừa tạo.
- Nếu flow sau đó cần id mới, bạn phải re-query hoặc verify backend contract riêng.
- Public event payload của `OnGamePlayerFriendUpdateEventHandler` và `OnGamePlayerGroupUpdateEventHandler` không có `userId`.
- `ServerGetPlayerInformationRequestData` và `AdminGetPlayerInformationRequestData` mới có `createPlayerIfNotExists`; `client` không có field này.
- `setAvatarAsync` và `avatar.type` vẫn dùng số thô, chưa có enum public tương ứng.

## 12. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một mảng relation nhẹ hoặc một field nhỏ.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với relation item từ `GamePlayerApi`, chỉ dùng nó như index nhẹ để lấy id và trạng thái; đừng coi đó là full entity snapshot.
- Với friend/group UI, đọc initial state bằng getter HTTP rồi nghe realtime update bằng socket event handler.
- Với `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với backend provisioning, ưu tiên `server/admin.getPlayerInformationAsync` với `createPlayerIfNotExists` thay vì để client tự xử lý.
- Với create flow, chuẩn bị sẵn bước re-fetch nếu bạn cần id mới tạo hoặc metadata chi tiết.

## 13. Ví Dụ Khuyến Nghị

### Đọc thông tin game player hiện tại với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new GamePlayerModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.playerCurrencies = true;
infoRequestParam.playerCurrencyKeys = new System.Collections.Generic.List<string> { "gold" };
infoRequestParam.playerFriends = true;
infoRequestParam.friendCatalogIds = new System.Collections.Generic.List<string> { "default-friend" };

var requestData = new GamePlayerModels.GetPlayerInformationRequestData();
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.gamePlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

### Backend đọc profile và tự tạo game player nếu chưa tồn tại

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new GamePlayerModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.playerStatistics = true;
infoRequestParam.playerStatisticsKeys = new System.Collections.Generic.List<string> { "rankScore" };

var requestData = new GamePlayerModels.ServerGetPlayerInformationRequestData();
requestData.userId = "1234567890";
requestData.infoRequestParam = infoRequestParam;
requestData.createPlayerIfNotExists = true;

var response = await GNNetwork.gamePlayer.server.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

### Add friend rồi đồng bộ UI bằng realtime event

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnGamePlayerFriendUpdateEventHandler.onUpdate = (update) => {
    var friendItems = update.playerFriends;
    UnityEngine.Debug.Log(friendItems);
};

GNNetwork.connectSocket(); // Follow README socket rule before expecting realtime updates.

var requestData = new GamePlayerModels.AddPlayerFriendRequestData();
requestData.friendId = "0987654321";
requestData.catalogId = "default-friend";

var response = await GNNetwork.gamePlayer.addPlayerFriendAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

### Tạo item cho player rồi re-query relation item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequestData = new GamePlayerModels.CreatePlayerItemRequestData();
createRequestData.catalogId = "weapon";
createRequestData.classId = "sword";
createRequestData.displayName = "Starter Sword";
createRequestData.amount = 1;

var createResponse = await GNNetwork.gamePlayer.createPlayerItemAsync(createRequestData);

if (createResponse.returnCode != ReturnCode.Ok) return;
if (createResponse.errorCode != ErrorCode.Ok) return;

var getInventoryRequestData = new GamePlayerModels.GetPlayerInventoryRequestData();
getInventoryRequestData.itemCatalogIds = new[] { "weapon" };

var inventoryResponse = await GNNetwork.gamePlayer.getPlayerInventoryAsync(getInventoryRequestData);

if (inventoryResponse.returnCode != ReturnCode.Ok) return;
if (inventoryResponse.errorCode != ErrorCode.Ok) return;

var inventoryRelations = inventoryResponse.responseData.infoResponseParameters.playerInventories;
```

## 14. Anti-Patterns

- Không giả định `GamePlayerApi` dùng socket transport chỉ vì có realtime event handler.
- Không dùng `GroupApi` để create/join/leave group khi flow là lifecycle từ góc nhìn player.
- Không dùng `GamePlayerApi` relation item như thể đó là full entity snapshot.
- Không quên `catalogId` khi gọi `addPlayerFriendAsync`.
- Không dùng `playerStatisticsKeys` thay cho `statisticsKeys` của `getPlayerStatisticsAsync`.
- Không dùng `skip` để phân trang log.
- Không dùng `token` để phân trang search hoặc leaderboard.
- Không giả định `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync` luôn trả id mới tạo trong response.
- Không bỏ qua kiểm tra `returnCode` và `errorCode`.

## 15. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `gamePlayer` / `gamePlayer.server` / `gamePlayer.admin` chưa.
- Nếu đang ở `server/admin`, đã truyền `userId` cho flow self-target chưa.
- Nếu đang ở `client`, có thật sự muốn target current authenticated game player không.
- Nếu method yêu cầu `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc relation nhẹ, có cần API chuyên biệt để lấy full metadata không.
- Nếu đang làm friend/group realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang tạo player/item/group/character và cần id mới, đã chuẩn bị bước re-query chưa.
- Có kiểm tra `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §4 Chọn Namespace | 80-95 |
| §5 Chọn Method — Đọc 1 game player | 104-127 |
| §5 Chọn Method — Search, leaderboard và log | 128-144 |
| §5 Chọn Method — Friend, group, character, item lifecycle | 146-159 |
| §5 Chọn Method — Mutation profile | 161-177 |
| §8 InfoRequestParam Rules | 217-248 |
| §10 Minimal Pattern | 287-306 |
| §13 Ví Dụ Khuyến Nghị | 343-446 |
