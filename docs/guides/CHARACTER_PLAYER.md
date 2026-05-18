# CharacterPlayerApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng HTTP operation với realtime event socket, và không sinh sai request ở các nhóm `characterId`, `owner/removeStatus`, friend/group lifecycle, leaderboard bạn bè và relation item nhẹ.

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

### Đọc 1 character hoặc 1 phần metadata

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar | `characterId` | `CharacterPlayerResponseData` | `avatar.type` hiện là số thô | `Ok`, `CharacterPlayerNotFound` |
| `getCatalogIdAsync` | Cần đọc `catalogId` của character | `characterId` | `CharacterPlayerResponseData` | Kết quả ở `infoResponseParameters.catalogId` | `Ok`, `CharacterPlayerNotFound` |
| `getCountryCodeAsync` | Cần đọc quốc gia | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getCustomDataAsync` | Cần đọc custom data | `characterId`, `customDataKeys?` | `CharacterPlayerResponseData` | Có thể filter theo key | `Ok`, `CharacterPlayerNotFound` |
| `getDisplayNameAsync` | Cần đọc display name | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getIpAddressCreateAsync` | Cần đọc IP lúc tạo character | `characterId` | `CharacterPlayerResponseData` | Trường này thường nhạy cảm, ưu tiên backend/admin | `Ok`, `CharacterPlayerNotFound` |
| `getOwnerAsync` | Cần đọc owner hiện tại | `characterId` | `CharacterPlayerResponseData` | Map `owner.type` bằng `OwnerType` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerBanAsync` | Cần đọc trạng thái ban | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerCurrencyAsync` | Cần đọc currency | `characterId`, `playerCurrencyKeys?` | `CharacterPlayerResponseData` | Không dùng `infoRequestParam` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerDataAsync` | Cần đọc player data | `characterId`, `playerDataKeys?` | `CharacterPlayerResponseData` | Không dùng `infoRequestParam` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerFriendAsync` | Cần đọc relation friend ở cấp character | `characterId`, `friendCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `friendId`, `catalogId`, `status`, `tsLastStatusUpdate` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerGroupAsync` | Cần đọc relation group của character | `characterId`, `groupCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `groupId`, `catalogId`, `status`, `tsLastStatusUpdate` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerInformationAsync` | Cần lấy snapshot tổng hợp của character | `characterId`, `infoRequestParam` | `CharacterPlayerResponseData` | Flow đọc tổng hợp quan trọng nhất | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerInventoryAsync` | Cần đọc relation inventory của character | `characterId`, `itemCatalogIds?` | `CharacterPlayerResponseData` | Mỗi phần tử chỉ có `itemId`, `catalogId`, `classId` | `Ok`, `CharacterPlayerNotFound` |
| `getPlayerStatisticsAsync` | Cần đọc statistics theo key | `characterId`, `statisticsKeys?` | `CharacterPlayerResponseData` | Không dùng `playerStatisticsKeys` ở đây | `Ok`, `CharacterPlayerNotFound` |
| `getRemoveStatusAsync` | Cần đọc trạng thái remove | `characterId` | `CharacterPlayerResponseData` | Kết quả ở `infoResponseParameters.removeStatus` | `Ok`, `CharacterPlayerNotFound` |
| `getSegmentAsync` | Cần đọc segment | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getTagAsync` | Cần đọc tag theo key | `characterId`, `tagKeys` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getTsCreateAsync` | Cần đọc thời điểm tạo character | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |
| `getTsLastLoginAsync` | Cần đọc lần login gần nhất | `characterId` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound` |

### Search, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `getPlayersWithDisplayNameAsync` | Tìm character theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` | Kết quả trả `characterId` | `Ok` |
| `getPlayersWithSegmentAsync` | Tìm character theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` | | `Ok` |
| `getPlayersWithTagAsync` | Tìm character theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `CharacterPlayersWithCharacterIdResponseData` | | `Ok`, `KeyNotFound` |
| `getFriendStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng quanh một character trong mạng bạn bè của character đó | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Không phải global leaderboard | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound` |
| `getFriendStatisticsLeaderboardAsync` | Cần bảng xếp hạng friend-only theo key | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Scope là bạn bè của character target | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound` |
| `getStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng toàn cục quanh một character | `characterId`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | Có thể filter theo `catalogId` | `Ok`, `KeyNotFound` |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?`, `catalogId?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này | `Ok`, `KeyNotFound`, `VersionInvalid` |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `catalogId?` | `GetCurrencyLeaderboardResponseData` | Có thể filter theo `catalogId` | `Ok`, `KeyNotFound` |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo character | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần `key` | `Ok` |
| `getLastLoginLeaderboardAsync` | Cần bảng xếp hạng theo lần login gần nhất | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetLastLoginLeaderboardResponseData` | Không cần `key` | `Ok` |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `characterId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` | `Ok` |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `characterId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | Phân trang bằng `token` | `Ok` |

### Friend, group, item lifecycle và mutation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | ErrorCode |
| --- | --- | --- | --- | --- | --- |
| `addPlayerFriendAsync` | Thêm một quan hệ friend ở cấp character | `characterId`, `friendId`, `catalogId` | `EmptyResponseData` | `friendId` là id ở cấp character | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `PlayerBan` |
| `removePlayerFriendAsync` | Gỡ một quan hệ friend | `characterId`, `friendId` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `createGroupAsync` | Tạo group từ góc nhìn character | `characterId`, `catalogId`, `groupMembers?`, `displayName?` | `CharacterPlayerResponseData` | `groupMembers[]` dùng `userId`, không dùng `characterId` | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `PlayerBan` |
| `joinGroupAsync` | Cho character join vào group đã tồn tại | `characterId`, `groupId` | `EmptyResponseData` | Flow lifecycle ở phía character | `Ok`, `CharacterPlayerNotFound`, `GroupNotFound`, `PlayerBan` |
| `leaveGroupAsync` | Cho character rời khỏi group | `characterId`, `groupId` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `GroupNotFound`, `PlayerBan` |
| `createPlayerItemAsync` | Tạo item mới cho character | `characterId`, `catalogId`, `classId`, `displayName?`, `amount?` | `CharacterPlayerResponseData` | Không có contract riêng cho `itemId` mới tạo | `Ok`, `CharacterPlayerNotFound`, `CatalogIdNotFound`, `ClassIdNotFound`, `PlayerBan` |
| `removePlayerItemAsync` | Xóa item khỏi character theo `itemId` | `characterId`, `itemId` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `ItemNotFound`, `PlayerBan` |
| `addSegmentAsync` | Gắn thêm segment | `characterId`, `value` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `removeSegmentAsync` | Gỡ segment | `characterId`, `value` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `setTagAsync` | Set hoặc upsert tag | `characterId`, `key`, `value` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound`, `PlayerBan` |
| `removeTagAsync` | Xóa tag theo key | `characterId`, `key` | `EmptyResponseData` | Không truyền `value` | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `setAvatarAsync` | Set avatar | `characterId`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `setCountryCodeAsync` | Set country code | `characterId`, `countryCode` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `setCustomDataAsync` | Set custom data theo nhiều key | `characterId`, `customDatas[]` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound`, `PlayerBan` |
| `setDisplayNameAsync` | Set display name | `characterId`, `displayName`, `uniqueDisplayName?` | `EmptyResponseData` | Có option ép unique | `Ok`, `CharacterPlayerNotFound`, `DisplayNameUsed`, `PlayerBan` |
| `setOwnerAsync` | Chuyển owner của character | `characterId`, `newOwnerId` | `EmptyResponseData` | Public contract không có `newOwnerType` | `Ok`, `CharacterPlayerNotFound`, `OwnerNotFound`, `GamePlayerNotFound`, `PlayerBan` |
| `setPlayerBanAsync` | Ban character đến thời điểm cụ thể | `characterId`, `tsExpire`, `reason` | `EmptyResponseData` | | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |
| `changePlayerCurrencyAsync` | Cộng/trừ currency | `characterId`, `playerCurrencies[]`, `log?` | `CharacterPlayerResponseData` | Đây là delta change | `Ok`, `CharacterPlayerNotFound`, `NotEnoughCurrency`, `KeyNotFound`, `PlayerBan` |
| `setPlayerDataAsync` | Set player data theo nhiều key | `characterId`, `playerDatas[]` | `CharacterPlayerResponseData` | | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound`, `PlayerBan` |
| `changePlayerStatisticsAsync` | Cộng/trừ statistics | `characterId`, `playerStatistics[]`, `log?` | `CharacterPlayerResponseData` | Đây là delta change | `Ok`, `CharacterPlayerNotFound`, `KeyNotFound`, `PlayerBan` |
| `setRemoveStatusAsync` | Đánh dấu character bị remove | `characterId`, `reason?` | `EmptyResponseData` | Soft remove, không phải hard delete | `Ok`, `CharacterPlayerNotFound`, `PlayerBan` |

## 6. Enum Và Reference

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

## 7. InfoRequestParam Rules

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

## 8. Decision Rules

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

## 9. Response Rules

Tất cả typed response của `CharacterPlayerApi` đều có:

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

- Hầu hết getter đơn lẻ trả `CharacterPlayerResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` trả `CharacterPlayersWithCharacterIdResponseData`, mỗi phần tử có `characterId` và `infoResponseParameters`.
- `getFriendStatisticsLeaderboard*Async` và `getStatisticsLeaderboard*Async` trả `GetStatisticsLeaderboardResponseData`.
- `getStatisticsLeaderboardAsync` còn có thêm `responseData.tsCreate`.
- `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync`, `getLastLoginLeaderboardAsync` trả `results` theo leaderboard shape.
- `getStatisticsLogAsync` và `getCurrencyLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `addPlayerFriendAsync`, `addSegmentAsync`, `joinGroupAsync`, `leaveGroupAsync`, `removePlayerFriendAsync`, `removePlayerItemAsync`, `removeSegmentAsync`, `removeTagAsync`, `setAvatarAsync`, `setCountryCodeAsync`, `setDisplayNameAsync`, `setOwnerAsync`, `setPlayerBanAsync`, `setRemoveStatusAsync`, `setTagAsync` trả `EmptyResponseData`.
- `createGroupAsync`, `createPlayerItemAsync`, `setCustomDataAsync`, `changePlayerCurrencyAsync`, `setPlayerDataAsync`, `changePlayerStatisticsAsync` trả `CharacterPlayerResponseData`.

## 10. Cảnh Báo Implementation Hiện Tại

- `CharacterPlayerModels.InfoRequestParam` hiện có field `characterCatalogIds`, nhưng public response của `CharacterPlayerApi` không có `playerCharacters`.
- Theo public contract hiện tại, AI không nên dùng field này trừ khi có spec backend riêng xác nhận ý nghĩa của nó.
- `createGroupAsync` và `createPlayerItemAsync` hiện không có response field public riêng cho id vừa tạo.
- Nếu flow sau đó cần `groupId` hoặc `itemId`, bạn phải re-query hoặc verify backend contract riêng.
- `setOwnerAsync` chỉ có `newOwnerId`; public SDK không cho chọn `newOwnerType`.
- Nếu flow phụ thuộc loại owner mới, bạn phải xác minh backend rule riêng thay vì tự suy diễn.
- `playerInventories`, `playerGroups`, `playerFriends` chỉ là relation item nhẹ, không phải full metadata entity.
- `CharacterPlayerApi` không có public method tạo character mới hoặc hard-delete character.
- `setRemoveStatusAsync` là soft-remove marker; nếu cần hard delete thật, bạn phải dùng contract khác ngoài public surface hiện tại.
- `avatar.type` vẫn là số thô, chưa có enum public tương ứng.

## 11. Best Practices

- Luôn giữ `characterId` ở biến riêng, đừng trộn với `userId`, `friendId`, `groupId`, `itemId`.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Với relation item từ `CharacterPlayerApi`, chỉ dùng nó như index nhẹ để lấy id và trạng thái; đừng coi đó là full entity snapshot.
- Với friend/group UI, đọc initial state bằng getter HTTP rồi nghe realtime update bằng socket event handler.
- Với `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với `setOwnerAsync`, nếu flow cần xác nhận owner sau mutation, hãy đọc lại bằng `getOwnerAsync`.
- Với create flow, chuẩn bị sẵn bước re-fetch nếu bạn cần id mới tạo hoặc metadata chi tiết.

## 12. Ví Dụ Khuyến Nghị

### Đọc thông tin character với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new CharacterPlayerModels.InfoRequestParam();
infoRequestParam.catalogId = true;
infoRequestParam.displayName = true;
infoRequestParam.owner = true;
infoRequestParam.playerInventories = true;
infoRequestParam.itemCatalogIds = new[] { "weapon" };

var requestData = new CharacterPlayerModels.GetPlayerInformationRequestData();
requestData.characterId = "CHAR0000001";
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.characterPlayer.getPlayerInformationAsync(requestData);

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}

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

if (response.hasReturnCodeError()) {
    throw new System.Exception(response.debugMessage);
}

if (response.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + response.errorCode);
}
```

### Tạo item cho character rồi re-query relation item

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var createRequestData = new CharacterPlayerModels.CreatePlayerItemRequestData();
createRequestData.characterId = "CHAR0000001";
createRequestData.catalogId = "weapon";
createRequestData.classId = "sword";
createRequestData.displayName = "Starter Sword";
createRequestData.amount = 1;

var createResponse = await GNNetwork.characterPlayer.createPlayerItemAsync(createRequestData);

if (createResponse.hasReturnCodeError()) {
    throw new System.Exception(createResponse.debugMessage);
}

if (createResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + createResponse.errorCode);
}

var getInventoryRequestData = new CharacterPlayerModels.GetPlayerInventoryRequestData();
getInventoryRequestData.characterId = "CHAR0000001";
getInventoryRequestData.itemCatalogIds = new[] { "weapon" };

var inventoryResponse = await GNNetwork.characterPlayer.getPlayerInventoryAsync(getInventoryRequestData);

if (inventoryResponse.hasReturnCodeError()) {
    throw new System.Exception(inventoryResponse.debugMessage);
}

if (inventoryResponse.errorCode != ErrorCode.Ok) {
    throw new System.Exception("Business error: " + inventoryResponse.errorCode);
}

var inventoryRelations = inventoryResponse.responseData.infoResponseParameters.playerInventories;
```

## 13. Anti-Patterns

- Không bỏ `characterId` ở các method target một character cụ thể.
- Không dùng `CharacterPlayerApi` để tạo character mới.
- Không dùng `userId` thay cho `characterId` hoặc `friendId` trong các flow character-level.
- Không gửi `characterId` trong `groupMembers[]` của `createGroupAsync`; field này dùng `userId`.
- Không tự thêm `newOwnerType` vào `setOwnerAsync`.
- Không dùng `CharacterPlayerApi` relation item như thể đó là full entity snapshot.
- Không giả định `createGroupAsync` hoặc `createPlayerItemAsync` luôn trả id mới tạo trong response.
- Không dùng `skip` để phân trang log.
- Không giả định socket event tự chứa full metadata hoặc thông tin ngoài `characterId` và mảng relation.
- Không bỏ qua kiểm tra `hasReturnCodeError()` và `errorCode`.

## 14. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `characterPlayer` / `characterPlayer.server` / `characterPlayer.admin` chưa.
- Có truyền `characterId` cho flow target một character cụ thể chưa.
- Nếu flow là create character, có đang dùng nhầm `CharacterPlayerApi` không.
- Nếu method yêu cầu `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc relation nhẹ, có cần API chuyên biệt để lấy full metadata không.
- Nếu đang làm friend/group realtime, đã tuân theo [rule socket chuẩn trong RULES](/docs/RULES.md#7-auth--socket-flow) chưa.
- Nếu đang dùng `setOwnerAsync`, có tránh tự thêm `newOwnerType` không.
- Nếu đang tạo item hoặc group và cần id mới, đã chuẩn bị bước re-query chưa.
- Có kiểm tra `hasReturnCodeError()` trước `errorCode` chưa.
