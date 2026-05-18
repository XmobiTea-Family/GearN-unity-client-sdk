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

### Đọc 1 game player hoặc 1 phần hồ sơ

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar | `userId?` | `GamePlayerResponseData` | `avatar.type` hiện là số thô | `Ok`, `GamePlayerNotFound` |
| `getCountryCodeAsync` | Cần đọc quốc gia | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.countryCode` | `Ok`, `GamePlayerNotFound` |
| `getCustomDataAsync` | Cần đọc custom data | `userId?`, `customDataKeys?` | `GamePlayerResponseData` | Có thể filter theo key | `Ok`, `GamePlayerNotFound` |
| `getDisplayNameAsync` | Cần đọc display name | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.displayName` | `Ok`, `GamePlayerNotFound` |
| `getIpAddressCreateAsync` | Cần đọc IP lúc tạo player | `userId?` | `GamePlayerResponseData` | Trường này thường nhạy cảm, ưu tiên backend/admin | `Ok`, `GamePlayerNotFound` |
| `getPlayerBanAsync` | Cần đọc trạng thái ban | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.playerBan` | `Ok`, `GamePlayerNotFound` |
| `getPlayerCharacterAsync` | Cần đọc relation character của player | `userId?`, `characterCatalogIds?` | `GamePlayerResponseData` | Mỗi phần tử chỉ có `characterId`, `catalogId` | `Ok`, `GamePlayerNotFound` |
| `getPlayerCurrencyAsync` | Cần đọc currency | `userId?`, `playerCurrencyKeys?` | `GamePlayerResponseData` | Không dùng `infoRequestParam` | `Ok`, `GamePlayerNotFound` |
| `getPlayerDataAsync` | Cần đọc player data | `userId?`, `playerDataKeys?` | `GamePlayerResponseData` | Không dùng `infoRequestParam` | `Ok`, `GamePlayerNotFound` |
| `getPlayerFriendAsync` | Cần đọc relation friend | `userId?`, `friendCatalogIds?` | `GamePlayerResponseData` | Mỗi phần tử chỉ có `friendId`, `catalogId`, `status`, `tsLastStatusUpdate` | `Ok`, `GamePlayerNotFound` |
| `getPlayerGroupAsync` | Cần đọc relation group | `userId?`, `groupCatalogIds?` | `GamePlayerResponseData` | Mỗi phần tử chỉ có `groupId`, `catalogId`, `status`, `tsLastStatusUpdate` | `Ok`, `GamePlayerNotFound` |
| `getPlayerInformationAsync` | Cần lấy snapshot tổng hợp của player | `userId?`, `infoRequestParam` | `GamePlayerResponseData` | Flow đọc tổng hợp quan trọng nhất | `Ok`, `GamePlayerNotFound`, `MasterPlayerNotFound` |
| `getPlayerInventoryAsync` | Cần đọc relation inventory | `userId?`, `itemCatalogIds?` | `GamePlayerResponseData` | Mỗi phần tử chỉ có `itemId`, `catalogId`, `classId` | `Ok`, `GamePlayerNotFound` |
| `getPlayerStatisticsAsync` | Cần đọc statistics theo key | `userId?`, `statisticsKeys?` | `GamePlayerResponseData` | Không dùng `playerStatisticsKeys` ở đây | `Ok`, `GamePlayerNotFound` |
| `getSegmentAsync` | Cần đọc segment | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.segments` | `Ok`, `GamePlayerNotFound` |
| `getTagAsync` | Cần đọc tag theo key | `userId?`, `tagKeys` | `GamePlayerResponseData` | Không query theo value | `Ok`, `GamePlayerNotFound` |
| `getTsCreateAsync` | Cần đọc thời điểm tạo player | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.tsCreate` | `Ok`, `GamePlayerNotFound` |
| `getTsLastLoginAsync` | Cần đọc lần login gần nhất | `userId?` | `GamePlayerResponseData` | Kết quả ở `infoResponseParameters.tsLastLogin` | `Ok`, `GamePlayerNotFound` |

### Search, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getPlayersWithDisplayNameAsync` | Tìm player theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | Phân trang bằng `skip/limit` | `Ok` |
| `getPlayersWithSegmentAsync` | Tìm player theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | Query theo exact segment value | `Ok` |
| `getPlayersWithTagAsync` | Tìm player theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `GamePlayersWithUserIdResponseData` | Query theo cặp `key/value` | `Ok`, `KeyNotFound` |
| `getFriendStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng quanh một player trong mạng bạn bè của player đó | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Không phải global leaderboard | `Ok`, `KeyNotFound`, `GamePlayerNotFound` |
| `getFriendStatisticsLeaderboardAsync` | Cần bảng xếp hạng friend-only theo key | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Scope là bạn bè của player target | `Ok`, `KeyNotFound`, `GamePlayerNotFound` |
| `getStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng toàn cục quanh một player | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Đây là global statistics leaderboard | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này | `Ok`, `KeyNotFound`, `VersionInvalid` |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCurrencyLeaderboardResponseData` | Không có `version` | `Ok`, `KeyNotFound` |
| `getLastLoginLeaderboardAsync` | Cần bảng xếp hạng theo lần login gần nhất | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetLastLoginLeaderboardResponseData` | Không cần `key` | `Ok` |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo player | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần `key` | `Ok` |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `userId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` | `Ok` |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `userId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | Phân trang bằng `token` | `Ok` |

### Friend, group, character và item lifecycle

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addPlayerFriendAsync` | Thêm một quan hệ friend | `userId?`, `friendId`, `catalogId` | `EmptyResponseData` | Không được quên `catalogId` | `Ok`, `CatalogIdNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `removePlayerFriendAsync` | Gỡ một quan hệ friend | `userId?`, `friendId` | `EmptyResponseData` | Không cần `catalogId` ở flow remove | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `createGroupAsync` | Tạo group từ phía player | `userId?`, `catalogId`, `groupMembers?`, `displayName?` | `GamePlayerResponseData` | `groupMembers[]` chỉ chứa `userId` | `Ok`, `CatalogIdNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `joinGroupAsync` | Cho player join vào một group đã tồn tại | `userId?`, `groupId` | `EmptyResponseData` | Flow lifecycle ở phía player | `Ok`, `GroupNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `leaveGroupAsync` | Cho player rời khỏi group | `userId?`, `groupId` | `EmptyResponseData` | Không dùng `GroupApi` cho flow này | `Ok`, `GroupNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `createPlayerCharacterAsync` | Tạo character mới cho player | `userId?`, `catalogId`, `displayName?`, `uniqueDisplayName?` | `GamePlayerResponseData` | Không có contract riêng cho `characterId` mới tạo | `Ok`, `CatalogIdNotFound`, `GamePlayerNotFound`, `DisplayNameUsed`, `PlayerBan` |
| `removePlayerCharacterAsync` | Xóa relation character khỏi player theo `characterId` | `userId?`, `characterId` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `createPlayerItemAsync` | Tạo item mới cho player | `userId?`, `catalogId`, `classId`, `displayName?`, `amount?` | `GamePlayerResponseData` | Không có contract riêng cho `itemId` mới tạo | `Ok`, `CatalogIdNotFound`, `ClassIdNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `removePlayerItemAsync` | Xóa item khỏi player theo `itemId` | `userId?`, `itemId` | `EmptyResponseData` | | `Ok`, `ItemNotFound`, `GamePlayerNotFound`, `PlayerBan` |

### Mutation profile

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addSegmentAsync` | Gắn thêm segment | `userId?`, `value` | `EmptyResponseData` | Thêm một segment value | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `removeSegmentAsync` | Gỡ segment | `userId?`, `value` | `EmptyResponseData` | Xóa theo exact value | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `setTagAsync` | Set hoặc upsert tag | `userId?`, `key`, `value` | `EmptyResponseData` | | `Ok`, `KeyNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `removeTagAsync` | Xóa tag theo key | `userId?`, `key` | `EmptyResponseData` | Không truyền `value` | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `setAvatarAsync` | Set avatar | `userId?`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `setCountryCodeAsync` | Set country code | `userId?`, `countryCode` | `EmptyResponseData` | | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `setCustomDataAsync` | Set custom data theo nhiều key | `userId?`, `customDatas[]` | `GamePlayerResponseData` | | `Ok`, `KeyNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `setDisplayNameAsync` | Set display name | `userId?`, `displayName`, `uniqueDisplayName?` | `EmptyResponseData` | Có option ép unique | `Ok`, `GamePlayerNotFound`, `DisplayNameUsed`, `PlayerBan` |
| `setPlayerBanAsync` | Ban player đến thời điểm cụ thể | `userId?`, `tsExpire`, `reason` | `EmptyResponseData` | Nên ưu tiên backend/admin | `Ok`, `GamePlayerNotFound`, `PlayerBan` |
| `changePlayerCurrencyAsync` | Cộng/trừ currency | `userId?`, `playerCurrencies[]`, `log?` | `GamePlayerResponseData` | Đây là delta change | `Ok`, `NotEnoughCurrency`, `KeyNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `setPlayerDataAsync` | Set player data theo nhiều key | `userId?`, `playerDatas[]` | `GamePlayerResponseData` | | `Ok`, `KeyNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `changePlayerStatisticsAsync` | Cộng/trừ statistics | `userId?`, `playerStatistics[]`, `log?` | `GamePlayerResponseData` | Đây là delta change | `Ok`, `KeyNotFound`, `GamePlayerNotFound`, `PlayerBan` |

## 6. Enum Và Reference

- DTO fields: [reference/dto/GAME_PLAYER.md](/docs/reference/dto/GAME_PLAYER.md). Method table: [reference/API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md).
- Events: [reference/EVENTS.md](/docs/reference/EVENTS.md#ongameplayerfriendupdateeventhandler).
- Enums: [FriendStatus](/docs/reference/ENUMS.md#friendstatus), [GroupStatus](/docs/reference/ENUMS.md#groupstatus).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/GamePlayer*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- `GenericModels.FriendItem.status` nên map bằng `FriendStatus`.
- `GenericModels.GroupItem.status` nên map bằng `GroupStatus`.
- `avatar.type` hiện chưa có enum public tương ứng.

## 7. InfoRequestParam Rules

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

## 8. Decision Rules

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

## 9. Response Rules

Tất cả typed response của `GamePlayerApi` đều có:

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

- Hầu hết getter đơn lẻ trả `GamePlayerResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` trả `GamePlayersWithUserIdResponseData`, mỗi phần tử có `userId` và `infoResponseParameters`.
- `getFriendStatisticsLeaderboard*Async` và `getStatisticsLeaderboard*Async` trả `GetStatisticsLeaderboardResponseData`.
- `getStatisticsLeaderboardAsync` còn có thêm `responseData.tsCreate`.
- `getCurrencyLeaderboardAsync`, `getLastLoginLeaderboardAsync`, `getCreateLeaderboardAsync` trả `results` theo leaderboard shape.
- `getStatisticsLogAsync` và `getCurrencyLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `addPlayerFriendAsync`, `addSegmentAsync`, `joinGroupAsync`, `leaveGroupAsync`, `removePlayerCharacterAsync`, `removePlayerFriendAsync`, `removePlayerItemAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setCountryCodeAsync`, `setDisplayNameAsync`, `setPlayerBanAsync`, `setTagAsync` trả `EmptyResponseData`.
- `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync`, `setCustomDataAsync`, `changePlayerCurrencyAsync`, `setPlayerDataAsync`, `changePlayerStatisticsAsync` trả `GamePlayerResponseData`.

## 10. Cảnh Báo Implementation Hiện Tại

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

## 11. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một mảng relation nhẹ hoặc một field nhỏ.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với relation item từ `GamePlayerApi`, chỉ dùng nó như index nhẹ để lấy id và trạng thái; đừng coi đó là full entity snapshot.
- Với friend/group UI, đọc initial state bằng getter HTTP rồi nghe realtime update bằng socket event handler.
- Với `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với backend provisioning, ưu tiên `server/admin.getPlayerInformationAsync` với `createPlayerIfNotExists` thay vì để client tự xử lý.
- Với create flow, chuẩn bị sẵn bước re-fetch nếu bạn cần id mới tạo hoặc metadata chi tiết.

## 12. Ví Dụ Khuyến Nghị

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

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

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

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

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

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
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

if (createResponse.hasReturnCodeError()) {
    throw new System.Exception(createResponse.debugMessage);
}

if (createResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + createResponse.errorCode);
}

var getInventoryRequestData = new GamePlayerModels.GetPlayerInventoryRequestData();
getInventoryRequestData.itemCatalogIds = new[] { "weapon" };

var inventoryResponse = await GNNetwork.gamePlayer.getPlayerInventoryAsync(getInventoryRequestData);

if (inventoryResponse.hasReturnCodeError()) {
    throw new System.Exception(inventoryResponse.debugMessage);
}

if (inventoryResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + inventoryResponse.errorCode);
}

var inventoryRelations = inventoryResponse.responseData.infoResponseParameters.playerInventories;
```

## 13. Anti-Patterns

- Không giả định `GamePlayerApi` dùng socket transport chỉ vì có realtime event handler.
- Không dùng `GroupApi` để create/join/leave group khi flow là lifecycle từ góc nhìn player.
- Không dùng `GamePlayerApi` relation item như thể đó là full entity snapshot.
- Không quên `catalogId` khi gọi `addPlayerFriendAsync`.
- Không dùng `playerStatisticsKeys` thay cho `statisticsKeys` của `getPlayerStatisticsAsync`.
- Không dùng `skip` để phân trang log.
- Không dùng `token` để phân trang search hoặc leaderboard.
- Không giả định `createGroupAsync`, `createPlayerCharacterAsync`, `createPlayerItemAsync` luôn trả id mới tạo trong response.
- Không bỏ qua kiểm tra `hasReturnCodeError()` và `errorCode`.

## 14. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `gamePlayer` / `gamePlayer.server` / `gamePlayer.admin` chưa.
- Nếu đang ở `server/admin`, đã truyền `userId` cho flow self-target chưa.
- Nếu đang ở `client`, có thật sự muốn target current authenticated game player không.
- Nếu method yêu cầu `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc relation nhẹ, có cần API chuyên biệt để lấy full metadata không.
- Nếu đang làm friend/group realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang tạo player/item/group/character và cần id mới, đã chuẩn bị bước re-query chưa.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
