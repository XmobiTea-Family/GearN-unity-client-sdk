# MasterPlayerApi

Tài liệu này dành cho AI code assistant và AI agent nội bộ. Mục tiêu là chọn đúng namespace `client/server/admin`, phân biệt đúng flow hồ sơ với flow link identity, và không sinh sai request ở các nhóm `infoRequestParam`, leaderboard, log, push notification và socket operation event.

## 1. Scope

- Áp dụng cho:
    - `GNNetwork.masterPlayer`
    - `GNNetwork.masterPlayer.server`
    - `GNNetwork.masterPlayer.admin`
- Toàn bộ method hiện tại của `MasterPlayerApi` đều gửi qua HTTP.
- `MasterPlayerApi` có đủ 3 role thật:
    - `GNNetwork.masterPlayer` -> `RequestRole.Client`
    - `GNNetwork.masterPlayer.server` -> `RequestRole.Server`
    - `GNNetwork.masterPlayer.admin` -> `RequestRole.Admin`
- Nếu không truyền `overrideSecretKey`, SDK sẽ tự lấy secret key theo role tương ứng.
- Chỉ dùng namespace `.server` khi bạn đã cấu hình `secretKey` với `permission rules` `server` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Chỉ dùng namespace `.admin` khi bạn đã cấu hình `secretKey` với `permission rules` `admin` hợp lệ trong `GNServerSettings`, hoặc chủ động truyền `overrideSecretKey`.
- Rule chuẩn để chọn `client/server/admin` và hiểu `self/other-self` xem [RULES](/docs/RULES.md#3-route--trust-boundary-của-caller). Không tự suy diễn route chỉ từ target ownership.
- Với hầu hết flow thao tác trên một player cụ thể:
    - `client` cho phép `userId?`
    - `server/admin` bắt buộc `userId`
- Rule thực tế:
    - ở `client`, bỏ `userId` sẽ target master player hiện đang auth
    - ở `server/admin`, phải truyền `userId` rõ ràng cho target player
- `MasterPlayerApi` là nhóm account/profile/identity của master player. Không dùng nhóm này để thao tác game player, character player, group, inventory item hoặc matchmaking.
- Public package hiện không export event handler socket riêng cho `MasterPlayerApi`.

## 2. Hard Rules

- Luôn ưu tiên `async/await`. Mặc định dùng `*Async()`.
- Bắt buộc đã `Resources/GNServerSettings` trước khi gọi.
- Không dùng socket transport cho các method của `MasterPlayerApi`.
- Chọn namespace theo trust boundary:
    - app/player -> `GNNetwork.masterPlayer`
    - trusted backend/service -> `GNNetwork.masterPlayer.server`
    - dashboard/ops/tooling -> `GNNetwork.masterPlayer.admin`
- Với `client`, chỉ nên bỏ `userId` khi thao tác trên master player hiện tại.
- Với `server/admin`, mọi flow self-target có `userId` đều phải truyền giá trị này rõ ràng.
- `getPlayerInformationAsync`, toàn bộ `getPlayersWith*Async`, `getStatisticsLeaderboardAroundPlayerAsync`, `getStatisticsLeaderboardAsync`, `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync` và `getLastLoginLeaderboardAsync` đều bắt buộc có `infoRequestParam`.
- `getPlayerCurrencyAsync` dùng `playerCurrencyKeys`, `getPlayerDataAsync` dùng `playerDataKeys`, `getPlayerStatisticsAsync` dùng `playerStatisticsKeys`.
- `InfoRequestParam` cũng có `playerCurrencyKeys`, `playerDataKeys`, `playerStatisticsKeys`, nhưng chỉ dùng để điều khiển payload của flow tổng hợp và search. Không được trộn lẫn mục đích giữa getter chuyên biệt và `infoRequestParam`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync` và `getPlayersWithTagAsync` phân trang bằng `skip/limit`.
- `getCurrencyLogAsync` và `getStatisticsLogAsync` phân trang bằng `token`, không dùng `skip`.
- `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync` là delta change, không phải set tuyệt đối.
- `changeAccountPasswordAsync` bắt buộc có `currentPassword`. `resetAccountPasswordAsync` không cần `currentPassword`.
- `updateTsLastLoginAsync` chỉ cập nhật dữ liệu last login, không làm mới auth token hoặc socket auth.
- `sendSocketOperationEventAsync` là HTTP wrapper để backend phát socket event tới player, không phải client-side socket send trực tiếp.
- `linkGoogleAsync` phải map `type` bằng `GoogleLoginType`.
- `addPushNotificationAsync` phải map `platformType` bằng `PushPlatformType`.
- `SetAvatarRequestData.type` hiện là số thô; package không export enum avatar public tương ứng.

## 3. Chọn Namespace

<!-- prettier-ignore -->
| Namespace | Role thật | `userId` behavior | Dùng khi nào |
| --- | --- | --- | --- |
| `GNNetwork.masterPlayer` | `Client` | Có thể bỏ `userId` để target player hiện tại | player app thao tác trên account/profile của chính user hiện tại |
| `GNNetwork.masterPlayer.server` | `Server` | Phải truyền `userId` ở các flow self-target | trusted backend, game server, worker xử lý account/profile |
| `GNNetwork.masterPlayer.admin` | `Admin` | Phải truyền `userId` ở các flow self-target | GM tool, dashboard, migration, vận hành dữ liệu player |

Rule nhanh:

- Logic chạy trong app public: ưu tiên `GNNetwork.masterPlayer`.
- Logic chạy trong backend tin cậy: ưu tiên `GNNetwork.masterPlayer.server`.
- Logic quản trị hoặc vận hành dữ liệu: ưu tiên `GNNetwork.masterPlayer.admin`.
- Không chọn `client` chỉ vì code ngắn hơn nếu operation thuộc trust boundary của backend.

## 4. Chọn Method

Đọc bảng này trước. Cột API contract rows trỏ thẳng đến row cần đọc trong `API_MASTER_PLAYER.md`; không cần mở full file API.

> Khi thấy [client:16-16](/docs/example.md) nghĩa là chỉ cần đọc đúng từ dòng 16 đến 16 (hoặc gọi chính xác là đọc đúng dòng 16) của tài liệu `/docs/example.md`, tương tự với những cái khác, ví dụ [client:12-15] nghĩa là đọc đúng từ dòng 12 đến 15 của tài liệu, nếu có tool đọc từ startLine đến endLine ưu tiên cái này thay vì mở toàn bộ file.

> Thứ tự columns `API contract rows` của `client` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp | Permission Rules khi truyền userId khác với masterPlayer đang authenticated |`, `server` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`, `admin` là: `| Method | Request Data DTO Link | Response Data DTO Link | Default Permission Rules | Error Code có thể gặp |`.

### Đọc 1 master player hoặc 1 phần hồ sơ

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | API contract rows |
| --- | --- | --- | --- | --- | --- |
| `getAvatarAsync` | Cần đọc avatar | `userId?` | `MasterPlayerResponseData` | `avatar.type` hiện là số thô | [client:18-18](/docs/reference/API_MASTER_PLAYER.md) / [server:110-110](/docs/reference/API_MASTER_PLAYER.md) / [admin:202-202](/docs/reference/API_MASTER_PLAYER.md) |
| `getCountryCodeAsync` | Cần đọc quốc gia | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.countryCode` | [client:19-19](/docs/reference/API_MASTER_PLAYER.md) / [server:111-111](/docs/reference/API_MASTER_PLAYER.md) / [admin:203-203](/docs/reference/API_MASTER_PLAYER.md) |
| `getCustomDataAsync` | Cần đọc custom data | `userId?`, `customDataKeys?` | `MasterPlayerResponseData` | Có thể filter theo key | [client:20-20](/docs/reference/API_MASTER_PLAYER.md) / [server:112-112](/docs/reference/API_MASTER_PLAYER.md) / [admin:204-204](/docs/reference/API_MASTER_PLAYER.md) |
| `getDisplayNameAsync` | Cần đọc display name | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.displayName` | [client:21-21](/docs/reference/API_MASTER_PLAYER.md) / [server:113-113](/docs/reference/API_MASTER_PLAYER.md) / [admin:205-205](/docs/reference/API_MASTER_PLAYER.md) |
| `getEmailAsync` | Cần đọc email | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.email` | [client:22-22](/docs/reference/API_MASTER_PLAYER.md) / [server:114-114](/docs/reference/API_MASTER_PLAYER.md) / [admin:206-206](/docs/reference/API_MASTER_PLAYER.md) |
| `getExternalAsync` | Cần đọc toàn bộ external identity đã link | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.external` | [client:23-23](/docs/reference/API_MASTER_PLAYER.md) / [server:115-115](/docs/reference/API_MASTER_PLAYER.md) / [admin:207-207](/docs/reference/API_MASTER_PLAYER.md) |
| `getIpAddressCreateAsync` | Cần đọc IP lúc tạo account | `userId?` | `MasterPlayerResponseData` | Trường này thường nhạy cảm, ưu tiên backend/admin | [client:24-24](/docs/reference/API_MASTER_PLAYER.md) / [server:116-116](/docs/reference/API_MASTER_PLAYER.md) / [admin:208-208](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayerBanAsync` | Cần đọc trạng thái ban | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.playerBan` | [client:25-25](/docs/reference/API_MASTER_PLAYER.md) / [server:117-117](/docs/reference/API_MASTER_PLAYER.md) / [admin:209-209](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayerCurrencyAsync` | Cần đọc player currencies | `userId?`, `playerCurrencyKeys?` | `MasterPlayerResponseData` | Không dùng `infoRequestParam` | [client:26-26](/docs/reference/API_MASTER_PLAYER.md) / [server:118-118](/docs/reference/API_MASTER_PLAYER.md) / [admin:210-210](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayerDataAsync` | Cần đọc player data | `userId?`, `playerDataKeys?` | `MasterPlayerResponseData` | Không dùng `infoRequestParam` | [client:27-27](/docs/reference/API_MASTER_PLAYER.md) / [server:119-119](/docs/reference/API_MASTER_PLAYER.md) / [admin:211-211](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayerInformationAsync` | Cần lấy nhiều field hồ sơ trong một lần gọi | `userId?`, `infoRequestParam` | `MasterPlayerResponseData` | Flow đọc tổng hợp quan trọng nhất | [client:28-28](/docs/reference/API_MASTER_PLAYER.md) / [server:120-120](/docs/reference/API_MASTER_PLAYER.md) / [admin:212-212](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayerStatisticsAsync` | Cần đọc statistics theo key | `userId?`, `playerStatisticsKeys?` | `MasterPlayerResponseData` | Không dùng `infoRequestParam` | [client:29-29](/docs/reference/API_MASTER_PLAYER.md) / [server:121-121](/docs/reference/API_MASTER_PLAYER.md) / [admin:213-213](/docs/reference/API_MASTER_PLAYER.md) |
| `getSegmentAsync` | Cần đọc segment | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.segments` | [client:39-39](/docs/reference/API_MASTER_PLAYER.md) / [server:131-131](/docs/reference/API_MASTER_PLAYER.md) / [admin:223-223](/docs/reference/API_MASTER_PLAYER.md) |
| `getTagAsync` | Cần đọc tag theo key | `userId?`, `tagKeys` | `MasterPlayerResponseData` | Không query theo value | [client:42-42](/docs/reference/API_MASTER_PLAYER.md) / [server:134-134](/docs/reference/API_MASTER_PLAYER.md) / [admin:226-226](/docs/reference/API_MASTER_PLAYER.md) |
| `getTsCreateAsync` | Cần đọc thời điểm tạo account | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.tsCreate` | [client:43-43](/docs/reference/API_MASTER_PLAYER.md) / [server:135-135](/docs/reference/API_MASTER_PLAYER.md) / [admin:227-227](/docs/reference/API_MASTER_PLAYER.md) |
| `getTsLastLoginAsync` | Cần đọc lần login gần nhất | `userId?` | `MasterPlayerResponseData` | Kết quả ở `infoResponseParameters.tsLastLogin` | [client:44-44](/docs/reference/API_MASTER_PLAYER.md) / [server:136-136](/docs/reference/API_MASTER_PLAYER.md) / [admin:228-228](/docs/reference/API_MASTER_PLAYER.md) |
| `getPushNotificationAsync` | Cần đọc danh sách push token đã đăng ký | `userId?` | `MasterPlayerResponseData` | Dữ liệu nằm ở `infoResponseParameters.pushNotifications`, không phải `results` | [client:100-100](/docs/reference/API_MASTER_PLAYER.md) / [server:192-192](/docs/reference/API_MASTER_PLAYER.md) / [admin:284-284](/docs/reference/API_MASTER_PLAYER.md) |
| `getOnlineStatusAsync` | Cần biết trạng thái socket hiện tại | `userId?` | `MasterPlayerResponseData` | Dữ liệu nằm ở `infoResponseParameters.onlineStatus`, không phải `results` | [client:102-102](/docs/reference/API_MASTER_PLAYER.md) / [server:194-194](/docs/reference/API_MASTER_PLAYER.md) / [admin:286-286](/docs/reference/API_MASTER_PLAYER.md) |

### Search player, leaderboard và log

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | API contract rows |
| --- | --- | --- | --- | --- | --- |
| `getPlayersWithAppleAsync` | Tìm player theo `appleId` | `appleIds[]`, `infoRequestParam` | `GetPlayersWithAppleResponseData` | Mỗi phần tử trả `appleId`, `userId`, `infoResponseParameters` | [client:30-30](/docs/reference/API_MASTER_PLAYER.md) / [server:122-122](/docs/reference/API_MASTER_PLAYER.md) / [admin:214-214](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithFacebookAsync` | Tìm player theo `facebookId` | `facebookIds[]`, `infoRequestParam` | `GetPlayersWithFacebookResponseData` | Không dùng cho Google | [client:32-32](/docs/reference/API_MASTER_PLAYER.md) / [server:124-124](/docs/reference/API_MASTER_PLAYER.md) / [admin:216-216](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithGenericServiceAsync` | Tìm player theo external service tự định nghĩa | `serviceName`, `genericIds[]`, `infoRequestParam` | `GetPlayersWithGenericServiceResponseData` | Dùng khi backend quản external provider riêng | [client:33-33](/docs/reference/API_MASTER_PLAYER.md) / [server:125-125](/docs/reference/API_MASTER_PLAYER.md) / [admin:217-217](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithGoogleAsync` | Tìm player theo `googleId` | `googleIds[]`, `infoRequestParam` | `GetPlayersWithGoogleResponseData` | Không dùng cho Google Play Games | [client:34-34](/docs/reference/API_MASTER_PLAYER.md) / [server:126-126](/docs/reference/API_MASTER_PLAYER.md) / [admin:218-218](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithGooglePlayGameServiceAsync` | Tìm player theo Google Play Games `playerId` | `playerIds[]`, `infoRequestParam` | `GetPlayersWithGooglePlayGameServiceResponseData` | Khác với Google account thường | [client:35-35](/docs/reference/API_MASTER_PLAYER.md) / [server:127-127](/docs/reference/API_MASTER_PLAYER.md) / [admin:219-219](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithGameCenterAsync` | Tìm player theo Game Center `playerId` | `playerIds[]`, `infoRequestParam` | `GetPlayersWithGameCenterResponseData` | Chỉ dành cho Apple Game Center | [client:36-36](/docs/reference/API_MASTER_PLAYER.md) / [server:128-128](/docs/reference/API_MASTER_PLAYER.md) / [admin:220-220](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithDisplayNameAsync` | Tìm player theo tên hiển thị | `keyword`, `infoRequestParam`, `skip?`, `limit?` | `MasterPlayersWithUserIdResponseData` | Phân trang bằng `skip/limit` | [client:31-31](/docs/reference/API_MASTER_PLAYER.md) / [server:123-123](/docs/reference/API_MASTER_PLAYER.md) / [admin:215-215](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithSegmentAsync` | Tìm player theo segment | `value`, `infoRequestParam`, `skip?`, `limit?` | `MasterPlayersWithUserIdResponseData` | Query theo exact segment value | [client:37-37](/docs/reference/API_MASTER_PLAYER.md) / [server:129-129](/docs/reference/API_MASTER_PLAYER.md) / [admin:221-221](/docs/reference/API_MASTER_PLAYER.md) |
| `getPlayersWithTagAsync` | Tìm player theo tag | `key`, `value`, `infoRequestParam`, `skip?`, `limit?` | `MasterPlayersWithUserIdResponseData` | Query theo cặp `key/value` | [client:38-38](/docs/reference/API_MASTER_PLAYER.md) / [server:130-130](/docs/reference/API_MASTER_PLAYER.md) / [admin:222-222](/docs/reference/API_MASTER_PLAYER.md) |
| `getStatisticsLeaderboardAroundPlayerAsync` | Cần bảng xếp hạng quanh một player cụ thể | `userId?`, `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetStatisticsLeaderboardResponseData` | Ở `server/admin` phải truyền `userId` | [client:40-40](/docs/reference/API_MASTER_PLAYER.md) / [server:132-132](/docs/reference/API_MASTER_PLAYER.md) / [admin:224-224](/docs/reference/API_MASTER_PLAYER.md) |
| `getStatisticsLeaderboardAsync` | Cần bảng xếp hạng statistics toàn cục theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?`, `version?` | `GetStatisticsLeaderboardResponseData` | `version` chỉ có ở method này | [client:41-41](/docs/reference/API_MASTER_PLAYER.md) / [server:133-133](/docs/reference/API_MASTER_PLAYER.md) / [admin:225-225](/docs/reference/API_MASTER_PLAYER.md) |
| `getCurrencyLeaderboardAsync` | Cần bảng xếp hạng currency theo key | `key`, `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCurrencyLeaderboardResponseData` | Không có `version` | [client:91-91](/docs/reference/API_MASTER_PLAYER.md) / [server:183-183](/docs/reference/API_MASTER_PLAYER.md) / [admin:275-275](/docs/reference/API_MASTER_PLAYER.md) |
| `getCreateLeaderboardAsync` | Cần bảng xếp hạng theo thời điểm tạo account | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetCreateLeaderboardResponseData` | Không cần `key` | [client:92-92](/docs/reference/API_MASTER_PLAYER.md) / [server:184-184](/docs/reference/API_MASTER_PLAYER.md) / [admin:276-276](/docs/reference/API_MASTER_PLAYER.md) |
| `getLastLoginLeaderboardAsync` | Cần bảng xếp hạng theo lần login gần nhất | `infoRequestParam`, `skip?`, `limit?`, `loadFromCache?` | `GetLastLoginLeaderboardResponseData` | Không cần `key` | [client:93-93](/docs/reference/API_MASTER_PLAYER.md) / [server:185-185](/docs/reference/API_MASTER_PLAYER.md) / [admin:277-277](/docs/reference/API_MASTER_PLAYER.md) |
| `getStatisticsLogAsync` | Cần audit statistics log | `keys?`, `userId?`, `limit?`, `token?` | `GetStatisticsLogResponseData` | Phân trang bằng `token` | [client:94-94](/docs/reference/API_MASTER_PLAYER.md) / [server:186-186](/docs/reference/API_MASTER_PLAYER.md) / [admin:278-278](/docs/reference/API_MASTER_PLAYER.md) |
| `getCurrencyLogAsync` | Cần audit currency log | `keys?`, `userId?`, `limit?`, `token?` | `GetCurrencyLogResponseData` | Phân trang bằng `token` | [client:95-95](/docs/reference/API_MASTER_PLAYER.md) / [server:187-187](/docs/reference/API_MASTER_PLAYER.md) / [admin:279-279](/docs/reference/API_MASTER_PLAYER.md) |

### Link và unlink identity

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | API contract rows |
| --- | --- | --- | --- | --- | --- |
| `linkAccountAsync` | Link account/password truyền thống | `userId?`, `username`, `password`, `forceLink?` | `MasterPlayerResponseData` | Dùng khi muốn gắn username/password vào player hiện tại | [client:45-45](/docs/reference/API_MASTER_PLAYER.md) / [server:137-137](/docs/reference/API_MASTER_PLAYER.md) / [admin:229-229](/docs/reference/API_MASTER_PLAYER.md) |
| `linkCustomIdAsync` | Link custom id của hệ thống riêng | `userId?`, `customId`, `forceLink?` | `MasterPlayerResponseData` | Không phải device id | [client:49-49](/docs/reference/API_MASTER_PLAYER.md) / [server:141-141](/docs/reference/API_MASTER_PLAYER.md) / [admin:233-233](/docs/reference/API_MASTER_PLAYER.md) |
| `linkAppleAsync` | Link Apple Sign-In | `userId?`, `token`, `forceLink?` | `MasterPlayerResponseData` | Token đến từ Apple login flow | [client:47-47](/docs/reference/API_MASTER_PLAYER.md) / [server:139-139](/docs/reference/API_MASTER_PLAYER.md) / [admin:231-231](/docs/reference/API_MASTER_PLAYER.md) |
| `linkFacebookAsync` | Link Facebook login | `userId?`, `token`, `forceLink?` | `MasterPlayerResponseData` | Không dùng cho Google | [client:51-51](/docs/reference/API_MASTER_PLAYER.md) / [server:143-143](/docs/reference/API_MASTER_PLAYER.md) / [admin:235-235](/docs/reference/API_MASTER_PLAYER.md) |
| `linkGoogleAsync` | Link Google account | `userId?`, `token`, `type`, `forceLink?` | `MasterPlayerResponseData` | `type` phải map bằng `GoogleLoginType` | [client:53-53](/docs/reference/API_MASTER_PLAYER.md) / [server:145-145](/docs/reference/API_MASTER_PLAYER.md) / [admin:237-237](/docs/reference/API_MASTER_PLAYER.md) |
| `linkGooglePlayGameServiceAsync` | Link Google Play Games | `userId?`, `token`, `forceLink?` | `MasterPlayerResponseData` | Khác với Google account thường | [client:54-54](/docs/reference/API_MASTER_PLAYER.md) / [server:146-146](/docs/reference/API_MASTER_PLAYER.md) / [admin:238-238](/docs/reference/API_MASTER_PLAYER.md) |
| `linkGameCenterAsync` | Link Game Center | `userId?`, `playerId`, `name`, `publicKeyUrl`, `signature`, `salt`, `timestamp`, `forceLink?` | `MasterPlayerResponseData` | Cần full verification bundle | [client:55-55](/docs/reference/API_MASTER_PLAYER.md) / [server:147-147](/docs/reference/API_MASTER_PLAYER.md) / [admin:239-239](/docs/reference/API_MASTER_PLAYER.md) |
| `linkGenericServiceAsync` | Link external provider tự định nghĩa | `userId?`, `serviceName`, `serviceData`, `forceLink?` | `GenericServiceMasterPlayerResponseData` | Có thể có `errorMessage` ở response | [client:52-52](/docs/reference/API_MASTER_PLAYER.md) / [server:144-144](/docs/reference/API_MASTER_PLAYER.md) / [admin:236-236](/docs/reference/API_MASTER_PLAYER.md) |
| `linkCustomDeviceIdAsync` | Link custom device id | `userId?`, `customDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:48-48](/docs/reference/API_MASTER_PLAYER.md) / [server:140-140](/docs/reference/API_MASTER_PLAYER.md) / [admin:232-232](/docs/reference/API_MASTER_PLAYER.md) |
| `linkAndroidDeviceIdAsync` | Link Android device id | `userId?`, `androidDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:46-46](/docs/reference/API_MASTER_PLAYER.md) / [server:138-138](/docs/reference/API_MASTER_PLAYER.md) / [admin:230-230](/docs/reference/API_MASTER_PLAYER.md) |
| `linkiOSDeviceIdAsync` | Link iOS device id | `userId?`, `iOSDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:56-56](/docs/reference/API_MASTER_PLAYER.md) / [server:148-148](/docs/reference/API_MASTER_PLAYER.md) / [admin:240-240](/docs/reference/API_MASTER_PLAYER.md) |
| `linkWindowsPhoneDeviceIdAsync` | Link Windows Phone device id | `userId?`, `windowsPhoneDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:60-60](/docs/reference/API_MASTER_PLAYER.md) / [server:152-152](/docs/reference/API_MASTER_PLAYER.md) / [admin:244-244](/docs/reference/API_MASTER_PLAYER.md) |
| `linkWindowsDeviceIdAsync` | Link Windows device id | `userId?`, `windowsDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:59-59](/docs/reference/API_MASTER_PLAYER.md) / [server:151-151](/docs/reference/API_MASTER_PLAYER.md) / [admin:243-243](/docs/reference/API_MASTER_PLAYER.md) |
| `linkLinuxDeviceIdAsync` | Link Linux device id | `userId?`, `linuxDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:57-57](/docs/reference/API_MASTER_PLAYER.md) / [server:149-149](/docs/reference/API_MASTER_PLAYER.md) / [admin:241-241](/docs/reference/API_MASTER_PLAYER.md) |
| `linkMacOSDeviceIdAsync` | Link macOS device id | `userId?`, `macOSDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Thuộc nhóm device | [client:58-58](/docs/reference/API_MASTER_PLAYER.md) / [server:150-150](/docs/reference/API_MASTER_PLAYER.md) / [admin:242-242](/docs/reference/API_MASTER_PLAYER.md) |
| `linkEditorDeviceIdAsync` | Link editor device id | `userId?`, `editorDeviceId`, `forceLink?` | `MasterPlayerResponseData` | Hữu ích cho dev/editor flow | [client:50-50](/docs/reference/API_MASTER_PLAYER.md) / [server:142-142](/docs/reference/API_MASTER_PLAYER.md) / [admin:234-234](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkAccountAsync` | Gỡ account/password đã link | `userId?`, `username` | `EmptyResponseData` | Không cần password ở flow unlink | [client:75-75](/docs/reference/API_MASTER_PLAYER.md) / [server:167-167](/docs/reference/API_MASTER_PLAYER.md) / [admin:259-259](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkCustomIdAsync` | Gỡ custom id | `userId?`, `customId` | `EmptyResponseData` |  | [client:79-79](/docs/reference/API_MASTER_PLAYER.md) / [server:171-171](/docs/reference/API_MASTER_PLAYER.md) / [admin:263-263](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkAppleAsync` | Gỡ Apple identity | `userId?`, `appleId` | `EmptyResponseData` |  | [client:77-77](/docs/reference/API_MASTER_PLAYER.md) / [server:169-169](/docs/reference/API_MASTER_PLAYER.md) / [admin:261-261](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkFacebookAsync` | Gỡ Facebook identity | `userId?`, `facebookId` | `EmptyResponseData` |  | [client:81-81](/docs/reference/API_MASTER_PLAYER.md) / [server:173-173](/docs/reference/API_MASTER_PLAYER.md) / [admin:265-265](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkGoogleAsync` | Gỡ Google identity | `userId?`, `googleId` | `EmptyResponseData` |  | [client:83-83](/docs/reference/API_MASTER_PLAYER.md) / [server:175-175](/docs/reference/API_MASTER_PLAYER.md) / [admin:267-267](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkGooglePlayGameServiceAsync` | Gỡ Google Play Games identity | `userId?`, `playerId` | `EmptyResponseData` |  | [client:84-84](/docs/reference/API_MASTER_PLAYER.md) / [server:176-176](/docs/reference/API_MASTER_PLAYER.md) / [admin:268-268](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkGameCenterAsync` | Gỡ Game Center identity | `userId?`, `playerId` | `EmptyResponseData` |  | [client:85-85](/docs/reference/API_MASTER_PLAYER.md) / [server:177-177](/docs/reference/API_MASTER_PLAYER.md) / [admin:269-269](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkGenericServiceAsync` | Gỡ external provider tự định nghĩa | `userId?`, `serviceName`, `serviceId` | `EmptyResponseData` | Cần đúng cặp `serviceName/serviceId` | [client:82-82](/docs/reference/API_MASTER_PLAYER.md) / [server:174-174](/docs/reference/API_MASTER_PLAYER.md) / [admin:266-266](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkCustomDeviceIdAsync` | Gỡ custom device id | `userId?`, `customDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:78-78](/docs/reference/API_MASTER_PLAYER.md) / [server:170-170](/docs/reference/API_MASTER_PLAYER.md) / [admin:262-262](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkAndroidDeviceIdAsync` | Gỡ Android device id | `userId?`, `androidDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:76-76](/docs/reference/API_MASTER_PLAYER.md) / [server:168-168](/docs/reference/API_MASTER_PLAYER.md) / [admin:260-260](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkiOSDeviceIdAsync` | Gỡ iOS device id | `userId?`, `iOSDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:86-86](/docs/reference/API_MASTER_PLAYER.md) / [server:178-178](/docs/reference/API_MASTER_PLAYER.md) / [admin:270-270](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkWindowsPhoneDeviceIdAsync` | Gỡ Windows Phone device id | `userId?`, `windowsPhoneDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:90-90](/docs/reference/API_MASTER_PLAYER.md) / [server:182-182](/docs/reference/API_MASTER_PLAYER.md) / [admin:274-274](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkWindowsDeviceIdAsync` | Gỡ Windows device id | `userId?`, `windowsDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:89-89](/docs/reference/API_MASTER_PLAYER.md) / [server:181-181](/docs/reference/API_MASTER_PLAYER.md) / [admin:273-273](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkLinuxDeviceIdAsync` | Gỡ Linux device id | `userId?`, `linuxDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:87-87](/docs/reference/API_MASTER_PLAYER.md) / [server:179-179](/docs/reference/API_MASTER_PLAYER.md) / [admin:271-271](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkMacOSDeviceIdAsync` | Gỡ macOS device id | `userId?`, `macOSDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:88-88](/docs/reference/API_MASTER_PLAYER.md) / [server:180-180](/docs/reference/API_MASTER_PLAYER.md) / [admin:272-272](/docs/reference/API_MASTER_PLAYER.md) |
| `unlinkEditorDeviceIdAsync` | Gỡ editor device id | `userId?`, `editorDeviceId` | `EmptyResponseData` | Thuộc nhóm device | [client:80-80](/docs/reference/API_MASTER_PLAYER.md) / [server:172-172](/docs/reference/API_MASTER_PLAYER.md) / [admin:264-264](/docs/reference/API_MASTER_PLAYER.md) |

### Mutation hồ sơ, account và outbound operation

<!-- prettier-ignore -->
| Method | Dùng khi nào | Cần truyền gì | Nhận được gì | Ghi chú | API contract rows |
| --- | --- | --- | --- | --- | --- |
| `addSegmentAsync` | Gắn thêm segment | `userId?`, `value` | `EmptyResponseData` | Thêm một segment value | [client:16-16](/docs/reference/API_MASTER_PLAYER.md) / [server:109-109](/docs/reference/API_MASTER_PLAYER.md) / [admin:201-201](/docs/reference/API_MASTER_PLAYER.md) |
| `removeSegmentAsync` | Gỡ segment | `userId?`, `value` | `EmptyResponseData` | Xóa theo exact value | [client:61-61](/docs/reference/API_MASTER_PLAYER.md) / [server:153-153](/docs/reference/API_MASTER_PLAYER.md) / [admin:245-245](/docs/reference/API_MASTER_PLAYER.md) |
| `setTagAsync` | Set hoặc upsert tag | `userId?`, `key`, `value` | `EmptyResponseData` |  | [client:73-73](/docs/reference/API_MASTER_PLAYER.md) / [server:165-165](/docs/reference/API_MASTER_PLAYER.md) / [admin:257-257](/docs/reference/API_MASTER_PLAYER.md) |
| `removeTagAsync` | Xóa tag theo key | `userId?`, `key` | `EmptyResponseData` | Không truyền `value` | [client:62-62](/docs/reference/API_MASTER_PLAYER.md) / [server:154-154](/docs/reference/API_MASTER_PLAYER.md) / [admin:246-246](/docs/reference/API_MASTER_PLAYER.md) |
| `setAvatarAsync` | Set avatar | `userId?`, `type`, `value` | `EmptyResponseData` | `type` chưa có enum public | [client:64-64](/docs/reference/API_MASTER_PLAYER.md) / [server:156-156](/docs/reference/API_MASTER_PLAYER.md) / [admin:248-248](/docs/reference/API_MASTER_PLAYER.md) |
| `setCountryCodeAsync` | Set country code | `userId?`, `countryCode` | `EmptyResponseData` |  | [client:65-65](/docs/reference/API_MASTER_PLAYER.md) / [server:157-157](/docs/reference/API_MASTER_PLAYER.md) / [admin:249-249](/docs/reference/API_MASTER_PLAYER.md) |
| `setCustomDataAsync` | Set custom data theo nhiều key | `userId?`, `customDatas[]` | `MasterPlayerResponseData` |  | [client:66-66](/docs/reference/API_MASTER_PLAYER.md) / [server:158-158](/docs/reference/API_MASTER_PLAYER.md) / [admin:250-250](/docs/reference/API_MASTER_PLAYER.md) |
| `setDisplayNameAsync` | Set display name | `userId?`, `displayName`, `uniqueDisplayName?` | `EmptyResponseData` | Có option ép unique | [client:67-67](/docs/reference/API_MASTER_PLAYER.md) / [server:159-159](/docs/reference/API_MASTER_PLAYER.md) / [admin:251-251](/docs/reference/API_MASTER_PLAYER.md) |
| `setEmailAsync` | Set email | `userId?`, `email` | `EmptyResponseData` |  | [client:68-68](/docs/reference/API_MASTER_PLAYER.md) / [server:160-160](/docs/reference/API_MASTER_PLAYER.md) / [admin:252-252](/docs/reference/API_MASTER_PLAYER.md) |
| `setPlayerBanAsync` | Ban player đến thời điểm cụ thể | `userId?`, `tsExpire`, `reason` | `EmptyResponseData` | Nên dùng ở backend/admin | [client:69-69](/docs/reference/API_MASTER_PLAYER.md) / [server:161-161](/docs/reference/API_MASTER_PLAYER.md) / [admin:253-253](/docs/reference/API_MASTER_PLAYER.md) |
| `changePlayerCurrencyAsync` | Cộng/trừ currency | `userId?`, `playerCurrencies[]`, `log?` | `MasterPlayerResponseData` | Đây là delta change | [client:70-70](/docs/reference/API_MASTER_PLAYER.md) / [server:162-162](/docs/reference/API_MASTER_PLAYER.md) / [admin:254-254](/docs/reference/API_MASTER_PLAYER.md) |
| `setPlayerDataAsync` | Set player data theo nhiều key | `userId?`, `playerDatas[]` | `MasterPlayerResponseData` |  | [client:71-71](/docs/reference/API_MASTER_PLAYER.md) / [server:163-163](/docs/reference/API_MASTER_PLAYER.md) / [admin:255-255](/docs/reference/API_MASTER_PLAYER.md) |
| `changePlayerStatisticsAsync` | Cộng/trừ statistics | `userId?`, `playerStatistics[]`, `log?` | `MasterPlayerResponseData` | Đây là delta change | [client:72-72](/docs/reference/API_MASTER_PLAYER.md) / [server:164-164](/docs/reference/API_MASTER_PLAYER.md) / [admin:256-256](/docs/reference/API_MASTER_PLAYER.md) |
| `updateTsLastLoginAsync` | Cập nhật timestamp last login | `userId?` | `EmptyResponseData` | Không refresh session | [client:74-74](/docs/reference/API_MASTER_PLAYER.md) / [server:166-166](/docs/reference/API_MASTER_PLAYER.md) / [admin:258-258](/docs/reference/API_MASTER_PLAYER.md) |
| `changeAccountPasswordAsync` | Đổi password có xác thực password cũ | `userId?`, `currentPassword`, `password` | `EmptyResponseData` | Flow an toàn hơn nếu user biết password hiện tại | [client:17-17](/docs/reference/API_MASTER_PLAYER.md) |
| `resetAccountPasswordAsync` | Reset password không cần password cũ | `userId?`, `password` | `EmptyResponseData` | Nên ưu tiên backend/admin | [client:63-63](/docs/reference/API_MASTER_PLAYER.md) / [server:155-155](/docs/reference/API_MASTER_PLAYER.md) / [admin:247-247](/docs/reference/API_MASTER_PLAYER.md) |
| `sendSocketOperationEventAsync` | Yêu cầu backend đẩy socket event tới player | `userId?`, `eventCode`, `eventParameters?` | `EmptyResponseData` | Bản thân method vẫn là HTTP | [client:96-96](/docs/reference/API_MASTER_PLAYER.md) / [server:188-188](/docs/reference/API_MASTER_PLAYER.md) / [admin:280-280](/docs/reference/API_MASTER_PLAYER.md) |
| `sendEmailAsync` | Gửi email tới player | `userId?`, `subject`, `contentHtml` | `EmptyResponseData` | Nên ưu tiên backend/admin | [client:97-97](/docs/reference/API_MASTER_PLAYER.md) / [server:189-189](/docs/reference/API_MASTER_PLAYER.md) / [admin:281-281](/docs/reference/API_MASTER_PLAYER.md) |
| `addPushNotificationAsync` | Đăng ký một push token mới | `userId?`, `token`, `platformType` | `AddPushNotificationResponseData` | `platformType` map bằng `PushPlatformType` | [client:98-98](/docs/reference/API_MASTER_PLAYER.md) / [server:190-190](/docs/reference/API_MASTER_PLAYER.md) / [admin:282-282](/docs/reference/API_MASTER_PLAYER.md) |
| `removePushNotificationAsync` | Xóa một push registration | `userId?`, `pushId` | `EmptyResponseData` | `pushId` lấy từ `addPushNotificationAsync` hoặc `getPushNotificationAsync` | [client:99-99](/docs/reference/API_MASTER_PLAYER.md) / [server:191-191](/docs/reference/API_MASTER_PLAYER.md) / [admin:283-283](/docs/reference/API_MASTER_PLAYER.md) |
| `sendPushNotificationAsync` | Gửi push notification tới player | `userId?`, `title`, `body`, `badge?`, `sound?`, `icon?`, `data?` | `SendPushNotificationResponseData` | Response có `message` | [client:101-101](/docs/reference/API_MASTER_PLAYER.md) / [server:193-193](/docs/reference/API_MASTER_PLAYER.md) / [admin:285-285](/docs/reference/API_MASTER_PLAYER.md) |

## 5. Method Signature

Mỗi method có 2 form: callback và `*Async()` Task. Mặc định sinh code bằng async form.

```csharp
// Callback
GNNetwork.masterPlayer.<method>(requestData, onResponse, overrideAuthToken, overrideSecretKey, customTags, timeout);

// Async
var response = await GNNetwork.masterPlayer.<method>Async(requestData, overrideAuthToken, overrideSecretKey, customTags, timeout);
```

Param chung:

<!-- prettier-ignore -->
| Param | Type | Khi nào cần |
| --- | --- | --- |
| `requestData` | domain-specific DTO | Payload chính; tạo bằng `new MasterPlayerModels.<Method>RequestData()` hoặc variant `Server*` / `Admin*` theo namespace |
| `onResponse` | `Action1<TResponse>` | Chỉ có ở callback form |
| `overrideAuthToken` | `string` | Impersonate / multi-session / request bằng auth token khác |
| `overrideSecretKey` | `string` | Override secret key mặc định của role cho một request |
| `customTags` | `GNHashtable` | Trace id, build version, A/B bucket; backend có thể log/route |
| `timeout` | `int` | Override timeout theo request, tính bằng giây |

Typed response expose public fields: `returnCode`, `errorCode`, `invalidMembers`, `debugMessage`, `responseData`. Xem [RULES.md response checking](/docs/RULES.md).

## 6. Request Field Rules

- DTO fields: [reference/dto/MASTER_PLAYER.md](/docs/reference/dto/MASTER_PLAYER.md). Method table: [reference/API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md).
- Enums: [GoogleLoginType](/docs/reference/ENUMS.md#googlelogintype), [PushPlatformType](/docs/reference/ENUMS.md#pushplatformtype).
- Error handling: [reference/ERROR_HANDLING.md](/docs/reference/ERROR_HANDLING.md).
- Permission rules: [reference/PERMISSION_RULES.md](/docs/reference/PERMISSION_RULES.md).
- Fallback `Runtime/` chỉ khi reference docs chưa đủ: `Runtime/Entity/Models/MasterPlayer*.cs`, `Runtime/Entity/Models/GenericModels.cs`.
- `LinkGoogleRequestData.type` nên map bằng `GoogleLoginType`.
- `AddPushNotificationRequestData.platformType` và `PushNotificationItem.platformType` nên map bằng `PushPlatformType`.
- `SetAvatarRequestData.type` và `InfoResponseParameters.avatar.type` hiện chưa có enum public tương ứng.

## 7. InfoRequestParam Rules

`MasterPlayerModels.InfoRequestParam` điều khiển payload trả về trong:

- `getPlayerInformationAsync`
- `getPlayersWithAppleAsync`
- `getPlayersWithFacebookAsync`
- `getPlayersWithGenericServiceAsync`
- `getPlayersWithGoogleAsync`
- `getPlayersWithGooglePlayGameServiceAsync`
- `getPlayersWithGameCenterAsync`
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
- Chỉ bật field mà màn hình hoặc flow hiện tại thật sự cần.
- Nếu cần filter dữ liệu con, dùng đúng field filter:
    - `playerDataKeys`
    - `playerCurrencyKeys`
    - `playerStatisticsKeys`
    - `customDataKeys`
    - `tagKeys`
- Nếu chỉ cần một field nhỏ như email, display name, player data hay statistics, ưu tiên getter chuyên biệt.

Các field thường dùng:

- `external`
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
- `email`
- `tsLastLogin`
- `pushNotifications`

## 8. Flow Và Decision Rules

- Cần đọc nhiều field profile trong một lần gọi: dùng `getPlayerInformationAsync`.
- Cần đọc đúng một field nhỏ: ưu tiên getter chuyên biệt như `getDisplayNameAsync`, `getEmailAsync`, `getPlayerDataAsync`.
- Cần tìm player theo external identity cụ thể: chọn đúng method theo provider, không được dùng lẫn Apple, Google, Google Play Games, Facebook, Game Center, Generic Service.
- Cần đọc leaderboard quanh một player cụ thể: dùng `getStatisticsLeaderboardAroundPlayerAsync`.
- Cần leaderboard statistics toàn cục: dùng `getStatisticsLeaderboardAsync`.
- Cần leaderboard theo currency: dùng `getCurrencyLeaderboardAsync`.
- Cần leaderboard theo thời điểm tạo account: dùng `getCreateLeaderboardAsync`.
- Cần leaderboard theo lần login gần nhất: dùng `getLastLoginLeaderboardAsync`.
- Cần link identity mới vào current player: dùng nhóm `link*Async`.
- Cần gỡ identity đã link: dùng nhóm `unlink*Async`.
- Cần đổi password khi user biết password hiện tại: dùng `changeAccountPasswordAsync`.
- Cần reset password từ backend/admin: dùng `resetAccountPasswordAsync`.
- Cần delta currency hoặc statistics: dùng `changePlayerCurrencyAsync` hoặc `changePlayerStatisticsAsync`.
- Cần push token registration: dùng `addPushNotificationAsync`.
- Cần lấy push token list hiện tại: dùng `getPushNotificationAsync`.
- Cần gửi dữ liệu realtime vào socket của player: dùng `sendSocketOperationEventAsync`, nhưng phải nhớ receiver cần có socket session hợp lệ.

## 9. Minimal Pattern

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new MasterPlayerModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.email = true;

var requestData = new MasterPlayerModels.GetPlayerInformationRequestData();
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.masterPlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

Nếu codebase đã có helper riêng như `hasReturnCodeError()` và muốn throw exception thay vì early-return, vẫn phải giữ thứ tự check 2 tầng: `returnCode` trước, `errorCode` sau.

Những response chính AI cần nhớ:

- Hầu hết getter đơn lẻ trả `MasterPlayerResponseData` và dữ liệu nằm trong `responseData.infoResponseParameters`.
- `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync` trả `responseData.results`, mỗi phần tử có `userId` và `infoResponseParameters`.
- `getPlayersWithAppleAsync`, `getPlayersWithFacebookAsync`, `getPlayersWithGoogleAsync`, `getPlayersWithGenericServiceAsync`, `getPlayersWithGooglePlayGameServiceAsync`, `getPlayersWithGameCenterAsync` trả `results` kèm identifier của provider.
- `getStatisticsLeaderboardAroundPlayerAsync`, `getStatisticsLeaderboardAsync`, `getCurrencyLeaderboardAsync`, `getCreateLeaderboardAsync`, `getLastLoginLeaderboardAsync` trả `responseData.results` với `userId`, `position`, `backupValue?`, `infoResponseParameters`.
- `getStatisticsLeaderboardAsync` còn có thêm `responseData.tsCreate`.
- `getStatisticsLogAsync` và `getCurrencyLogAsync` trả `responseData.results` và có thể có `responseData.token`.
- `linkGenericServiceAsync` trả `GenericServiceMasterPlayerResponseData`; ngoài `infoResponseParameters` còn có thể có `errorMessage`.
- `getPushNotificationAsync` trả `MasterPlayerResponseData`; danh sách push nằm ở `responseData.infoResponseParameters.pushNotifications`.
- `addPushNotificationAsync` trả `AddPushNotificationResponseData` với `pushId`.
- `sendPushNotificationAsync` trả `SendPushNotificationResponseData` với `message`.
- `addSegmentAsync`, `removeSegmentAsync`, `setTagAsync`, `removeTagAsync`, `changeAccountPasswordAsync`, `resetAccountPasswordAsync`, `setAvatarAsync`, `setCountryCodeAsync`, `setDisplayNameAsync`, `setEmailAsync`, `setPlayerBanAsync`, `updateTsLastLoginAsync`, toàn bộ `unlink*Async`, `sendSocketOperationEventAsync`, `sendEmailAsync`, `removePushNotificationAsync` trả `EmptyResponseData`.
- `setCustomDataAsync`, `changePlayerCurrencyAsync`, `setPlayerDataAsync`, `changePlayerStatisticsAsync`, `getOnlineStatusAsync` và đa số `link*Async` trả `MasterPlayerResponseData`.

## 10. Cảnh Báo Implementation Hiện Tại

- Public package hiện không export event handler socket riêng cho `MasterPlayerApi`.
- Nếu bạn cần nhận socket event do `sendSocketOperationEventAsync` phát ra, bạn phải dựa vào hệ event socket chung ở tầng khác hoặc spec backend riêng.
- `setAvatarAsync` và `InfoResponseParameters.avatar.type` vẫn dùng số thô, chưa có enum public tương ứng.
- `linkGenericServiceAsync` là case đặc biệt vì response data có thể chứa `errorMessage`.
- `getPushNotificationAsync` không trả `results`; dữ liệu nằm trong `infoResponseParameters.pushNotifications`.
- Package có expose `sendEmailAsync`, `sendPushNotificationAsync`, `sendSocketOperationEventAsync` ở cả `client`, `server`, `admin`, nhưng trong production nên ưu tiên `server/admin` cho các flow có trust boundary cao.
- `getOnlineStatusAsync` không trả boolean `isOnline`; bạn phải tự diễn giải từ `socketId` theo contract backend thực tế.

## 11. Best Practices

- Dùng getter chuyên biệt khi chỉ cần một field nhỏ.
- Với query lớn, giữ `infoRequestParam` tối giản để giảm payload.
- Trong app public, ưu tiên self-flow và tránh để client trực tiếp gọi các operation ops-heavy như email/push nếu không có lý do rõ ràng.
- Với `changePlayerCurrencyAsync` và `changePlayerStatisticsAsync`, luôn truyền `log` nếu flow cần audit.
- Với `getCurrencyLogAsync` và `getStatisticsLogAsync`, nên truyền ít nhất `keys` hoặc `userId` trong production để tránh query quá rộng.
- Với `forceLink`, chỉ bật khi flow ownership merge/reclaim đã được thiết kế rõ.
- Với `linkGameCenterAsync`, chuẩn bị đầy đủ verification bundle từ platform trước khi gọi SDK.
- Với `sendSocketOperationEventAsync`, chỉ dùng khi bạn biết receiver đang connect socket và đã auth socket thành công.
- Không giả định `getOnlineStatusAsync` trả boolean.

## 12. Ví Dụ Khuyến Nghị

### Đọc thông tin master player hiện tại với `infoRequestParam` tối giản

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new MasterPlayerModels.InfoRequestParam();
infoRequestParam.displayName = true;
infoRequestParam.email = true;
infoRequestParam.playerCurrencies = true;
infoRequestParam.playerCurrencyKeys = new System.Collections.Generic.List<string> { "gold" };

var requestData = new MasterPlayerModels.GetPlayerInformationRequestData();
requestData.infoRequestParam = infoRequestParam;

var response = await GNNetwork.masterPlayer.getPlayerInformationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

### Link Google account với `GoogleLoginType`

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new MasterPlayerModels.LinkGoogleRequestData();
requestData.token = "google-id-token";
requestData.type = (int)GoogleLoginType.IdToken;
requestData.forceLink = false;

var response = await GNNetwork.masterPlayer.linkGoogleAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var playerInfo = response.responseData.infoResponseParameters;
```

### Backend đọc leaderboard quanh một player cụ thể

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var infoRequestParam = new MasterPlayerModels.InfoRequestParam();
infoRequestParam.displayName = true;

var requestData = new MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData();
requestData.userId = "1234567890";
requestData.key = "rankScore";
requestData.infoRequestParam = infoRequestParam;
requestData.limit = 20;

var response = await GNNetwork.masterPlayer.server.getStatisticsLeaderboardAroundPlayerAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var leaderboard = response.responseData.results;
```

### Đăng ký push token với `PushPlatformType`

```csharp
using XmobiTea.GearN;
using XmobiTea.GearN.Constant;
using XmobiTea.GearN.Entity.Models;

var requestData = new MasterPlayerModels.AddPushNotificationRequestData();
requestData.token = "device-push-token";
requestData.platformType = (int)PushPlatformType.Android;

var response = await GNNetwork.masterPlayer.addPushNotificationAsync(requestData);

if (response.returnCode != ReturnCode.Ok) return;
if (response.errorCode != ErrorCode.Ok) return;

var pushId = response.responseData.pushId;
```

## 13. Anti-Patterns

- Không dùng `MasterPlayerApi` để thao tác game player, character player, group hoặc inventory item.
- Không chọn sai provider method khi search identity.
- Không bỏ `infoRequestParam` ở các method bắt buộc.
- Không dùng `skip` để phân trang `getCurrencyLogAsync` hoặc `getStatisticsLogAsync`.
- Không dùng `token` để phân trang `getPlayersWithDisplayNameAsync`, `getPlayersWithSegmentAsync`, `getPlayersWithTagAsync`.
- Không hardcode `type = 1` hoặc `type = 2` cho `linkGoogleAsync` khi package đã export `GoogleLoginType`.
- Không hardcode `platformType = 1` hoặc `2` cho push khi package đã export `PushPlatformType`.
- Không giả định `sendSocketOperationEventAsync` là thao tác gửi qua socket trực tiếp từ client.
- Không giả định `getPushNotificationAsync` trả `results`.
- Không bật `forceLink` một cách mù quáng.
- Không bỏ qua kiểm tra `returnCode` trước, rồi `errorCode` sau.

## 14. AI Checklist

- Đã `Resources/GNServerSettings` chưa.
- Đã chọn đúng namespace `masterPlayer` / `masterPlayer.server` / `masterPlayer.admin` chưa.
- Nếu đang ở `server/admin`, đã truyền `userId` cho flow self-target chưa.
- Nếu đang ở `client`, có thật sự muốn target current authenticated player không.
- Nếu method yêu cầu `infoRequestParam`, đã truyền object này chưa.
- Nếu đang đọc field nhỏ, có cần getter chuyên biệt thay vì `getPlayerInformationAsync` không.
- Nếu đang link Google, đã dùng `GoogleLoginType` chưa.
- Nếu đang đăng ký push token, đã dùng `PushPlatformType` chưa.
- Nếu đang lấy log, có dùng `token` cho page tiếp chưa.
- Nếu đang gửi socket event, receiver có socket session hợp lệ không.
- Có kiểm tra `returnCode` trước, rồi `errorCode` sau chưa.
- Nếu đang dùng `getOnlineStatusAsync`, có nhớ rằng response không có boolean `isOnline` không.

## Quick Map

Dùng bảng này để đọc đúng dòng mà không load cả file. `offset = startLine - 1`, `limit = endLine - startLine + 1`.

<!-- prettier-ignore -->
| Section | Lines |
| --- | --- |
| §3 Chọn Namespace | 53-68 |
| §4 Chọn Method — Đọc 1 master player | 77-100 |
| §4 Chọn Method — Search, leaderboard và log | 101-122 |
| §4 Chọn Method — Link và unlink identity | 123-159 |
| §4 Chọn Method — Mutation hồ sơ, account và outbound | 161-187 |
| §9 Minimal Pattern | 296-334 |
| §12 Ví Dụ Khuyến Nghị | 357-444 |
