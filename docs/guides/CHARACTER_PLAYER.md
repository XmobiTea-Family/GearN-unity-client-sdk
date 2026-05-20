# CharacterPlayerApi

Tài liệu này là landing page cho AI code assistant khi cần dùng `GNNetwork.characterPlayer*`. Đọc file này để chọn đúng namespace, method, DTO nhanh, rồi chỉ mở đúng row trong [API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md) khi cần contract chi tiết.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.characterPlayer`
    - `GNNetwork.characterPlayer.server`
    - `GNNetwork.characterPlayer.admin`
- Toàn bộ method hiện tại của `CharacterPlayerApi` đều gửi qua HTTP.
- `CharacterPlayerApi` có đủ 3 role thật:
    - `GNNetwork.characterPlayer` -> `RequestRole.Client`
    - `GNNetwork.characterPlayer.server` -> `RequestRole.Server`
    - `GNNetwork.characterPlayer.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu `self/other-self` xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Không tự suy diễn route chỉ từ target ownership.
- Khác với `GamePlayerApi`, public contract hiện tại gần như luôn yêu cầu `characterId` rõ ràng cho các flow target một character cụ thể.
- `client`, `server`, `admin` hiện dùng cùng shape request; khác biệt chính là trust boundary và secret key mặc định.
- `CharacterPlayerApi` là nhóm metadata/lifecycle ở cấp character:
    - đọc metadata và owner/remove status của character
    - đọc relation nhẹ tới inventory, group, friend
    - search character
    - leaderboard toàn cục hoặc leaderboard trong mạng bạn bè
    - create group từ góc nhìn character
    - create item cho character
    - add/remove friend
    - join/leave group
- `CharacterPlayerApi` không có public method tạo character mới. Nếu cần tạo character, phải dùng `GamePlayerApi.createPlayerCharacterAsync`.
- Realtime update friend/group là luồng riêng qua socket event handler, không phải transport của các method `CharacterPlayerApi`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket transport cho các method của `CharacterPlayerApi`.
- Chọn namespace theo trust boundary:
    - app/player -> `GNNetwork.characterPlayer`
    - trusted backend/service -> `GNNetwork.characterPlayer.server`
    - dashboard/ops/tooling -> `GNNetwork.characterPlayer.admin`
- Khi method target một character cụ thể, luôn phải truyền `characterId`. Không có cơ chế public auto-select current character.
- `getPlayerInformationAsync`, `getFriendStatisticsLeaderboardAroundPlayerAsync`, `getFriendStatisticsLeaderboardAsync`, `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync`, `getStatisticsLeaderboardAroundPlayerAsync`, `getStatisticsLeaderboardAsync`, `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync` và `getLastLoginLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getPlayerStatisticsAsync` dùng `statisticsKeys`, còn `infoRequestParam` dùng `playerStatisticsKeys`. Không được dùng lẫn hai field này.
- `getPlayerInventoryAsync` dùng `itemCatalogIds`, `getPlayerGroupAsync` dùng `groupCatalogIds`, `getPlayerFriendAsync` dùng `friendCatalogIds`.
- `getOwnerAsync` trả `owner.type` và `owner.id`; `owner.type` nên map bằng `OwnerType`.
- `setOwnerAsync` chỉ nhận `newOwnerId`. Public contract hiện không có `newOwnerType`; AI không được tự bịa field này.
- `getRemoveStatusAsync` đọc remove status; `setRemoveStatusAsync` là soft-remove marker, không phải hard delete.
- `addPlayerFriendAsync` bắt buộc có `characterId`, `friendId`, `catalogId`.
- Trong `CharacterPlayerApi`, `friendId` là quan hệ ở cấp character, không phải cấp game-player.
- `createGroupAsync` nhận `groupMembers[]` là `userId`, không phải `characterId`.
- `createPlayerItemAsync` và `createGroupAsync` hiện không có contract public riêng để trả `itemId` hoặc `groupId` vừa tạo.
- `setAvatarAsync` trả `EmptyResponseData`. `SetAvatarRequestData.type` hiện là số thô, package không export enum avatar public tương ứng.
- `playerGroups[].status` nên map bằng `GroupStatus`, `playerFriends[].status` nên map bằng `FriendStatus`.
- `playerInventories`, `playerGroups`, `playerFriends` trong `CharacterPlayerApi` là relation item nhẹ; không được giả định chúng chứa full metadata chi tiết.
- `getCurrencyLogAsync` và `getStatisticsLogAsync` phân trang bằng `token`, không dùng `skip`.

## 3. HTTP Và Socket

Rule cứng:

- Nếu cần đọc/ghi metadata hoặc lifecycle ở cấp character: dùng `GNNetwork.characterPlayer*` qua HTTP.
- Nếu cần realtime friend/group update: dùng socket event handler riêng.
- Không được giả định gọi `addPlayerFriendAsync`, `removePlayerFriendAsync`, `joinGroupAsync` hoặc `leaveGroupAsync` là đủ để UI tự nhận realtime nếu chưa auth socket.

Event handler public: xem [reference/EVENTS.md](/docs/reference/EVENTS.md#oncharacterplayerfriendupdateeventhandler) và [reference/EVENTS.md](/docs/reference/EVENTS.md#oncharacterplayergroupupdateeventhandler).

Realtime rule:

- Muốn nhận event realtime, tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow).
- `OnCharacterPlayerFriendUpdateEventHandler.onUpdate`:
    - payload có `characterId`
    - có `playerFriends`
- `OnCharacterPlayerGroupUpdateEventHandler.onUpdate`:
    - payload có `characterId`
    - có `playerGroups`

## 4. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | Dùng khi nào |
| --- | --- | --- |
| `GNNetwork.characterPlayer` | `Client` | player app thao tác trên character cụ thể mà client đang giữ `characterId` |
| `GNNetwork.characterPlayer.server` | `Server` | trusted backend, game server, worker xử lý lifecycle character |
| `GNNetwork.characterPlayer.admin` | `Admin` | GM tool, dashboard, migration, vận hành dữ liệu character |

Rule nhanh:

- Logic chạy trong app public: ưu tiên `GNNetwork.characterPlayer`.
- Logic chạy trong backend tin cậy: ưu tiên `GNNetwork.characterPlayer.server`.
- Logic quản trị hoặc vận hành dữ liệu: ưu tiên `GNNetwork.characterPlayer.admin`.
- Không chọn namespace theo cảm tính; request shape giống nhau nhưng trust boundary khác nhau.

## 5. Chọn Method

Đọc các bảng use case bên dưới trước. Cột index này trỏ thẳng đến row contract trong `API_CHARACTER_PLAYER.md`; không cần mở full file API khi chỉ cần DTO, permission, hoặc ErrorCode của một method.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp | Permission Rules khi truyền characterId mà gamePlayer đang authenticated không phải là owner của characterPlayer này |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

<!-- prettier-ignore -->
| Method | API contract rows |
| --- | --- |
| `addPlayerFriendAsync` | [client:15-15](/docs/reference/API_CHARACTER_PLAYER.md) / [server:74-74](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:133-133](/docs/reference/API_CHARACTER_PLAYER.md) |
| `addSegmentAsync` | [client:16-16](/docs/reference/API_CHARACTER_PLAYER.md) / [server:75-75](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:134-134](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getAvatarAsync` | [client:17-17](/docs/reference/API_CHARACTER_PLAYER.md) / [server:76-76](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:135-135](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCatalogIdAsync` | [client:18-18](/docs/reference/API_CHARACTER_PLAYER.md) / [server:77-77](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:136-136](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCountryCodeAsync` | [client:19-19](/docs/reference/API_CHARACTER_PLAYER.md) / [server:78-78](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:137-137](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCustomDataAsync` | [client:20-20](/docs/reference/API_CHARACTER_PLAYER.md) / [server:79-79](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:138-138](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getDisplayNameAsync` | [client:21-21](/docs/reference/API_CHARACTER_PLAYER.md) / [server:80-80](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:139-139](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getFriendStatisticsLeaderboardAroundPlayerAsync` | [client:22-22](/docs/reference/API_CHARACTER_PLAYER.md) / [server:81-81](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:140-140](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getFriendStatisticsLeaderboardAsync` | [client:23-23](/docs/reference/API_CHARACTER_PLAYER.md) / [server:82-82](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:141-141](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getIpAddressCreateAsync` | [client:24-24](/docs/reference/API_CHARACTER_PLAYER.md) / [server:83-83](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:142-142](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getOwnerAsync` | [client:25-25](/docs/reference/API_CHARACTER_PLAYER.md) / [server:84-84](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:143-143](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerBanAsync` | [client:26-26](/docs/reference/API_CHARACTER_PLAYER.md) / [server:85-85](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:144-144](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerCurrencyAsync` | [client:27-27](/docs/reference/API_CHARACTER_PLAYER.md) / [server:86-86](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:145-145](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerDataAsync` | [client:28-28](/docs/reference/API_CHARACTER_PLAYER.md) / [server:87-87](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:146-146](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerFriendAsync` | [client:29-29](/docs/reference/API_CHARACTER_PLAYER.md) / [server:88-88](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:147-147](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerGroupAsync` | [client:30-30](/docs/reference/API_CHARACTER_PLAYER.md) / [server:89-89](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:148-148](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerInformationAsync` | [client:31-31](/docs/reference/API_CHARACTER_PLAYER.md) / [server:90-90](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:149-149](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerInventoryAsync` | [client:32-32](/docs/reference/API_CHARACTER_PLAYER.md) / [server:91-91](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:150-150](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayerStatisticsAsync` | [client:33-33](/docs/reference/API_CHARACTER_PLAYER.md) / [server:92-92](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:151-151](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayersWithDisplayNameAsync` | [client:34-34](/docs/reference/API_CHARACTER_PLAYER.md) / [server:93-93](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:152-152](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayersWithSegmentAsync` | [client:35-35](/docs/reference/API_CHARACTER_PLAYER.md) / [server:94-94](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:153-153](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getPlayersWithTagAsync` | [client:36-36](/docs/reference/API_CHARACTER_PLAYER.md) / [server:95-95](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:154-154](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getRemoveStatusAsync` | [client:37-37](/docs/reference/API_CHARACTER_PLAYER.md) / [server:96-96](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:155-155](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getSegmentAsync` | [client:38-38](/docs/reference/API_CHARACTER_PLAYER.md) / [server:97-97](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:156-156](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getStatisticsLeaderboardAroundPlayerAsync` | [client:39-39](/docs/reference/API_CHARACTER_PLAYER.md) / [server:98-98](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:157-157](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getStatisticsLeaderboardAsync` | [client:40-40](/docs/reference/API_CHARACTER_PLAYER.md) / [server:99-99](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:158-158](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getTagAsync` | [client:41-41](/docs/reference/API_CHARACTER_PLAYER.md) / [server:100-100](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:159-159](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getTsCreateAsync` | [client:42-42](/docs/reference/API_CHARACTER_PLAYER.md) / [server:101-101](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:160-160](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getTsLastLoginAsync` | [client:43-43](/docs/reference/API_CHARACTER_PLAYER.md) / [server:102-102](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:161-161](/docs/reference/API_CHARACTER_PLAYER.md) |
| `createGroupAsync` | [client:44-44](/docs/reference/API_CHARACTER_PLAYER.md) / [server:103-103](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:162-162](/docs/reference/API_CHARACTER_PLAYER.md) |
| `createPlayerItemAsync` | [client:45-45](/docs/reference/API_CHARACTER_PLAYER.md) / [server:104-104](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:163-163](/docs/reference/API_CHARACTER_PLAYER.md) |
| `joinGroupAsync` | [client:46-46](/docs/reference/API_CHARACTER_PLAYER.md) / [server:105-105](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:164-164](/docs/reference/API_CHARACTER_PLAYER.md) |
| `leaveGroupAsync` | [client:47-47](/docs/reference/API_CHARACTER_PLAYER.md) / [server:106-106](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:165-165](/docs/reference/API_CHARACTER_PLAYER.md) |
| `removePlayerFriendAsync` | [client:48-48](/docs/reference/API_CHARACTER_PLAYER.md) / [server:107-107](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:166-166](/docs/reference/API_CHARACTER_PLAYER.md) |
| `removePlayerItemAsync` | [client:49-49](/docs/reference/API_CHARACTER_PLAYER.md) / [server:108-108](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:167-167](/docs/reference/API_CHARACTER_PLAYER.md) |
| `removeSegmentAsync` | [client:50-50](/docs/reference/API_CHARACTER_PLAYER.md) / [server:109-109](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:168-168](/docs/reference/API_CHARACTER_PLAYER.md) |
| `removeTagAsync` | [client:51-51](/docs/reference/API_CHARACTER_PLAYER.md) / [server:110-110](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:169-169](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setAvatarAsync` | [client:52-52](/docs/reference/API_CHARACTER_PLAYER.md) / [server:111-111](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:170-170](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setCountryCodeAsync` | [client:53-53](/docs/reference/API_CHARACTER_PLAYER.md) / [server:112-112](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:171-171](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setCustomDataAsync` | [client:54-54](/docs/reference/API_CHARACTER_PLAYER.md) / [server:113-113](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:172-172](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setDisplayNameAsync` | [client:55-55](/docs/reference/API_CHARACTER_PLAYER.md) / [server:114-114](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:173-173](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setOwnerAsync` | [client:56-56](/docs/reference/API_CHARACTER_PLAYER.md) / [server:115-115](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:174-174](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setPlayerBanAsync` | [client:57-57](/docs/reference/API_CHARACTER_PLAYER.md) / [server:116-116](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:175-175](/docs/reference/API_CHARACTER_PLAYER.md) |
| `changePlayerCurrencyAsync` | [client:58-58](/docs/reference/API_CHARACTER_PLAYER.md) / [server:117-117](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:176-176](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setPlayerDataAsync` | [client:59-59](/docs/reference/API_CHARACTER_PLAYER.md) / [server:118-118](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:177-177](/docs/reference/API_CHARACTER_PLAYER.md) |
| `changePlayerStatisticsAsync` | [client:60-60](/docs/reference/API_CHARACTER_PLAYER.md) / [server:119-119](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:178-178](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setRemoveStatusAsync` | [client:61-61](/docs/reference/API_CHARACTER_PLAYER.md) / [server:120-120](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:179-179](/docs/reference/API_CHARACTER_PLAYER.md) |
| `setTagAsync` | [client:62-62](/docs/reference/API_CHARACTER_PLAYER.md) / [server:121-121](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:180-180](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCurrencyLeaderboardAsync` | [client:63-63](/docs/reference/API_CHARACTER_PLAYER.md) / [server:122-122](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:181-181](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCreateLeaderboardAsync` | [client:64-64](/docs/reference/API_CHARACTER_PLAYER.md) / [server:123-123](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:182-182](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getLastLoginLeaderboardAsync` | [client:65-65](/docs/reference/API_CHARACTER_PLAYER.md) / [server:124-124](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:183-183](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getStatisticsLogAsync` | [client:66-66](/docs/reference/API_CHARACTER_PLAYER.md) / [server:125-125](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:184-184](/docs/reference/API_CHARACTER_PLAYER.md) |
| `getCurrencyLogAsync` | [client:67-67](/docs/reference/API_CHARACTER_PLAYER.md) / [server:126-126](/docs/reference/API_CHARACTER_PLAYER.md) / [admin:185-185](/docs/reference/API_CHARACTER_PLAYER.md) |

### Đọc 1 character hoặc 1 phần metadata

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú |
| --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar | `characterId` | `CharacterPlayerResponseData` | `avatar.type` hiện là số thô |
| `getCatalogIdAsync` | Cần đọc `catalogId` của character | `characterId` | `CharacterPlayerResponseData` | Kết quả ở `infoResponseParameters.catalogId` |
| `getCountryCodeAsync` | Cần đọc quốc gia | `characterId` | `CharacterPlayerResponseData` |  |
| `getCustomDataAsync` | Cần đọc custom data | `characterId`, `customDataKeys?` | `CharacterPlayerResponseData` | Có thể filter theo key |
| `getDisplayNameAsync` | Cần đọc display name | `characterId` | `CharacterPlayerResponseData` |  |
| `getIpAddressCreateAsync` | Cần đọc IP lúc tạo character | `characterId` | `CharacterPlayerResponseData` | Trường này thường nhạy cảm, ưu tiên backend/admin |
| `getOwnerAsync` | Cần đọc owner hiện tại | `characterId` | `CharacterPlayerResponseData` | Map `owner.type` bằng `OwnerType` |
| `getPlayerBanAsync` | Cần đọc trạng thái ban | `characterId` | `CharacterPlayerResponseData` |  |
| `getPlayerCurrencyAsync` | Cần đọc currency | `characterId`, `playerCurrencyKeys?` | `CharacterPlayerResponseData` | Không dùng `infoRequestParam` |
| `getPlayerDataAsync` | Cần đọc player data | `characterId`, `playerDataKeys?` | `CharacterPlayerResponseData` | Không dùng `infoRequestParam` |
| `getPlayerFriendAsync` | Cần đọc relation friend ở cấp character | `characterId`, `friendCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `friendId`, `catalogId`, `status`, `tsLastStatusUpdate` |
| `getPlayerGroupAsync` | Cần đọc relation group của character | `characterId`, `groupCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `groupId`, `catalogId`, `status`, `tsLastStatusUpdate` |
| `getPlayerInformationAsync` | Cần lấy snapshot tổng hợp của character | `characterId`, `infoRequestParam` | `CharacterPlayerResponseData` | Flow đọc tổng hợp quan trọng nhất |
| `getPlayerInventoryAsync` | Cần đọc relation inventory của character | `characterId`, `itemCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `itemId`, `catalogId`, `classId` |
| `getPlayerStatisticsAsync` | Cần đọc statistics theo key | `characterId`, `statisticsKeys?` | `CharacterPlayerResponseData` | Không dùng `playerStatisticsKeys` ở đây |
| `getRemoveStatusAsync` | Cần đọc trạng thái remove | `characterId` | `CharacterPlayerResponseData` | Kết quả ở `infoResponseParameters.removeStatus` |
| `getSegmentAsync` | Cần đọc segment | `characterId` | `CharacterPlayerResponseData` |  |
| `getTagAsync` | Cần đọc tag theo key | `characterId`, `tagKeys` | `CharacterPlayerResponseData` |  |
| `getTsCreateAsync` | Cần đọc thời điểm tạo character | `characterId` | `CharacterPlayerResponseData` |  |
| `getTsLastLoginAsync` | Cần đọc lần login gần nhất | `characterId` | `CharacterPlayerResponseData` |  |

### Search, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú |
| --- | --- | --- | --- | --- |
| `getPlayersWithDisplayNameAsync` | Tìm character theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` | Kết quả trả `characterId` |
| `getPlayersWithSegmentAsync` | Tìm character theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` |  |
| `getPlayersWithTagAsync` | Tìm character theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` |  |
| `getFriendStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng quanh một character trong mạng bạn bè của character đó | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Không phải global leaderboard |
| `getFriendStatisticsLeaderboardAsync` | Cần bảng xếp hạng friend-only theo key | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Scope là bạn bè của character target |
| `getStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng toàn cục quanh một character | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | Có thể filter theo `catalogId` |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetCurrencyLeaderboardResponseData` | Có thể filter theo `catalogId` |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo character | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần `key` |
| `getLastLoginLeaderboardAsync` | Cần bảng xếp hạng theo lần login gần nhất | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetLastLoginLeaderboardResponseData` | Không cần `key` |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `characterId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `characterId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | Phân trang bằng `token` |

### Friend, group, item lifecycle và mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú |
| --- | --- | --- | --- | --- |
| `addPlayerFriendAsync` | Thêm một quan hệ friend ở cấp character | `characterId`, `friendId`, `catalogId` | `EmptyResponseData` | `friendId` là id ở cấp character |
| `removePlayerFriendAsync` | Gỡ một quan hệ friend | `characterId`, `friendId` | `EmptyResponseData` |  |
| `createGroupAsync` | Tạo group từ góc nhìn character | `characterId`, `catalogId`, `groupMembers?`, `displayName?` | `CharacterPlayerResponseData` | `groupMembers[]` dùng `userId`, không dùng `characterId` |
| `joinGroupAsync` | Cho character join vào group đã tồn tại | `characterId`, `groupId` | `EmptyResponseData` | Flow lifecycle ở phía character |
| `leaveGroupAsync` | Cho character rời khỏi group | `characterId`, `groupId` | `EmptyResponseData` |  |
| `createPlayerItemAsync` | Tạo item mới cho character | `characterId`, `catalogId`, `classId`, `displayName?`, `amount?` | `CharacterPlayerResponseData` | Không có contract riêng cho `itemId` mới tạo |
| `removePlayerItemAsync` | Xóa item khỏi character theo `itemId` | `characterId`, `itemId` | `EmptyResponseData` |  |
| `addSegmentAsync` | Gắn thêm segment | `characterId`, `value` | `EmptyResponseData` |  |
| `removeSegmentAsync` | Gỡ segment | `characterId`, `value` | `EmptyResponseData` |  |
| `setTagAsync` | Set hoặc upsert tag | `characterId`, `key`, `value` | `EmptyResponseData` |  |
| `removeTagAsync` | Xóa tag theo key | `characterId`, `key` | `EmptyResponseData` | Không truyền `value` |
| `setAvatarAsync` | Set avatar | `characterId`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public |
| `setCountryCodeAsync` | Set country code | `characterId`, `countryCode` | `EmptyResponseData` |  |
| `setCustomDataAsync` | Set custom data theo nhiều key | `characterId`, `customDatas[]` | `CharacterPlayerResponseData` |  |
| `setDisplayNameAsync` | Set display name | `characterId`, `displayName`, `uniqueDisplayName?` | `EmptyResponseData` | Có option ép unique |
| `setOwnerAsync` | Chuyển owner của character | `characterId`, `newOwnerId` | `EmptyResponseData` | Public contract không có `newOwnerType` |
| `setPlayerBanAsync` | Ban character đến thời điểm cụ thể | `characterId`, `tsExpire`, `reason` | `EmptyResponseData` |  |
| `changePlayerCurrencyAsync` | Cộng/trừ currency | `characterId`, `playerCurrencies[]`, `log?` | `CharacterPlayerResponseData` | Đây là delta change |
| `setPlayerDataAsync` | Set player data theo nhiều key | `characterId`, `playerDatas[]` | `CharacterPlayerResponseData` |  |
| `changePlayerStatisticsAsync` | Cộng/trừ statistics | `characterId`, `playerStatistics[]`, `log?` | `CharacterPlayerResponseData` | Đây là delta change |
| `setRemoveStatusAsync` | Đánh dấu character bị remove | `characterId`, `reason?` | `EmptyResponseData` | Soft remove, không phải hard delete |

## 6. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.characterPlayer.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.characterPlayer.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Với route khác, giữ nguyên method và đổi namespace:

```csharp
await GNNetwork.characterPlayer.server.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
await GNNetwork.characterPlayer.admin.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new CharacterPlayerModels.<Method>RequestData()` hoặc variant `Server*` / `Admin*` đúng route |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / tool dùng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md#2-response-checking-2-tier).

## 7. Request Field Rules Và Reference

- DTO fields: [reference/dto/CHARACTER_PLAYER.md](/docs/reference/dto/CHARACTER_PLAYER.md). Method table: [reference/API_CHARACTER_PLAYER.md](/docs/reference/API_CHARACTER_PLAYER.md).
- Events: [reference/EVENTS.md](/docs/reference/EVENTS.md#oncharacterplayerfriendupdateeventhandler).
- Enums: [FriendStatus](/docs/reference/ENUMS.md#friendstatus), [GroupStatus](/docs/reference/ENUMS.md#groupstatus), [OwnerType](/docs/reference/ENUMS.md#ownertype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/CharacterPlayer*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- `GenericModels.FriendItem.status` nên map bằng `FriendStatus`.
- `GenericModels.GroupItem.status` nên map bằng `GroupStatus`.
- `infoResponseParameters.owner.type` nên map bằng `OwnerType`.
- `SetAvatarRequestData.type` và `avatar.type` hiện chưa có enum public tương ứng.

## 8. InfoRequestParam Rules

`CharacterPlayerModels.InfoRequestParam` điều khiển payload trả về trong:

- `getPlayerInformationAsync`
- `getFriendStatisticsLeaderboardAroundPlayerAsync`
- `getFriendStatisticsLeaderboardAsync`
- `getPlayersWithDisplayNameAsync`
- `getPlayersWithSegmentAsync`
- `getPlayersWithTagAsync`
- `getStatisticsLeaderboardAroundPlayerAsync`
- `getStatisticsLeaderboardAsync`
- `getCurrencyLeaderboardAsync`
- `getCreateLeaderboardAsync`
- `getLastLoginLeaderboardAsync`

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
    - `itemCatalogIds`
    - `groupCatalogIds`
    - `friendCatalogIds`
- Nếu chỉ cần một mảng relation nhẹ hoặc một field nhỏ, ưu tiên getter chuyên biệt.

Các field thường dùng:

- `catalogId`
- `owner`
- `removeStatus`
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
- `playerInventories`
- `playerGroups`
- `playerFriends`

## 9. Decision Rules

- Cần đọc snapshot tổng hợp của một character: dùng `getPlayerInformationAsync`.
- Cần đọc đúng một field nhỏ như `catalogId`, `owner`, `removeStatus`, `displayName`: ưu tiên getter chuyên biệt.
- Cần search character theo display name/segment/tag: dùng nhóm `getPlayersWith*Async`.
- Cần leaderboard trong mạng bạn bè của character: dùng `getFriendStatisticsLeaderboardAsync` hoặc `getFriendStatisticsLeaderboardAroundPlayerAsync`.
- Cần leaderboard toàn cục: dùng `getStatisticsLeaderboardAsync`, `getStatisticsLeaderboardAroundPlayerAsync`, `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync`, `getLastLoginLeaderboardAsync`.
- Cần create character mới: không dùng `CharacterPlayerApi`; phải dùng `GamePlayerApi.createPlayerCharacterAsync`.
- Cần create/join/leave group từ góc nhìn character: dùng `createGroupAsync`, `joinGroupAsync`, `leaveGroupAsync`.
- Cần quản lý metadata chi tiết của group: dùng `GroupApi`.
- Cần quản lý metadata chi tiết của item: dùng `InventoryApi`.
- Cần chuyển owner của character: dùng `setOwnerAsync`, nhưng không được tự thêm `newOwnerType`.
- Cần soft-remove character: dùng `setRemoveStatusAsync`.
- Cần realtime friend/group UI: dùng event handler socket sau khi đã auth socket.

## 10. Minimal Pattern

Tất cả typed response của `CharacterPlayerApi` đều có:

- `returnCode`
- `debugMessage`
- `invalidMembers`
- `errorCode`
- `responseData`

Pattern tối thiểu:

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new CharacterPlayerModels.GetPlayerInformationRequestData();
requestData.characterId = "CHAR0000001";
requestData.infoRequestParam = new CharacterPlayerModels.InfoRequestParam {
    displayName = true,
    catalogId = true
};

var response = await GNNetwork.characterPlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var characterInfo = response.responseData.infoResponseParameters;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

Những response chính AI cần nhớ:

- Hầu hết getter đơn lẻ trả `CharacterPlayerResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` trả `CharacterPlayersWithCharacterIdResponseData`, mỗi phần tử có `characterId` và `infoResponseParameters`.
- `getFriendStatisticsLeaderboard*Async` và `getStatisticsLeaderboard*Async` trả `GetStatisticsLeaderboardResponseData`.
- `getStatisticsLeaderboardAsync` còn có thêm `responseData.tsCreate`.
- `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync`, `getLastLoginLeaderboardAsync` trả `results` theo leaderboard shape.
- `getStatisticsLogAsync` và `getCurrencyLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `addPlayerFriendAsync`, `addSegmentAsync`, `joinGroupAsync`, `leaveGroupAsync`, `removePlayerFriendAsync`, `removePlayerItemAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setCountryCodeAsync`, `setDisplayNameAsync`, `setOwnerAsync`, `setPlayerBanAsync`, `setRemoveStatusAsync`, `setTagAsync` trả `EmptyResponseData`.
- `createGroupAsync`, `createPlayerItemAsync`, `setCustomDataAsync`, `changePlayerCurrencyAsync`, `setPlayerDataAsync`, `changePlayerStatisticsAsync` trả `CharacterPlayerResponseData`.

## 11. Cảnh Báo Implementation Hiện Tại

- `CharacterPlayerModels.InfoRequestParam` không cần dùng field `characterCatalogIds`, vì public response của `CharacterPlayerApi` không có `playerCharacters`.
- Theo public contract hiện tại, AI không nên dùng field này trừ khi có spec backend riêng xác nhận ý nghĩa của nó.
- `createGroupAsync` và `createPlayerItemAsync` hiện không có response field public riêng cho id vừa tạo.
- Nếu flow sau đó cần `groupId` hoặc `itemId`, bạn phải re-query hoặc verify backend contract riêng.
- `setOwnerAsync` chỉ có `newOwnerId`; public SDK không cho chọn `newOwnerType`.
- Nếu flow phụ thuộc loại owner mới, bạn phải xác minh backend rule riêng thay vì tự suy diễn.
- `playerInventories`, `playerGroups`, `playerFriends` chỉ là relation item nhẹ, không phải full metadata entity.
- `CharacterPlayerApi` không có public method tạo character mới hoặc hard-delete character.
- `setRemoveStatusAsync` là soft-remove marker; nếu cần hard delete thật, bạn phải dùng contract khác ngoài public surface hiện tại.
- `avatar.type` vẫn là số thô, chưa có enum public tương ứng.

## 12. Best Practices

- Luôn giữ `characterId` ở biến riêng, đừng trộn với `userId`, `friendId`, `groupId`, `itemId`.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với relation item từ `CharacterPlayerApi`, chỉ dùng nó như index nhẹ để lấy id và trạng thái; đừng coi đó là full entity snapshot.
- Với friend/group UI, đọc initial state bằng getter HTTP rồi nghe realtime update bằng socket event handler.
- Với `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với `setOwnerAsync`, nếu flow cần xác nhận owner sau mutation, hãy đọc lại bằng `getOwnerAsync`.
- Với create flow, chuẩn bị sẵn bước re-fetch nếu bạn cần id mới tạo hoặc metadata chi tiết.

## 13. Ví Dụ Khuyến Nghị

### Đọc thông tin character với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;
using System.Collections.Generic;

var infoRequestParam = new CharacterPlayerModels.InfoRequestParam();
infoRequestParam.catalogId = true;
infoRequestParam.displayName = true;
infoRequestParam.owner = true;
infoRequestParam.playerInventories = true;
infoRequestParam.itemCatalogIds = new List<string> { "weapon" };

var requestData = new CharacterPlayerModels.GetPlayerInformationRequestData();
requestData.characterId = "CHAR0000001";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.characterPlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var characterInfo = response.responseData.infoResponseParameters;
```

### Add friend rồi đồng bộ UI bằng realtime event

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

OnCharacterPlayerFriendUpdateEventHandler.onUpdate = (update) => {
    if (update.characterId != "CHAR0000001") {
        return;
    }

    var friendItems = update.playerFriends;
    UnityEngine.Debug.Log(friendItems);
};

GNNetwork.connectSocket(); // Follow README socket rule before expecting realtime updates.

var requestData = new CharacterPlayerModels.AddPlayerFriendRequestData();
requestData.characterId = "CHAR0000001";
requestData.friendId = "CHAR0000002";
requestData.catalogId = "default-friend";

var response = await GNNetwork.characterPlayer.addPlayerFriendAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;
```

### Tạo item cho character rồi re-query relation item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;
using System.Collections.Generic;

var createRequestData = new CharacterPlayerModels.CreatePlayerItemRequestData();
createRequestData.characterId = "CHAR0000001";
createRequestData.catalogId = "weapon";
createRequestData.classId = "sword";
createRequestData.displayName = "Starter Sword";
createRequestData.amount = 1;

var createResponse = await GNNetwork.characterPlayer.createPlayerItemAsync(createRequestData);

if (createResponse.returnCode != ReturnCode.Ok) return;
if (createResponse.errorCode != ErrorCode.Ok) return;

var getInventoryRequestData = new CharacterPlayerModels.GetPlayerInventoryRequestData();
getInventoryRequestData.characterId = "CHAR0000001";
getInventoryRequestData.itemCatalogIds = new List<string> { "weapon" };

var inventoryResponse = await GNNetwork.characterPlayer.getPlayerInventoryAsync(getInventoryRequestData);

if (inventoryResponse.returnCode != ReturnCode.Ok) return;
if (inventoryResponse.errorCode != ErrorCode.Ok) return;

var inventoryRelations = inventoryResponse.responseData.infoResponseParameters.playerInventories;
```

## 14. Anti-Patterns

- Không bỏ `characterId` ở các method target một character cụ thể.
- Không dùng `CharacterPlayerApi` để tạo character mới.
- Không dùng `userId` thay cho `characterId` hoặc `friendId` trong các flow character-level.
- Không gửi `characterId` trong `groupMembers[]` của `createGroupAsync`; field này dùng `userId`.
- Không tự thêm `newOwnerType` vào `setOwnerAsync`.
- Không dùng `CharacterPlayerApi` relation item như thể đó là full entity snapshot.
- Không giả định `createGroupAsync` hoặc `createPlayerItemAsync` luôn trả id mới tạo trong response.
- Không dùng `skip` để phân trang log.
- Không giả định socket event tự chứa full metadata hoặc thông tin ngoài `characterId` và mảng relation.
- Không bỏ qua kiểm tra `returnCode` trước `errorCode`.

## 15. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `characterPlayer` / `characterPlayer.server` / `characterPlayer.admin` chưa.
- Có truyền `characterId` cho flow target một character cụ thể chưa.
- Nếu flow là create character, có đang dùng nhầm `CharacterPlayerApi` không.
- Nếu method yêu cầu `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc relation nhẹ, có cần API chuyên biệt để lấy full metadata không.
- Nếu đang làm friend/group realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang dùng `setOwnerAsync`, có tránh tự thêm `newOwnerType` không.
- Nếu đang tạo item hoặc group và cần id mới, đã chuẩn bị bước re-query chưa.
- Có kiểm tra `returnCode` trước `errorCode` chưa.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §4 Chọn Namespace | 79-94 |
| §5 Chọn Method — Snapshot tổng hợp + field getter (getPlayerInformation + các getter đơn) | 95-158 |
| §5 Chọn Method — Đọc 1 character hoặc 1 phần metadata | 160-184 |
| §5 Chọn Method — Search, leaderboard và log | 186-202 |
| §5 Chọn Method — Friend, group, item lifecycle và mutation | 204-229 |
| §8 InfoRequestParam Rules | 275-328 |
| §10 Minimal Pattern | 344-388 |
| §13 Ví Dụ Khuyến Nghị | 412-500 |
