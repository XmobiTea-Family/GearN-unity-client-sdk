# DTO Reference: MasterPlayer

Master-player account: identity linking, profile, contact info, external providers.

Related API reference: [API_MASTER_PLAYER.md](/docs/reference/API_MASTER_PLAYER.md).

Mỗi section bên dưới là 1 class DTO. Field table cho biết: tên field, TS type, `required`/optional, doc comment, ràng buộc length/range/default.

> **Cách dùng**: khi gọi `*Async()`, bạn truyền instance DTO (`new MasterPlayerModels.<Method>RequestData()`) với các field required (+ optional nếu cần). Response class expose `responseData` là instance của class `*ResponseData` tương ứng. Không dùng object literal cast — xem [RULES § 8.1](/docs/RULES.md#81-build-request-dto-trong-code-copy-paste).

> **Naming pattern**: Mỗi method có 3 variant DTO — `XxxRequestData` (client), `ServerXxxRequestData` (server), `AdminXxxRequestData` (admin). Variant `Server`/`Admin` thường thêm field bắt buộc như `userId`. Khi tìm DTO cho một route cụ thể, nhảy thẳng tới section `[Server|Admin]XxxRequestData` tương ứng — không cần đọc cả 3.

> **Server variant `userId` override**: Every `Server*RequestData` class overrides the parent's optional `userId?: string` with a required `userId: string` (via `public declare userId: string` with `mustNonNull: true`). Sections marked "Không có field public (payload rỗng)" for `Server*` variants mean no *new* fields — but `userId` changes from optional to **required** on those routes.

> Nếu cần sử dụng `GNArray` hoặc `GNHashtable` đọc [GNDATA.md](/docs/reference/GNDATA.md)

## Danh sách

- **MasterPlayerModels** (from `MasterPlayerModels.ts`)
    - [CustomDataParam](#customdataparam)
    - [InfoRequestParam](#inforequestparam)
    - [PlayerCurrencyParam](#playercurrencyparam)
    - [PlayerDataParam](#playerdataparam)
    - [PlayerStatisticsParam](#playerstatisticsparam)
    - [GenericService](#genericservice)
    - [Device](#device)
    - [Account](#account)
    - [Custom](#custom)
    - [Apple](#apple)
    - [Google](#google)
    - [Facebook](#facebook)
    - [GooglePlayGameService](#googleplaygameservice)
    - [GameCenter](#gamecenter)
    - [ExternalItem](#externalitem)
    - [AddSegmentRequestData](#addsegmentrequestdata)
    - [ServerAddSegmentRequestData](#serveraddsegmentrequestdata)
    - [AdminAddSegmentRequestData](#adminaddsegmentrequestdata)
    - [ChangeAccountPasswordRequestData](#changeaccountpasswordrequestdata)
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
    - [GetEmailRequestData](#getemailrequestdata)
    - [ServerGetEmailRequestData](#servergetemailrequestdata)
    - [AdminGetEmailRequestData](#admingetemailrequestdata)
    - [GetExternalRequestData](#getexternalrequestdata)
    - [ServerGetExternalRequestData](#servergetexternalrequestdata)
    - [AdminGetExternalRequestData](#admingetexternalrequestdata)
    - [GetIpAddressCreateRequestData](#getipaddresscreaterequestdata)
    - [ServerGetIpAddressCreateRequestData](#servergetipaddresscreaterequestdata)
    - [AdminGetIpAddressCreateRequestData](#admingetipaddresscreaterequestdata)
    - [GetPlayerBanRequestData](#getplayerbanrequestdata)
    - [ServerGetPlayerBanRequestData](#servergetplayerbanrequestdata)
    - [AdminGetPlayerBanRequestData](#admingetplayerbanrequestdata)
    - [GetPlayerCurrencyRequestData](#getplayercurrencyrequestdata)
    - [ServerGetPlayerCurrencyRequestData](#servergetplayercurrencyrequestdata)
    - [AdminGetPlayerCurrencyRequestData](#admingetplayercurrencyrequestdata)
    - [GetPlayerDataRequestData](#getplayerdatarequestdata)
    - [ServerGetPlayerDataRequestData](#servergetplayerdatarequestdata)
    - [AdminGetPlayerDataRequestData](#admingetplayerdatarequestdata)
    - [GetPlayerInformationRequestData](#getplayerinformationrequestdata)
    - [ServerGetPlayerInformationRequestData](#servergetplayerinformationrequestdata)
    - [AdminGetPlayerInformationRequestData](#admingetplayerinformationrequestdata)
    - [GetPlayerStatisticsRequestData](#getplayerstatisticsrequestdata)
    - [ServerGetPlayerStatisticsRequestData](#servergetplayerstatisticsrequestdata)
    - [AdminGetPlayerStatisticsRequestData](#admingetplayerstatisticsrequestdata)
    - [GetPlayersWithAppleRequestData](#getplayerswithapplerequestdata)
    - [ServerGetPlayersWithAppleRequestData](#servergetplayerswithapplerequestdata)
    - [AdminGetPlayersWithAppleRequestData](#admingetplayerswithapplerequestdata)
    - [GetPlayersWithDisplayNameRequestData](#getplayerswithdisplaynamerequestdata)
    - [ServerGetPlayersWithDisplayNameRequestData](#servergetplayerswithdisplaynamerequestdata)
    - [AdminGetPlayersWithDisplayNameRequestData](#admingetplayerswithdisplaynamerequestdata)
    - [GetPlayersWithFacebookRequestData](#getplayerswithfacebookrequestdata)
    - [ServerGetPlayersWithFacebookRequestData](#servergetplayerswithfacebookrequestdata)
    - [AdminGetPlayersWithFacebookRequestData](#admingetplayerswithfacebookrequestdata)
    - [GetPlayersWithGenericServiceRequestData](#getplayerswithgenericservicerequestdata)
    - [ServerGetPlayersWithGenericServiceRequestData](#servergetplayerswithgenericservicerequestdata)
    - [AdminGetPlayersWithGenericServiceRequestData](#admingetplayerswithgenericservicerequestdata)
    - [GetPlayersWithGoogleRequestData](#getplayerswithgooglerequestdata)
    - [ServerGetPlayersWithGoogleRequestData](#servergetplayerswithgooglerequestdata)
    - [AdminGetPlayersWithGoogleRequestData](#admingetplayerswithgooglerequestdata)
    - [GetPlayersWithGooglePlayGameServiceRequestData](#getplayerswithgoogleplaygameservicerequestdata)
    - [ServerGetPlayersWithGooglePlayGameServiceRequestData](#servergetplayerswithgoogleplaygameservicerequestdata)
    - [AdminGetPlayersWithGooglePlayGameServiceRequestData](#admingetplayerswithgoogleplaygameservicerequestdata)
    - [GetPlayersWithGameCenterRequestData](#getplayerswithgamecenterrequestdata)
    - [ServerGetPlayersWithGameCenterRequestData](#servergetplayerswithgamecenterrequestdata)
    - [AdminGetPlayersWithGameCenterRequestData](#admingetplayerswithgamecenterrequestdata)
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
    - [GetLastLoginLeaderboardRequestData](#getlastloginleaderboardrequestdata)
    - [ServerGetLastLoginLeaderboardRequestData](#servergetlastloginleaderboardrequestdata)
    - [AdminGetLastLoginLeaderboardRequestData](#admingetlastloginleaderboardrequestdata)
    - [GetTagRequestData](#gettagrequestdata)
    - [ServerGetTagRequestData](#servergettagrequestdata)
    - [AdminGetTagRequestData](#admingettagrequestdata)
    - [GetTsCreateRequestData](#gettscreaterequestdata)
    - [ServerGetTsCreateRequestData](#servergettscreaterequestdata)
    - [AdminGetTsCreateRequestData](#admingettscreaterequestdata)
    - [GetTsLastLoginRequestData](#gettslastloginrequestdata)
    - [ServerGetTsLastLoginRequestData](#servergettslastloginrequestdata)
    - [AdminGetTsLastLoginRequestData](#admingettslastloginrequestdata)
    - [LinkAccountRequestData](#linkaccountrequestdata)
    - [ServerLinkAccountRequestData](#serverlinkaccountrequestdata)
    - [AdminLinkAccountRequestData](#adminlinkaccountrequestdata)
    - [LinkAndroidDeviceIdRequestData](#linkandroiddeviceidrequestdata)
    - [ServerLinkAndroidDeviceIdRequestData](#serverlinkandroiddeviceidrequestdata)
    - [AdminLinkAndroidDeviceIdRequestData](#adminlinkandroiddeviceidrequestdata)
    - [LinkAppleRequestData](#linkapplerequestdata)
    - [ServerLinkAppleRequestData](#serverlinkapplerequestdata)
    - [AdminLinkAppleRequestData](#adminlinkapplerequestdata)
    - [LinkCustomDeviceIdRequestData](#linkcustomdeviceidrequestdata)
    - [ServerLinkCustomDeviceIdRequestData](#serverlinkcustomdeviceidrequestdata)
    - [AdminLinkCustomDeviceIdRequestData](#adminlinkcustomdeviceidrequestdata)
    - [LinkCustomIdRequestData](#linkcustomidrequestdata)
    - [ServerLinkCustomIdRequestData](#serverlinkcustomidrequestdata)
    - [AdminLinkCustomIdRequestData](#adminlinkcustomidrequestdata)
    - [LinkEditorDeviceIdRequestData](#linkeditordeviceidrequestdata)
    - [ServerLinkEditorDeviceIdRequestData](#serverlinkeditordeviceidrequestdata)
    - [AdminLinkEditorDeviceIdRequestData](#adminlinkeditordeviceidrequestdata)
    - [LinkFacebookRequestData](#linkfacebookrequestdata)
    - [ServerLinkFacebookRequestData](#serverlinkfacebookrequestdata)
    - [AdminLinkFacebookRequestData](#adminlinkfacebookrequestdata)
    - [LinkGenericServiceRequestData](#linkgenericservicerequestdata)
    - [ServerLinkGenericServiceRequestData](#serverlinkgenericservicerequestdata)
    - [AdminLinkGenericServiceRequestData](#adminlinkgenericservicerequestdata)
    - [LinkGoogleRequestData](#linkgooglerequestdata)
    - [ServerLinkGoogleRequestData](#serverlinkgooglerequestdata)
    - [AdminLinkGoogleRequestData](#adminlinkgooglerequestdata)
    - [LinkGooglePlayGameServiceRequestData](#linkgoogleplaygameservicerequestdata)
    - [ServerLinkGooglePlayGameServiceRequestData](#serverlinkgoogleplaygameservicerequestdata)
    - [AdminLinkGooglePlayGameServiceRequestData](#adminlinkgoogleplaygameservicerequestdata)
    - [LinkGameCenterRequestData](#linkgamecenterrequestdata)
    - [ServerLinkGameCenterRequestData](#serverlinkgamecenterrequestdata)
    - [AdminLinkGameCenterRequestData](#adminlinkgamecenterrequestdata)
    - [LinkiOSDeviceIdRequestData](#linkiosdeviceidrequestdata)
    - [ServerLinkiOSDeviceIdRequestData](#serverlinkiosdeviceidrequestdata)
    - [AdminLinkiOSDeviceIdRequestData](#adminlinkiosdeviceidrequestdata)
    - [LinkLinuxDeviceIdRequestData](#linklinuxdeviceidrequestdata)
    - [ServerLinkLinuxDeviceIdRequestData](#serverlinklinuxdeviceidrequestdata)
    - [AdminLinkLinuxDeviceIdRequestData](#adminlinklinuxdeviceidrequestdata)
    - [LinkMacOSDeviceIdRequestData](#linkmacosdeviceidrequestdata)
    - [ServerLinkMacOSDeviceIdRequestData](#serverlinkmacosdeviceidrequestdata)
    - [AdminLinkMacOSDeviceIdRequestData](#adminlinkmacosdeviceidrequestdata)
    - [LinkWindowsDeviceIdRequestData](#linkwindowsdeviceidrequestdata)
    - [ServerLinkWindowsDeviceIdRequestData](#serverlinkwindowsdeviceidrequestdata)
    - [AdminLinkWindowsDeviceIdRequestData](#adminlinkwindowsdeviceidrequestdata)
    - [LinkWindowsPhoneDeviceIdRequestData](#linkwindowsphonedeviceidrequestdata)
    - [ServerLinkWindowsPhoneDeviceIdRequestData](#serverlinkwindowsphonedeviceidrequestdata)
    - [AdminLinkWindowsPhoneDeviceIdRequestData](#adminlinkwindowsphonedeviceidrequestdata)
    - [RemoveSegmentRequestData](#removesegmentrequestdata)
    - [ServerRemoveSegmentRequestData](#serverremovesegmentrequestdata)
    - [AdminRemoveSegmentRequestData](#adminremovesegmentrequestdata)
    - [RemoveTagRequestData](#removetagrequestdata)
    - [ServerRemoveTagRequestData](#serverremovetagrequestdata)
    - [AdminRemoveTagRequestData](#adminremovetagrequestdata)
    - [ResetAccountPasswordRequestData](#resetaccountpasswordrequestdata)
    - [ServerResetAccountPasswordRequestData](#serverresetaccountpasswordrequestdata)
    - [AdminResetAccountPasswordRequestData](#adminresetaccountpasswordrequestdata)
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
    - [SetEmailRequestData](#setemailrequestdata)
    - [ServerSetEmailRequestData](#serversetemailrequestdata)
    - [AdminSetEmailRequestData](#adminsetemailrequestdata)
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
    - [UpdateTsLastLoginRequestData](#updatetslastloginrequestdata)
    - [ServerUpdateTsLastLoginRequestData](#serverupdatetslastloginrequestdata)
    - [AdminUpdateTsLastLoginRequestData](#adminupdatetslastloginrequestdata)
    - [UnlinkAccountRequestData](#unlinkaccountrequestdata)
    - [ServerUnlinkAccountRequestData](#serverunlinkaccountrequestdata)
    - [AdminUnlinkAccountRequestData](#adminunlinkaccountrequestdata)
    - [UnlinkAndroidDeviceIdRequestData](#unlinkandroiddeviceidrequestdata)
    - [ServerUnlinkAndroidDeviceIdRequestData](#serverunlinkandroiddeviceidrequestdata)
    - [AdminUnlinkAndroidDeviceIdRequestData](#adminunlinkandroiddeviceidrequestdata)
    - [UnlinkAppleRequestData](#unlinkapplerequestdata)
    - [ServerUnlinkAppleRequestData](#serverunlinkapplerequestdata)
    - [AdminUnlinkAppleRequestData](#adminunlinkapplerequestdata)
    - [UnlinkCustomDeviceIdRequestData](#unlinkcustomdeviceidrequestdata)
    - [ServerUnlinkCustomDeviceIdRequestData](#serverunlinkcustomdeviceidrequestdata)
    - [AdminUnlinkCustomDeviceIdRequestData](#adminunlinkcustomdeviceidrequestdata)
    - [UnlinkCustomIdRequestData](#unlinkcustomidrequestdata)
    - [ServerUnlinkCustomIdRequestData](#serverunlinkcustomidrequestdata)
    - [AdminUnlinkCustomIdRequestData](#adminunlinkcustomidrequestdata)
    - [UnlinkEditorDeviceIdRequestData](#unlinkeditordeviceidrequestdata)
    - [ServerUnlinkEditorDeviceIdRequestData](#serverunlinkeditordeviceidrequestdata)
    - [AdminUnlinkEditorDeviceIdRequestData](#adminunlinkeditordeviceidrequestdata)
    - [UnlinkFacebookRequestData](#unlinkfacebookrequestdata)
    - [ServerUnlinkFacebookRequestData](#serverunlinkfacebookrequestdata)
    - [AdminUnlinkFacebookRequestData](#adminunlinkfacebookrequestdata)
    - [UnlinkGenericServiceRequestData](#unlinkgenericservicerequestdata)
    - [ServerUnlinkGenericServiceRequestData](#serverunlinkgenericservicerequestdata)
    - [AdminUnlinkGenericServiceRequestData](#adminunlinkgenericservicerequestdata)
    - [UnlinkGoogleRequestData](#unlinkgooglerequestdata)
    - [ServerUnlinkGoogleRequestData](#serverunlinkgooglerequestdata)
    - [AdminUnlinkGoogleRequestData](#adminunlinkgooglerequestdata)
    - [UnlinkGooglePlayGameServiceRequestData](#unlinkgoogleplaygameservicerequestdata)
    - [ServerUnlinkGooglePlayGameServiceRequestData](#serverunlinkgoogleplaygameservicerequestdata)
    - [AdminUnlinkGooglePlayGameServiceRequestData](#adminunlinkgoogleplaygameservicerequestdata)
    - [UnlinkGameCenterRequestData](#unlinkgamecenterrequestdata)
    - [ServerUnlinkGameCenterRequestData](#serverunlinkgamecenterrequestdata)
    - [AdminUnlinkGameCenterRequestData](#adminunlinkgamecenterrequestdata)
    - [UnlinkiOSDeviceIdRequestData](#unlinkiosdeviceidrequestdata)
    - [ServerUnlinkiOSDeviceIdRequestData](#serverunlinkiosdeviceidrequestdata)
    - [AdminUnlinkiOSDeviceIdRequestData](#adminunlinkiosdeviceidrequestdata)
    - [UnlinkLinuxDeviceIdRequestData](#unlinklinuxdeviceidrequestdata)
    - [ServerUnlinkLinuxDeviceIdRequestData](#serverunlinklinuxdeviceidrequestdata)
    - [AdminUnlinkLinuxDeviceIdRequestData](#adminunlinklinuxdeviceidrequestdata)
    - [UnlinkMacOSDeviceIdRequestData](#unlinkmacosdeviceidrequestdata)
    - [ServerUnlinkMacOSDeviceIdRequestData](#serverunlinkmacosdeviceidrequestdata)
    - [AdminUnlinkMacOSDeviceIdRequestData](#adminunlinkmacosdeviceidrequestdata)
    - [UnlinkWindowsDeviceIdRequestData](#unlinkwindowsdeviceidrequestdata)
    - [ServerUnlinkWindowsDeviceIdRequestData](#serverunlinkwindowsdeviceidrequestdata)
    - [AdminUnlinkWindowsDeviceIdRequestData](#adminunlinkwindowsdeviceidrequestdata)
    - [UnlinkWindowsPhoneDeviceIdRequestData](#unlinkwindowsphonedeviceidrequestdata)
    - [ServerUnlinkWindowsPhoneDeviceIdRequestData](#serverunlinkwindowsphonedeviceidrequestdata)
    - [AdminUnlinkWindowsPhoneDeviceIdRequestData](#adminunlinkwindowsphonedeviceidrequestdata)
    - [SendSocketOperationEventRequestData](#sendsocketoperationeventrequestdata)
    - [ServerSendSocketOperationEventRequestData](#serversendsocketoperationeventrequestdata)
    - [AdminSendSocketOperationEventRequestData](#adminsendsocketoperationeventrequestdata)
    - [SendEmailRequestData](#sendemailrequestdata)
    - [ServerSendEmailRequestData](#serversendemailrequestdata)
    - [AdminSendEmailRequestData](#adminsendemailrequestdata)
    - [AddPushNotificationRequestData](#addpushnotificationrequestdata)
    - [ServerAddPushNotificationRequestData](#serveraddpushnotificationrequestdata)
    - [AdminAddPushNotificationRequestData](#adminaddpushnotificationrequestdata)
    - [GetPushNotificationRequestData](#getpushnotificationrequestdata)
    - [ServerGetPushNotificationRequestData](#servergetpushnotificationrequestdata)
    - [AdminGetPushNotificationRequestData](#admingetpushnotificationrequestdata)
    - [RemovePushNotificationRequestData](#removepushnotificationrequestdata)
    - [ServerRemovePushNotificationRequestData](#serverremovepushnotificationrequestdata)
    - [AdminRemovePushNotificationRequestData](#adminremovepushnotificationrequestdata)
    - [SendPushNotificationRequestData](#sendpushnotificationrequestdata)
    - [ServerSendPushNotificationRequestData](#serversendpushnotificationrequestdata)
    - [AdminSendPushNotificationRequestData](#adminsendpushnotificationrequestdata)
    - [GetOnlineStatusRequestData](#getonlinestatusrequestdata)
    - [ServerGetOnlineStatusRequestData](#servergetonlinestatusrequestdata)
    - [AdminGetOnlineStatusRequestData](#admingetonlinestatusrequestdata)
    - [PushNotificationItem](#pushnotificationitem)
    - [InfoResponseParameters](#inforesponseparameters)
    - [OnlineStatusItem](#onlinestatusitem)
    - [MasterPlayerResponseData](#masterplayerresponsedata)
    - [GenericServiceMasterPlayerResponseData](#genericservicemasterplayerresponsedata)
    - [MasterPlayerWithUserIdResponseData](#masterplayerwithuseridresponsedata)
    - [MasterPlayerWithAppleIdResponseData](#masterplayerwithappleidresponsedata)
    - [GetPlayersWithAppleResponseData](#getplayerswithappleresponsedata)
    - [MasterPlayersWithUserIdResponseData](#masterplayerswithuseridresponsedata)
    - [MasterPlayerWithFacebookIdResponseData](#masterplayerwithfacebookidresponsedata)
    - [GetPlayersWithFacebookResponseData](#getplayerswithfacebookresponsedata)
    - [MasterPlayerWithGenericServiceIdResponseData](#masterplayerwithgenericserviceidresponsedata)
    - [GetPlayersWithGenericServiceResponseData](#getplayerswithgenericserviceresponsedata)
    - [MasterPlayerWithGoogleIdResponseData](#masterplayerwithgoogleidresponsedata)
    - [GetPlayersWithGoogleResponseData](#getplayerswithgoogleresponsedata)
    - [MasterPlayerWithPlayerIdResponseData](#masterplayerwithplayeridresponsedata)
    - [GetPlayersWithGooglePlayGameServiceResponseData](#getplayerswithgoogleplaygameserviceresponsedata)
    - [GetPlayersWithGameCenterResponseData](#getplayerswithgamecenterresponsedata)
    - [MasterPlayerLeaderboardResponseData](#masterplayerleaderboardresponsedata)
    - [MasterPlayerLogResponseData](#masterplayerlogresponsedata)
    - [GetStatisticsLeaderboardResponseData](#getstatisticsleaderboardresponsedata)
    - [GetCurrencyLeaderboardResponseData](#getcurrencyleaderboardresponsedata)
    - [GetCreateLeaderboardResponseData](#getcreateleaderboardresponsedata)
    - [GetLastLoginLeaderboardResponseData](#getlastloginleaderboardresponsedata)
    - [GetCurrencyLeaderboardRequestData](#getcurrencyleaderboardrequestdata)
    - [ServerGetCurrencyLeaderboardRequestData](#servergetcurrencyleaderboardrequestdata)
    - [AdminGetCurrencyLeaderboardRequestData](#admingetcurrencyleaderboardrequestdata)
    - [GetStatisticsLogResponseData](#getstatisticslogresponsedata)
    - [GetCurrencyLogResponseData](#getcurrencylogresponsedata)
    - [AddPushNotificationResponseData](#addpushnotificationresponsedata)
    - [SendPushNotificationResponseData](#sendpushnotificationresponsedata)
    - [EmptyResponseData](#emptyresponsedata)
- **MasterPlayerRequestModels** (from `MasterPlayerRequestModels.ts`)
    - [AddSegmentOperationRequest](#addsegmentoperationrequest)
    - [ServerAddSegmentOperationRequest](#serveraddsegmentoperationrequest)
    - [AdminAddSegmentOperationRequest](#adminaddsegmentoperationrequest)
    - [ChangeAccountPasswordOperationRequest](#changeaccountpasswordoperationrequest)
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
    - [GetEmailOperationRequest](#getemailoperationrequest)
    - [ServerGetEmailOperationRequest](#servergetemailoperationrequest)
    - [AdminGetEmailOperationRequest](#admingetemailoperationrequest)
    - [GetExternalOperationRequest](#getexternaloperationrequest)
    - [ServerGetExternalOperationRequest](#servergetexternaloperationrequest)
    - [AdminGetExternalOperationRequest](#admingetexternaloperationrequest)
    - [GetIpAddressCreateOperationRequest](#getipaddresscreateoperationrequest)
    - [ServerGetIpAddressCreateOperationRequest](#servergetipaddresscreateoperationrequest)
    - [AdminGetIpAddressCreateOperationRequest](#admingetipaddresscreateoperationrequest)
    - [GetPlayerBanOperationRequest](#getplayerbanoperationrequest)
    - [ServerGetPlayerBanOperationRequest](#servergetplayerbanoperationrequest)
    - [AdminGetPlayerBanOperationRequest](#admingetplayerbanoperationrequest)
    - [GetPlayerCurrencyOperationRequest](#getplayercurrencyoperationrequest)
    - [ServerGetPlayerCurrencyOperationRequest](#servergetplayercurrencyoperationrequest)
    - [AdminGetPlayerCurrencyOperationRequest](#admingetplayercurrencyoperationrequest)
    - [GetPlayerDataOperationRequest](#getplayerdataoperationrequest)
    - [ServerGetPlayerDataOperationRequest](#servergetplayerdataoperationrequest)
    - [AdminGetPlayerDataOperationRequest](#admingetplayerdataoperationrequest)
    - [GetPlayerInformationOperationRequest](#getplayerinformationoperationrequest)
    - [ServerGetPlayerInformationOperationRequest](#servergetplayerinformationoperationrequest)
    - [AdminGetPlayerInformationOperationRequest](#admingetplayerinformationoperationrequest)
    - [GetPlayerStatisticsOperationRequest](#getplayerstatisticsoperationrequest)
    - [ServerGetPlayerStatisticsOperationRequest](#servergetplayerstatisticsoperationrequest)
    - [AdminGetPlayerStatisticsOperationRequest](#admingetplayerstatisticsoperationrequest)
    - [GetPlayersWithAppleOperationRequest](#getplayerswithappleoperationrequest)
    - [ServerGetPlayersWithAppleOperationRequest](#servergetplayerswithappleoperationrequest)
    - [AdminGetPlayersWithAppleOperationRequest](#admingetplayerswithappleoperationrequest)
    - [GetPlayersWithDisplayNameOperationRequest](#getplayerswithdisplaynameoperationrequest)
    - [ServerGetPlayersWithDisplayNameOperationRequest](#servergetplayerswithdisplaynameoperationrequest)
    - [AdminGetPlayersWithDisplayNameOperationRequest](#admingetplayerswithdisplaynameoperationrequest)
    - [GetPlayersWithFacebookOperationRequest](#getplayerswithfacebookoperationrequest)
    - [ServerGetPlayersWithFacebookOperationRequest](#servergetplayerswithfacebookoperationrequest)
    - [AdminGetPlayersWithFacebookOperationRequest](#admingetplayerswithfacebookoperationrequest)
    - [GetPlayersWithGenericServiceOperationRequest](#getplayerswithgenericserviceoperationrequest)
    - [ServerGetPlayersWithGenericServiceOperationRequest](#servergetplayerswithgenericserviceoperationrequest)
    - [AdminGetPlayersWithGenericServiceOperationRequest](#admingetplayerswithgenericserviceoperationrequest)
    - [GetPlayersWithGoogleOperationRequest](#getplayerswithgoogleoperationrequest)
    - [ServerGetPlayersWithGoogleOperationRequest](#servergetplayerswithgoogleoperationrequest)
    - [AdminGetPlayersWithGoogleOperationRequest](#admingetplayerswithgoogleoperationrequest)
    - [GetPlayersWithGooglePlayGameServiceOperationRequest](#getplayerswithgoogleplaygameserviceoperationrequest)
    - [ServerGetPlayersWithGooglePlayGameServiceOperationRequest](#servergetplayerswithgoogleplaygameserviceoperationrequest)
    - [AdminGetPlayersWithGooglePlayGameServiceOperationRequest](#admingetplayerswithgoogleplaygameserviceoperationrequest)
    - [GetPlayersWithGameCenterOperationRequest](#getplayerswithgamecenteroperationrequest)
    - [ServerGetPlayersWithGameCenterOperationRequest](#servergetplayerswithgamecenteroperationrequest)
    - [AdminGetPlayersWithGameCenterOperationRequest](#admingetplayerswithgamecenteroperationrequest)
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
    - [LinkAccountOperationRequest](#linkaccountoperationrequest)
    - [ServerLinkAccountOperationRequest](#serverlinkaccountoperationrequest)
    - [AdminLinkAccountOperationRequest](#adminlinkaccountoperationrequest)
    - [LinkAndroidDeviceIdOperationRequest](#linkandroiddeviceidoperationrequest)
    - [ServerLinkAndroidDeviceIdOperationRequest](#serverlinkandroiddeviceidoperationrequest)
    - [AdminLinkAndroidDeviceIdOperationRequest](#adminlinkandroiddeviceidoperationrequest)
    - [LinkAppleOperationRequest](#linkappleoperationrequest)
    - [ServerLinkAppleOperationRequest](#serverlinkappleoperationrequest)
    - [AdminLinkAppleOperationRequest](#adminlinkappleoperationrequest)
    - [LinkCustomDeviceIdOperationRequest](#linkcustomdeviceidoperationrequest)
    - [ServerLinkCustomDeviceIdOperationRequest](#serverlinkcustomdeviceidoperationrequest)
    - [AdminLinkCustomDeviceIdOperationRequest](#adminlinkcustomdeviceidoperationrequest)
    - [LinkCustomIdOperationRequest](#linkcustomidoperationrequest)
    - [ServerLinkCustomIdOperationRequest](#serverlinkcustomidoperationrequest)
    - [AdminLinkCustomIdOperationRequest](#adminlinkcustomidoperationrequest)
    - [LinkEditorDeviceIdOperationRequest](#linkeditordeviceidoperationrequest)
    - [ServerLinkEditorDeviceIdOperationRequest](#serverlinkeditordeviceidoperationrequest)
    - [AdminLinkEditorDeviceIdOperationRequest](#adminlinkeditordeviceidoperationrequest)
    - [LinkFacebookOperationRequest](#linkfacebookoperationrequest)
    - [ServerLinkFacebookOperationRequest](#serverlinkfacebookoperationrequest)
    - [AdminLinkFacebookOperationRequest](#adminlinkfacebookoperationrequest)
    - [LinkGenericServiceOperationRequest](#linkgenericserviceoperationrequest)
    - [ServerLinkGenericServiceOperationRequest](#serverlinkgenericserviceoperationrequest)
    - [AdminLinkGenericServiceOperationRequest](#adminlinkgenericserviceoperationrequest)
    - [LinkGoogleOperationRequest](#linkgoogleoperationrequest)
    - [ServerLinkGoogleOperationRequest](#serverlinkgoogleoperationrequest)
    - [AdminLinkGoogleOperationRequest](#adminlinkgoogleoperationrequest)
    - [LinkGooglePlayGameServiceOperationRequest](#linkgoogleplaygameserviceoperationrequest)
    - [ServerLinkGooglePlayGameServiceOperationRequest](#serverlinkgoogleplaygameserviceoperationrequest)
    - [AdminLinkGooglePlayGameServiceOperationRequest](#adminlinkgoogleplaygameserviceoperationrequest)
    - [LinkGameCenterOperationRequest](#linkgamecenteroperationrequest)
    - [ServerLinkGameCenterOperationRequest](#serverlinkgamecenteroperationrequest)
    - [AdminLinkGameCenterOperationRequest](#adminlinkgamecenteroperationrequest)
    - [LinkiOSDeviceIdOperationRequest](#linkiosdeviceidoperationrequest)
    - [ServerLinkiOSDeviceIdOperationRequest](#serverlinkiosdeviceidoperationrequest)
    - [AdminLinkiOSDeviceIdOperationRequest](#adminlinkiosdeviceidoperationrequest)
    - [LinkLinuxDeviceIdOperationRequest](#linklinuxdeviceidoperationrequest)
    - [ServerLinkLinuxDeviceIdOperationRequest](#serverlinklinuxdeviceidoperationrequest)
    - [AdminLinkLinuxDeviceIdOperationRequest](#adminlinklinuxdeviceidoperationrequest)
    - [LinkMacOSDeviceIdOperationRequest](#linkmacosdeviceidoperationrequest)
    - [ServerLinkMacOSDeviceIdOperationRequest](#serverlinkmacosdeviceidoperationrequest)
    - [AdminLinkMacOSDeviceIdOperationRequest](#adminlinkmacosdeviceidoperationrequest)
    - [LinkWindowsDeviceIdOperationRequest](#linkwindowsdeviceidoperationrequest)
    - [ServerLinkWindowsDeviceIdOperationRequest](#serverlinkwindowsdeviceidoperationrequest)
    - [AdminLinkWindowsDeviceIdOperationRequest](#adminlinkwindowsdeviceidoperationrequest)
    - [LinkWindowsPhoneDeviceIdOperationRequest](#linkwindowsphonedeviceidoperationrequest)
    - [ServerLinkWindowsPhoneDeviceIdOperationRequest](#serverlinkwindowsphonedeviceidoperationrequest)
    - [AdminLinkWindowsPhoneDeviceIdOperationRequest](#adminlinkwindowsphonedeviceidoperationrequest)
    - [RemoveSegmentOperationRequest](#removesegmentoperationrequest)
    - [ServerRemoveSegmentOperationRequest](#serverremovesegmentoperationrequest)
    - [AdminRemoveSegmentOperationRequest](#adminremovesegmentoperationrequest)
    - [RemoveTagOperationRequest](#removetagoperationrequest)
    - [ServerRemoveTagOperationRequest](#serverremovetagoperationrequest)
    - [AdminRemoveTagOperationRequest](#adminremovetagoperationrequest)
    - [ResetAccountPasswordOperationRequest](#resetaccountpasswordoperationrequest)
    - [ServerResetAccountPasswordOperationRequest](#serverresetaccountpasswordoperationrequest)
    - [AdminResetAccountPasswordOperationRequest](#adminresetaccountpasswordoperationrequest)
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
    - [SetEmailOperationRequest](#setemailoperationrequest)
    - [ServerSetEmailOperationRequest](#serversetemailoperationrequest)
    - [AdminSetEmailOperationRequest](#adminsetemailoperationrequest)
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
    - [UpdateTsLastLoginOperationRequest](#updatetslastloginoperationrequest)
    - [ServerUpdateTsLastLoginOperationRequest](#serverupdatetslastloginoperationrequest)
    - [AdminUpdateTsLastLoginOperationRequest](#adminupdatetslastloginoperationrequest)
    - [UnlinkAccountOperationRequest](#unlinkaccountoperationrequest)
    - [ServerUnlinkAccountOperationRequest](#serverunlinkaccountoperationrequest)
    - [AdminUnlinkAccountOperationRequest](#adminunlinkaccountoperationrequest)
    - [UnlinkAndroidDeviceIdOperationRequest](#unlinkandroiddeviceidoperationrequest)
    - [ServerUnlinkAndroidDeviceIdOperationRequest](#serverunlinkandroiddeviceidoperationrequest)
    - [AdminUnlinkAndroidDeviceIdOperationRequest](#adminunlinkandroiddeviceidoperationrequest)
    - [UnlinkAppleOperationRequest](#unlinkappleoperationrequest)
    - [ServerUnlinkAppleOperationRequest](#serverunlinkappleoperationrequest)
    - [AdminUnlinkAppleOperationRequest](#adminunlinkappleoperationrequest)
    - [UnlinkCustomDeviceIdOperationRequest](#unlinkcustomdeviceidoperationrequest)
    - [ServerUnlinkCustomDeviceIdOperationRequest](#serverunlinkcustomdeviceidoperationrequest)
    - [AdminUnlinkCustomDeviceIdOperationRequest](#adminunlinkcustomdeviceidoperationrequest)
    - [UnlinkCustomIdOperationRequest](#unlinkcustomidoperationrequest)
    - [ServerUnlinkCustomIdOperationRequest](#serverunlinkcustomidoperationrequest)
    - [AdminUnlinkCustomIdOperationRequest](#adminunlinkcustomidoperationrequest)
    - [UnlinkEditorDeviceIdOperationRequest](#unlinkeditordeviceidoperationrequest)
    - [ServerUnlinkEditorDeviceIdOperationRequest](#serverunlinkeditordeviceidoperationrequest)
    - [AdminUnlinkEditorDeviceIdOperationRequest](#adminunlinkeditordeviceidoperationrequest)
    - [UnlinkFacebookOperationRequest](#unlinkfacebookoperationrequest)
    - [ServerUnlinkFacebookOperationRequest](#serverunlinkfacebookoperationrequest)
    - [AdminUnlinkFacebookOperationRequest](#adminunlinkfacebookoperationrequest)
    - [UnlinkGenericServiceOperationRequest](#unlinkgenericserviceoperationrequest)
    - [ServerUnlinkGenericServiceOperationRequest](#serverunlinkgenericserviceoperationrequest)
    - [AdminUnlinkGenericServiceOperationRequest](#adminunlinkgenericserviceoperationrequest)
    - [UnlinkGoogleOperationRequest](#unlinkgoogleoperationrequest)
    - [ServerUnlinkGoogleOperationRequest](#serverunlinkgoogleoperationrequest)
    - [AdminUnlinkGoogleOperationRequest](#adminunlinkgoogleoperationrequest)
    - [UnlinkGooglePlayGameServiceOperationRequest](#unlinkgoogleplaygameserviceoperationrequest)
    - [ServerUnlinkGooglePlayGameServiceOperationRequest](#serverunlinkgoogleplaygameserviceoperationrequest)
    - [AdminUnlinkGooglePlayGameServiceOperationRequest](#adminunlinkgoogleplaygameserviceoperationrequest)
    - [UnlinkGameCenterOperationRequest](#unlinkgamecenteroperationrequest)
    - [ServerUnlinkGameCenterOperationRequest](#serverunlinkgamecenteroperationrequest)
    - [AdminUnlinkGameCenterOperationRequest](#adminunlinkgamecenteroperationrequest)
    - [UnlinkiOSDeviceIdOperationRequest](#unlinkiosdeviceidoperationrequest)
    - [ServerUnlinkiOSDeviceIdOperationRequest](#serverunlinkiosdeviceidoperationrequest)
    - [AdminUnlinkiOSDeviceIdOperationRequest](#adminunlinkiosdeviceidoperationrequest)
    - [UnlinkLinuxDeviceIdOperationRequest](#unlinklinuxdeviceidoperationrequest)
    - [ServerUnlinkLinuxDeviceIdOperationRequest](#serverunlinklinuxdeviceidoperationrequest)
    - [AdminUnlinkLinuxDeviceIdOperationRequest](#adminunlinklinuxdeviceidoperationrequest)
    - [UnlinkMacOSDeviceIdOperationRequest](#unlinkmacosdeviceidoperationrequest)
    - [ServerUnlinkMacOSDeviceIdOperationRequest](#serverunlinkmacosdeviceidoperationrequest)
    - [AdminUnlinkMacOSDeviceIdOperationRequest](#adminunlinkmacosdeviceidoperationrequest)
    - [UnlinkWindowsDeviceIdOperationRequest](#unlinkwindowsdeviceidoperationrequest)
    - [ServerUnlinkWindowsDeviceIdOperationRequest](#serverunlinkwindowsdeviceidoperationrequest)
    - [AdminUnlinkWindowsDeviceIdOperationRequest](#adminunlinkwindowsdeviceidoperationrequest)
    - [UnlinkWindowsPhoneDeviceIdOperationRequest](#unlinkwindowsphonedeviceidoperationrequest)
    - [ServerUnlinkWindowsPhoneDeviceIdOperationRequest](#serverunlinkwindowsphonedeviceidoperationrequest)
    - [AdminUnlinkWindowsPhoneDeviceIdOperationRequest](#adminunlinkwindowsphonedeviceidoperationrequest)
    - [GetCurrencyLeaderboardOperationRequest](#getcurrencyleaderboardoperationrequest)
    - [ServerGetCurrencyLeaderboardOperationRequest](#servergetcurrencyleaderboardoperationrequest)
    - [AdminGetCurrencyLeaderboardOperationRequest](#admingetcurrencyleaderboardoperationrequest)
    - [GetCreateLeaderboardOperationRequest](#getcreateleaderboardoperationrequest)
    - [ServerGetCreateLeaderboardOperationRequest](#servergetcreateleaderboardoperationrequest)
    - [AdminGetCreateLeaderboardOperationRequest](#admingetcreateleaderboardoperationrequest)
    - [GetLastLoginLeaderboardOperationRequest](#getlastloginleaderboardoperationrequest)
    - [ServerGetLastLoginLeaderboardOperationRequest](#servergetlastloginleaderboardoperationrequest)
    - [AdminGetLastLoginLeaderboardOperationRequest](#admingetlastloginleaderboardoperationrequest)
    - [GetStatisticsLogOperationRequest](#getstatisticslogoperationrequest)
    - [ServerGetStatisticsLogOperationRequest](#servergetstatisticslogoperationrequest)
    - [AdminGetStatisticsLogOperationRequest](#admingetstatisticslogoperationrequest)
    - [GetCurrencyLogOperationRequest](#getcurrencylogoperationrequest)
    - [ServerGetCurrencyLogOperationRequest](#servergetcurrencylogoperationrequest)
    - [AdminGetCurrencyLogOperationRequest](#admingetcurrencylogoperationrequest)
    - [SendSocketOperationEventOperationRequest](#sendsocketoperationeventoperationrequest)
    - [ServerSendSocketOperationEventOperationRequest](#serversendsocketoperationeventoperationrequest)
    - [AdminSendSocketOperationEventOperationRequest](#adminsendsocketoperationeventoperationrequest)
    - [SendEmailOperationRequest](#sendemailoperationrequest)
    - [ServerSendEmailOperationRequest](#serversendemailoperationrequest)
    - [AdminSendEmailOperationRequest](#adminsendemailoperationrequest)
    - [AddPushNotificationOperationRequest](#addpushnotificationoperationrequest)
    - [ServerAddPushNotificationOperationRequest](#serveraddpushnotificationoperationrequest)
    - [AdminAddPushNotificationOperationRequest](#adminaddpushnotificationoperationrequest)
    - [RemovePushNotificationOperationRequest](#removepushnotificationoperationrequest)
    - [ServerRemovePushNotificationOperationRequest](#serverremovepushnotificationoperationrequest)
    - [AdminRemovePushNotificationOperationRequest](#adminremovepushnotificationoperationrequest)
    - [GetPushNotificationOperationRequest](#getpushnotificationoperationrequest)
    - [ServerGetPushNotificationOperationRequest](#servergetpushnotificationoperationrequest)
    - [AdminGetPushNotificationOperationRequest](#admingetpushnotificationoperationrequest)
    - [SendPushNotificationOperationRequest](#sendpushnotificationoperationrequest)
    - [ServerSendPushNotificationOperationRequest](#serversendpushnotificationoperationrequest)
    - [AdminSendPushNotificationOperationRequest](#adminsendpushnotificationoperationrequest)
    - [GetOnlineStatusOperationRequest](#getonlinestatusoperationrequest)
    - [ServerGetOnlineStatusOperationRequest](#servergetonlinestatusoperationrequest)
    - [AdminGetOnlineStatusOperationRequest](#admingetonlinestatusoperationrequest)
- **MasterPlayerResponseModels** (from `MasterPlayerResponseModels.ts`)
    - [AddSegmentOperationResponse](#addsegmentoperationresponse)
    - [ChangeAccountPasswordOperationResponse](#changeaccountpasswordoperationresponse)
    - [GetAvatarOperationResponse](#getavataroperationresponse)
    - [GetCountryCodeOperationResponse](#getcountrycodeoperationresponse)
    - [GetCustomDataOperationResponse](#getcustomdataoperationresponse)
    - [GetDisplayNameOperationResponse](#getdisplaynameoperationresponse)
    - [GetEmailOperationResponse](#getemailoperationresponse)
    - [GetExternalOperationResponse](#getexternaloperationresponse)
    - [GetIpAddressCreateOperationResponse](#getipaddresscreateoperationresponse)
    - [GetPlayerBanOperationResponse](#getplayerbanoperationresponse)
    - [GetPlayerCurrencyOperationResponse](#getplayercurrencyoperationresponse)
    - [GetPlayerDataOperationResponse](#getplayerdataoperationresponse)
    - [GetPlayerInformationOperationResponse](#getplayerinformationoperationresponse)
    - [GetPlayerStatisticsOperationResponse](#getplayerstatisticsoperationresponse)
    - [GetPlayersWithAppleOperationResponse](#getplayerswithappleoperationresponse)
    - [GetPlayersWithDisplayNameOperationResponse](#getplayerswithdisplaynameoperationresponse)
    - [GetPlayersWithFacebookOperationResponse](#getplayerswithfacebookoperationresponse)
    - [GetPlayersWithGenericServiceOperationResponse](#getplayerswithgenericserviceoperationresponse)
    - [GetPlayersWithGoogleOperationResponse](#getplayerswithgoogleoperationresponse)
    - [GetPlayersWithGooglePlayGameServiceOperationResponse](#getplayerswithgoogleplaygameserviceoperationresponse)
    - [GetPlayersWithGameCenterOperationResponse](#getplayerswithgamecenteroperationresponse)
    - [GetPlayersWithSegmentOperationResponse](#getplayerswithsegmentoperationresponse)
    - [GetPlayersWithTagOperationResponse](#getplayerswithtagoperationresponse)
    - [GetSegmentOperationResponse](#getsegmentoperationresponse)
    - [GetStatisticsLeaderboardAroundPlayerOperationResponse](#getstatisticsleaderboardaroundplayeroperationresponse)
    - [GetStatisticsLeaderboardOperationResponse](#getstatisticsleaderboardoperationresponse)
    - [GetTagOperationResponse](#gettagoperationresponse)
    - [GetTsCreateOperationResponse](#gettscreateoperationresponse)
    - [GetTsLastLoginOperationResponse](#gettslastloginoperationresponse)
    - [LinkAccountOperationResponse](#linkaccountoperationresponse)
    - [LinkAndroidDeviceIdOperationResponse](#linkandroiddeviceidoperationresponse)
    - [LinkAppleOperationResponse](#linkappleoperationresponse)
    - [LinkCustomDeviceIdOperationResponse](#linkcustomdeviceidoperationresponse)
    - [LinkCustomIdOperationResponse](#linkcustomidoperationresponse)
    - [LinkEditorDeviceIdOperationResponse](#linkeditordeviceidoperationresponse)
    - [LinkFacebookOperationResponse](#linkfacebookoperationresponse)
    - [LinkGenericServiceOperationResponse](#linkgenericserviceoperationresponse)
    - [LinkGoogleOperationResponse](#linkgoogleoperationresponse)
    - [LinkGooglePlayGameServiceOperationResponse](#linkgoogleplaygameserviceoperationresponse)
    - [LinkGameCenterOperationResponse](#linkgamecenteroperationresponse)
    - [LinkiOSDeviceIdOperationResponse](#linkiosdeviceidoperationresponse)
    - [LinkLinuxDeviceIdOperationResponse](#linklinuxdeviceidoperationresponse)
    - [LinkMacOSDeviceIdOperationResponse](#linkmacosdeviceidoperationresponse)
    - [LinkWindowsDeviceIdOperationResponse](#linkwindowsdeviceidoperationresponse)
    - [LinkWindowsPhoneDeviceIdOperationResponse](#linkwindowsphonedeviceidoperationresponse)
    - [RemoveSegmentOperationResponse](#removesegmentoperationresponse)
    - [RemoveTagOperationResponse](#removetagoperationresponse)
    - [ResetAccountPasswordOperationResponse](#resetaccountpasswordoperationresponse)
    - [SetAvatarOperationResponse](#setavataroperationresponse)
    - [SetCountryCodeOperationResponse](#setcountrycodeoperationresponse)
    - [SetCustomDataOperationResponse](#setcustomdataoperationresponse)
    - [SetDisplayNameOperationResponse](#setdisplaynameoperationresponse)
    - [SetEmailOperationResponse](#setemailoperationresponse)
    - [SetPlayerBanOperationResponse](#setplayerbanoperationresponse)
    - [ChangePlayerCurrencyOperationResponse](#changeplayercurrencyoperationresponse)
    - [SetPlayerDataOperationResponse](#setplayerdataoperationresponse)
    - [ChangePlayerStatisticsOperationResponse](#changeplayerstatisticsoperationresponse)
    - [SetTagOperationResponse](#settagoperationresponse)
    - [UpdateTsLastLoginOperationResponse](#updatetslastloginoperationresponse)
    - [UnlinkAccountOperationResponse](#unlinkaccountoperationresponse)
    - [UnlinkAndroidDeviceIdOperationResponse](#unlinkandroiddeviceidoperationresponse)
    - [UnlinkAppleOperationResponse](#unlinkappleoperationresponse)
    - [UnlinkCustomDeviceIdOperationResponse](#unlinkcustomdeviceidoperationresponse)
    - [UnlinkCustomIdOperationResponse](#unlinkcustomidoperationresponse)
    - [UnlinkEditorDeviceIdOperationResponse](#unlinkeditordeviceidoperationresponse)
    - [UnlinkFacebookOperationResponse](#unlinkfacebookoperationresponse)
    - [UnlinkGenericServiceOperationResponse](#unlinkgenericserviceoperationresponse)
    - [UnlinkGoogleOperationResponse](#unlinkgoogleoperationresponse)
    - [UnlinkGooglePlayGameServiceOperationResponse](#unlinkgoogleplaygameserviceoperationresponse)
    - [UnlinkGameCenterOperationResponse](#unlinkgamecenteroperationresponse)
    - [UnlinkiOSDeviceIdOperationResponse](#unlinkiosdeviceidoperationresponse)
    - [UnlinkLinuxDeviceIdOperationResponse](#unlinklinuxdeviceidoperationresponse)
    - [UnlinkMacOSDeviceIdOperationResponse](#unlinkmacosdeviceidoperationresponse)
    - [UnlinkWindowsDeviceIdOperationResponse](#unlinkwindowsdeviceidoperationresponse)
    - [UnlinkWindowsPhoneDeviceIdOperationResponse](#unlinkwindowsphonedeviceidoperationresponse)
    - [GetCurrencyLeaderboardOperationResponse](#getcurrencyleaderboardoperationresponse)
    - [GetCreateLeaderboardOperationResponse](#getcreateleaderboardoperationresponse)
    - [GetLastLoginLeaderboardOperationResponse](#getlastloginleaderboardoperationresponse)
    - [GetStatisticsLogOperationResponse](#getstatisticslogoperationresponse)
    - [GetCurrencyLogOperationResponse](#getcurrencylogoperationresponse)
    - [SendSocketOperationEventOperationResponse](#sendsocketoperationeventoperationresponse)
    - [SendEmailOperationResponse](#sendemailoperationresponse)
    - [AddPushNotificationOperationResponse](#addpushnotificationoperationresponse)
    - [RemovePushNotificationOperationResponse](#removepushnotificationoperationresponse)
    - [GetPushNotificationOperationResponse](#getpushnotificationoperationresponse)
    - [SendPushNotificationOperationResponse](#sendpushnotificationoperationresponse)
    - [GetOnlineStatusOperationResponse](#getonlinestatusoperationresponse)

---

## Namespace `MasterPlayerModels`

### CustomDataParam

Defines the reusable parameter block CustomDataParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `value` | `object` | yes | Arbitrary value to store for this custom data key. May be a primitive, `GNHashtable`, or `GNArray`. |

### InfoRequestParam

Selects which optional master-player fields should be returned in `infoResponseParameters`. Boolean flags default to `false`; key arrays narrow list-style fields to specific keys only.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `external` | `bool?` | no | Includes linked external identities such as account, device, Google, Facebook, or Apple. — _default=false_ |
| `segments` | `bool?` | no | Includes the segment names currently attached to the player. — _default=false_ |
| `customDatas` | `bool?` | no | Includes custom data entries. — _default=false_ |
| `displayName` | `bool?` | no | Includes the player's display name. — _default=false_ |
| `avatar` | `bool?` | no | Includes the avatar descriptor. — _default=false_ |
| `tsCreate` | `bool?` | no | Includes the creation timestamp. — _default=false_ |
| `tags` | `bool?` | no | Includes tag entries. — _default=false_ |
| `playerBan` | `bool?` | no | Includes the active ban state when present. — _default=false_ |
| `playerCurrencies` | `bool?` | no | Includes player currency entries. — _default=false_ |
| `playerStatistics` | `bool?` | no | Includes player statistics entries. — _default=false_ |
| `playerDatas` | `bool?` | no | Includes player data entries. — _default=false_ |
| `ipAddressCreate` | `bool?` | no | Includes the creation IP address. — _default=false_ |
| `countryCode` | `bool?` | no | Includes the country code currently stored for the player. — _default=false_ |
| `email` | `bool?` | no | Includes the email currently stored for the player. — _default=false_ |
| `tsLastLogin` | `bool?` | no | Includes the last-login timestamp. — _default=false_ |
| `pushNotifications` | `bool?` | no | Includes registered push-notification endpoints. — _default=false_ |
| `onlineStatus` | `bool?` | no | Includes the player's online status, if supported by the connected game server. — _default=false_ |
| `playerDataKeys` | `List<string>?` | no | Restricts `playerDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `playerCurrencyKeys` | `List<string>?` | no | Restricts `playerCurrencies` to the specified currency keys when that field is requested. — _elementCls=String_ |
| `playerStatisticsKeys` | `List<string>?` | no | Restricts `playerStatistics` to the specified statistic keys when that field is requested. — _elementCls=String_ |
| `customDataKeys` | `List<string>?` | no | Restricts `customDatas` to the specified keys when that field is requested. — _elementCls=String_ |
| `tagKeys` | `List<string>?` | no | Restricts `tags` to the specified tag keys when that field is requested. — _elementCls=String_ |

### PlayerCurrencyParam

Defines the reusable parameter block PlayerCurrencyParam.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | Currency key identifying the currency to change. — _minLength=2, maxLength=32_ |
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

### GenericService

Represents one linked external generic service identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | Name of the external service provider. |
| `serviceId` | `string` | yes | Player identifier within the external service. |

### Device

Represents all device IDs currently linked to the master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customDeviceId` | `string?` | no | Custom device identifier when linked. |
| `androidDeviceId` | `string?` | no | Android device identifier when linked. |
| `iOSDeviceId` | `string?` | no | iOS device identifier when linked. |
| `windowsPhoneDeviceId` | `string?` | no | Windows Phone device identifier when linked. |
| `windowsDeviceId` | `string?` | no | Windows PC device identifier when linked. |
| `linuxDeviceId` | `string?` | no | Linux device identifier when linked. |
| `macOSDeviceId` | `string?` | no | macOS device identifier when linked. |
| `editorDeviceId` | `string?` | no | Editor (development) device identifier when linked. |

### Account

Represents a linked GearN account identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `username` | `string?` | no | GearN account username when an account credential is linked. |

### Custom

Represents a linked custom ID identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `customId` | `string?` | no | Custom ID value when linked. |

### Apple

Represents a linked Apple identity (Sign in with Apple).

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleId` | `string` | yes | Apple user identifier from Sign in with Apple. |
| `email` | `string` | yes | Email address from the Apple identity. |

### Google

Represents a linked Google identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleId` | `string` | yes | Google user identifier (sub claim from the ID token). |
| `displayName` | `string` | yes | Display name from the Google profile. |
| `email` | `string` | yes | Email address from the Google identity. |

### Facebook

Represents a linked Facebook identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookId` | `string` | yes | Facebook user ID from the access token. |
| `displayName` | `string` | yes | Display name from the Facebook profile. |
| `email` | `string` | yes | Email address from the Facebook identity. |

### GooglePlayGameService

Represents a linked Google Play Game Services identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Google Play Games player ID. |
| `displayName` | `string` | yes | Display name from the Google Play Games profile. |
| `email` | `string` | yes | Email address associated with the Google Play Games account. |

### GameCenter

Represents a linked Apple Game Center identity.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Apple Game Center player ID. |
| `displayName` | `string` | yes | Display name from the Game Center profile. |
| `email` | `string` | yes | Email address associated with the Game Center account. |

### ExternalItem

Groups all external identities that may be linked to one master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `device` | `Device?` | no | Linked device IDs; present when at least one device ID is linked. |
| `account` | `Account?` | no | Linked GearN account; present when an account credential is linked. |
| `custom` | `Custom?` | no | Linked custom ID; present when a custom ID is linked. |
| `apple` | `Apple?` | no | Linked Apple identity; present when Sign in with Apple is linked. |
| `google` | `Google?` | no | Linked Google identity; present when Google Sign-In is linked. |
| `facebook` | `Facebook?` | no | Linked Facebook identity; present when Facebook is linked. |
| `genericServices` | `List<GenericService>?` | no | List of linked generic service identities. — _elementCls=GenericService_ |
| `googlePlayGameService` | `GooglePlayGameService?` | no | Linked Google Play Game Services identity; present when linked. |
| `gameCenter` | `GameCenter?` | no | Linked Apple Game Center identity; present when linked. |

### AddSegmentRequestData

Defines the request payload for AddSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |

### ServerAddSegmentRequestData

Extends: `AddSegmentRequestData`

Defines the request payload for ServerAddSegment.

_Không có field public (payload rỗng)._

### AdminAddSegmentRequestData

Extends: `ServerAddSegmentRequestData`

Defines the request payload for AdminAddSegment.

_Không có field public (payload rỗng)._

### ChangeAccountPasswordRequestData

Defines the request payload for ChangeAccountPassword.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `currentPassword` | `string` | yes | _minLength=6, maxLength=64_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

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

### GetEmailRequestData

Defines the request payload for GetEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetEmailRequestData

Extends: `GetEmailRequestData`

Defines the request payload for ServerGetEmail.

_Không có field public (payload rỗng)._

### AdminGetEmailRequestData

Extends: `ServerGetEmailRequestData`

Defines the request payload for AdminGetEmail.

_Không có field public (payload rỗng)._

### GetExternalRequestData

Defines the request payload for GetExternal.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetExternalRequestData

Extends: `GetExternalRequestData`

Defines the request payload for ServerGetExternal.

_Không có field public (payload rỗng)._

### AdminGetExternalRequestData

Extends: `ServerGetExternalRequestData`

Defines the request payload for AdminGetExternal.

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

### GetPlayerInformationRequestData

Reads the current or target master-player profile using the requested projection. On the client route, omit `userId` to target the authenticated player itself.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Required field projection that controls which optional data is returned. |

### ServerGetPlayerInformationRequestData

Extends: `GetPlayerInformationRequestData`

Reads a specific target master player on a trusted route.

_Không có field public (payload rỗng)._

### AdminGetPlayerInformationRequestData

Extends: `ServerGetPlayerInformationRequestData`

Defines the request payload for AdminGetPlayerInformation.

_Không có field public (payload rỗng)._

### GetPlayerStatisticsRequestData

Defines the request payload for GetPlayerStatistics.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerStatisticsKeys` | `List<string>?` | no | _elementCls=String_ |

### ServerGetPlayerStatisticsRequestData

Extends: `GetPlayerStatisticsRequestData`

Defines the request payload for ServerGetPlayerStatistics.

_Không có field public (payload rỗng)._

### AdminGetPlayerStatisticsRequestData

Extends: `ServerGetPlayerStatisticsRequestData`

Defines the request payload for AdminGetPlayerStatistics.

_Không có field public (payload rỗng)._

### GetPlayersWithAppleRequestData

Defines the request payload for GetPlayersWithApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithAppleRequestData

Extends: `GetPlayersWithAppleRequestData`

Defines the request payload for ServerGetPlayersWithApple.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithAppleRequestData

Extends: `ServerGetPlayersWithAppleRequestData`

Defines the request payload for AdminGetPlayersWithApple.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameRequestData

Defines the request payload for GetPlayersWithDisplayName.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `keyword` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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

### GetPlayersWithFacebookRequestData

Defines the request payload for GetPlayersWithFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithFacebookRequestData

Extends: `GetPlayersWithFacebookRequestData`

Defines the request payload for ServerGetPlayersWithFacebook.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithFacebookRequestData

Extends: `ServerGetPlayersWithFacebookRequestData`

Defines the request payload for AdminGetPlayersWithFacebook.

_Không có field public (payload rỗng)._

### GetPlayersWithGenericServiceRequestData

Defines the request payload for GetPlayersWithGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceName` | `string` | yes | _minLength=2, maxLength=32_ |
| `genericIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithGenericServiceRequestData

Extends: `GetPlayersWithGenericServiceRequestData`

Defines the request payload for ServerGetPlayersWithGenericService.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGenericServiceRequestData

Extends: `ServerGetPlayersWithGenericServiceRequestData`

Defines the request payload for AdminGetPlayersWithGenericService.

_Không có field public (payload rỗng)._

### GetPlayersWithGoogleRequestData

Defines the request payload for GetPlayersWithGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithGoogleRequestData

Extends: `GetPlayersWithGoogleRequestData`

Defines the request payload for ServerGetPlayersWithGoogle.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGoogleRequestData

Extends: `ServerGetPlayersWithGoogleRequestData`

Defines the request payload for AdminGetPlayersWithGoogle.

_Không có field public (payload rỗng)._

### GetPlayersWithGooglePlayGameServiceRequestData

Defines the request payload for GetPlayersWithGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithGooglePlayGameServiceRequestData

Extends: `GetPlayersWithGooglePlayGameServiceRequestData`

Defines the request payload for ServerGetPlayersWithGooglePlayGameService.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGooglePlayGameServiceRequestData

Extends: `ServerGetPlayersWithGooglePlayGameServiceRequestData`

Defines the request payload for AdminGetPlayersWithGooglePlayGameService.

_Không có field public (payload rỗng)._

### GetPlayersWithGameCenterRequestData

Defines the request payload for GetPlayersWithGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerIds` | `List<string>` | yes | _elementCls=String_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |

### ServerGetPlayersWithGameCenterRequestData

Extends: `GetPlayersWithGameCenterRequestData`

Defines the request payload for ServerGetPlayersWithGameCenter.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGameCenterRequestData

Extends: `ServerGetPlayersWithGameCenterRequestData`

Defines the request payload for AdminGetPlayersWithGameCenter.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentRequestData

Defines the request payload for GetPlayersWithSegment.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `value` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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

### GetLastLoginLeaderboardRequestData

Defines the request payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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

### LinkAccountRequestData

Defines the request payload for LinkAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAccountRequestData

Extends: `LinkAccountRequestData`

Defines the request payload for ServerLinkAccount.

_Không có field public (payload rỗng)._

### AdminLinkAccountRequestData

Extends: `ServerLinkAccountRequestData`

Defines the request payload for AdminLinkAccount.

_Không có field public (payload rỗng)._

### LinkAndroidDeviceIdRequestData

Defines the request payload for LinkAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAndroidDeviceIdRequestData

Extends: `LinkAndroidDeviceIdRequestData`

Defines the request payload for ServerLinkAndroidDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkAndroidDeviceIdRequestData

Extends: `ServerLinkAndroidDeviceIdRequestData`

Defines the request payload for AdminLinkAndroidDeviceId.

_Không có field public (payload rỗng)._

### LinkAppleRequestData

Defines the request payload for LinkApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkAppleRequestData

Extends: `LinkAppleRequestData`

Defines the request payload for ServerLinkApple.

_Không có field public (payload rỗng)._

### AdminLinkAppleRequestData

Extends: `ServerLinkAppleRequestData`

Defines the request payload for AdminLinkApple.

_Không có field public (payload rỗng)._

### LinkCustomDeviceIdRequestData

Defines the request payload for LinkCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkCustomDeviceIdRequestData

Extends: `LinkCustomDeviceIdRequestData`

Defines the request payload for ServerLinkCustomDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkCustomDeviceIdRequestData

Extends: `ServerLinkCustomDeviceIdRequestData`

Defines the request payload for AdminLinkCustomDeviceId.

_Không có field public (payload rỗng)._

### LinkCustomIdRequestData

Defines the request payload for LinkCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkCustomIdRequestData

Extends: `LinkCustomIdRequestData`

Defines the request payload for ServerLinkCustomId.

_Không có field public (payload rỗng)._

### AdminLinkCustomIdRequestData

Extends: `ServerLinkCustomIdRequestData`

Defines the request payload for AdminLinkCustomId.

_Không có field public (payload rỗng)._

### LinkEditorDeviceIdRequestData

Defines the request payload for LinkEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkEditorDeviceIdRequestData

Extends: `LinkEditorDeviceIdRequestData`

Defines the request payload for ServerLinkEditorDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkEditorDeviceIdRequestData

Extends: `ServerLinkEditorDeviceIdRequestData`

Defines the request payload for AdminLinkEditorDeviceId.

_Không có field public (payload rỗng)._

### LinkFacebookRequestData

Defines the request payload for LinkFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkFacebookRequestData

Extends: `LinkFacebookRequestData`

Defines the request payload for ServerLinkFacebook.

_Không có field public (payload rỗng)._

### AdminLinkFacebookRequestData

Extends: `ServerLinkFacebookRequestData`

Defines the request payload for AdminLinkFacebook.

_Không có field public (payload rỗng)._

### LinkGenericServiceRequestData

Defines the request payload for LinkGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceData` | `GNHashtable` | yes | Service-specific credential or identity data required by the external generic service provider. |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGenericServiceRequestData

Extends: `LinkGenericServiceRequestData`

Defines the request payload for ServerLinkGenericService.

_Không có field public (payload rỗng)._

### AdminLinkGenericServiceRequestData

Extends: `ServerLinkGenericServiceRequestData`

Defines the request payload for AdminLinkGenericService.

_Không có field public (payload rỗng)._

### LinkGoogleRequestData

Defines the request payload for LinkGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `type` | `int` | yes | _min=1, max=2_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGoogleRequestData

Extends: `LinkGoogleRequestData`

Defines the request payload for ServerLinkGoogle.

_Không có field public (payload rỗng)._

### AdminLinkGoogleRequestData

Extends: `ServerLinkGoogleRequestData`

Defines the request payload for AdminLinkGoogle.

_Không có field public (payload rỗng)._

### LinkGooglePlayGameServiceRequestData

Defines the request payload for LinkGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | _minLength=32, maxLength=2048_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGooglePlayGameServiceRequestData

Extends: `LinkGooglePlayGameServiceRequestData`

Defines the request payload for ServerLinkGooglePlayGameService.

_Không có field public (payload rỗng)._

### AdminLinkGooglePlayGameServiceRequestData

Extends: `ServerLinkGooglePlayGameServiceRequestData`

Defines the request payload for AdminLinkGooglePlayGameService.

_Không có field public (payload rỗng)._

### LinkGameCenterRequestData

Defines the request payload for LinkGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=2, maxLength=64_ |
| `name` | `string` | yes | _minLength=2, maxLength=128_ |
| `publicKeyUrl` | `string` | yes | _minLength=2, maxLength=2048_ |
| `signature` | `string` | yes | _minLength=2, maxLength=2048_ |
| `salt` | `string` | yes | _minLength=2, maxLength=256_ |
| `timestamp` | `long` | yes | Unix timestamp from the Game Center signature verification payload. |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkGameCenterRequestData

Extends: `LinkGameCenterRequestData`

Defines the request payload for ServerLinkGameCenter.

_Không có field public (payload rỗng)._

### AdminLinkGameCenterRequestData

Extends: `ServerLinkGameCenterRequestData`

Defines the request payload for AdminLinkGameCenter.

_Không có field public (payload rỗng)._

### LinkiOSDeviceIdRequestData

Defines the request payload for LinkiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkiOSDeviceIdRequestData

Extends: `LinkiOSDeviceIdRequestData`

Defines the request payload for ServerLinkiOSDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkiOSDeviceIdRequestData

Extends: `ServerLinkiOSDeviceIdRequestData`

Defines the request payload for AdminLinkiOSDeviceId.

_Không có field public (payload rỗng)._

### LinkLinuxDeviceIdRequestData

Defines the request payload for LinkLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkLinuxDeviceIdRequestData

Extends: `LinkLinuxDeviceIdRequestData`

Defines the request payload for ServerLinkLinuxDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkLinuxDeviceIdRequestData

Extends: `ServerLinkLinuxDeviceIdRequestData`

Defines the request payload for AdminLinkLinuxDeviceId.

_Không có field public (payload rỗng)._

### LinkMacOSDeviceIdRequestData

Defines the request payload for LinkMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkMacOSDeviceIdRequestData

Extends: `LinkMacOSDeviceIdRequestData`

Defines the request payload for ServerLinkMacOSDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkMacOSDeviceIdRequestData

Extends: `ServerLinkMacOSDeviceIdRequestData`

Defines the request payload for AdminLinkMacOSDeviceId.

_Không có field public (payload rỗng)._

### LinkWindowsDeviceIdRequestData

Defines the request payload for LinkWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkWindowsDeviceIdRequestData

Extends: `LinkWindowsDeviceIdRequestData`

Defines the request payload for ServerLinkWindowsDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkWindowsDeviceIdRequestData

Extends: `ServerLinkWindowsDeviceIdRequestData`

Defines the request payload for AdminLinkWindowsDeviceId.

_Không có field public (payload rỗng)._

### LinkWindowsPhoneDeviceIdRequestData

Defines the request payload for LinkWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |
| `forceLink` | `bool?` | no | _default=false_ |

### ServerLinkWindowsPhoneDeviceIdRequestData

Extends: `LinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for ServerLinkWindowsPhoneDeviceId.

_Không có field public (payload rỗng)._

### AdminLinkWindowsPhoneDeviceIdRequestData

Extends: `ServerLinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for AdminLinkWindowsPhoneDeviceId.

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

### ResetAccountPasswordRequestData

Defines the request payload for ResetAccountPassword.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `password` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerResetAccountPasswordRequestData

Extends: `ResetAccountPasswordRequestData`

Defines the request payload for ServerResetAccountPassword.

_Không có field public (payload rỗng)._

### AdminResetAccountPasswordRequestData

Extends: `ServerResetAccountPasswordRequestData`

Defines the request payload for AdminResetAccountPassword.

_Không có field public (payload rỗng)._

### SetAvatarRequestData

Defines the request payload for SetAvatar.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `type` | `int` | yes | Avatar type identifier. Maps to the public avatar type enum. |
| `value` | `string` | yes | _minLength=1, maxLength=128_ |

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

### SetEmailRequestData

Defines the request payload for SetEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `email` | `string` | yes | _minLength=5, maxLength=128_ |

### ServerSetEmailRequestData

Extends: `SetEmailRequestData`

Defines the request payload for ServerSetEmail.

_Không có field public (payload rỗng)._

### AdminSetEmailRequestData

Extends: `ServerSetEmailRequestData`

Defines the request payload for AdminSetEmail.

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

Reads currency change logs for the current or target master player. Pagination is token-based rather than skip-based.

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

Reads statistic change logs for the current or target master player. Pagination is token-based rather than skip-based.

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

### UpdateTsLastLoginRequestData

Defines the request payload for UpdateTsLastLogin.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerUpdateTsLastLoginRequestData

Extends: `UpdateTsLastLoginRequestData`

Defines the request payload for ServerUpdateTsLastLogin.

_Không có field public (payload rỗng)._

### AdminUpdateTsLastLoginRequestData

Extends: `ServerUpdateTsLastLoginRequestData`

Defines the request payload for AdminUpdateTsLastLogin.

_Không có field public (payload rỗng)._

### UnlinkAccountRequestData

Defines the request payload for UnlinkAccount.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `username` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerUnlinkAccountRequestData

Extends: `UnlinkAccountRequestData`

Defines the request payload for ServerUnlinkAccount.

_Không có field public (payload rỗng)._

### AdminUnlinkAccountRequestData

Extends: `ServerUnlinkAccountRequestData`

Defines the request payload for AdminUnlinkAccount.

_Không có field public (payload rỗng)._

### UnlinkAndroidDeviceIdRequestData

Defines the request payload for UnlinkAndroidDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `androidDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkAndroidDeviceIdRequestData

Extends: `UnlinkAndroidDeviceIdRequestData`

Defines the request payload for ServerUnlinkAndroidDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkAndroidDeviceIdRequestData

Extends: `ServerUnlinkAndroidDeviceIdRequestData`

Defines the request payload for AdminUnlinkAndroidDeviceId.

_Không có field public (payload rỗng)._

### UnlinkAppleRequestData

Defines the request payload for UnlinkApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `appleId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkAppleRequestData

Extends: `UnlinkAppleRequestData`

Defines the request payload for ServerUnlinkApple.

_Không có field public (payload rỗng)._

### AdminUnlinkAppleRequestData

Extends: `ServerUnlinkAppleRequestData`

Defines the request payload for AdminUnlinkApple.

_Không có field public (payload rỗng)._

### UnlinkCustomDeviceIdRequestData

Defines the request payload for UnlinkCustomDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkCustomDeviceIdRequestData

Extends: `UnlinkCustomDeviceIdRequestData`

Defines the request payload for ServerUnlinkCustomDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkCustomDeviceIdRequestData

Extends: `ServerUnlinkCustomDeviceIdRequestData`

Defines the request payload for AdminUnlinkCustomDeviceId.

_Không có field public (payload rỗng)._

### UnlinkCustomIdRequestData

Defines the request payload for UnlinkCustomId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `customId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkCustomIdRequestData

Extends: `UnlinkCustomIdRequestData`

Defines the request payload for ServerUnlinkCustomId.

_Không có field public (payload rỗng)._

### AdminUnlinkCustomIdRequestData

Extends: `ServerUnlinkCustomIdRequestData`

Defines the request payload for AdminUnlinkCustomId.

_Không có field public (payload rỗng)._

### UnlinkEditorDeviceIdRequestData

Defines the request payload for UnlinkEditorDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `editorDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkEditorDeviceIdRequestData

Extends: `UnlinkEditorDeviceIdRequestData`

Defines the request payload for ServerUnlinkEditorDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkEditorDeviceIdRequestData

Extends: `ServerUnlinkEditorDeviceIdRequestData`

Defines the request payload for AdminUnlinkEditorDeviceId.

_Không có field public (payload rỗng)._

### UnlinkFacebookRequestData

Defines the request payload for UnlinkFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `facebookId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkFacebookRequestData

Extends: `UnlinkFacebookRequestData`

Defines the request payload for ServerUnlinkFacebook.

_Không có field public (payload rỗng)._

### AdminUnlinkFacebookRequestData

Extends: `ServerUnlinkFacebookRequestData`

Defines the request payload for AdminUnlinkFacebook.

_Không có field public (payload rỗng)._

### UnlinkGenericServiceRequestData

Defines the request payload for UnlinkGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `serviceName` | `string` | yes | _minLength=6, maxLength=32_ |
| `serviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGenericServiceRequestData

Extends: `UnlinkGenericServiceRequestData`

Defines the request payload for ServerUnlinkGenericService.

_Không có field public (payload rỗng)._

### AdminUnlinkGenericServiceRequestData

Extends: `ServerUnlinkGenericServiceRequestData`

Defines the request payload for AdminUnlinkGenericService.

_Không có field public (payload rỗng)._

### UnlinkGoogleRequestData

Defines the request payload for UnlinkGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `googleId` | `string` | yes | _minLength=6, maxLength=32_ |

### ServerUnlinkGoogleRequestData

Extends: `UnlinkGoogleRequestData`

Defines the request payload for ServerUnlinkGoogle.

_Không có field public (payload rỗng)._

### AdminUnlinkGoogleRequestData

Extends: `ServerUnlinkGoogleRequestData`

Defines the request payload for AdminUnlinkGoogle.

_Không có field public (payload rỗng)._

### UnlinkGooglePlayGameServiceRequestData

Defines the request payload for UnlinkGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGooglePlayGameServiceRequestData

Extends: `UnlinkGooglePlayGameServiceRequestData`

Defines the request payload for ServerUnlinkGooglePlayGameService.

_Không có field public (payload rỗng)._

### AdminUnlinkGooglePlayGameServiceRequestData

Extends: `ServerUnlinkGooglePlayGameServiceRequestData`

Defines the request payload for AdminUnlinkGooglePlayGameService.

_Không có field public (payload rỗng)._

### UnlinkGameCenterRequestData

Defines the request payload for UnlinkGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `playerId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkGameCenterRequestData

Extends: `UnlinkGameCenterRequestData`

Defines the request payload for ServerUnlinkGameCenter.

_Không có field public (payload rỗng)._

### AdminUnlinkGameCenterRequestData

Extends: `ServerUnlinkGameCenterRequestData`

Defines the request payload for AdminUnlinkGameCenter.

_Không có field public (payload rỗng)._

### UnlinkiOSDeviceIdRequestData

Defines the request payload for UnlinkiOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `iOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkiOSDeviceIdRequestData

Extends: `UnlinkiOSDeviceIdRequestData`

Defines the request payload for ServerUnlinkiOSDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkiOSDeviceIdRequestData

Extends: `ServerUnlinkiOSDeviceIdRequestData`

Defines the request payload for AdminUnlinkiOSDeviceId.

_Không có field public (payload rỗng)._

### UnlinkLinuxDeviceIdRequestData

Defines the request payload for UnlinkLinuxDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `linuxDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkLinuxDeviceIdRequestData

Extends: `UnlinkLinuxDeviceIdRequestData`

Defines the request payload for ServerUnlinkLinuxDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkLinuxDeviceIdRequestData

Extends: `ServerUnlinkLinuxDeviceIdRequestData`

Defines the request payload for AdminUnlinkLinuxDeviceId.

_Không có field public (payload rỗng)._

### UnlinkMacOSDeviceIdRequestData

Defines the request payload for UnlinkMacOSDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `macOSDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkMacOSDeviceIdRequestData

Extends: `UnlinkMacOSDeviceIdRequestData`

Defines the request payload for ServerUnlinkMacOSDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkMacOSDeviceIdRequestData

Extends: `ServerUnlinkMacOSDeviceIdRequestData`

Defines the request payload for AdminUnlinkMacOSDeviceId.

_Không có field public (payload rỗng)._

### UnlinkWindowsDeviceIdRequestData

Defines the request payload for UnlinkWindowsDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkWindowsDeviceIdRequestData

Extends: `UnlinkWindowsDeviceIdRequestData`

Defines the request payload for ServerUnlinkWindowsDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkWindowsDeviceIdRequestData

Extends: `ServerUnlinkWindowsDeviceIdRequestData`

Defines the request payload for AdminUnlinkWindowsDeviceId.

_Không có field public (payload rỗng)._

### UnlinkWindowsPhoneDeviceIdRequestData

Defines the request payload for UnlinkWindowsPhoneDeviceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `windowsPhoneDeviceId` | `string` | yes | _minLength=6, maxLength=64_ |

### ServerUnlinkWindowsPhoneDeviceIdRequestData

Extends: `UnlinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for ServerUnlinkWindowsPhoneDeviceId.

_Không có field public (payload rỗng)._

### AdminUnlinkWindowsPhoneDeviceIdRequestData

Extends: `ServerUnlinkWindowsPhoneDeviceIdRequestData`

Defines the request payload for AdminUnlinkWindowsPhoneDeviceId.

_Không có field public (payload rỗng)._

### SendSocketOperationEventRequestData

Sends a backend-routed socket event to the current or target player's active socket session. This is still an HTTP MasterPlayer operation, not a raw socket transport call.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | Optional self-target shortcut on the client route. — _minLength=10, maxLength=10_ |
| `eventCode` | `string` | yes | Backend-defined event code forwarded to socket listeners. — _minLength=1, maxLength=64_ |
| `eventParameters` | `GNHashtable?` | yes | Optional raw event payload delivered with the socket event. — _minLength=0, maxLength=128_ |

### ServerSendSocketOperationEventRequestData

Extends: `SendSocketOperationEventRequestData`

Defines the request payload for ServerSendSocketOperationEvent.

_Không có field public (payload rỗng)._

### AdminSendSocketOperationEventRequestData

Extends: `ServerSendSocketOperationEventRequestData`

Defines the request payload for AdminSendSocketOperationEvent.

_Không có field public (payload rỗng)._

### SendEmailRequestData

Defines the request payload for SendEmail.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `subject` | `string` | yes | _minLength=2, maxLength=256_ |
| `contentHtml` | `string` | yes | _minLength=2, maxLength=8192_ |

### ServerSendEmailRequestData

Extends: `SendEmailRequestData`

Defines the request payload for ServerSendEmail.

_Không có field public (payload rỗng)._

### AdminSendEmailRequestData

Extends: `ServerSendEmailRequestData`

Defines the request payload for AdminSendEmail.

_Không có field public (payload rỗng)._

### AddPushNotificationRequestData

Registers a push-notification endpoint for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `token` | `string` | yes | Device push token issued by the push provider. — _minLength=10, maxLength=256_ |
| `platformType` | `int` | yes | Push platform mapped by the public `PushPlatformType` enum. — _min=1_ |

### ServerAddPushNotificationRequestData

Extends: `AddPushNotificationRequestData`

Defines the request payload for ServerAddPushNotification.

_Không có field public (payload rỗng)._

### AdminAddPushNotificationRequestData

Extends: `ServerAddPushNotificationRequestData`

Defines the request payload for AdminAddPushNotification.

_Không có field public (payload rỗng)._

### GetPushNotificationRequestData

Reads registered push-notification endpoints for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetPushNotificationRequestData

Extends: `GetPushNotificationRequestData`

Defines the request payload for ServerGetPushNotification.

_Không có field public (payload rỗng)._

### AdminGetPushNotificationRequestData

Extends: `ServerGetPushNotificationRequestData`

Defines the request payload for AdminGetPushNotification.

_Không có field public (payload rỗng)._

### RemovePushNotificationRequestData

Defines the request payload for RemovePushNotification.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `pushId` | `string` | yes | _minLength=8, maxLength=8_ |

### ServerRemovePushNotificationRequestData

Extends: `RemovePushNotificationRequestData`

Defines the request payload for ServerRemovePushNotification.

_Không có field public (payload rỗng)._

### AdminRemovePushNotificationRequestData

Extends: `ServerRemovePushNotificationRequestData`

Defines the request payload for AdminRemovePushNotification.

_Không có field public (payload rỗng)._

### SendPushNotificationRequestData

Triggers a push-notification send workflow for the current or target master player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |
| `title` | `string` | yes | Title text displayed as the push notification header. |
| `body` | `string` | yes | Body text displayed as the push notification message. |
| `badge` | `int?` | no | _default=null_ |
| `sound` | `string?` | no | Sound file name played on notification receipt (platform-specific). |
| `icon` | `string?` | no | Icon resource name or URL shown in the notification (platform-specific). |
| `data` | `GNHashtable?` | no | Platform-specific custom payload forwarded to the push provider. |

### ServerSendPushNotificationRequestData

Extends: `SendPushNotificationRequestData`

Defines the request payload for ServerSendPushNotification.

_Không có field public (payload rỗng)._

### AdminSendPushNotificationRequestData

Extends: `ServerSendPushNotificationRequestData`

Defines the request payload for AdminSendPushNotification.

_Không có field public (payload rỗng)._

### GetOnlineStatusRequestData

Defines the request payload for GetOnlineStatus.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string?` | no | _minLength=10, maxLength=10_ |

### ServerGetOnlineStatusRequestData

Extends: `GetOnlineStatusRequestData`

Defines the request payload for ServerGetOnlineStatus.

_Không có field public (payload rỗng)._

### AdminGetOnlineStatusRequestData

Extends: `ServerGetOnlineStatusRequestData`

Defines the request payload for AdminGetOnlineStatus.

_Không có field public (payload rỗng)._


### PushNotificationItem

Describes one registered push endpoint stored for a player.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `token` | `string` | yes | FCM device registration token issued by the push provider. |
| `pushId` | `string` | yes | Backend-assigned push endpoint identifier for this registration. |
| `platformType` | `int` | yes | Push platform mapped by the public `PushPlatformType` enum. |

### InfoResponseParameters

Contains the optional fields requested through `InfoRequestParam`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `external` | `ExternalItem?` | no | Linked external identity snapshot. |
| `segments` | `List<string>?` | no | _elementCls=String_ |
| `customDatas` | `List<GenericModels.DataItem>?` | no | _elementCls=GenericModels.DataItem_ |
| `displayName` | `string?` | no | Display name of the master player. |
| `avatar` | `GenericModels.AvatarItem?` | no | Avatar data of the master player. |
| `tsCreate` | `long?` | no | Account creation timestamp of the master player. |
| `tags` | `List<GenericModels.TagItem>?` | no | _elementCls=GenericModels.TagItem_ |
| `playerBan` | `GenericModels.BanItem?` | no | Ban state of the master player; present when a ban is active. |
| `playerDatas` | `List<GenericModels.DataItem>?` | no | _elementCls=GenericModels.DataItem_ |
| `playerCurrencies` | `List<GenericModels.CurrencyItem>?` | no | _elementCls=GenericModels.CurrencyItem_ |
| `playerStatistics` | `List<GenericModels.StatisticsItem>?` | no | _elementCls=GenericModels.StatisticsItem_ |
| `tsLastLogin` | `long?` | no | Timestamp of the master player's last successful login. |
| `ipAddressCreate` | `string?` | no | IP address recorded at the time of account creation. |
| `countryCode` | `string?` | no | Country code associated with the master player account. |
| `email` | `string?` | no | Email address linked to the master player account. |
| `pushNotifications` | `List<MasterPlayerModels.PushNotificationItem>?` | no | Registered push endpoints when `pushNotifications` was requested. — _elementCls=MasterPlayerModels.PushNotificationItem_ |
| `onlineStatus` | `OnlineStatusItem?` | no | Online status snapshot; present when `onlineStatus` is enabled in `InfoRequestParam`. |

### OnlineStatusItem

Online status snapshot returned when `InfoRequestParam.onlineStatus` is `true`.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `tsLastLogin` | `long` | yes | Unix timestamp (ms) of the player's last login. |
| `socketId` | `string` | yes | Active socket connection ID, or empty string if the player is offline. |

### MasterPlayerResponseData

Base master-player response envelope.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `infoResponseParameters` | `InfoResponseParameters` | yes | Optional field bag controlled by the corresponding `InfoRequestParam`. |

### GenericServiceMasterPlayerResponseData

Extends: `MasterPlayerResponseData`

Master-player envelope for generic-service link or lookup flows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `errorMessage` | `string?` | no | Provider-specific error text returned by the backend when available. |

### MasterPlayerWithUserIdResponseData

Extends: `MasterPlayerResponseData`

Master-player envelope that also exposes the resolved master-player user ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | Master-player user identifier. |

### MasterPlayerWithAppleIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithAppleId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `appleId` | `string` | yes | Apple user identifier from Sign in with Apple. |

### GetPlayersWithAppleResponseData

Defines the response payload for GetPlayersWithApple.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithAppleIdResponseData>` | yes | _elementCls=MasterPlayerWithAppleIdResponseData_ |

### MasterPlayersWithUserIdResponseData

Defines the response payload for MasterPlayersWithUserId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithUserIdResponseData>` | yes | _elementCls=MasterPlayerWithUserIdResponseData_ |

### MasterPlayerWithFacebookIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithFacebookId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `facebookId` | `string` | yes | Facebook user identifier from the linked Facebook account. |

### GetPlayersWithFacebookResponseData

Defines the response payload for GetPlayersWithFacebook.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithFacebookIdResponseData>` | yes | _elementCls=MasterPlayerWithFacebookIdResponseData_ |

### MasterPlayerWithGenericServiceIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithGenericServiceId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `serviceId` | `string` | yes | Player identifier within the linked external generic service. |

### GetPlayersWithGenericServiceResponseData

Defines the response payload for GetPlayersWithGenericService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithGenericServiceIdResponseData>` | yes | _elementCls=MasterPlayerWithGenericServiceIdResponseData_ |

### MasterPlayerWithGoogleIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithGoogleId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `googleId` | `string` | yes | Google account identifier from the linked Google account. |

### GetPlayersWithGoogleResponseData

Defines the response payload for GetPlayersWithGoogle.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithGoogleIdResponseData>` | yes | _elementCls=MasterPlayerWithGoogleIdResponseData_ |

### MasterPlayerWithPlayerIdResponseData

Extends: `MasterPlayerWithUserIdResponseData`

Defines the response payload for MasterPlayerWithPlayerId.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `playerId` | `string` | yes | Google Play Game Service or Game Center player identifier. |

### GetPlayersWithGooglePlayGameServiceResponseData

Defines the response payload for GetPlayersWithGooglePlayGameService.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithPlayerIdResponseData>` | yes | _elementCls=MasterPlayerWithPlayerIdResponseData_ |

### GetPlayersWithGameCenterResponseData

Defines the response payload for GetPlayersWithGameCenter.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerWithPlayerIdResponseData>` | yes | _elementCls=MasterPlayerWithPlayerIdResponseData_ |

### MasterPlayerLeaderboardResponseData

Extends: `MasterPlayerWithUserIdResponseData`

One leaderboard row for master-player ranking endpoints.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `position` | `int` | yes | Ranking position returned by the backend leaderboard implementation. |
| `backupValue` | `double?` | no | Optional archived score value from the last leaderboard backup. |

### MasterPlayerLogResponseData

Describes one statistics or currency change log entry.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `userId` | `string` | yes | User identifier of the master player who owns this log entry. |
| `tsCreate` | `long` | yes | Timestamp when the change was recorded. |
| `log` | `string` | yes | Log message or label describing the operation that caused the change. |
| `key` | `string` | yes | Statistics or currency key that was changed. |
| `amount` | `double` | yes | Delta applied to the value in this operation. |
| `startValue` | `double` | yes | Value of the key before the change was applied. |
| `finalValue` | `double` | yes | Value of the key after the change was applied. |

### GetStatisticsLeaderboardResponseData

Returns a statistics leaderboard page plus its optional snapshot timestamp.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |
| `tsCreate` | `long?` | no | Snapshot timestamp used for this leaderboard page when returned by the backend. |

### GetCurrencyLeaderboardResponseData

Defines the response payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

### GetCreateLeaderboardResponseData

Defines the response payload for GetCreateLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

### GetLastLoginLeaderboardResponseData

Defines the response payload for GetLastLoginLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLeaderboardResponseData>` | yes | _elementCls=MasterPlayerLeaderboardResponseData_ |

### GetCurrencyLeaderboardRequestData

Defines the request payload for GetCurrencyLeaderboard.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `key` | `string` | yes | _minLength=2, maxLength=32_ |
| `infoRequestParam` | `InfoRequestParam` | yes | Controls which optional profile fields are included in the response. |
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

### GetStatisticsLogResponseData

Returns one page of statistics logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLogResponseData>` | yes | _elementCls=MasterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### GetCurrencyLogResponseData

Returns one page of currency logs.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `results` | `List<MasterPlayerLogResponseData>` | yes | _elementCls=MasterPlayerLogResponseData_ |
| `token` | `string?` | no | Continuation token for the next page, or `undefined` when pagination is exhausted. |

### AddPushNotificationResponseData

Returns the backend-generated push endpoint ID.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `pushId` | `string` | yes | Backend-assigned push endpoint identifier for the newly registered device token. |

### SendPushNotificationResponseData

Returns the backend send status message for push-dispatch workflows.

<!-- prettier-ignore -->
| Field | Type | Required | Notes |
| --- | --- | --- | --- |
| `message` | `string` | yes | Status message returned by the backend after dispatching the push notification. |

### EmptyResponseData

Defines an intentionally empty response payload.

_Không có field public (payload rỗng)._

## Namespace `MasterPlayerRequestModels`

### AddSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.AddSegmentRequestData>`

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

### ChangeAccountPasswordOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.ChangeAccountPasswordRequestData>`

Maps the ChangeAccountPassword operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetAvatarRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetCountryCodeRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetCustomDataRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetDisplayNameRequestData>`

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

### GetEmailOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetEmailRequestData>`

Maps the GetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetEmailOperationRequest

Extends: `GetEmailOperationRequest`

Maps the ServerGetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetEmailOperationRequest

Extends: `GetEmailOperationRequest`

Maps the AdminGetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetExternalOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetExternalRequestData>`

Maps the GetExternal operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetExternalOperationRequest

Extends: `GetExternalOperationRequest`

Maps the ServerGetExternal operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetExternalOperationRequest

Extends: `GetExternalOperationRequest`

Maps the AdminGetExternal operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetIpAddressCreateOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetIpAddressCreateRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayerBanRequestData>`

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

### GetPlayerCurrencyOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayerCurrencyRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayerDataRequestData>`

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

### GetPlayerInformationOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayerInformationRequestData>`

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

### GetPlayerStatisticsOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayerStatisticsRequestData>`

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

### GetPlayersWithAppleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithAppleRequestData>`

Maps the GetPlayersWithApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithAppleOperationRequest

Extends: `GetPlayersWithAppleOperationRequest`

Maps the ServerGetPlayersWithApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithAppleOperationRequest

Extends: `GetPlayersWithAppleOperationRequest`

Maps the AdminGetPlayersWithApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithDisplayNameRequestData>`

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

### GetPlayersWithFacebookOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithFacebookRequestData>`

Maps the GetPlayersWithFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithFacebookOperationRequest

Extends: `GetPlayersWithFacebookOperationRequest`

Maps the ServerGetPlayersWithFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithFacebookOperationRequest

Extends: `GetPlayersWithFacebookOperationRequest`

Maps the AdminGetPlayersWithFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGenericServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithGenericServiceRequestData>`

Maps the GetPlayersWithGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithGenericServiceOperationRequest

Extends: `GetPlayersWithGenericServiceOperationRequest`

Maps the ServerGetPlayersWithGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGenericServiceOperationRequest

Extends: `GetPlayersWithGenericServiceOperationRequest`

Maps the AdminGetPlayersWithGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGoogleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithGoogleRequestData>`

Maps the GetPlayersWithGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithGoogleOperationRequest

Extends: `GetPlayersWithGoogleOperationRequest`

Maps the ServerGetPlayersWithGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGoogleOperationRequest

Extends: `GetPlayersWithGoogleOperationRequest`

Maps the AdminGetPlayersWithGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGooglePlayGameServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData>`

Maps the GetPlayersWithGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithGooglePlayGameServiceOperationRequest

Extends: `GetPlayersWithGooglePlayGameServiceOperationRequest`

Maps the ServerGetPlayersWithGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGooglePlayGameServiceOperationRequest

Extends: `GetPlayersWithGooglePlayGameServiceOperationRequest`

Maps the AdminGetPlayersWithGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGameCenterOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithGameCenterRequestData>`

Maps the GetPlayersWithGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPlayersWithGameCenterOperationRequest

Extends: `GetPlayersWithGameCenterOperationRequest`

Maps the ServerGetPlayersWithGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPlayersWithGameCenterOperationRequest

Extends: `GetPlayersWithGameCenterOperationRequest`

Maps the AdminGetPlayersWithGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithSegmentRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPlayersWithTagRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetSegmentRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetStatisticsLeaderboardRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetTagRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetTsCreateRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetTsLastLoginRequestData>`

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

### LinkAccountOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkAccountRequestData>`

Maps the LinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkAccountOperationRequest

Extends: `LinkAccountOperationRequest`

Maps the ServerLinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkAccountOperationRequest

Extends: `LinkAccountOperationRequest`

Maps the AdminLinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkAndroidDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkAndroidDeviceIdRequestData>`

Maps the LinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkAndroidDeviceIdOperationRequest

Extends: `LinkAndroidDeviceIdOperationRequest`

Maps the ServerLinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkAndroidDeviceIdOperationRequest

Extends: `LinkAndroidDeviceIdOperationRequest`

Maps the AdminLinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkAppleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkAppleRequestData>`

Maps the LinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkAppleOperationRequest

Extends: `LinkAppleOperationRequest`

Maps the ServerLinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkAppleOperationRequest

Extends: `LinkAppleOperationRequest`

Maps the AdminLinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkCustomDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkCustomDeviceIdRequestData>`

Maps the LinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkCustomDeviceIdOperationRequest

Extends: `LinkCustomDeviceIdOperationRequest`

Maps the ServerLinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkCustomDeviceIdOperationRequest

Extends: `LinkCustomDeviceIdOperationRequest`

Maps the AdminLinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkCustomIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkCustomIdRequestData>`

Maps the LinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkCustomIdOperationRequest

Extends: `LinkCustomIdOperationRequest`

Maps the ServerLinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkCustomIdOperationRequest

Extends: `LinkCustomIdOperationRequest`

Maps the AdminLinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkEditorDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkEditorDeviceIdRequestData>`

Maps the LinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkEditorDeviceIdOperationRequest

Extends: `LinkEditorDeviceIdOperationRequest`

Maps the ServerLinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkEditorDeviceIdOperationRequest

Extends: `LinkEditorDeviceIdOperationRequest`

Maps the AdminLinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkFacebookOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkFacebookRequestData>`

Maps the LinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkFacebookOperationRequest

Extends: `LinkFacebookOperationRequest`

Maps the ServerLinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkFacebookOperationRequest

Extends: `LinkFacebookOperationRequest`

Maps the AdminLinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkGenericServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkGenericServiceRequestData>`

Maps the LinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkGenericServiceOperationRequest

Extends: `LinkGenericServiceOperationRequest`

Maps the ServerLinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkGenericServiceOperationRequest

Extends: `LinkGenericServiceOperationRequest`

Maps the AdminLinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkGoogleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkGoogleRequestData>`

Maps the LinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkGoogleOperationRequest

Extends: `LinkGoogleOperationRequest`

Maps the ServerLinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkGoogleOperationRequest

Extends: `LinkGoogleOperationRequest`

Maps the AdminLinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkGooglePlayGameServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkGooglePlayGameServiceRequestData>`

Maps the LinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkGooglePlayGameServiceOperationRequest

Extends: `LinkGooglePlayGameServiceOperationRequest`

Maps the ServerLinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkGooglePlayGameServiceOperationRequest

Extends: `LinkGooglePlayGameServiceOperationRequest`

Maps the AdminLinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkGameCenterOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkGameCenterRequestData>`

Maps the LinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkGameCenterOperationRequest

Extends: `LinkGameCenterOperationRequest`

Maps the ServerLinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkGameCenterOperationRequest

Extends: `LinkGameCenterOperationRequest`

Maps the AdminLinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkiOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkiOSDeviceIdRequestData>`

Maps the LinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkiOSDeviceIdOperationRequest

Extends: `LinkiOSDeviceIdOperationRequest`

Maps the ServerLinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkiOSDeviceIdOperationRequest

Extends: `LinkiOSDeviceIdOperationRequest`

Maps the AdminLinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkLinuxDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkLinuxDeviceIdRequestData>`

Maps the LinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkLinuxDeviceIdOperationRequest

Extends: `LinkLinuxDeviceIdOperationRequest`

Maps the ServerLinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkLinuxDeviceIdOperationRequest

Extends: `LinkLinuxDeviceIdOperationRequest`

Maps the AdminLinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkMacOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkMacOSDeviceIdRequestData>`

Maps the LinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkMacOSDeviceIdOperationRequest

Extends: `LinkMacOSDeviceIdOperationRequest`

Maps the ServerLinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkMacOSDeviceIdOperationRequest

Extends: `LinkMacOSDeviceIdOperationRequest`

Maps the AdminLinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkWindowsDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkWindowsDeviceIdRequestData>`

Maps the LinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkWindowsDeviceIdOperationRequest

Extends: `LinkWindowsDeviceIdOperationRequest`

Maps the ServerLinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkWindowsDeviceIdOperationRequest

Extends: `LinkWindowsDeviceIdOperationRequest`

Maps the AdminLinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### LinkWindowsPhoneDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData>`

Maps the LinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerLinkWindowsPhoneDeviceIdOperationRequest

Extends: `LinkWindowsPhoneDeviceIdOperationRequest`

Maps the ServerLinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminLinkWindowsPhoneDeviceIdOperationRequest

Extends: `LinkWindowsPhoneDeviceIdOperationRequest`

Maps the AdminLinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.RemoveSegmentRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.RemoveTagRequestData>`

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

### ResetAccountPasswordOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.ResetAccountPasswordRequestData>`

Maps the ResetAccountPassword operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerResetAccountPasswordOperationRequest

Extends: `ResetAccountPasswordOperationRequest`

Maps the ServerResetAccountPassword operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminResetAccountPasswordOperationRequest

Extends: `ResetAccountPasswordOperationRequest`

Maps the AdminResetAccountPassword operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetAvatarRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetCountryCodeRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetCustomDataRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetDisplayNameRequestData>`

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

### SetEmailOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetEmailRequestData>`

Maps the SetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSetEmailOperationRequest

Extends: `SetEmailOperationRequest`

Maps the ServerSetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSetEmailOperationRequest

Extends: `SetEmailOperationRequest`

Maps the AdminSetEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SetPlayerBanOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetPlayerBanRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.ChangePlayerCurrencyRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetPlayerDataRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.ChangePlayerStatisticsRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SetTagRequestData>`

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

### UpdateTsLastLoginOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UpdateTsLastLoginRequestData>`

Maps the UpdateTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUpdateTsLastLoginOperationRequest

Extends: `UpdateTsLastLoginOperationRequest`

Maps the ServerUpdateTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUpdateTsLastLoginOperationRequest

Extends: `UpdateTsLastLoginOperationRequest`

Maps the AdminUpdateTsLastLogin operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkAccountOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkAccountRequestData>`

Maps the UnlinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkAccountOperationRequest

Extends: `UnlinkAccountOperationRequest`

Maps the ServerUnlinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkAccountOperationRequest

Extends: `UnlinkAccountOperationRequest`

Maps the AdminUnlinkAccount operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkAndroidDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkAndroidDeviceIdRequestData>`

Maps the UnlinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkAndroidDeviceIdOperationRequest

Extends: `UnlinkAndroidDeviceIdOperationRequest`

Maps the ServerUnlinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkAndroidDeviceIdOperationRequest

Extends: `UnlinkAndroidDeviceIdOperationRequest`

Maps the AdminUnlinkAndroidDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkAppleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkAppleRequestData>`

Maps the UnlinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkAppleOperationRequest

Extends: `UnlinkAppleOperationRequest`

Maps the ServerUnlinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkAppleOperationRequest

Extends: `UnlinkAppleOperationRequest`

Maps the AdminUnlinkApple operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkCustomDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkCustomDeviceIdRequestData>`

Maps the UnlinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkCustomDeviceIdOperationRequest

Extends: `UnlinkCustomDeviceIdOperationRequest`

Maps the ServerUnlinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkCustomDeviceIdOperationRequest

Extends: `UnlinkCustomDeviceIdOperationRequest`

Maps the AdminUnlinkCustomDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkCustomIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkCustomIdRequestData>`

Maps the UnlinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkCustomIdOperationRequest

Extends: `UnlinkCustomIdOperationRequest`

Maps the ServerUnlinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkCustomIdOperationRequest

Extends: `UnlinkCustomIdOperationRequest`

Maps the AdminUnlinkCustomId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkEditorDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkEditorDeviceIdRequestData>`

Maps the UnlinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkEditorDeviceIdOperationRequest

Extends: `UnlinkEditorDeviceIdOperationRequest`

Maps the ServerUnlinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkEditorDeviceIdOperationRequest

Extends: `UnlinkEditorDeviceIdOperationRequest`

Maps the AdminUnlinkEditorDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkFacebookOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkFacebookRequestData>`

Maps the UnlinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkFacebookOperationRequest

Extends: `UnlinkFacebookOperationRequest`

Maps the ServerUnlinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkFacebookOperationRequest

Extends: `UnlinkFacebookOperationRequest`

Maps the AdminUnlinkFacebook operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkGenericServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkGenericServiceRequestData>`

Maps the UnlinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkGenericServiceOperationRequest

Extends: `UnlinkGenericServiceOperationRequest`

Maps the ServerUnlinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkGenericServiceOperationRequest

Extends: `UnlinkGenericServiceOperationRequest`

Maps the AdminUnlinkGenericService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkGoogleOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkGoogleRequestData>`

Maps the UnlinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkGoogleOperationRequest

Extends: `UnlinkGoogleOperationRequest`

Maps the ServerUnlinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkGoogleOperationRequest

Extends: `UnlinkGoogleOperationRequest`

Maps the AdminUnlinkGoogle operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkGooglePlayGameServiceOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData>`

Maps the UnlinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkGooglePlayGameServiceOperationRequest

Extends: `UnlinkGooglePlayGameServiceOperationRequest`

Maps the ServerUnlinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkGooglePlayGameServiceOperationRequest

Extends: `UnlinkGooglePlayGameServiceOperationRequest`

Maps the AdminUnlinkGooglePlayGameService operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkGameCenterOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkGameCenterRequestData>`

Maps the UnlinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkGameCenterOperationRequest

Extends: `UnlinkGameCenterOperationRequest`

Maps the ServerUnlinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkGameCenterOperationRequest

Extends: `UnlinkGameCenterOperationRequest`

Maps the AdminUnlinkGameCenter operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkiOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkiOSDeviceIdRequestData>`

Maps the UnlinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkiOSDeviceIdOperationRequest

Extends: `UnlinkiOSDeviceIdOperationRequest`

Maps the ServerUnlinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkiOSDeviceIdOperationRequest

Extends: `UnlinkiOSDeviceIdOperationRequest`

Maps the AdminUnlinkiOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkLinuxDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkLinuxDeviceIdRequestData>`

Maps the UnlinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkLinuxDeviceIdOperationRequest

Extends: `UnlinkLinuxDeviceIdOperationRequest`

Maps the ServerUnlinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkLinuxDeviceIdOperationRequest

Extends: `UnlinkLinuxDeviceIdOperationRequest`

Maps the AdminUnlinkLinuxDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkMacOSDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkMacOSDeviceIdRequestData>`

Maps the UnlinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkMacOSDeviceIdOperationRequest

Extends: `UnlinkMacOSDeviceIdOperationRequest`

Maps the ServerUnlinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkMacOSDeviceIdOperationRequest

Extends: `UnlinkMacOSDeviceIdOperationRequest`

Maps the AdminUnlinkMacOSDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkWindowsDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkWindowsDeviceIdRequestData>`

Maps the UnlinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkWindowsDeviceIdOperationRequest

Extends: `UnlinkWindowsDeviceIdOperationRequest`

Maps the ServerUnlinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkWindowsDeviceIdOperationRequest

Extends: `UnlinkWindowsDeviceIdOperationRequest`

Maps the AdminUnlinkWindowsDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### UnlinkWindowsPhoneDeviceIdOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData>`

Maps the UnlinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerUnlinkWindowsPhoneDeviceIdOperationRequest

Extends: `UnlinkWindowsPhoneDeviceIdOperationRequest`

Maps the ServerUnlinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminUnlinkWindowsPhoneDeviceIdOperationRequest

Extends: `UnlinkWindowsPhoneDeviceIdOperationRequest`

Maps the AdminUnlinkWindowsPhoneDeviceId operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetCurrencyLeaderboardRequestData>`

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

### GetCreateLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetCreateLeaderboardRequestData>`

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

### GetLastLoginLeaderboardOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetLastLoginLeaderboardRequestData>`

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

### GetStatisticsLogOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetStatisticsLogRequestData>`

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

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetCurrencyLogRequestData>`

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

### SendSocketOperationEventOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SendSocketOperationEventRequestData>`

Maps the SendSocketOperationEvent operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSendSocketOperationEventOperationRequest

Extends: `SendSocketOperationEventOperationRequest`

Maps the ServerSendSocketOperationEvent operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSendSocketOperationEventOperationRequest

Extends: `SendSocketOperationEventOperationRequest`

Maps the AdminSendSocketOperationEvent operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SendEmailOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SendEmailRequestData>`

Maps the SendEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSendEmailOperationRequest

Extends: `SendEmailOperationRequest`

Maps the ServerSendEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSendEmailOperationRequest

Extends: `SendEmailOperationRequest`

Maps the AdminSendEmail operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AddPushNotificationOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.AddPushNotificationRequestData>`

Maps the AddPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerAddPushNotificationOperationRequest

Extends: `AddPushNotificationOperationRequest`

Maps the ServerAddPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminAddPushNotificationOperationRequest

Extends: `AddPushNotificationOperationRequest`

Maps the AdminAddPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### RemovePushNotificationOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.RemovePushNotificationRequestData>`

Maps the RemovePushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerRemovePushNotificationOperationRequest

Extends: `RemovePushNotificationOperationRequest`

Maps the ServerRemovePushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminRemovePushNotificationOperationRequest

Extends: `RemovePushNotificationOperationRequest`

Maps the AdminRemovePushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetPushNotificationOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetPushNotificationRequestData>`

Maps the GetPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetPushNotificationOperationRequest

Extends: `GetPushNotificationOperationRequest`

Maps the ServerGetPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetPushNotificationOperationRequest

Extends: `GetPushNotificationOperationRequest`

Maps the AdminGetPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### SendPushNotificationOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.SendPushNotificationRequestData>`

Maps the SendPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerSendPushNotificationOperationRequest

Extends: `SendPushNotificationOperationRequest`

Maps the ServerSendPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminSendPushNotificationOperationRequest

Extends: `SendPushNotificationOperationRequest`

Maps the AdminSendPushNotification operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### GetOnlineStatusOperationRequest

Extends: `CustomOperationRequestAbstract<MasterPlayerModels.GetOnlineStatusRequestData>`

Maps the GetOnlineStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### ServerGetOnlineStatusOperationRequest

Extends: `GetOnlineStatusOperationRequest`

Maps the ServerGetOnlineStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

### AdminGetOnlineStatusOperationRequest

Extends: `GetOnlineStatusOperationRequest`

Maps the AdminGetOnlineStatus operation to a typed request wrapper.

_Không có field public (payload rỗng)._

## Namespace `MasterPlayerResponseModels`

### AddSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the AddSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangeAccountPasswordOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the ChangeAccountPassword operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCountryCodeOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetCountryCode operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetEmailOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetEmail operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetExternalOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetExternal operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetIpAddressCreateOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetIpAddressCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerBanOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPlayerBan operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPlayerCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerDataOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPlayerData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerInformationOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPlayerInformation operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayerStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPlayerStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithAppleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithAppleResponseData>`

Maps the GetPlayersWithApple operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayersWithUserIdResponseData>`

Maps the GetPlayersWithDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithFacebookOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithFacebookResponseData>`

Maps the GetPlayersWithFacebook operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGenericServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithGenericServiceResponseData>`

Maps the GetPlayersWithGenericService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGoogleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithGoogleResponseData>`

Maps the GetPlayersWithGoogle operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGooglePlayGameServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithGooglePlayGameServiceResponseData>`

Maps the GetPlayersWithGooglePlayGameService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithGameCenterOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetPlayersWithGameCenterResponseData>`

Maps the GetPlayersWithGameCenter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayersWithUserIdResponseData>`

Maps the GetPlayersWithSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPlayersWithTagOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayersWithUserIdResponseData>`

Maps the GetPlayersWithTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardAroundPlayerOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboardAroundPlayer operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetStatisticsLeaderboardResponseData>`

Maps the GetStatisticsLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTagOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsCreateOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetTsCreate operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetTsLastLoginOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetTsLastLogin operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkAccountOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkAccount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkAndroidDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkAndroidDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkAppleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkApple operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkCustomDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkCustomDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkCustomIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkCustomId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkEditorDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkEditorDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkFacebookOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkFacebook operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkGenericServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GenericServiceMasterPlayerResponseData>`

Maps the LinkGenericService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkGoogleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkGoogle operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkGooglePlayGameServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkGooglePlayGameService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkGameCenterOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkGameCenter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkiOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkiOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkLinuxDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkLinuxDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkMacOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkMacOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkWindowsDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkWindowsDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### LinkWindowsPhoneDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the LinkWindowsPhoneDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveSegmentOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the RemoveSegment operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemoveTagOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the RemoveTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ResetAccountPasswordOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the ResetAccountPassword operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetAvatarOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetAvatar operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCountryCodeOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetCountryCode operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetCustomDataOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the SetCustomData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetDisplayNameOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetDisplayName operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetEmailOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetEmail operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetPlayerBanOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetPlayerBan operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerCurrencyOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the ChangePlayerCurrency operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetPlayerDataOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the SetPlayerData operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### ChangePlayerStatisticsOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the ChangePlayerStatistics operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SetTagOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SetTag operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UpdateTsLastLoginOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UpdateTsLastLogin operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkAccountOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkAccount operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkAndroidDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkAndroidDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkAppleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkApple operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkCustomDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkCustomDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkCustomIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkCustomId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkEditorDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkEditorDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkFacebookOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkFacebook operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkGenericServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkGenericService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkGoogleOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkGoogle operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkGooglePlayGameServiceOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkGooglePlayGameService operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkGameCenterOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkGameCenter operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkiOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkiOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkLinuxDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkLinuxDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkMacOSDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkMacOSDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkWindowsDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkWindowsDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### UnlinkWindowsPhoneDeviceIdOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the UnlinkWindowsPhoneDeviceId operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetCurrencyLeaderboardResponseData>`

Maps the GetCurrencyLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCreateLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetCreateLeaderboardResponseData>`

Maps the GetCreateLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetLastLoginLeaderboardOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetLastLoginLeaderboardResponseData>`

Maps the GetLastLoginLeaderboard operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetStatisticsLogOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetStatisticsLogResponseData>`

Maps the GetStatisticsLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetCurrencyLogOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.GetCurrencyLogResponseData>`

Maps the GetCurrencyLog operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SendSocketOperationEventOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SendSocketOperationEvent operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SendEmailOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the SendEmail operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### AddPushNotificationOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.AddPushNotificationResponseData>`

Maps the AddPushNotification operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### RemovePushNotificationOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.EmptyResponseData>`

Maps the RemovePushNotification operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetPushNotificationOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetPushNotification operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### SendPushNotificationOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.SendPushNotificationResponseData>`

Maps the SendPushNotification operation to a typed response wrapper.

_Không có field public (payload rỗng)._

### GetOnlineStatusOperationResponse

Extends: `CustomOperationResponseAbstract<MasterPlayerModels.MasterPlayerResponseData>`

Maps the GetOnlineStatus operation to a typed response wrapper.

_Không có field public (payload rỗng)._
