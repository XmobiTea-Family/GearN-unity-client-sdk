# DTO Reference: GamePlayer

Game-player profile, friend/group relation, currency, statistics, segment, tag, social identity.

Related API reference: [API_GAME_PLAYER.md](/docs/reference/API_GAME_PLAYER.md).

Mỗi section bên dưới là 1 class DTO trong namespace `<Models>`. Field table cho biết: tên field, kiểu C# tương ứng, có `required` hay không (suy từ metadata `DataMember` / nullable / optional), doc comment, và ràng buộc length/range/default nếu có.

> **Server variant `userId` override**: Every `Server*RequestData` class overrides the parent's optional `userId?: string` with a required `userId: string` (via `public declare userId: string` with `mustNonNull: true`). Sections marked "Không có field public (payload rỗng)" for `Server*` variants mean no *new* fields — but `userId` changes from optional to **required** on those routes.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng.

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `userId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

## Danh sách

- **GamePlayerModels** (from `Runtime/Entity/Models/GamePlayerModels.cs`)
    - [InfoRequestParam](#inforequestparam)
    - [CustomDataParam](#customdataparam)
    - [GroupMemberParam](#groupmemberparam)
    - [PlayerCurrencyParam](#playercurrencyparam)
    - [PlayerDataParam](#playerdataparam)
    - [PlayerStatisticsParam](#playerstatisticsparam)
    - [AddPlayerFriendRequestData](#addplayerfriendrequestdata)
    - [ServerAddPlayerFriendRequestData](#serveraddplayerfriendrequestdata)
    - [AdminAddPlayerFriendRequestData](#adminaddplayerfriendrequestdata)
    - [AddSegmentRequestData](#addsegmentrequestdata)
    - [ServerAddSegmentRequestData](#serveraddsegmentrequestdata)
    - [AdminAddSegmentRequestData](#adminaddsegmentrequestdata)
    - [GetAvatarRequestData](#getavatarrequestdata)
    - [ServerGetAvatarRequestData](#servergetavatarrequestdata)
    - [AdminGetAvatarRequestData](#admingetavatarrequestdata)
    - [GetCountryCodeRequestData](#getcountrycoderequestdata)
    - [ServerGetCountryCodeRequestData](#servergetcountrycoderequestdata)
    - [AdminGetCountryCodeRequestData](#admingetcountrycoderequestdata)
    - [GetCustomDataRequestData](#getcustomdatarequestdata)
    - [ServerGetCustomDataRequestData](#servergetcustomdatarequestdata)
    - [AdminGetCustomDataRequestData](#admingetcustomdatarequestdata)
    - [GetDisplayNameRequestData](#getdisplaynamerequestdata)
    - [ServerGetDisplayNameRequestData](#servergetdisplaynamerequestdata)
    - [AdminGetDisplayNameRequestData](#admingetdisplaynamerequestdata)
    - [GetFriendStatisticsLeaderboardAroundPlayerRequestData](#getfriendstatisticsleaderboardaroundplayerrequestdata)
    - [ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData](#servergetfriendstatisticsleaderboardaroundplayerrequestdata)
    - [AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData](#admingetfriendstatisticsleaderboardaroundplayerrequestdata)
    - [GetFriendStatisticsLeaderboardRequestData](#getfriendstatisticsleaderboardrequestdata)
    - [ServerGetFriendStatisticsLeaderboardRequestData](#servergetfriendstatisticsleaderboardrequestdata)
    - [AdminGetFriendStatisticsLeaderboardRequestData](#admingetfriendstatisticsleaderboardrequestdata)
    - [GetIpAddressCreateRequestData](#getipaddresscreaterequestdata)
    - [ServerGetIpAddressCreateRequestData](#servergetipaddresscreaterequestdata)
    - [AdminGetIpAddressCreateRequestData](#admingetipaddresscreaterequestdata)
    - [GetPlayerBanRequestData](#getplayerbanrequestdata)
    - [ServerGetPlayerBanRequestData](#servergetplayerbanrequestdata)
    - [AdminGetPlayerBanRequestData](#admingetplayerbanrequestdata)
    - [GetPlayerCharacterRequestData](#getplayercharacterrequestdata)
    - [ServerGetPlayerCharacterRequestData](#servergetplayercharacterrequestdata)
    - [AdminGetPlayerCharacterRequestData](#admingetplayercharacterrequestdata)
    - [GetPlayerCurrencyRequestData](#getplayercurrencyrequestdata)
    - [ServerGetPlayerCurrencyRequestData](#servergetplayercurrencyrequestdata)
    - [AdminGetPlayerCurrencyRequestData](#admingetplayercurrencyrequestdata)
    - [GetPlayerDataRequestData](#getplayerdatarequestdata)
    - [ServerGetPlayerDataRequestData](#servergetplayerdatarequestdata)
    - [AdminGetPlayerDataRequestData](#admingetplayerdatarequestdata)
    - [GetPlayerFriendRequestData](#getplayerfriendrequestdata)
    - [ServerGetPlayerFriendRequestData](#servergetplayerfriendrequestdata)
    - [AdminGetPlayerFriendRequestData](#admingetplayerfriendrequestdata)
    - [GetPlayerGroupRequestData](#getplayergrouprequestdata)
    - [ServerGetPlayerGroupRequestData](#servergetplayergrouprequestdata)
    - [AdminGetPlayerGroupRequestData](#admingetplayergrouprequestdata)
    - [GetPlayerInformationRequestData](#getplayerinformationrequestdata)
    - [ServerGetPlayerInformationRequestData](#servergetplayerinformationrequestdata)
    - [AdminGetPlayerInformationRequestData](#admingetplayerinformationrequestdata)
    - [GetPlayerInventoryRequestData](#getplayerinventoryrequestdata)
    - [ServerGetPlayerInventoryRequestData](#servergetplayerinventoryrequestdata)
    - [AdminGetPlayerInventoryRequestData](#admingetplayerinventoryrequestdata)
    - [GetPlayerStatisticsRequestData](#getplayerstatisticsrequestdata)
    - [ServerGetPlayerStatisticsRequestData](#servergetplayerstatisticsrequestdata)
    - [AdminGetPlayerStatisticsRequestData](#admingetplayerstatisticsrequestdata)
    - [GetPlayersWithDisplayNameRequestData](#getplayerswithdisplaynamerequestdata)
    - [ServerGetPlayersWithDisplayNameRequestData](#servergetplayerswithdisplaynamerequestdata)
    - [AdminGetPlayersWithDisplayNameRequestData](#admingetplayerswithdisplaynamerequestdata)
    - [GetPlayersWithSegmentRequestData](#getplayerswithsegmentrequestdata)
    - [ServerGetPlayersWithSegmentRequestData](#servergetplayerswithsegmentrequestdata)
    - [AdminGetPlayersWithSegmentRequestData](#admingetplayerswithsegmentrequestdata)
    - [GetPlayersWithTagRequestData](#getplayerswithtagrequestdata)
    - [ServerGetPlayersWithTagRequestData](#servergetplayerswithtagrequestdata)
    - [AdminGetPlayersWithTagRequestData](#admingetplayerswithtagrequestdata)
    - [GetSegmentRequestData](#getsegmentrequestdata)
    - [ServerGetSegmentRequestData](#servergetsegmentrequestdata)
    - [AdminGetSegmentRequestData](#admingetsegmentrequestdata)
    - [GetStatisticsLeaderboardAroundPlayerRequestData](#getstatisticsleaderboardaroundplayerrequestdata)
    - [ServerGetStatisticsLeaderboardAroundPlayerRequestData](#servergetstatisticsleaderboardaroundplayerrequestdata)
    - [AdminGetStatisticsLeaderboardAroundPlayerRequestData](#admingetstatisticsleaderboardaroundplayerrequestdata)
    - [GetStatisticsLeaderboardRequestData](#getstatisticsleaderboardrequestdata)
    - [ServerGetStatisticsLeaderboardRequestData](#servergetstatisticsleaderboardrequestdata)
    - [AdminGetStatisticsLeaderboardRequestData](#admingetstatisticsleaderboardrequestdata)
    - [GetCreateLeaderboardRequestData](#getcreateleaderboardrequestdata)
    - [ServerGetCreateLeaderboardRequestData](#servergetcreateleaderboardrequestdata)
    - [AdminGetCreateLeaderboardRequestData](#admingetcreateleaderboardrequestdata)
    - [GetTagRequestData](#gettagrequestdata)
    - [ServerGetTagRequestData](#servergettagrequestdata)
    - [AdminGetTagRequestData](#admingettagrequestdata)
    - [GetTsCreateRequestData](#gettscreaterequestdata)
    - [ServerGetTsCreateRequestData](#servergettscreaterequestdata)
    - [AdminGetTsCreateRequestData](#admingettscreaterequestdata)
    - [GetTsLastLoginRequestData](#gettslastloginrequestdata)
    - [ServerGetTsLastLoginRequestData](#servergettslastloginrequestdata)
    - [AdminGetTsLastLoginRequestData](#admingettslastloginrequestdata)
    - [CreateGroupRequestData](#creategrouprequestdata)
    - [ServerCreateGroupRequestData](#servercreategrouprequestdata)
    - [AdminCreateGroupRequestData](#admincreategrouprequestdata)
    - [CreatePlayerCharacterRequestData](#createplayercharacterrequestdata)
    - [ServerCreatePlayerCharacterRequestData](#servercreateplayercharacterrequestdata)
    - [AdminCreatePlayerCharacterRequestData](#admincreateplayercharacterrequestdata)
    - [CreatePlayerItemRequestData](#createplayeritemrequestdata)
    - [ServerCreatePlayerItemRequestData](#servercreateplayeritemrequestdata)
    - [AdminCreatePlayerItemRequestData](#admincreateplayeritemrequestdata)
    - [JoinGroupRequestData](#joingrouprequestdata)
    - [ServerJoinGroupRequestData](#serverjoingrouprequestdata)
    - [AdminJoinGroupRequestData](#adminjoingrouprequestdata)
    - [LeaveGroupRequestData](#leavegrouprequestdata)
    - [ServerLeaveGroupRequestData](#serverleavegrouprequestdata)
    - [AdminLeaveGroupRequestData](#adminleavegrouprequestdata)
    - [RemovePlayerCharacterRequestData](#removeplayercharacterrequestdata)
    - [ServerRemovePlayerCharacterRequestData](#serverremoveplayercharacterrequestdata)
    - [AdminRemovePlayerCharacterRequestData](#adminremoveplayercharacterrequestdata)
    - [RemovePlayerFriendRequestData](#removeplayerfriendrequestdata)
    - [ServerRemovePlayerFriendRequestData](#serverremoveplayerfriendrequestdata)
    - [AdminRemovePlayerFriendRequestData](#adminremoveplayerfriendrequestdata)
    - [RemovePlayerItemRequestData](#removeplayeritemrequestdata)
    - [ServerRemovePlayerItemRequestData](#serverremoveplayeritemrequestdata)
    - [AdminRemovePlayerItemRequestData](#adminremoveplayeritemrequestdata)
    - [RemoveSegmentRequestData](#removesegmentrequestdata)
    - [ServerRemoveSegmentRequestData](#serverremovesegmentrequestdata)
    - [AdminRemoveSegmentRequestData](#adminremovesegmentrequestdata)
    - [RemoveTagRequestData](#removetagrequestdata)
    - [ServerRemoveTagRequestData](#serverremovetagrequestdata)
    - [AdminRemoveTagRequestData](#adminremovetagrequestdata)
    - [SetAvatarRequestData](#setavatarrequestdata)
    - [ServerSetAvatarRequestData](#serversetavatarrequestdata)
    - [AdminSetAvatarRequestData](#adminsetavatarrequestdata)
    - [SetCountryCodeRequestData](#setcountrycoderequestdata)
    - [ServerSetCountryCodeRequestData](#serversetcountrycoderequestdata)
    - [AdminSetCountryCodeRequestData](#adminsetcountrycoderequestdata)
    - [SetCustomDataRequestData](#setcustomdatarequestdata)
    - [ServerSetCustomDataRequestData](#serversetcustomdatarequestdata)
    - [AdminSetCustomDataRequestData](#adminsetcustomdatarequestdata)
    - [SetDisplayNameRequestData](#setdisplaynamerequestdata)
    - [ServerSetDisplayNameRequestData](#serversetdisplaynamerequestdata)
    - [AdminSetDisplayNameRequestData](#adminsetdisplaynamerequestdata)
    - [SetPlayerBanRequestData](#setplayerbanrequestdata)
    - [ServerSetPlayerBanRequestData](#serversetplayerbanrequestdata)
    - [AdminSetPlayerBanRequestData](#adminsetplayerbanrequestdata)
    - [ChangePlayerCurrencyRequestData](#changeplayercurrencyrequestdata)
    - [ServerChangePlayerCurrencyRequestData](#serverchangeplayercurrencyrequestdata)
    - [AdminChangePlayerCurrencyRequestData](#adminchangeplayercurrencyrequestdata)
    - [SetPlayerDataRequestData](#setplayerdatarequestdata)
    - [ServerSetPlayerDataRequestData](#serversetplayerdatarequestdata)
    - [AdminSetPlayerDataRequestData](#adminsetplayerdatarequestdata)
    - [ChangePlayerStatisticsRequestData](#changeplayerstatisticsrequestdata)
    - [ServerChangePlayerStatisticsRequestData](#serverchangeplayerstatisticsrequestdata)
    - [AdminChangePlayerStatisticsRequestData](#adminchangeplayerstatisticsrequestdata)
    - [SetTagRequestData](#settagrequestdata)
    - [ServerSetTagRequestData](#serversettagrequestdata)
    - [AdminSetTagRequestData](#adminsettagrequestdata)
    - [GetCurrencyLogRequestData](#getcurrencylogrequestdata)
    - [ServerGetCurrencyLogRequestData](#servergetcurrencylogrequestdata)
    - [AdminGetCurrencyLogRequestData](#admingetcurrencylogrequestdata)
    - [GetStatisticsLogRequestData](#getstatisticslogrequestdata)
    - [ServerGetStatisticsLogRequestData](#servergetstatisticslogrequestdata)
    - [AdminGetStatisticsLogRequestData](#admingetstatisticslogrequestdata)
    - [InfoResponseParameters](#inforesponseparameters)
    - [GamePlayerResponseData](#gameplayerresponsedata)
    - [GamePlayerWithUserIdResponseData](#gameplayerwithuseridresponsedata)
    - [GamePlayerLeaderboardResponseData](#gameplayerleaderboardresponsedata)
    - [GamePlayerLogResponseData](#gameplayerlogresponsedata)
    - [GetStatisticsLeaderboardResponseData](#getstatisticsleaderboardresponsedata)
    - [GetCurrencyLeaderboardResponseData](#getcurrencyleaderboardresponsedata)
    - [GetLastLoginLeaderboardResponseData](#getlastloginleaderboardresponsedata)
    - [GetCreateLeaderboardResponseData](#getcreateleaderboardresponsedata)
    - [GamePlayersWithUserIdResponseData](#gameplayerswithuseridresponsedata)
    - [GetCurrencyLeaderboardRequestData](#getcurrencyleaderboardrequestdata)
    - [ServerGetCurrencyLeaderboardRequestData](#servergetcurrencyleaderboardrequestdata)
    - [AdminGetCurrencyLeaderboardRequestData](#admingetcurrencyleaderboardrequestdata)
    - [GetLastLoginLeaderboardRequestData](#getlastloginleaderboardrequestdata)
    - [ServerGetLastLoginLeaderboardRequestData](#servergetlastloginleaderboardrequestdata)
    - [AdminGetLastLoginLeaderboardRequestData](#admingetlastloginleaderboardrequestdata)
    - [GetStatisticsLogResponseData](#getstatisticslogresponsedata)
    - [GetCurrencyLogResponseData](#getcurrencylogresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **GamePlayerRequestModels** (from `Runtime/Entity/Models/GamePlayerRequestModels.cs`)
    - [AddPlayerFriendOperationRequest](#addplayerfriendoperationrequest)
    - [ServerAddPlayerFriendOperationRequest](#serveraddplayerfriendoperationrequest)
    - [AdminAddPlayerFriendOperationRequest](#adminaddplayerfriendoperationrequest)
    - [AddSegmentOperationRequest](#addsegmentoperationrequest)
    - [ServerAddSegmentOperationRequest](#serveraddsegmentoperationrequest)
    - [AdminAddSegmentOperationRequest](#adminaddsegmentoperationrequest)
    - [GetAvatarOperationRequest](#getavataroperationrequest)
    - [ServerGetAvatarOperationRequest](#servergetavataroperationrequest)
    - [AdminGetAvatarOperationRequest](#admingetavataroperationrequest)
    - [GetCountryCodeOperationRequest](#getcountrycodeoperationrequest)
    - [ServerGetCountryCodeOperationRequest](#servergetcountrycodeoperationrequest)
    - [AdminGetCountryCodeOperationRequest](#admingetcountrycodeoperationrequest)
    - [GetCustomDataOperationRequest](#getcustomdataoperationrequest)
    - [ServerGetCustomDataOperationRequest](#servergetcustomdataoperationrequest)
    - [AdminGetCustomDataOperationRequest](#admingetcustomdataoperationrequest)
    - [GetDisplayNameOperationRequest](#getdisplaynameoperationrequest)
    - [ServerGetDisplayNameOperationRequest](#servergetdisplaynameoperationrequest)
    - [AdminGetDisplayNameOperationRequest](#admingetdisplaynameoperationrequest)
    - [GetFriendStatisticsLeaderboardAroundPlayerOperationRequest](#getfriendstatisticsleaderboardaroundplayeroperationrequest)
    - [ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest](#servergetfriendstatisticsleaderboardaroundplayeroperationrequest)
    - [AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest](#admingetfriendstatisticsleaderboardaroundplayeroperationrequest)
    - [GetFriendStatisticsLeaderboardOperationRequest](#getfriendstatisticsleaderboardoperationrequest)
    - [ServerGetFriendStatisticsLeaderboardOperationRequest](#servergetfriendstatisticsleaderboardoperationrequest)
    - [AdminGetFriendStatisticsLeaderboardOperationRequest](#admingetfriendstatisticsleaderboardoperationrequest)
    - [GetIpAddressCreateOperationRequest](#getipaddresscreateoperationrequest)
    - [ServerGetIpAddressCreateOperationRequest](#servergetipaddresscreateoperationrequest)
    - [AdminGetIpAddressCreateOperationRequest](#admingetipaddresscreateoperationrequest)
    - [GetPlayerBanOperationRequest](#getplayerbanoperationrequest)
    - [ServerGetPlayerBanOperationRequest](#servergetplayerbanoperationrequest)
    - [AdminGetPlayerBanOperationRequest](#admingetplayerbanoperationrequest)
    - [GetPlayerCharacterOperationRequest](#getplayercharacteroperationrequest)
    - [ServerGetPlayerCharacterOperationRequest](#servergetplayercharacteroperationrequest)
    - [AdminGetPlayerCharacterOperationRequest](#admingetplayercharacteroperationrequest)
    - [GetPlayerCurrencyOperationRequest](#getplayercurrencyoperationrequest)
    - [ServerGetPlayerCurrencyOperationRequest](#servergetplayercurrencyoperationrequest)
    - [AdminGetPlayerCurrencyOperationRequest](#admingetplayercurrencyoperationrequest)
    - [GetPlayerDataOperationRequest](#getplayerdataoperationrequest)
    - [ServerGetPlayerDataOperationRequest](#servergetplayerdataoperationrequest)
    - [AdminGetPlayerDataOperationRequest](#admingetplayerdataoperationrequest)
    - [GetPlayerFriendOperationRequest](#getplayerfriendoperationrequest)
    - [ServerGetPlayerFriendOperationRequest](#servergetplayerfriendoperationrequest)
    - [AdminGetPlayerFriendOperationRequest](#admingetplayerfriendoperationrequest)
    - [GetPlayerGroupOperationRequest](#getplayergroupoperationrequest)
    - [ServerGetPlayerGroupOperationRequest](#servergetplayergroupoperationrequest)
    - [AdminGetPlayerGroupOperationRequest](#admingetplayergroupoperationrequest)
    - [GetPlayerInformationOperationRequest](#getplayerinformationoperationrequest)
    - [ServerGetPlayerInformationOperationRequest](#servergetplayerinformationoperationrequest)
    - [AdminGetPlayerInformationOperationRequest](#admingetplayerinformationoperationrequest)
    - [GetPlayerInventoryOperationRequest](#getplayerinventoryoperationrequest)
    - [ServerGetPlayerInventoryOperationRequest](#servergetplayerinventoryoperationrequest)
    - [AdminGetPlayerInventoryOperationRequest](#admingetplayerinventoryoperationrequest)
    - [GetPlayerStatisticsOperationRequest](#getplayerstatisticsoperationrequest)
    - [ServerGetPlayerStatisticsOperationRequest](#servergetplayerstatisticsoperationrequest)
    - [AdminGetPlayerStatisticsOperationRequest](#admingetplayerstatisticsoperationrequest)
    - [GetPlayersWithDisplayNameOperationRequest](#getplayerswithdisplaynameoperationrequest)
    - [ServerGetPlayersWithDisplayNameOperationRequest](#servergetplayerswithdisplaynameoperationrequest)
    - [AdminGetPlayersWithDisplayNameOperationRequest](#admingetplayerswithdisplaynameoperationrequest)
    - [GetPlayersWithSegmentOperationRequest](#getplayerswithsegmentoperationrequest)
    - [ServerGetPlayersWithSegmentOperationRequest](#servergetplayerswithsegmentoperationrequest)
    - [AdminGetPlayersWithSegmentOperationRequest](#admingetplayerswithsegmentoperationrequest)
    - [GetPlayersWithTagOperationRequest](#getplayerswithtagoperationrequest)
    - [ServerGetPlayersWithTagOperationRequest](#servergetplayerswithtagoperationrequest)
    - [AdminGetPlayersWithTagOperationRequest](#admingetplayerswithtagoperationrequest)
    - [GetSegmentOperationRequest](#getsegmentoperationrequest)
    - [ServerGetSegmentOperationRequest](#servergetsegmentoperationrequest)
    - [AdminGetSegmentOperationRequest](#admingetsegmentoperationrequest)
    - [GetStatisticsLeaderboardAroundPlayerOperationRequest](#getstatisticsleaderboardaroundplayeroperationrequest)
    - [ServerGetStatisticsLeaderboardAroundPlayerOperationRequest](#servergetstatisticsleaderboardaroundplayeroperationrequest)
    - [AdminGetStatisticsLeaderboardAroundPlayerOperationRequest](#admingetstatisticsleaderboardaroundplayeroperationrequest)
    - [GetStatisticsLeaderboardOperationRequest](#getstatisticsleaderboardoperationrequest)
    - [ServerGetStatisticsLeaderboardOperationRequest](#servergetstatisticsleaderboardoperationrequest)
    - [AdminGetStatisticsLeaderboardOperationRequest](#admingetstatisticsleaderboardoperationrequest)
    - [GetTagOperationRequest](#gettagoperationrequest)
    - [ServerGetTagOperationRequest](#servergettagoperationrequest)
    - [AdminGetTagOperationRequest](#admingettagoperationrequest)
    - [GetTsCreateOperationRequest](#gettscreateoperationrequest)
    - [ServerGetTsCreateOperationRequest](#servergettscreateoperationrequest)
    - [AdminGetTsCreateOperationRequest](#admingettscreateoperationrequest)
    - [GetTsLastLoginOperationRequest](#gettslastloginoperationrequest)
    - [ServerGetTsLastLoginOperationRequest](#servergettslastloginoperationrequest)
    - [AdminGetTsLastLoginOperationRequest](#admingettslastloginoperationrequest)
    - [CreateGroupOperationRequest](#creategroupoperationrequest)
    - [ServerCreateGroupOperationRequest](#servercreategroupoperationrequest)
    - [AdminCreateGroupOperationRequest](#admincreategroupoperationrequest)
    - [CreatePlayerCharacterOperationRequest](#createplayercharacteroperationrequest)
    - [ServerCreatePlayerCharacterOperationRequest](#servercreateplayercharacteroperationrequest)
    - [AdminCreatePlayerCharacterOperationRequest](#admincreateplayercharacteroperationrequest)
    - [CreatePlayerItemOperationRequest](#createplayeritemoperationrequest)
    - [ServerCreatePlayerItemOperationRequest](#servercreateplayeritemoperationrequest)
    - [AdminCreatePlayerItemOperationRequest](#admincreateplayeritemoperationrequest)
    - [JoinGroupOperationRequest](#joingroupoperationrequest)
    - [ServerJoinGroupOperationRequest](#serverjoingroupoperationrequest)
    - [AdminJoinGroupOperationRequest](#adminjoingroupoperationrequest)
    - [LeaveGroupOperationRequest](#leavegroupoperationrequest)
    - [ServerLeaveGroupOperationRequest](#serverleavegroupoperationrequest)
    - [AdminLeaveGroupOperationRequest](#adminleavegroupoperationrequest)
    - [RemovePlayerCharacterOperationRequest](#removeplayercharacteroperationrequest)
    - [ServerRemovePlayerCharacterOperationRequest](#serverremoveplayercharacteroperationrequest)
    - [AdminRemovePlayerCharacterOperationRequest](#adminremoveplayercharacteroperationrequest)
    - [RemovePlayerFriendOperationRequest](#removeplayerfriendoperationrequest)
    - [ServerRemovePlayerFriendOperationRequest](#serverremoveplayerfriendoperationrequest)
    - [AdminRemovePlayerFriendOperationRequest](#adminremoveplayerfriendoperationrequest)
    - [RemovePlayerItemOperationRequest](#removeplayeritemoperationrequest)
    - [ServerRemovePlayerItemOperationRequest](#serverremoveplayeritemoperationrequest)
    - [AdminRemovePlayerItemOperationRequest](#adminremoveplayeritemoperationrequest)
    - [RemoveSegmentOperationRequest](#removesegmentoperationrequest)
    - [ServerRemoveSegmentOperationRequest](#serverremovesegmentoperationrequest)
    - [AdminRemoveSegmentOperationRequest](#adminremovesegmentoperationrequest)
    - [RemoveTagOperationRequest](#removetagoperationrequest)
    - [ServerRemoveTagOperationRequest](#serverremovetagoperationrequest)
    - [AdminRemoveTagOperationRequest](#adminremovetagoperationrequest)
    - [SetAvatarOperationRequest](#setavataroperationrequest)
    - [ServerSetAvatarOperationRequest](#serversetavataroperationrequest)
    - [AdminSetAvatarOperationRequest](#adminsetavataroperationrequest)
    - [SetCountryCodeOperationRequest](#setcountrycodeoperationrequest)
    - [ServerSetCountryCodeOperationRequest](#serversetcountrycodeoperationrequest)
    - [AdminSetCountryCodeOperationRequest](#adminsetcountrycodeoperationrequest)
    - [SetCustomDataOperationRequest](#setcustomdataoperationrequest)
    - [ServerSetCustomDataOperationRequest](#serversetcustomdataoperationrequest)
    - [AdminSetCustomDataOperationRequest](#adminsetcustomdataoperationrequest)
    - [SetDisplayNameOperationRequest](#setdisplaynameoperationrequest)
    - [ServerSetDisplayNameOperationRequest](#serversetdisplaynameoperationrequest)
    - [AdminSetDisplayNameOperationRequest](#adminsetdisplaynameoperationrequest)
    - [SetPlayerBanOperationRequest](#setplayerbanoperationrequest)
    - [ServerSetPlayerBanOperationRequest](#serversetplayerbanoperationrequest)
    - [AdminSetPlayerBanOperationRequest](#adminsetplayerbanoperationrequest)
    - [ChangePlayerCurrencyOperationRequest](#changeplayercurrencyoperationrequest)
    - [ServerChangePlayerCurrencyOperationRequest](#serverchangeplayercurrencyoperationrequest)
    - [AdminChangePlayerCurrencyOperationRequest](#adminchangeplayercurrencyoperationrequest)
    - [SetPlayerDataOperationRequest](#setplayerdataoperationrequest)
    - [ServerSetPlayerDataOperationRequest](#serversetplayerdataoperationrequest)
    - [AdminSetPlayerDataOperationRequest](#adminsetplayerdataoperationrequest)
    - [ChangePlayerStatisticsOperationRequest](#changeplayerstatisticsoperationrequest)
    - [ServerChangePlayerStatisticsOperationRequest](#serverchangeplayerstatisticsoperationrequest)
    - [AdminChangePlayerStatisticsOperationRequest](#adminchangeplayerstatisticsoperationrequest)
    - [SetTagOperationRequest](#settagoperationrequest)
    - [ServerSetTagOperationRequest](#serversettagoperationrequest)
    - [AdminSetTagOperationRequest](#adminsettagoperationrequest)
    - [GetCurrencyLeaderboardOperationRequest](#getcurrencyleaderboardoperationrequest)
    - [ServerGetCurrencyLeaderboardOperationRequest](#servergetcurrencyleaderboardoperationrequest)
    - [AdminGetCurrencyLeaderboardOperationRequest](#admingetcurrencyleaderboardoperationrequest)
    - [GetLastLoginLeaderboardOperationRequest](#getlastloginleaderboardoperationrequest)
    - [ServerGetLastLoginLeaderboardOperationRequest](#servergetlastloginleaderboardoperationrequest)
    - [AdminGetLastLoginLeaderboardOperationRequest](#admingetlastloginleaderboardoperationrequest)
    - [GetCreateLeaderboardOperationRequest](#getcreateleaderboardoperationrequest)
    - [ServerGetCreateLeaderboardOperationRequest](#servergetcreateleaderboardoperationrequest)
    - [AdminGetCreateLeaderboardOperationRequest](#admingetcreateleaderboardoperationrequest)
    - [GetStatisticsLogOperationRequest](#getstatisticslogoperationrequest)
    - [ServerGetStatisticsLogOperationRequest](#servergetstatisticslogoperationrequest)
    - [AdminGetStatisticsLogOperationRequest](#admingetstatisticslogoperationrequest)
    - [GetCurrencyLogOperationRequest](#getcurrencylogoperationrequest)
    - [ServerGetCurrencyLogOperationRequest](#servergetcurrencylogoperationrequest)
    - [AdminGetCurrencyLogOperationRequest](#admingetcurrencylogoperationrequest)
- **GamePlayerResponseModels** (from `Runtime/Entity/Models/GamePlayerResponseModels.cs`)
    - [AddPlayerFriendOperationResponse](#addplayerfriendoperationresponse)
    - [AddSegmentOperationResponse](#addsegmentoperationresponse)
    - [GetAvatarOperationResponse](#getavataroperationresponse)
    - [GetCountryCodeOperationResponse](#getcountrycodeoperationresponse)
    - [GetCustomDataOperationResponse](#getcustomdataoperationresponse)
    - [GetDisplayNameOperationResponse](#getdisplaynameoperationresponse)
    - [GetFriendStatisticsLeaderboardAroundPlayerOperationResponse](#getfriendstatisticsleaderboardaroundplayeroperationresponse)
    - [GetFriendStatisticsLeaderboardOperationResponse](#getfriendstatisticsleaderboardoperationresponse)
    - [GetIpAddressCreateOperationResponse](#getipaddresscreateoperationresponse)
    - [GetPlayerBanOperationResponse](#getplayerbanoperationresponse)
    - [GetPlayerCharacterOperationResponse](#getplayercharacteroperationresponse)
    - [GetPlayerCurrencyOperationResponse](#getplayercurrencyoperationresponse)
    - [GetPlayerDataOperationResponse](#getplayerdataoperationresponse)
    - [GetPlayerFriendOperationResponse](#getplayerfriendoperationresponse)
    - [GetPlayerGroupOperationResponse](#getplayergroupoperationresponse)
    - [GetPlayerInformationOperationResponse](#getplayerinformationoperationresponse)
    - [GetPlayerInventoryOperationResponse](#getplayerinventoryoperationresponse)
    - [GetPlayerStatisticsOperationResponse](#getplayerstatisticsoperationresponse)
    - [GetPlayersWithDisplayNameOperationResponse](#getplayerswithdisplaynameoperationresponse)
    - [GetPlayersWithSegmentOperationResponse](#getplayerswithsegmentoperationresponse)
    - [GetPlayersWithTagOperationResponse](#getplayerswithtagoperationresponse)
    - [GetSegmentOperationResponse](#getsegmentoperationresponse)
    - [GetStatisticsLeaderboardAroundPlayerOperationResponse](#getstatisticsleaderboardaroundplayeroperationresponse)
    - [GetStatisticsLeaderboardOperationResponse](#getstatisticsleaderboardoperationresponse)
    - [GetTagOperationResponse](#gettagoperationresponse)
    - [GetTsCreateOperationResponse](#gettscreateoperationresponse)
    - [GetTsLastLoginOperationResponse](#gettslastloginoperationresponse)
    - [CreateGroupOperationResponse](#creategroupoperationresponse)
    - [CreatePlayerCharacterOperationResponse](#createplayercharacteroperationresponse)
    - [CreatePlayerItemOperationResponse](#createplayeritemoperationresponse)
    - [JoinGroupOperationResponse](#joingroupoperationresponse)
    - [LeaveGroupOperationResponse](#leavegroupoperationresponse)
    - [RemovePlayerCharacterOperationResponse](#removeplayercharacteroperationresponse)
    - [RemovePlayerFriendOperationResponse](#removeplayerfriendoperationresponse)
    - [RemovePlayerItemOperationResponse](#removeplayeritemoperationresponse)
    - [RemoveSegmentOperationResponse](#removesegmentoperationresponse)
    - [RemoveTagOperationResponse](#removetagoperationresponse)
    - [SetAvatarOperationResponse](#setavataroperationresponse)
    - [SetCountryCodeOperationResponse](#setcountrycodeoperationresponse)
    - [SetCustomDataOperationResponse](#setcustomdataoperationresponse)
    - [SetDisplayNameOperationResponse](#setdisplaynameoperationresponse)
    - [SetPlayerBanOperationResponse](#setplayerbanoperationresponse)
    - [ChangePlayerCurrencyOperationResponse](#changeplayercurrencyoperationresponse)
    - [SetPlayerDataOperationResponse](#setplayerdataoperationresponse)
    - [ChangePlayerStatisticsOperationResponse](#changeplayerstatisticsoperationresponse)
    - [SetTagOperationResponse](#settagoperationresponse)
    - [GetCurrencyLeaderboardOperationResponse](#getcurrencyleaderboardoperationresponse)
    - [GetLastLoginLeaderboardOperationResponse](#getlastloginleaderboardoperationresponse)
    - [GetCreateLeaderboardOperationResponse](#getcreateleaderboardoperationresponse)
    - [GetStatisticsLogOperationResponse](#getstatisticslogoperationresponse)
    - [GetCurrencyLogOperationResponse](#getcurrencylogoperationresponse)

---

## Namespace `GamePlayerModels`

### InfoRequestParam

Selects which optional game-player fields and lightweight relations should be returned. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `segments` | `bool?` | no | _default=false_ |
| `customDatas` | `bool?` | no | _default=false_ |
| `displayName` | `bool?` | no | _default=false_ |
| `avatar` | `bool?` | no | _default=false_ |
| `tsCreate` | `bool?` | no | _default=false_ |
| `tags` | `bool?` | no | _default=false_ |
| `playerBan` | `bool?` | no | _default=false_ |
| `playerCurrencies` | `bool?` | no | _default=false_ |
| `playerStatistics` | `bool?` | no | _default=false_ |
| `playerDatas` | `bool?` | no | _default=false_ |
| `ipAddressCreate` | `bool?` | no | _default=false_ |
| `countryCode` | `bool?` | no | _default=false_ |
| `tsLastLogin` | `bool?` | no | _default=false_ |
| `playerCharacters` | `bool?` | no | Includes relation items for characters owned by the player, optionally filtered by `characterCatalogIds`. — _default=false_ |
| `playerInventories` | `bool?` | no | Includes relation items for inventory owned by the player, optionally filtered by `itemCatalogIds`. — _default=false_ |
| `playerGroups` | `bool?` | no | Includes relation items for groups joined or owned by the player, optionally filtered by `groupCatalogIds`. — _default=false_ |
| `playerFriends` | `bool?` | no | Includes relation items for friends attached to the player, optionally filtered by `friendCatalogIds`. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |
| `characterCatalogIds` | `List<string>?` | no | Restricts `playerCharacters` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `itemCatalogIds` | `List<string>?` | no | Restricts `playerInventories` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `groupCatalogIds` | `List<string>?` | no | Restricts `playerGroups` to relation items whose catalog IDs match this list. — _elementCls=String_ |
| `friendCatalogIds` | `List<string>?` | no | Restricts `playerFriends` to relation items whose catalog IDs match this list. — _elementCls=String_ |

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### GroupMemberParam

Describes one game-player member included when creating a group.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | _minLength=10, maxLength=10_ |

### PlayerCurrencyParam

Defines the reusable parameter block PlayerCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `amount` | `double` | yes | Currency amount delta to apply (positive to add, negative to subtract). |

### PlayerDataParam

Defines the reusable parameter block PlayerDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this player data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### PlayerStatisticsParam

Defines the reusable parameter block PlayerStatisticsParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `double` | yes | Statistic value to apply; interpretation depends on the configured aggregation method. |

### AddPlayerFriendRequestData

Creates a friend relation between the current or target game player and another game player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `friendId` | `string` | yes | Target friend user ID. — _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | Friend catalog used to create the relation record. — _minLength=2, maxLength=32_ |

### ServerAddPlayerFriendRequestData

Extends: `AddPlayerFriendRequestData`

Defines the request payload for ServerAddPlayerFriend.

_Không có field public (payload rỗng)._

### AdminAddPlayerFriendRequestData

Extends: `ServerAddPlayerFriendRequestData`

Defines the request payload for AdminAddPlayerFriend.

_Không có field public (payload rỗng)._

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Không có field public (payload rỗng)._

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không có field public (payload rỗng)._

### GetAvatarRequestData

Defines the request payload for GetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetAvatarRequestData

Extends: `GetAvatarRequestData`

Defines the request payload for ServerGetAvatar.

_Không có field public (payload rỗng)._

### AdminGetAvatarRequestData

Extends: `ServerGetAvatarRequestData`

Defines the request payload for AdminGetAvatar.

_Không có field public (payload rỗng)._

### GetCountryCodeRequestData

Defines the request payload for GetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetCountryCodeRequestData

Extends: `GetCountryCodeRequestData`

Defines the request payload for ServerGetCountryCode.

_Không có field public (payload rỗng)._

### AdminGetCountryCodeRequestData

Extends: `ServerGetCountryCodeRequestData`

Defines the request payload for AdminGetCountryCode.

_Không có field public (payload rỗng)._

### GetCustomDataRequestData

Defines the request payload for GetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetCustomDataRequestData

Extends: `GetCustomDataRequestData`

Defines the request payload for ServerGetCustomData.

_Không có field public (payload rỗng)._

### AdminGetCustomDataRequestData

Extends: `ServerGetCustomDataRequestData`

Defines the request payload for AdminGetCustomData.

_Không có field public (payload rỗng)._

### GetDisplayNameRequestData

Defines the request payload for GetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetDisplayNameRequestData

Extends: `GetDisplayNameRequestData`

Defines the request payload for ServerGetDisplayName.

_Không có field public (payload rỗng)._

### AdminGetDisplayNameRequestData

Extends: `ServerGetDisplayNameRequestData`

Defines the request payload for AdminGetDisplayName.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetFriendStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboardAroundPlayer.

_Không có field public (payload rỗng)._

### AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboardAroundPlayer.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardRequestData

Defines the request payload for GetFriendStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetFriendStatisticsLeaderboardRequestData

Extends: `GetFriendStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetFriendStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetFriendStatisticsLeaderboardRequestData

Extends: `ServerGetFriendStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetFriendStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### GetIpAddressCreateRequestData

Defines the request payload for GetIpAddressCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetIpAddressCreateRequestData

Extends: `GetIpAddressCreateRequestData`

Defines the request payload for ServerGetIpAddressCreate.

_Không có field public (payload rỗng)._

### AdminGetIpAddressCreateRequestData

Extends: `ServerGetIpAddressCreateRequestData`

Defines the request payload for AdminGetIpAddressCreate.

_Không có field public (payload rỗng)._

### GetPlayerBanRequestData

Defines the request payload for GetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetPlayerBanRequestData

Extends: `GetPlayerBanRequestData`

Defines the request payload for ServerGetPlayerBan.

_Không có field public (payload rỗng)._

### AdminGetPlayerBanRequestData

Extends: `ServerGetPlayerBanRequestData`

Defines the request payload for AdminGetPlayerBan.

_Không có field public (payload rỗng)._

### GetPlayerCharacterRequestData

Defines the request payload for GetPlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `characterCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerCharacterRequestData

Extends: `GetPlayerCharacterRequestData`

Defines the request payload for ServerGetPlayerCharacter.

_Không có field public (payload rỗng)._

### AdminGetPlayerCharacterRequestData

Extends: `ServerGetPlayerCharacterRequestData`

Defines the request payload for AdminGetPlayerCharacter.

_Không có field public (payload rỗng)._

### GetPlayerCurrencyRequestData

Defines the request payload for GetPlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerCurrencyKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerCurrencyRequestData

Extends: `GetPlayerCurrencyRequestData`

Defines the request payload for ServerGetPlayerCurrency.

_Không có field public (payload rỗng)._

### AdminGetPlayerCurrencyRequestData

Extends: `ServerGetPlayerCurrencyRequestData`

Defines the request payload for AdminGetPlayerCurrency.

_Không có field public (payload rỗng)._

### GetPlayerDataRequestData

Defines the request payload for GetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerDataKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerDataRequestData

Extends: `GetPlayerDataRequestData`

Defines the request payload for ServerGetPlayerData.

_Không có field public (payload rỗng)._

### AdminGetPlayerDataRequestData

Extends: `ServerGetPlayerDataRequestData`

Defines the request payload for AdminGetPlayerData.

_Không có field public (payload rỗng)._

### GetPlayerFriendRequestData

Defines the request payload for GetPlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `friendCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerFriendRequestData

Extends: `GetPlayerFriendRequestData`

Defines the request payload for ServerGetPlayerFriend.

_Không có field public (payload rỗng)._

### AdminGetPlayerFriendRequestData

Extends: `ServerGetPlayerFriendRequestData`

Defines the request payload for AdminGetPlayerFriend.

_Không có field public (payload rỗng)._

### GetPlayerGroupRequestData

Defines the request payload for GetPlayerGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerGroupRequestData

Extends: `GetPlayerGroupRequestData`

Defines the request payload for ServerGetPlayerGroup.

_Không có field public (payload rỗng)._

### AdminGetPlayerGroupRequestData

Extends: `ServerGetPlayerGroupRequestData`

Defines the request payload for AdminGetPlayerGroup.

_Không có field public (payload rỗng)._

### GetPlayerInformationRequestData

Reads the current or target game-player profile using the requested projection. On the client route, omit `userId` to target the authenticated player itself.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Required field projection that controls which optional data is returned. |

### ServerGetPlayerInformationRequestData

Extends: `GetPlayerInformationRequestData`

Reads a specific target game player on a trusted route.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `createPlayerIfNotExists` | `bool?` | no | Allows the backend to create the missing game-player record before returning it. — _default=false_ |

### AdminGetPlayerInformationRequestData

Extends: `ServerGetPlayerInformationRequestData`

Defines the request payload for AdminGetPlayerInformation.

_Không có field public (payload rỗng)._

### GetPlayerInventoryRequestData

Defines the request payload for GetPlayerInventory.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `itemCatalogIds` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerInventoryRequestData

Extends: `GetPlayerInventoryRequestData`

Defines the request payload for ServerGetPlayerInventory.

_Không có field public (payload rỗng)._

### AdminGetPlayerInventoryRequestData

Extends: `ServerGetPlayerInventoryRequestData`

Defines the request payload for AdminGetPlayerInventory.

_Không có field public (payload rỗng)._

### GetPlayerStatisticsRequestData

Defines the request payload for GetPlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `statisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerStatisticsRequestData

Extends: `GetPlayerStatisticsRequestData`

Defines the request payload for ServerGetPlayerStatistics.

_Không có field public (payload rỗng)._

### AdminGetPlayerStatisticsRequestData

Extends: `ServerGetPlayerStatisticsRequestData`

Defines the request payload for AdminGetPlayerStatistics.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameRequestData

Defines the request payload for GetPlayersWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetPlayersWithDisplayNameRequestData

Extends: `GetPlayersWithDisplayNameRequestData`

Defines the request payload for ServerGetPlayersWithDisplayName.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithDisplayNameRequestData

Extends: `ServerGetPlayersWithDisplayNameRequestData`

Defines the request payload for AdminGetPlayersWithDisplayName.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentRequestData

Defines the request payload for GetPlayersWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetPlayersWithSegmentRequestData

Extends: `GetPlayersWithSegmentRequestData`

Defines the request payload for ServerGetPlayersWithSegment.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithSegmentRequestData

Extends: `ServerGetPlayersWithSegmentRequestData`

Defines the request payload for AdminGetPlayersWithSegment.

_Không có field public (payload rỗng)._

### GetPlayersWithTagRequestData

Defines the request payload for GetPlayersWithTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |

### ServerGetPlayersWithTagRequestData

Extends: `GetPlayersWithTagRequestData`

Defines the request payload for ServerGetPlayersWithTag.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithTagRequestData

Extends: `ServerGetPlayersWithTagRequestData`

Defines the request payload for AdminGetPlayersWithTag.

_Không có field public (payload rỗng)._

### GetSegmentRequestData

Defines the request payload for GetSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetSegmentRequestData

Extends: `GetSegmentRequestData`

Defines the request payload for ServerGetSegment.

_Không có field public (payload rỗng)._

### AdminGetSegmentRequestData

Extends: `ServerGetSegmentRequestData`

Defines the request payload for AdminGetSegment.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundPlayerRequestData

Defines the request payload for GetStatisticsLeaderboardAroundPlayer.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `GetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for ServerGetStatisticsLeaderboardAroundPlayer.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundPlayerRequestData

Extends: `ServerGetStatisticsLeaderboardAroundPlayerRequestData`

Defines the request payload for AdminGetStatisticsLeaderboardAroundPlayer.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardRequestData

Defines the request payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |
| `version` | `string?` | no | _minLength=2, maxLength=32_ |

### ServerGetStatisticsLeaderboardRequestData

Extends: `GetStatisticsLeaderboardRequestData`

Defines the request payload for ServerGetStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardRequestData

Extends: `ServerGetStatisticsLeaderboardRequestData`

Defines the request payload for AdminGetStatisticsLeaderboard.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardRequestData

Defines the request payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetCreateLeaderboardRequestData

Extends: `GetCreateLeaderboardRequestData`

Defines the request payload for ServerGetCreateLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetCreateLeaderboardRequestData

Extends: `ServerGetCreateLeaderboardRequestData`

Defines the request payload for AdminGetCreateLeaderboard.

_Không có field public (payload rỗng)._

### GetTagRequestData

Defines the request payload for GetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `tagKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetTagRequestData

Extends: `GetTagRequestData`

Defines the request payload for ServerGetTag.

_Không có field public (payload rỗng)._

### AdminGetTagRequestData

Extends: `ServerGetTagRequestData`

Defines the request payload for AdminGetTag.

_Không có field public (payload rỗng)._

### GetTsCreateRequestData

Defines the request payload for GetTsCreate.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetTsCreateRequestData

Extends: `GetTsCreateRequestData`

Defines the request payload for ServerGetTsCreate.

_Không có field public (payload rỗng)._

### AdminGetTsCreateRequestData

Extends: `ServerGetTsCreateRequestData`

Defines the request payload for AdminGetTsCreate.

_Không có field public (payload rỗng)._

### GetTsLastLoginRequestData

Defines the request payload for GetTsLastLogin.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetTsLastLoginRequestData

Extends: `GetTsLastLoginRequestData`

Defines the request payload for ServerGetTsLastLogin.

_Không có field public (payload rỗng)._

### AdminGetTsLastLoginRequestData

Extends: `ServerGetTsLastLoginRequestData`

Defines the request payload for AdminGetTsLastLogin.

_Không có field public (payload rỗng)._

### CreateGroupRequestData

Creates a group owned by or attached to the current or target game player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `groupMembers` | `List<GroupMemberParam>?` | no | Additional game-player members expressed as user IDs, not character IDs. — _elementCls=GroupMemberParam_ |
| `displayName` | `string?` | no | _default=""_ |

### ServerCreateGroupRequestData

Extends: `CreateGroupRequestData`

Defines the request payload for ServerCreateGroup.

_Không có field public (payload rỗng)._

### AdminCreateGroupRequestData

Extends: `ServerCreateGroupRequestData`

Defines the request payload for AdminCreateGroup.

_Không có field public (payload rỗng)._

### CreatePlayerCharacterRequestData

Defines the request payload for CreatePlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `uniqueDisplayName` | `bool?` | no | _default=false_ |

### ServerCreatePlayerCharacterRequestData

Extends: `CreatePlayerCharacterRequestData`

Defines the request payload for ServerCreatePlayerCharacter.

_Không có field public (payload rỗng)._

### AdminCreatePlayerCharacterRequestData

Extends: `ServerCreatePlayerCharacterRequestData`

Defines the request payload for AdminCreatePlayerCharacter.

_Không có field public (payload rỗng)._

### CreatePlayerItemRequestData

Defines the request payload for CreatePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `catalogId` | `string` | yes | _minLength=2, maxLength=32_ |
| `classId` | `string` | yes | _minLength=2, maxLength=32_ |
| `displayName` | `string?` | no | _default=""_ |
| `amount` | `int?` | no | _default=1_ |

### ServerCreatePlayerItemRequestData

Extends: `CreatePlayerItemRequestData`

Defines the request payload for ServerCreatePlayerItem.

_Không có field public (payload rỗng)._

### AdminCreatePlayerItemRequestData

Extends: `ServerCreatePlayerItemRequestData`

Defines the request payload for AdminCreatePlayerItem.

_Không có field public (payload rỗng)._

### JoinGroupRequestData

Defines the request payload for JoinGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerJoinGroupRequestData

Extends: `JoinGroupRequestData`

Defines the request payload for ServerJoinGroup.

_Không có field public (payload rỗng)._

### AdminJoinGroupRequestData

Extends: `ServerJoinGroupRequestData`

Defines the request payload for AdminJoinGroup.

_Không có field public (payload rỗng)._

### LeaveGroupRequestData

Defines the request payload for LeaveGroup.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `groupId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerLeaveGroupRequestData

Extends: `LeaveGroupRequestData`

Defines the request payload for ServerLeaveGroup.

_Không có field public (payload rỗng)._

### AdminLeaveGroupRequestData

Extends: `ServerLeaveGroupRequestData`

Defines the request payload for AdminLeaveGroup.

_Không có field public (payload rỗng)._

### RemovePlayerCharacterRequestData

Defines the request payload for RemovePlayerCharacter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `characterId` | `string` | yes | _minLength=11, maxLength=11_ |

### ServerRemovePlayerCharacterRequestData

Extends: `RemovePlayerCharacterRequestData`

Defines the request payload for ServerRemovePlayerCharacter.

_Không có field public (payload rỗng)._

### AdminRemovePlayerCharacterRequestData

Extends: `ServerRemovePlayerCharacterRequestData`

Defines the request payload for AdminRemovePlayerCharacter.

_Không có field public (payload rỗng)._

### RemovePlayerFriendRequestData

Defines the request payload for RemovePlayerFriend.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `friendId` | `string` | yes | _minLength=10, maxLength=10_ |

### ServerRemovePlayerFriendRequestData

Extends: `RemovePlayerFriendRequestData`

Defines the request payload for ServerRemovePlayerFriend.

_Không có field public (payload rỗng)._

### AdminRemovePlayerFriendRequestData

Extends: `ServerRemovePlayerFriendRequestData`

Defines the request payload for AdminRemovePlayerFriend.

_Không có field public (payload rỗng)._

### RemovePlayerItemRequestData

Defines the request payload for RemovePlayerItem.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `itemId` | `string` | yes | _minLength=12, maxLength=12_ |

### ServerRemovePlayerItemRequestData

Extends: `RemovePlayerItemRequestData`

Defines the request payload for ServerRemovePlayerItem.

_Không có field public (payload rỗng)._

### AdminRemovePlayerItemRequestData

Extends: `ServerRemovePlayerItemRequestData`

Defines the request payload for AdminRemovePlayerItem.

_Không có field public (payload rỗng)._

### RemoveSegmentRequestData

Defines the request payload for RemoveSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveSegmentRequestData

Extends: `RemoveSegmentRequestData`

Defines the request payload for ServerRemoveSegment.

_Không có field public (payload rỗng)._

### AdminRemoveSegmentRequestData

Extends: `ServerRemoveSegmentRequestData`

Defines the request payload for AdminRemoveSegment.

_Không có field public (payload rỗng)._

### RemoveTagRequestData

Defines the request payload for RemoveTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerRemoveTagRequestData

Extends: `RemoveTagRequestData`

Defines the request payload for ServerRemoveTag.

_Không có field public (payload rỗng)._

### AdminRemoveTagRequestData

Extends: `ServerRemoveTagRequestData`

Defines the request payload for AdminRemoveTag.

_Không có field public (payload rỗng)._

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `type` | `int` | yes | Avatar type identifier. User custom this type enum. |
| `value` | `string` | yes | Avatar value such as a URL, file ID, or provider-specific string. — _minLength=1, maxLength=128_ |

### ServerSetAvatarRequestData

Extends: `SetAvatarRequestData`

Defines the request payload for ServerSetAvatar.

_Không có field public (payload rỗng)._

### AdminSetAvatarRequestData

Extends: `ServerSetAvatarRequestData`

Defines the request payload for AdminSetAvatar.

_Không có field public (payload rỗng)._

### SetCountryCodeRequestData

Defines the request payload for SetCountryCode.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `countryCode` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetCountryCodeRequestData

Extends: `SetCountryCodeRequestData`

Defines the request payload for ServerSetCountryCode.

_Không có field public (payload rỗng)._

### AdminSetCountryCodeRequestData

Extends: `ServerSetCountryCodeRequestData`

Defines the request payload for AdminSetCountryCode.

_Không có field public (payload rỗng)._

### SetCustomDataRequestData

Defines the request payload for SetCustomData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDatas` | `List<CustomDataParam>` | yes | _minLength=1, maxLength=32, elementCls=CustomDataParam_ |

### ServerSetCustomDataRequestData

Extends: `SetCustomDataRequestData`

Defines the request payload for ServerSetCustomData.

_Không có field public (payload rỗng)._

### AdminSetCustomDataRequestData

Extends: `ServerSetCustomDataRequestData`

Defines the request payload for AdminSetCustomData.

_Không có field public (payload rỗng)._

### SetDisplayNameRequestData

Defines the request payload for SetDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `displayName` | `string` | yes | _minLength=5, maxLength=32_ |
| `uniqueDisplayName` | `bool?` | no | _default=false_ |

### ServerSetDisplayNameRequestData

Extends: `SetDisplayNameRequestData`

Defines the request payload for ServerSetDisplayName.

_Không có field public (payload rỗng)._

### AdminSetDisplayNameRequestData

Extends: `ServerSetDisplayNameRequestData`

Defines the request payload for AdminSetDisplayName.

_Không có field public (payload rỗng)._

### SetPlayerBanRequestData

Defines the request payload for SetPlayerBan.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `tsExpire` | `long` | yes | Expiration timestamp of the ban (Unix timestamp); use a far-future value for a permanent ban. |
| `reason` | `string` | yes | Human-readable reason for the ban recorded on the backend. |

### ServerSetPlayerBanRequestData

Extends: `SetPlayerBanRequestData`

Defines the request payload for ServerSetPlayerBan.

_Không có field public (payload rỗng)._

### AdminSetPlayerBanRequestData

Extends: `ServerSetPlayerBanRequestData`

Defines the request payload for AdminSetPlayerBan.

_Không có field public (payload rỗng)._

### ChangePlayerCurrencyRequestData

Defines the request payload for ChangePlayerCurrency.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerCurrencies` | `List<PlayerCurrencyParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerCurrencyParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerChangePlayerCurrencyRequestData

Extends: `ChangePlayerCurrencyRequestData`

Defines the request payload for ServerChangePlayerCurrency.

_Không có field public (payload rỗng)._

### AdminChangePlayerCurrencyRequestData

Extends: `ServerChangePlayerCurrencyRequestData`

Defines the request payload for AdminChangePlayerCurrency.

_Không có field public (payload rỗng)._

### SetPlayerDataRequestData

Defines the request payload for SetPlayerData.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerDatas` | `List<PlayerDataParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerDataParam_ |

### ServerSetPlayerDataRequestData

Extends: `SetPlayerDataRequestData`

Defines the request payload for ServerSetPlayerData.

_Không có field public (payload rỗng)._

### AdminSetPlayerDataRequestData

Extends: `ServerSetPlayerDataRequestData`

Defines the request payload for AdminSetPlayerData.

_Không có field public (payload rỗng)._

### ChangePlayerStatisticsRequestData

Defines the request payload for ChangePlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerStatistics` | `List<PlayerStatisticsParam>` | yes | _minLength=1, maxLength=32, elementCls=PlayerStatisticsParam_ |
| `log` | `string?` | no | _minLength=1, maxLength=256_ |

### ServerChangePlayerStatisticsRequestData

Extends: `ChangePlayerStatisticsRequestData`

Defines the request payload for ServerChangePlayerStatistics.

_Không có field public (payload rỗng)._

### AdminChangePlayerStatisticsRequestData

Extends: `ServerChangePlayerStatisticsRequestData`

Defines the request payload for AdminChangePlayerStatistics.

_Không có field public (payload rỗng)._

### SetTagRequestData

Defines the request payload for SetTag.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerSetTagRequestData

Extends: `SetTagRequestData`

Defines the request payload for ServerSetTag.

_Không có field public (payload rỗng)._

### AdminSetTagRequestData

Extends: `ServerSetTagRequestData`

Defines the request payload for AdminSetTag.

_Không có field public (payload rỗng)._

### GetCurrencyLogRequestData

Reads currency change logs for the current or target game player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | yes | _minLength=1, maxLength=32, elementCls=String_ |
| `userId` | `string?` | yes | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | yes | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetCurrencyLogRequestData

Extends: `GetCurrencyLogRequestData`

Defines the request payload for ServerGetCurrencyLog.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLogRequestData

Extends: `ServerGetCurrencyLogRequestData`

Defines the request payload for AdminGetCurrencyLog.

_Không có field public (payload rỗng)._

### GetStatisticsLogRequestData

Reads statistic change logs for the current or target game player. Pagination is token-based rather than skip-based.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keys` | `List<string>?` | yes | _minLength=1, maxLength=32, elementCls=String_ |
| `userId` | `string?` | yes | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `token` | `string?` | yes | Continuation token returned by the previous page. — _minLength=24, maxLength=24_ |

### ServerGetStatisticsLogRequestData

Extends: `GetStatisticsLogRequestData`

Defines the request payload for ServerGetStatisticsLog.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLogRequestData

Extends: `ServerGetStatisticsLogRequestData`

Defines the request payload for AdminGetStatisticsLog.

_Không có field public (payload rỗng)._

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `segments` | `List<string>?` | no | Segment names currently assigned to the player. — _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | Custom data entries; present when `customDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the player; present when requested. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar descriptor; present when requested. |
| `tsCreate` | `long?` | no | Creation timestamp of the player account; present when requested. |
| `tags` | `List<GenericModels.TagItem>?` | no | Tag entries assigned to the player. — _elementCls=GenericModels.TagItem_ |
| `playerBan` | `GenericModels.BanItem?` | no | Ban state of the player; present when requested and a ban exists. |
| `playerDatas` | `List<GenericModels.DataItem>?` | no | Player data entries; present when `playerDatas` is enabled in `InfoRequestParam`. — _elementCls=GenericModels.DataItem_ |
| `playerCurrencies` | `List<GenericModels.CurrencyItem>?` | no | Currency balances; present when `playerCurrencies` is enabled. — _elementCls=GenericModels.CurrencyItem_ |
| `playerStatistics` | `List<GenericModels.StatisticsItem>?` | no | Statistics values; present when `playerStatistics` is enabled. — _elementCls=GenericModels.StatisticsItem_ |
| `playerCharacters` | `List<GenericModels.CharacterItem>?` | no | Lightweight relation items for owned character players, not full character snapshots. — _elementCls=GenericModels.CharacterItem_ |
| `playerInventories` | `List<GenericModels.InventoryItem>?` | no | Lightweight relation items for inventory owned by the player. — _elementCls=GenericModels.InventoryItem_ |
| `playerGroups` | `List<GenericModels.GroupItem>?` | no | Lightweight relation items for groups attached to the player. — _elementCls=GenericModels.GroupItem_ |
| `playerFriends` | `List<GenericModels.FriendItem>?` | no | Lightweight relation items for friends attached to the player. — _elementCls=GenericModels.FriendItem_ |
| `tsLastLogin` | `long?` | no | Timestamp of the player's last login; present when requested. |
| `ipAddressCreate` | `string?` | no | IP address recorded at account creation; present when requested. |
| `countryCode` | `string?` | no | Country code associated with the player; present when requested. |

### GamePlayerResponseData

Base game-player response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

### GamePlayerWithUserIdResponseData

Extends: `GamePlayerResponseData`

Game-player envelope that also exposes the resolved game-player user ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Game-player user identifier. |

### GamePlayerLeaderboardResponseData

Extends: `GamePlayerWithUserIdResponseData`

Defines the response payload for GamePlayerLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Zero-based leaderboard rank position of this player. |
| `backupValue` | `double?` | no | Backup statistic or currency value used as a tiebreaker when present. |

### GamePlayerLogResponseData

Defines the response payload for GamePlayerLog.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Game-player user ID this log entry belongs to. |
| `tsCreate` | `long` | yes | Timestamp when this log entry was recorded. |
| `log` | `string` | yes | Human-readable log message describing the change. |
| `key` | `string` | yes | Currency or statistics key that was changed. |
| `amount` | `double` | yes | Delta amount applied in this change. |
| `startValue` | `double` | yes | Value before the change was applied. |
| `finalValue` | `double` | yes | Value after the change was applied. |

### GetStatisticsLeaderboardResponseData

Defines the response payload for GetStatisticsLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | Ordered list of game-player leaderboard entries. — _elementCls=GamePlayerLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Timestamp when this leaderboard snapshot was last generated; present when available. |

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

### GetLastLoginLeaderboardResponseData

Defines the response payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLeaderboardResponseData>` | yes | _elementCls=GamePlayerLeaderboardResponseData_ |

### GamePlayersWithUserIdResponseData

Defines the response payload for GamePlayersWithUserId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerWithUserIdResponseData>` | yes | _elementCls=GamePlayerWithUserIdResponseData_ |

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetCurrencyLeaderboardRequestData

Extends: `GetCurrencyLeaderboardRequestData`

Defines the request payload for ServerGetCurrencyLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLeaderboardRequestData

Extends: `ServerGetCurrencyLeaderboardRequestData`

Defines the request payload for AdminGetCurrencyLeaderboard.

_Không có field public (payload rỗng)._

### GetLastLoginLeaderboardRequestData

Defines the request payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional player fields are included in the response. |
| `skip` | `int?` | no | _min=0, default=0_ |
| `limit` | `int?` | no | _min=1, max=100, default=10_ |
| `loadFromCache` | `bool?` | no | _default=true_ |

### ServerGetLastLoginLeaderboardRequestData

Extends: `GetLastLoginLeaderboardRequestData`

Defines the request payload for ServerGetLastLoginLeaderboard.

_Không có field public (payload rỗng)._

### AdminGetLastLoginLeaderboardRequestData

Extends: `ServerGetLastLoginLeaderboardRequestData`

Defines the request payload for AdminGetLastLoginLeaderboard.

_Không có field public (payload rỗng)._

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLogResponseData>` | yes | _elementCls=GamePlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<GamePlayerLogResponseData>` | yes | _elementCls=GamePlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `GamePlayerRequestModels`

### AddPlayerFriendOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.AddPlayerFriendRequestData>`

Maps the AddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddPlayerFriendOperationRequest

Extends: `AddPlayerFriendOperationRequest`

Maps the ServerAddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddPlayerFriendOperationRequest

Extends: `AddPlayerFriendOperationRequest`

Maps the AdminAddPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AddSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.AddSegmentRequestData>`

Maps the AddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddSegmentOperationRequest

Extends: `AddSegmentOperationRequest`

Maps the ServerAddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddSegmentOperationRequest

Extends: `AddSegmentOperationRequest`

Maps the AdminAddSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetAvatarRequestData>`

Maps the GetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetAvatarOperationRequest

Extends: `GetAvatarOperationRequest`

Maps the ServerGetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetAvatarOperationRequest

Extends: `GetAvatarOperationRequest`

Maps the AdminGetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCountryCodeOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetCountryCodeRequestData>`

Maps the GetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCountryCodeOperationRequest

Extends: `GetCountryCodeOperationRequest`

Maps the ServerGetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCountryCodeOperationRequest

Extends: `GetCountryCodeOperationRequest`

Maps the AdminGetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetCustomDataRequestData>`

Maps the GetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCustomDataOperationRequest

Extends: `GetCustomDataOperationRequest`

Maps the ServerGetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCustomDataOperationRequest

Extends: `GetCustomDataOperationRequest`

Maps the AdminGetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetDisplayNameRequestData>`

Maps the GetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetDisplayNameOperationRequest

Extends: `GetDisplayNameOperationRequest`

Maps the ServerGetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetDisplayNameOperationRequest

Extends: `GetDisplayNameOperationRequest`

Maps the AdminGetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData>`

Maps the GetFriendStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `GetFriendStatisticsLeaderboardAroundPlayerOperationRequest`

Maps the ServerGetFriendStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `GetFriendStatisticsLeaderboardAroundPlayerOperationRequest`

Maps the AdminGetFriendStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetFriendStatisticsLeaderboardRequestData>`

Maps the GetFriendStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetFriendStatisticsLeaderboardOperationRequest

Extends: `GetFriendStatisticsLeaderboardOperationRequest`

Maps the ServerGetFriendStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetFriendStatisticsLeaderboardOperationRequest

Extends: `GetFriendStatisticsLeaderboardOperationRequest`

Maps the AdminGetFriendStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetIpAddressCreateOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetIpAddressCreateRequestData>`

Maps the GetIpAddressCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetIpAddressCreateOperationRequest

Extends: `GetIpAddressCreateOperationRequest`

Maps the ServerGetIpAddressCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetIpAddressCreateOperationRequest

Extends: `GetIpAddressCreateOperationRequest`

Maps the AdminGetIpAddressCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerBanOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerBanRequestData>`

Maps the GetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerBanOperationRequest

Extends: `GetPlayerBanOperationRequest`

Maps the ServerGetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerBanOperationRequest

Extends: `GetPlayerBanOperationRequest`

Maps the AdminGetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerCharacterOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerCharacterRequestData>`

Maps the GetPlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerCharacterOperationRequest

Extends: `GetPlayerCharacterOperationRequest`

Maps the ServerGetPlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerCharacterOperationRequest

Extends: `GetPlayerCharacterOperationRequest`

Maps the AdminGetPlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerCurrencyOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerCurrencyRequestData>`

Maps the GetPlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerCurrencyOperationRequest

Extends: `GetPlayerCurrencyOperationRequest`

Maps the ServerGetPlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerCurrencyOperationRequest

Extends: `GetPlayerCurrencyOperationRequest`

Maps the AdminGetPlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerDataOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerDataRequestData>`

Maps the GetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerDataOperationRequest

Extends: `GetPlayerDataOperationRequest`

Maps the ServerGetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerDataOperationRequest

Extends: `GetPlayerDataOperationRequest`

Maps the AdminGetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerFriendOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerFriendRequestData>`

Maps the GetPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerFriendOperationRequest

Extends: `GetPlayerFriendOperationRequest`

Maps the ServerGetPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerFriendOperationRequest

Extends: `GetPlayerFriendOperationRequest`

Maps the AdminGetPlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerGroupOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerGroupRequestData>`

Maps the GetPlayerGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerGroupOperationRequest

Extends: `GetPlayerGroupOperationRequest`

Maps the ServerGetPlayerGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerGroupOperationRequest

Extends: `GetPlayerGroupOperationRequest`

Maps the AdminGetPlayerGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerInformationOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerInformationRequestData>`

Maps the GetPlayerInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerInformationOperationRequest

Extends: `GetPlayerInformationOperationRequest`

Maps the ServerGetPlayerInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerInformationOperationRequest

Extends: `GetPlayerInformationOperationRequest`

Maps the AdminGetPlayerInformation operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerInventoryOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerInventoryRequestData>`

Maps the GetPlayerInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerInventoryOperationRequest

Extends: `GetPlayerInventoryOperationRequest`

Maps the ServerGetPlayerInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerInventoryOperationRequest

Extends: `GetPlayerInventoryOperationRequest`

Maps the AdminGetPlayerInventory operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayerStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayerStatisticsRequestData>`

Maps the GetPlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayerStatisticsOperationRequest

Extends: `GetPlayerStatisticsOperationRequest`

Maps the ServerGetPlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayerStatisticsOperationRequest

Extends: `GetPlayerStatisticsOperationRequest`

Maps the AdminGetPlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayersWithDisplayNameRequestData>`

Maps the GetPlayersWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithDisplayNameOperationRequest

Extends: `GetPlayersWithDisplayNameOperationRequest`

Maps the ServerGetPlayersWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithDisplayNameOperationRequest

Extends: `GetPlayersWithDisplayNameOperationRequest`

Maps the AdminGetPlayersWithDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayersWithSegmentRequestData>`

Maps the GetPlayersWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithSegmentOperationRequest

Extends: `GetPlayersWithSegmentOperationRequest`

Maps the ServerGetPlayersWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithSegmentOperationRequest

Extends: `GetPlayersWithSegmentOperationRequest`

Maps the AdminGetPlayersWithSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithTagOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetPlayersWithTagRequestData>`

Maps the GetPlayersWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithTagOperationRequest

Extends: `GetPlayersWithTagOperationRequest`

Maps the ServerGetPlayersWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithTagOperationRequest

Extends: `GetPlayersWithTagOperationRequest`

Maps the AdminGetPlayersWithTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetSegmentRequestData>`

Maps the GetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetSegmentOperationRequest

Extends: `GetSegmentOperationRequest`

Maps the ServerGetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetSegmentOperationRequest

Extends: `GetSegmentOperationRequest`

Maps the AdminGetSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>`

Maps the GetStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `GetStatisticsLeaderboardAroundPlayerOperationRequest`

Maps the ServerGetStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardAroundPlayerOperationRequest

Extends: `GetStatisticsLeaderboardAroundPlayerOperationRequest`

Maps the AdminGetStatisticsLeaderboardAroundPlayer operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetStatisticsLeaderboardRequestData>`

Maps the GetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLeaderboardOperationRequest

Extends: `GetStatisticsLeaderboardOperationRequest`

Maps the ServerGetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLeaderboardOperationRequest

Extends: `GetStatisticsLeaderboardOperationRequest`

Maps the AdminGetStatisticsLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetTagRequestData>`

Maps the GetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetTagOperationRequest

Extends: `GetTagOperationRequest`

Maps the ServerGetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetTagOperationRequest

Extends: `GetTagOperationRequest`

Maps the AdminGetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetTsCreateRequestData>`

Maps the GetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetTsCreateOperationRequest

Extends: `GetTsCreateOperationRequest`

Maps the ServerGetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetTsCreateOperationRequest

Extends: `GetTsCreateOperationRequest`

Maps the AdminGetTsCreate operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetTsLastLoginOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetTsLastLoginRequestData>`

Maps the GetTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetTsLastLoginOperationRequest

Extends: `GetTsLastLoginOperationRequest`

Maps the ServerGetTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetTsLastLoginOperationRequest

Extends: `GetTsLastLoginOperationRequest`

Maps the AdminGetTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### CreateGroupOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.CreateGroupRequestData>`

Maps the CreateGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreateGroupOperationRequest

Extends: `CreateGroupOperationRequest`

Maps the ServerCreateGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreateGroupOperationRequest

Extends: `CreateGroupOperationRequest`

Maps the AdminCreateGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### CreatePlayerCharacterOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.CreatePlayerCharacterRequestData>`

Maps the CreatePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreatePlayerCharacterOperationRequest

Extends: `CreatePlayerCharacterOperationRequest`

Maps the ServerCreatePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreatePlayerCharacterOperationRequest

Extends: `CreatePlayerCharacterOperationRequest`

Maps the AdminCreatePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### CreatePlayerItemOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.CreatePlayerItemRequestData>`

Maps the CreatePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerCreatePlayerItemOperationRequest

Extends: `CreatePlayerItemOperationRequest`

Maps the ServerCreatePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminCreatePlayerItemOperationRequest

Extends: `CreatePlayerItemOperationRequest`

Maps the AdminCreatePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### JoinGroupOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.JoinGroupRequestData>`

Maps the JoinGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerJoinGroupOperationRequest

Extends: `JoinGroupOperationRequest`

Maps the ServerJoinGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminJoinGroupOperationRequest

Extends: `JoinGroupOperationRequest`

Maps the AdminJoinGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LeaveGroupOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.LeaveGroupRequestData>`

Maps the LeaveGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLeaveGroupOperationRequest

Extends: `LeaveGroupOperationRequest`

Maps the ServerLeaveGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLeaveGroupOperationRequest

Extends: `LeaveGroupOperationRequest`

Maps the AdminLeaveGroup operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerCharacterOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.RemovePlayerCharacterRequestData>`

Maps the RemovePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemovePlayerCharacterOperationRequest

Extends: `RemovePlayerCharacterOperationRequest`

Maps the ServerRemovePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemovePlayerCharacterOperationRequest

Extends: `RemovePlayerCharacterOperationRequest`

Maps the AdminRemovePlayerCharacter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerFriendOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.RemovePlayerFriendRequestData>`

Maps the RemovePlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemovePlayerFriendOperationRequest

Extends: `RemovePlayerFriendOperationRequest`

Maps the ServerRemovePlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemovePlayerFriendOperationRequest

Extends: `RemovePlayerFriendOperationRequest`

Maps the AdminRemovePlayerFriend operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerItemOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.RemovePlayerItemRequestData>`

Maps the RemovePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemovePlayerItemOperationRequest

Extends: `RemovePlayerItemOperationRequest`

Maps the ServerRemovePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemovePlayerItemOperationRequest

Extends: `RemovePlayerItemOperationRequest`

Maps the AdminRemovePlayerItem operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.RemoveSegmentRequestData>`

Maps the RemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveSegmentOperationRequest

Extends: `RemoveSegmentOperationRequest`

Maps the ServerRemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveSegmentOperationRequest

Extends: `RemoveSegmentOperationRequest`

Maps the AdminRemoveSegment operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.RemoveTagRequestData>`

Maps the RemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemoveTagOperationRequest

Extends: `RemoveTagOperationRequest`

Maps the ServerRemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemoveTagOperationRequest

Extends: `RemoveTagOperationRequest`

Maps the AdminRemoveTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetAvatarRequestData>`

Maps the SetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetAvatarOperationRequest

Extends: `SetAvatarOperationRequest`

Maps the ServerSetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetAvatarOperationRequest

Extends: `SetAvatarOperationRequest`

Maps the AdminSetAvatar operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetCountryCodeOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetCountryCodeRequestData>`

Maps the SetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetCountryCodeOperationRequest

Extends: `SetCountryCodeOperationRequest`

Maps the ServerSetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetCountryCodeOperationRequest

Extends: `SetCountryCodeOperationRequest`

Maps the AdminSetCountryCode operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetCustomDataRequestData>`

Maps the SetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetCustomDataOperationRequest

Extends: `SetCustomDataOperationRequest`

Maps the ServerSetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetCustomDataOperationRequest

Extends: `SetCustomDataOperationRequest`

Maps the AdminSetCustomData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetDisplayNameRequestData>`

Maps the SetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetDisplayNameOperationRequest

Extends: `SetDisplayNameOperationRequest`

Maps the ServerSetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetDisplayNameOperationRequest

Extends: `SetDisplayNameOperationRequest`

Maps the AdminSetDisplayName operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetPlayerBanOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetPlayerBanRequestData>`

Maps the SetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetPlayerBanOperationRequest

Extends: `SetPlayerBanOperationRequest`

Maps the ServerSetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetPlayerBanOperationRequest

Extends: `SetPlayerBanOperationRequest`

Maps the AdminSetPlayerBan operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerCurrencyOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.ChangePlayerCurrencyRequestData>`

Maps the ChangePlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerChangePlayerCurrencyOperationRequest

Extends: `ChangePlayerCurrencyOperationRequest`

Maps the ServerChangePlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminChangePlayerCurrencyOperationRequest

Extends: `ChangePlayerCurrencyOperationRequest`

Maps the AdminChangePlayerCurrency operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetPlayerDataOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetPlayerDataRequestData>`

Maps the SetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetPlayerDataOperationRequest

Extends: `SetPlayerDataOperationRequest`

Maps the ServerSetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetPlayerDataOperationRequest

Extends: `SetPlayerDataOperationRequest`

Maps the AdminSetPlayerData operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.ChangePlayerStatisticsRequestData>`

Maps the ChangePlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerChangePlayerStatisticsOperationRequest

Extends: `ChangePlayerStatisticsOperationRequest`

Maps the ServerChangePlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminChangePlayerStatisticsOperationRequest

Extends: `ChangePlayerStatisticsOperationRequest`

Maps the AdminChangePlayerStatistics operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.SetTagRequestData>`

Maps the SetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetTagOperationRequest

Extends: `SetTagOperationRequest`

Maps the ServerSetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetTagOperationRequest

Extends: `SetTagOperationRequest`

Maps the AdminSetTag operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetCurrencyLeaderboardRequestData>`

Maps the GetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCurrencyLeaderboardOperationRequest

Extends: `GetCurrencyLeaderboardOperationRequest`

Maps the ServerGetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLeaderboardOperationRequest

Extends: `GetCurrencyLeaderboardOperationRequest`

Maps the AdminGetCurrencyLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetLastLoginLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetLastLoginLeaderboardRequestData>`

Maps the GetLastLoginLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetLastLoginLeaderboardOperationRequest

Extends: `GetLastLoginLeaderboardOperationRequest`

Maps the ServerGetLastLoginLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetLastLoginLeaderboardOperationRequest

Extends: `GetLastLoginLeaderboardOperationRequest`

Maps the AdminGetLastLoginLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetCreateLeaderboardRequestData>`

Maps the GetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCreateLeaderboardOperationRequest

Extends: `GetCreateLeaderboardOperationRequest`

Maps the ServerGetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCreateLeaderboardOperationRequest

Extends: `GetCreateLeaderboardOperationRequest`

Maps the AdminGetCreateLeaderboard operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetStatisticsLogRequestData>`

Maps the GetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetStatisticsLogOperationRequest

Extends: `GetStatisticsLogOperationRequest`

Maps the ServerGetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetStatisticsLogOperationRequest

Extends: `GetStatisticsLogOperationRequest`

Maps the AdminGetStatisticsLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLogOperationRequest

Extends: `CustomOperationRequestAbstract<GamePlayerModels.GetCurrencyLogRequestData>`

Maps the GetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetCurrencyLogOperationRequest

Extends: `GetCurrencyLogOperationRequest`

Maps the ServerGetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetCurrencyLogOperationRequest

Extends: `GetCurrencyLogOperationRequest`

Maps the AdminGetCurrencyLog operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `GamePlayerResponseModels`

### AddPlayerFriendOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the AddPlayerFriend operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### AddSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the AddSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCountryCodeOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetCountryCode operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardAroundPlayerOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetFriendStatisticsLeaderboardAroundPlayer operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetFriendStatisticsLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetFriendStatisticsLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetIpAddressCreateOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetIpAddressCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerBanOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerBan operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerCharacterOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerCharacter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerDataOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerFriendOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerFriend operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerGroupOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerGroup operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerInformationOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerInventoryOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerInventory operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetPlayerStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayersWithUserIdResponseData>`

Maps the GetPlayersWithDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayersWithUserIdResponseData>`

Maps the GetPlayersWithSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithTagOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayersWithUserIdResponseData>`

Maps the GetPlayersWithTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundPlayerOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboardAroundPlayer operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetTsCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsLastLoginOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the GetTsLastLogin operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### CreateGroupOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the CreateGroup operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### CreatePlayerCharacterOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the CreatePlayerCharacter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### CreatePlayerItemOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the CreatePlayerItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### JoinGroupOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the JoinGroup operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LeaveGroupOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the LeaveGroup operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerCharacterOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the RemovePlayerCharacter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerFriendOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the RemovePlayerFriend operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemovePlayerItemOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the RemovePlayerItem operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the RemoveSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the RemoveTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the SetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCountryCodeOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the SetCountryCode operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the SetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the SetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetPlayerBanOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the SetPlayerBan operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the ChangePlayerCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetPlayerDataOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the SetPlayerData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GamePlayerResponseData>`

Maps the ChangePlayerStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.EmptyResponseData>`

Maps the SetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetCurrencyLeaderboardResponseData>`

Maps the GetCurrencyLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetLastLoginLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetLastLoginLeaderboardResponseData>`

Maps the GetLastLoginLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetCreateLeaderboardResponseData>`

Maps the GetCreateLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetStatisticsLogResponseData>`

Maps the GetStatisticsLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLogOperationResponse

Extends: `CustomOperationResponseAbstract<GamePlayerModels.GetCurrencyLogResponseData>`

Maps the GetCurrencyLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._
