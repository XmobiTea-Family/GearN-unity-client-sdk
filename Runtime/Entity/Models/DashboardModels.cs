namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

    public partial class DashboardModels
    {
        public class ChangePasswordAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string currentPassword;

            [StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class GetAdminAccountListRequestData
        {
        }

        public class GetGameInformationRequestData
        {
            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

        }

        public class GetGameListRequestData
        {
        }

        public class GetMasterGameSettingsRequestData
        {
        }

        public class GetSecretInfoInformationRequestData
        {
            [StringDataMember(code = GNParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class GetSecretInfoListRequestData
        {
        }

        public class GetServerLogRequestData
        {
            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 50, minValue = 5, maxValue = 200, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class GrantAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            [StringDataMember(code = GNParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class GrantGameRequestData
        {
            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

        }

        public class GrantSecretInfoRequestData
        {
            [StringDataMember(code = GNParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true, isOptional = true)]
            public string? secretKey;

            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? gameId;

            [NumberDataMember(code = GNParameterCode.Role, mustInt = true)]
            public int role;

            [GNHashtableDataMember(code = GNParameterCode.Permission, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        public class LoginByAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class RemoveAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class SetGameInformationRequestData
        {
            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [StringDataMember(code = GNParameterCode.GameName, isOptional = true)]
            public string? gameName;

            [StringDataMember(code = GNParameterCode.GameDescription, isOptional = true)]
            public string? gameDescription;

            [StringDataMember(code = GNParameterCode.GameIconUrl, isOptional = true)]
            public string? gameIconUrl;

            [GNHashtableDataMember(code = GNParameterCode.GameSettings, isOptional = true)]
            public GameSettingsParam? gameSettings;

            [GNArrayDataMember(code = GNParameterCode.MatchmakingQueueSettings, isOptional = true, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam>? matchmakingQueueSettings;

        }

        public class SetMasterGameSettingsRequestData
        {
            [GNHashtableDataMember(code = GNParameterCode.ThirtPartySettings, isOptional = true)]
            public ThirtPartyParam? thirtPartySettings;

            [GNHashtableDataMember(code = GNParameterCode.MasterPlayerSettings, isOptional = true)]
            public MasterPlayerSettingsParam? masterPlayerSettings;

            [GNHashtableDataMember(code = GNParameterCode.EmailSettings, isOptional = true)]
            public EmailSettingsParam? emailSettings;

            [GNHashtableDataMember(code = GNParameterCode.PushNotificationSettings, isOptional = true)]
            public PushNotificationSettingsParam? pushNotificationSettings;

        }

        public class SetPasswordAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class SetSecretInfoInformationRequestData
        {
            [StringDataMember(code = GNParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

            [BooleanDataMember(code = GNParameterCode.Remove, isOptional = true)]
            public bool? remove;

            [NumberDataMember(code = GNParameterCode.TsExpire, isOptional = true)]
            public long? tsExpire;

            [GNHashtableDataMember(code = GNParameterCode.Permission, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        public class SetSecretKeyAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = GNParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class GetUsernameAdminAccountRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class GetAnalyticsRequestData
        {
            [NumberDataMember(code = GNParameterCode.Timestamp, minValue = 0, isOptional = true)]
            public long? timestamp;

            [BooleanDataMember(code = GNParameterCode.AnalyticsItem, isOptional = true)]
            public bool? analyticsItem;

            [BooleanDataMember(code = GNParameterCode.Country, isOptional = true)]
            public bool? country;

            [BooleanDataMember(code = GNParameterCode.RequestComplete, isOptional = true)]
            public bool? requestComplete;

            [BooleanDataMember(code = GNParameterCode.OperationSystem, isOptional = true)]
            public bool? operationSystem;

            [BooleanDataMember(code = GNParameterCode.DatabaseSystem, isOptional = true)]
            public bool? databaseSystem;

            [BooleanDataMember(code = GNParameterCode.Cost, isOptional = true)]
            public bool? cost;

            [BooleanDataMember(code = GNParameterCode.MonthlyCost, isOptional = true)]
            public bool? monthlyCost;

        }

        public class GetEventCallbackCloudScriptRequestData
        {
        }

        public class SetEventCallbackCloudScriptRequestData
        {
            [StringDataMember(code = GNParameterCode.EventName, minLength = 6, maxLength = 128, mustNonNull = true)]
            public string eventName;

            [StringDataMember(code = GNParameterCode.Script, minLength = 6, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

        }

        public class ResetStatisticsLeaderboardRequestData
        {
            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = GNParameterCode.Version, minLength = 2, maxLength = 32)]
            public string version;

            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [StringDataMember(code = GNParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class GetBackupStatisticsLeaderboardVersionRequestData
        {
            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [NumberDataMember(code = GNParameterCode.OwnerType, mustInt = true)]
            public int type;

            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

        }

        public class GetServerGameDataRequestData
        {
            [StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [BooleanDataMember(code = GNParameterCode.MasterPlayerCount, isOptional = true)]
            public bool? masterPlayerCount;

            [BooleanDataMember(code = GNParameterCode.GamePlayerCount, isOptional = true)]
            public bool? gamePlayerCount;

            [BooleanDataMember(code = GNParameterCode.CharacterPlayerCount, isOptional = true)]
            public bool? characterPlayerCount;

            [BooleanDataMember(code = GNParameterCode.InventoryCount, isOptional = true)]
            public bool? inventoryCount;

            [BooleanDataMember(code = GNParameterCode.StoreInventoryCount, isOptional = true)]
            public bool? storeInventoryCount;

            [BooleanDataMember(code = GNParameterCode.GroupCount, isOptional = true)]
            public bool? groupCount;

            [BooleanDataMember(code = GNParameterCode.Country, isOptional = true)]
            public bool? country;

            [BooleanDataMember(code = GNParameterCode.Version, isOptional = true)]
            public bool? version;

        }

    }

    public partial class DashboardModels
    {
        public class AuthenticatePermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.LoginByAccount, isOptional = true)]
            public PermissionRulesParam? loginByAccount;

            [GNHashtableDataMember(code = GNParameterCode.LoginByAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByAndroidDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByApple, isOptional = true)]
            public PermissionRulesParam? loginByApple;

            [GNHashtableDataMember(code = GNParameterCode.LoginByCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByCustomDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByCustomId, isOptional = true)]
            public PermissionRulesParam? loginByCustomId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByFacebook, isOptional = true)]
            public PermissionRulesParam? loginByFacebook;

            [GNHashtableDataMember(code = GNParameterCode.LoginByGenericService, isOptional = true)]
            public PermissionRulesParam? loginByGenericService;

            [GNHashtableDataMember(code = GNParameterCode.LoginByGoogle, isOptional = true)]
            public PermissionRulesParam? loginByGoogle;

            [GNHashtableDataMember(code = GNParameterCode.LoginByGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? loginByGooglePlayGameService;

            [GNHashtableDataMember(code = GNParameterCode.LoginByGameCenter, isOptional = true)]
            public PermissionRulesParam? loginByGameCenter;

            [GNHashtableDataMember(code = GNParameterCode.LoginByiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByiOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.RegisterAccount, isOptional = true)]
            public PermissionRulesParam? registerAccount;

            [GNHashtableDataMember(code = GNParameterCode.LoginByEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByEditorDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByLinuxDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByMacOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LoginByWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.RefreshAuthToken, isOptional = true)]
            public PermissionRulesParam? refreshAuthToken;
        }

        public class CharacterCatalogSettingsParam
        {
            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

        }

        public class CharacterPlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = GNParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = GNParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = GNParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = GNParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = GNParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = GNParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = GNParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = GNParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? setPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? setPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = GNParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            [GNHashtableDataMember(code = GNParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            [GNHashtableDataMember(code = GNParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            [GNHashtableDataMember(code = GNParameterCode.GrantPlayerItem, isOptional = true)]
            public PermissionRulesParam? grantPlayerItem;

            [GNHashtableDataMember(code = GNParameterCode.GrantGroup, isOptional = true)]
            public PermissionRulesParam? grantGroup;

            [GNHashtableDataMember(code = GNParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            [GNHashtableDataMember(code = GNParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            [GNHashtableDataMember(code = GNParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            [GNHashtableDataMember(code = GNParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class CharacterPlayerSettingsParam
        {
            [GNArrayDataMember(code = GNParameterCode.CurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrencySettings;

            [GNArrayDataMember(code = GNParameterCode.StatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = GNParameterCode.DatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = GNParameterCode.GroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            [GNArrayDataMember(code = GNParameterCode.ItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            [GNArrayDataMember(code = GNParameterCode.FriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        public class ContentPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.GetContentData, isOptional = true)]
            public PermissionRulesParam? getContentData;

            [GNHashtableDataMember(code = GNParameterCode.SetContentData, isOptional = true)]
            public PermissionRulesParam? setContentData;

            [GNHashtableDataMember(code = GNParameterCode.CreateNewFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? createNewFileUploadInfo;

            [GNHashtableDataMember(code = GNParameterCode.GetFileUploadInfoList, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfoList;

            [GNHashtableDataMember(code = GNParameterCode.GetFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfo;

            [GNHashtableDataMember(code = GNParameterCode.RemoveFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? removeFileUploadInfo;

            [GNHashtableDataMember(code = GNParameterCode.RequestDownloadFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? requestDownloadFileUploadInfo;

        }

        public class CurrencySettingsParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [NumberDataMember(code = GNParameterCode.InitialValue)]
            public double initialValue;

            [StringDataMember(code = GNParameterCode.DisplayName, minLength = 2, maxLength = 64)]
            public string displayName;

            [BooleanDataMember(code = GNParameterCode.Index)]
            public bool index;

        }

        public class DataSettingsParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = GNParameterCode.DisplayName, minLength = 2, maxLength = 64)]
            public string displayName;

            [NumberDataMember(code = GNParameterCode.Permission, mustInt = true)]
            public int permission;

        }

        public class FriendCatalogSettingsParam
        {
            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [BooleanDataMember(code = GNParameterCode.ForceAcceptFriend)]
            public bool forceAcceptFriend;

        }

        public class EmailSettingsParam
        {
            [StringDataMember(code = GNParameterCode.SendFrom)]
            public string sendFrom;

            [StringDataMember(code = GNParameterCode.SendGridApiKey)]
            public string sendGridApiKey;

        }

        public class PushNotificationSettingsParam
        {
            [StringDataMember(code = GNParameterCode.ProjectId)]
            public string projectId;

            [StringDataMember(code = GNParameterCode.ClientEmail)]
            public string clientEmail;

            [StringDataMember(code = GNParameterCode.PrivateKey)]
            public string privateKey;

        }

        public class GamePlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = GNParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = GNParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = GNParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = GNParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = GNParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = GNParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = GNParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = GNParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? setPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? setPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerCharacter, isOptional = true)]
            public PermissionRulesParam? getPlayerCharacter;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            [GNHashtableDataMember(code = GNParameterCode.GetOnlineStatus, isOptional = true)]
            public PermissionRulesParam? getOnlineStatus;

            [GNHashtableDataMember(code = GNParameterCode.GrantGroup, isOptional = true)]
            public PermissionRulesParam? grantGroup;

            [GNHashtableDataMember(code = GNParameterCode.GrantPlayerItem, isOptional = true)]
            public PermissionRulesParam? grantPlayerItem;

            [GNHashtableDataMember(code = GNParameterCode.GrantPlayerCharacter, isOptional = true)]
            public PermissionRulesParam? grantPlayerCharacter;

            [GNHashtableDataMember(code = GNParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            [GNHashtableDataMember(code = GNParameterCode.RemovePlayerCharacter, isOptional = true)]
            public PermissionRulesParam? removePlayerCharacter;

            [GNHashtableDataMember(code = GNParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            [GNHashtableDataMember(code = GNParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class GamePlayerSettingsParam
        {
            [GNArrayDataMember(code = GNParameterCode.CurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrencySettings;

            [GNArrayDataMember(code = GNParameterCode.StatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = GNParameterCode.DatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = GNParameterCode.CharacterCatalogSettings, elementCls = typeof(CharacterCatalogSettingsParam), isOptional = true)]
            public List<CharacterCatalogSettingsParam>? playerCharacterCatalogSettings;

            [GNArrayDataMember(code = GNParameterCode.GroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            [GNArrayDataMember(code = GNParameterCode.ItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            [GNArrayDataMember(code = GNParameterCode.FriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        public class GameSettingsParam
        {
            [GNHashtableDataMember(code = GNParameterCode.GamePlayerSettings, isOptional = true)]
            public GamePlayerSettingsParam? gamePlayerSettings;

            [GNHashtableDataMember(code = GNParameterCode.CharacterPlayerSettings, isOptional = true)]
            public CharacterPlayerSettingsParam? characterPlayerSettings;

            [GNHashtableDataMember(code = GNParameterCode.GroupSettings, isOptional = true)]
            public GroupSettingsParam? groupSettings;

            [GNHashtableDataMember(code = GNParameterCode.InventorySettings, isOptional = true)]
            public InventorySettingsParam? inventorySettings;

        }

        public class GenericServiceSettingsParam
        {
            [StringDataMember(code = GNParameterCode.ServiceName, minLength = 2, maxLength = 32)]
            public string serviceName;

        }

        public class GroupCatalogSettingsParam
        {
            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            [BooleanDataMember(code = GNParameterCode.ForceAcceptMember)]
            public bool forceAcceptMember;

        }

        public class GroupPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = GNParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = GNParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = GNParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = GNParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = GNParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = GNParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = GNParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = GNParameterCode.SetGroupCurrency, isOptional = true)]
            public PermissionRulesParam? setGroupCurrency;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupCurrency, isOptional = true)]
            public PermissionRulesParam? getGroupCurrency;

            [GNHashtableDataMember(code = GNParameterCode.SetGroupStatistics, isOptional = true)]
            public PermissionRulesParam? setGroupStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupStatistics, isOptional = true)]
            public PermissionRulesParam? getGroupStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboardAroundGroup, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundGroup;

            [GNHashtableDataMember(code = GNParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetGroupData, isOptional = true)]
            public PermissionRulesParam? setGroupData;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupData, isOptional = true)]
            public PermissionRulesParam? getGroupData;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupInformation, isOptional = true)]
            public PermissionRulesParam? getGroupInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupsWithSegment, isOptional = true)]
            public PermissionRulesParam? getGroupsWithSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupsWithTag, isOptional = true)]
            public PermissionRulesParam? getGroupsWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = GNParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupInventory, isOptional = true)]
            public PermissionRulesParam? getGroupInventory;

            [GNHashtableDataMember(code = GNParameterCode.RemoveGroupItem, isOptional = true)]
            public PermissionRulesParam? removeGroupItem;

            [GNHashtableDataMember(code = GNParameterCode.GrantGroupItem, isOptional = true)]
            public PermissionRulesParam? grantGroupItem;

            [GNHashtableDataMember(code = GNParameterCode.GetMembers, isOptional = true)]
            public PermissionRulesParam? getMembers;

            [GNHashtableDataMember(code = GNParameterCode.AddMember, isOptional = true)]
            public PermissionRulesParam? addMember;

            [GNHashtableDataMember(code = GNParameterCode.RemoveMember, isOptional = true)]
            public PermissionRulesParam? removeMember;

            [GNHashtableDataMember(code = GNParameterCode.SendGroupMessage, isOptional = true)]
            public PermissionRulesParam? sendGroupMessage;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupMessage, isOptional = true)]
            public PermissionRulesParam? getGroupMessage;

            [GNHashtableDataMember(code = GNParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.GetGroupsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getGroupsWithDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class GroupSettingsParam
        {
            [GNArrayDataMember(code = GNParameterCode.CurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? groupCurrencySettings;

            [GNArrayDataMember(code = GNParameterCode.StatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? groupStatisticsSettings;

            [GNArrayDataMember(code = GNParameterCode.DatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? groupDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = GNParameterCode.ItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? groupItemCatalogSettings;

        }

        public class InventoryPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = GNParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = GNParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = GNParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = GNParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = GNParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = GNParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = GNParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = GNParameterCode.SetItemStatistics, isOptional = true)]
            public PermissionRulesParam? setItemStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetItemStatistics, isOptional = true)]
            public PermissionRulesParam? getItemStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboardAroundItem, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundItem;

            [GNHashtableDataMember(code = GNParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetItemData, isOptional = true)]
            public PermissionRulesParam? setItemData;

            [GNHashtableDataMember(code = GNParameterCode.GetItemData, isOptional = true)]
            public PermissionRulesParam? getItemData;

            [GNHashtableDataMember(code = GNParameterCode.GetItemInformation, isOptional = true)]
            public PermissionRulesParam? getItemInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetItemsWithSegment, isOptional = true)]
            public PermissionRulesParam? getItemsWithSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getItemsWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = GNParameterCode.GetClassId, isOptional = true)]
            public PermissionRulesParam? getClassId;

            [GNHashtableDataMember(code = GNParameterCode.GetItemType, isOptional = true)]
            public PermissionRulesParam? getItemType;

            [GNHashtableDataMember(code = GNParameterCode.GetAmount, isOptional = true)]
            public PermissionRulesParam? getAmount;

            [GNHashtableDataMember(code = GNParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            [GNHashtableDataMember(code = GNParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.SetAmount, isOptional = true)]
            public PermissionRulesParam? setAmount;

            [GNHashtableDataMember(code = GNParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            [GNHashtableDataMember(code = GNParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.GetItemsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getItemsWithDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

        }

        public class InventorySettingsParam
        {
            [GNArrayDataMember(code = GNParameterCode.StatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? inventoryStatisticsSettings;

            [GNArrayDataMember(code = GNParameterCode.DatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? inventoryDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        public class ItemCatalogSettingsParam
        {
            [StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [NumberDataMember(code = GNParameterCode.ItemType, mustInt = true)]
            public int itemType;

            [GNArrayDataMember(code = GNParameterCode.ItemClassSettings, elementCls = typeof(ItemClassSettingsParam))]
            public List<ItemClassSettingsParam> itemClassSettings;

        }

        public class ItemClassSettingsParam
        {
            [StringDataMember(code = GNParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            [StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

        }

        public class MasterAdminPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.SetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? setMasterGameSettings;

            [GNHashtableDataMember(code = GNParameterCode.GrantAdminAccount, isOptional = true)]
            public PermissionRulesParam? grantAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.RemoveAdminAccount, isOptional = true)]
            public PermissionRulesParam? removeAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.SetPasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? setPasswordAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.SetSecretKeyAdminAccount, isOptional = true)]
            public PermissionRulesParam? setSecretKeyAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.SetGameInformation, isOptional = true)]
            public PermissionRulesParam? setGameInformation;

            [GNHashtableDataMember(code = GNParameterCode.GrantGame, isOptional = true)]
            public PermissionRulesParam? grantGame;

            [GNHashtableDataMember(code = GNParameterCode.ChangePasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? changePasswordAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.GetAdminAccountList, isOptional = true)]
            public PermissionRulesParam? getAdminAccountList;

            [GNHashtableDataMember(code = GNParameterCode.GetGameInformation, isOptional = true)]
            public PermissionRulesParam? getGameInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetGameList, isOptional = true)]
            public PermissionRulesParam? getGameList;

            [GNHashtableDataMember(code = GNParameterCode.GetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? getMasterGameSettings;

            [GNHashtableDataMember(code = GNParameterCode.GetServerLog, isOptional = true)]
            public PermissionRulesParam? getServerLog;

            [GNHashtableDataMember(code = GNParameterCode.GetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? getSecretInfoInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetSecretInfoList, isOptional = true)]
            public PermissionRulesParam? getSecretInfoList;

            [GNHashtableDataMember(code = GNParameterCode.GrantSecretInfo, isOptional = true)]
            public PermissionRulesParam? grantSecretInfo;

            [GNHashtableDataMember(code = GNParameterCode.SetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? setSecretInfoInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetUsernameAdminAccount, isOptional = true)]
            public PermissionRulesParam? getUsernameAdminAccount;

            [GNHashtableDataMember(code = GNParameterCode.GetAnalytics, isOptional = true)]
            public PermissionRulesParam? getAnalytics;

            [GNHashtableDataMember(code = GNParameterCode.GetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? getEventCallbackCloudScript;

            [GNHashtableDataMember(code = GNParameterCode.SetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? setEventCallbackCloudScript;

            [GNHashtableDataMember(code = GNParameterCode.ResetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? resetStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetBackupStatisticsLeaderboardVersion, isOptional = true)]
            public PermissionRulesParam? getBackupStatisticsLeaderboardVersion;

            [GNHashtableDataMember(code = GNParameterCode.GetServerGameData, isOptional = true)]
            public PermissionRulesParam? getServerGameData;

        }

        public class MultiplayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.CancelAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelAllMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.CancelMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.CreateMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? createMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.GetMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.GetMatch, isOptional = true)]
            public PermissionRulesParam? getMatch;

            [GNHashtableDataMember(code = GNParameterCode.GetQueueStatistics, isOptional = true)]
            public PermissionRulesParam? getQueueStatistics;

            [GNHashtableDataMember(code = GNParameterCode.JoinMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? joinMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.ListMatchmakingTicketsForPlayer, isOptional = true)]
            public PermissionRulesParam? listMatchmakingTicketsForPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getAllMatchmakingTicket;

            [GNHashtableDataMember(code = GNParameterCode.GetAllMatch, isOptional = true)]
            public PermissionRulesParam? getAllMatch;

        }

        public class MasterPlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.LinkAccount, isOptional = true)]
            public PermissionRulesParam? linkAccount;

            [GNHashtableDataMember(code = GNParameterCode.LinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? linkAndroidDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkApple, isOptional = true)]
            public PermissionRulesParam? linkApple;

            [GNHashtableDataMember(code = GNParameterCode.LinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? linkCustomDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkCustomId, isOptional = true)]
            public PermissionRulesParam? linkCustomId;

            [GNHashtableDataMember(code = GNParameterCode.LinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? linkEditorDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkFacebook, isOptional = true)]
            public PermissionRulesParam? linkFacebook;

            [GNHashtableDataMember(code = GNParameterCode.LinkGenericService, isOptional = true)]
            public PermissionRulesParam? linkGenericService;

            [GNHashtableDataMember(code = GNParameterCode.LinkGoogle, isOptional = true)]
            public PermissionRulesParam? linkGoogle;

            [GNHashtableDataMember(code = GNParameterCode.LinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? linkGooglePlayGameService;

            [GNHashtableDataMember(code = GNParameterCode.LinkGameCenter, isOptional = true)]
            public PermissionRulesParam? linkGameCenter;

            [GNHashtableDataMember(code = GNParameterCode.LinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkiOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? linkLinuxDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkMacOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.LinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkAccount, isOptional = true)]
            public PermissionRulesParam? unlinkAccount;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkAndroidDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkApple, isOptional = true)]
            public PermissionRulesParam? unlinkApple;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkCustomId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkEditorDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkFacebook, isOptional = true)]
            public PermissionRulesParam? unlinkFacebook;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkGenericService, isOptional = true)]
            public PermissionRulesParam? unlinkGenericService;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkGoogle, isOptional = true)]
            public PermissionRulesParam? unlinkGoogle;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? unlinkGooglePlayGameService;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkGameCenter, isOptional = true)]
            public PermissionRulesParam? unlinkGameCenter;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkiOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkLinuxDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkMacOSDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.UnlinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = GNParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = GNParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = GNParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = GNParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = GNParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = GNParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = GNParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = GNParameterCode.SetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? setTsLastLogin;

            [GNHashtableDataMember(code = GNParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = GNParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = GNParameterCode.ChangeAccountPassword, isOptional = true)]
            public PermissionRulesParam? changeAccountPassword;

            [GNHashtableDataMember(code = GNParameterCode.ResetAccountPassword, isOptional = true)]
            public PermissionRulesParam? resetAccountPassword;

            [GNHashtableDataMember(code = GNParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = GNParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? setPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? setPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = GNParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithApple, isOptional = true)]
            public PermissionRulesParam? getPlayersWithApple;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithFacebook, isOptional = true)]
            public PermissionRulesParam? getPlayersWithFacebook;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithGoogle, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGoogle;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithGenericService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGenericService;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGooglePlayGameService;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithGameCenter, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGameCenter;

            [GNHashtableDataMember(code = GNParameterCode.GetExternal, isOptional = true)]
            public PermissionRulesParam? getExternal;

            [GNHashtableDataMember(code = GNParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = GNParameterCode.GetEmail, isOptional = true)]
            public PermissionRulesParam? getEmail;

            [GNHashtableDataMember(code = GNParameterCode.SetEmail, isOptional = true)]
            public PermissionRulesParam? setEmail;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = GNParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

            [GNHashtableDataMember(code = GNParameterCode.SendSocketOperationEvent, isOptional = true)]
            public PermissionRulesParam? sendSocketOperationEvent;

            [GNHashtableDataMember(code = GNParameterCode.SendEmail, isOptional = true)]
            public PermissionRulesParam? sendEmail;

            [GNHashtableDataMember(code = GNParameterCode.SendPushNotification, isOptional = true)]
            public PermissionRulesParam? sendPushNotification;

            [GNHashtableDataMember(code = GNParameterCode.AddPushNotification, isOptional = true)]
            public PermissionRulesParam? addPushNotification;

            [GNHashtableDataMember(code = GNParameterCode.RemovePushNotification, isOptional = true)]
            public PermissionRulesParam? removePushNotification;

            [GNHashtableDataMember(code = GNParameterCode.GetPushNotification, isOptional = true)]
            public PermissionRulesParam? getPushNotification;

        }

        public class MasterPlayerSettingsParam
        {
            [GNArrayDataMember(code = GNParameterCode.GenericServiceSettings, elementCls = typeof(GenericServiceSettingsParam), isOptional = true)]
            public List<GenericServiceSettingsParam>? genericServiceSettings;

            [GNArrayDataMember(code = GNParameterCode.CurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrencySettings;

            [GNArrayDataMember(code = GNParameterCode.StatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = GNParameterCode.DatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        public class CloudScriptPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.ExecuteFunction, isOptional = true)]
            public PermissionRulesParam? executeFunction;

            [GNHashtableDataMember(code = GNParameterCode.AddFunction, isOptional = true)]
            public PermissionRulesParam? addFunction;

            [GNHashtableDataMember(code = GNParameterCode.GetFunctions, isOptional = true)]
            public PermissionRulesParam? getFunctions;

            [GNHashtableDataMember(code = GNParameterCode.GetFunction, isOptional = true)]
            public PermissionRulesParam? getFunction;

            [GNHashtableDataMember(code = GNParameterCode.EditFunction, isOptional = true)]
            public PermissionRulesParam? editFunction;

        }

        public class PermissionParam
        {
            [GNHashtableDataMember(code = GNParameterCode.Authenticate, isOptional = true)]
            public AuthenticatePermissionRulesParam? authenticate;

            [GNHashtableDataMember(code = GNParameterCode.MasterPlayer, isOptional = true)]
            public MasterPlayerPermissionRulesParam? masterPlayer;

            [GNHashtableDataMember(code = GNParameterCode.GamePlayer, isOptional = true)]
            public GamePlayerPermissionRulesParam? gamePlayer;

            [GNHashtableDataMember(code = GNParameterCode.CharacterPlayer, isOptional = true)]
            public CharacterPlayerPermissionRulesParam? characterPlayer;

            [GNHashtableDataMember(code = GNParameterCode.Content, isOptional = true)]
            public ContentPermissionRulesParam? content;

            [GNHashtableDataMember(code = GNParameterCode.Group, isOptional = true)]
            public GroupPermissionRulesParam? group;

            [GNHashtableDataMember(code = GNParameterCode.Inventory, isOptional = true)]
            public InventoryPermissionRulesParam? inventory;

            [GNHashtableDataMember(code = GNParameterCode.StoreInventory, isOptional = true)]
            public StoreInventoryPermissionRulesParam? storeInventory;

            [GNHashtableDataMember(code = GNParameterCode.MasterAdmin, isOptional = true)]
            public MasterAdminPermissionRulesParam? masterAdmin;

            [GNHashtableDataMember(code = GNParameterCode.Multiplayer, isOptional = true)]
            public MultiplayerPermissionRulesParam? multiplayer;

            [GNHashtableDataMember(code = GNParameterCode.CloudScript, isOptional = true)]
            public CloudScriptPermissionRulesParam? cloudScript;

        }

        public class PermissionRulesParam
        {
            [BooleanDataMember(code = GNParameterCode.SelfEnable, isOptional = true)]
            public bool? selfEnable;

            [BooleanDataMember(code = GNParameterCode.OtherSelfEnable, isOptional = true)]
            public bool? otherSelfEnable;

            [BooleanDataMember(code = GNParameterCode.AdminSelfEnable, isOptional = true)]
            public bool? adminSelfEnable;

            [BooleanDataMember(code = GNParameterCode.ServerSelfEnable, isOptional = true)]
            public bool? serverSelfEnable;

        }

        public class StatisticsSettingsParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [NumberDataMember(code = GNParameterCode.StatisticsAggregationMethod, mustInt = true)]
            public int statisticsAggregationMethod;

            [NumberDataMember(code = GNParameterCode.MaximumValue, isOptional = true, defaultValue = 0)]
            public double? maximumValue;

            [NumberDataMember(code = GNParameterCode.MinimumValue, isOptional = true, defaultValue = 0)]
            public double? minimumValue;

            [NumberDataMember(code = GNParameterCode.InitialValue)]
            public double initialValue;

            [StringDataMember(code = GNParameterCode.DisplayName, minLength = 2, maxLength = 64)]
            public string displayName;

            [BooleanDataMember(code = GNParameterCode.Index)]
            public bool index;

        }

        public class StoreInventoryPermissionRulesParam
        {
            [GNHashtableDataMember(code = GNParameterCode.BuyStoreItem, isOptional = true)]
            public PermissionRulesParam? buyStoreItem;

            [GNHashtableDataMember(code = GNParameterCode.GetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? getStoreItemInformation;

            [GNHashtableDataMember(code = GNParameterCode.GetStoreItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getStoreItemsWithTag;

            [GNHashtableDataMember(code = GNParameterCode.GrantStoreItem, isOptional = true)]
            public PermissionRulesParam? grantStoreItem;

            [GNHashtableDataMember(code = GNParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = GNParameterCode.SetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? setStoreItemInformation;

            [GNHashtableDataMember(code = GNParameterCode.ValidateAppleAppStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateAppleAppStoreReceipt;

            [GNHashtableDataMember(code = GNParameterCode.ValidateGooglePlayStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateGooglePlayStoreReceipt;

            [GNHashtableDataMember(code = GNParameterCode.ValidateFacebookStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateFacebookStoreReceipt;

            [GNHashtableDataMember(code = GNParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = GNParameterCode.PresentStoreItem, isOptional = true)]
            public PermissionRulesParam? presentStoreItem;

            [GNHashtableDataMember(code = GNParameterCode.GetStoreLog, isOptional = true)]
            public PermissionRulesParam? getStoreLog;

            [GNHashtableDataMember(code = GNParameterCode.GetStoreUsed, isOptional = true)]
            public PermissionRulesParam? getStoreUsed;

            [GNHashtableDataMember(code = GNParameterCode.RemoveStoreUsed, isOptional = true)]
            public PermissionRulesParam? removeStoreUsed;

        }

        public class TagSettingsParam
        {
            [StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
            public string? displayName;

            [BooleanDataMember(code = GNParameterCode.Index)]
            public bool index;

        }

        public class ThirtPartyAppleSettingsParam
        {
            [StringDataMember(code = GNParameterCode.AppleClientId)]
            public string appleClientId;

            [BooleanDataMember(code = GNParameterCode.SandboxEnable)]
            public bool sandboxEnable;

        }

        public class ThirtPartyFacebookSettingsParam
        {
            [StringDataMember(code = GNParameterCode.FacebookAppId)]
            public string facebookAppId;

            [StringDataMember(code = GNParameterCode.FacebookAppToken)]
            public string facebookAppToken;

            [StringDataMember(code = GNParameterCode.FacebookInappSecret)]
            public string facebookInappSecret;

        }

        public class ThirtPartyGoogleSettingsParam
        {
            [StringDataMember(code = GNParameterCode.GoogleClientId)]
            public string googleClientId;

            [StringDataMember(code = GNParameterCode.PackageId)]
            public string packageId;

            [StringDataMember(code = GNParameterCode.PublicRSAKey)]
            public string publicRSAKey;

        }

        public class ThirtPartyGameCenterSettingsParam
        {
            [StringDataMember(code = GNParameterCode.PackageId)]
            public string packageId;

        }

        public class ThirtPartyGooglePlayGameSettingsParam
        {
            [StringDataMember(code = GNParameterCode.RedirectUri)]
            public string redirectUri;

            [StringDataMember(code = GNParameterCode.ClientId)]
            public string clientId;

            [StringDataMember(code = GNParameterCode.ClientSecret)]
            public string clientSecret;

            [StringDataMember(code = GNParameterCode.ApplicationId)]
            public string applicationId;

        }

        public class ThirtPartyParam
        {
            [GNHashtableDataMember(code = GNParameterCode.GoogleSettings, isOptional = true)]
            public ThirtPartyGoogleSettingsParam? googleSettings;

            [GNHashtableDataMember(code = GNParameterCode.FacebookSettings, isOptional = true)]
            public ThirtPartyFacebookSettingsParam? facebookSettings;

            [GNHashtableDataMember(code = GNParameterCode.AppleSettings, isOptional = true)]
            public ThirtPartyAppleSettingsParam? appleSettings;

            [GNHashtableDataMember(code = GNParameterCode.GooglePlayGameService, isOptional = true)]
            public ThirtPartyGooglePlayGameSettingsParam? googlePlayGameSettings;

            [GNHashtableDataMember(code = GNParameterCode.GameCenterSettings, isOptional = true)]
            public ThirtPartyGameCenterSettingsParam? gameCenterSettings;

        }

    }

    public partial class DashboardModels
    {
        public class AdminAccountResponseData
        {
            [StringDataMember(code = GNParameterCode.UserId)]
            public string userId;

            [StringDataMember(code = GNParameterCode.Username)]
            public string username;

            [StringDataMember(code = GNParameterCode.SecretKey)]
            public string secretKey;

        }

        public class GetAdminAccountListResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(AdminAccountResponseData))]
            public List<AdminAccountResponseData> results;
        }

        public class SizeParam
        {
            [NumberDataMember(code = GNParameterCode.Min, minValue = 1, mustInt = true)]
            public int min;

            [NumberDataMember(code = GNParameterCode.Max, minValue = 1, mustInt = true)]
            public int max;

        }

        public class TeamParam
        {
            [StringDataMember(code = GNParameterCode.TeamId, minLength = 1, maxLength = 32)]
            public string teamId;

            [GNHashtableDataMember(code = GNParameterCode.TeamSize)]
            public SizeParam teamSize;

        }

        public class LinearExpansionsParam
        {
            [NumberDataMember(code = GNParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            [NumberDataMember(code = GNParameterCode.Delta, isOptional = true)]
            public int? delta;

            [NumberDataMember(code = GNParameterCode.Limit, isOptional = true)]
            public int? limit;

        }

        public class CustomExpansionsParam
        {
            [NumberDataMember(code = GNParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            [GNArrayDataMember(code = GNParameterCode.OverrideValue, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideValue;

            [GNArrayDataMember(code = GNParameterCode.OverrideMin, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMin;

            [GNArrayDataMember(code = GNParameterCode.OverrideMax, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMax;

        }

        public class AdvancedSettingsParam
        {
            [NumberDataMember(code = GNParameterCode.SecondsUntilOptional, minValue = 1)]
            public int secondsUntilOptional;

            [NumberDataMember(code = GNParameterCode.ExpansionType, minValue = 1, maxValue = 3, isOptional = true, mustInt = true)]
            public int? expansionType;

            [GNHashtableDataMember(code = GNParameterCode.LinearExpansions, isOptional = true)]
            public LinearExpansionsParam? linearExpansions;

            [GNHashtableDataMember(code = GNParameterCode.CustomExpansions, isOptional = true)]
            public CustomExpansionsParam? customExpansions;

        }

        public class RuleParam
        {
            [StringDataMember(code = GNParameterCode.Name, minLength = 1, maxLength = 32)]
            public string name;

            [NumberDataMember(code = GNParameterCode.Type, minValue = 1, maxValue = 8, mustInt = true)]
            public int type;

            [NumberDataMember(code = GNParameterCode.AttributeSource, minValue = 1, maxValue = 2, isOptional = true)]
            public int? attributeSource;

            [StringDataMember(code = GNParameterCode.AttributePath, minLength = 1, maxLength = 32, isOptional = true)]
            public string? attributePath;

            [DataMember(code = GNParameterCode.DefaultValue, isOptional = true)]
            public object? defaultValue;

            [NumberDataMember(code = GNParameterCode.CompairType, minValue = 1, maxValue = 2, isOptional = true, mustInt = true)]
            public int? compairType;

            [NumberDataMember(code = GNParameterCode.AllowedDifference, minValue = 0, isOptional = true)]
            public int? allowedDifference;

            [NumberDataMember(code = GNParameterCode.Min, isOptional = true)]
            public int? min;

            [NumberDataMember(code = GNParameterCode.Max, isOptional = true)]
            public int? max;

            [GNHashtableDataMember(code = GNParameterCode.AdvancedSettings, isOptional = true)]
            public AdvancedSettingsParam? advancedSettings;

        }

        public class ServerAllocationParam
        {
            [BooleanDataMember(code = GNParameterCode.Enable)]
            public bool enable;

        }

        public class MatchmakingQueueSettingsParam
        {
            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNHashtableDataMember(code = GNParameterCode.MatchSize)]
            public SizeParam matchSize;

            [GNHashtableDataMember(code = GNParameterCode.TicketSize)]
            public SizeParam ticketSize;

            [GNHashtableDataMember(code = GNParameterCode.ServerAllocation)]
            public ServerAllocationParam serverAllocation;

            [GNArrayDataMember(code = GNParameterCode.Teams, isOptional = true, elementCls = typeof(TeamParam))]
            public List<TeamParam>? teams;

            [GNArrayDataMember(code = GNParameterCode.Rules, isOptional = true, elementCls = typeof(RuleParam))]
            public List<RuleParam>? rules;

            [BooleanDataMember(code = GNParameterCode.Remove, isOptional = true)]
            public bool? remove;
        }

        public class GetGameInformationResponseData
        {
            [StringDataMember(code = GNParameterCode.GameId)]
            public string gameId;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.CreatorId)]
            public string creatorId;

            [StringDataMember(code = GNParameterCode.GameDescription)]
            public string gameDescription;

            [StringDataMember(code = GNParameterCode.GameIconUrl)]
            public string gameIconUrl;

            [GNHashtableDataMember(code = GNParameterCode.GameSettings)]
            public GameSettingsParam gameSettings;

            [GNArrayDataMember(code = GNParameterCode.MatchmakingQueueSettings, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam> matchmakingQueueSettings;

        }

        public class GameWithGameIdResponseData
        {
            [StringDataMember(code = GNParameterCode.GameId)]
            public string gameId;

        }

        public class GetGameListResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(GameWithGameIdResponseData))]
            public List<GameWithGameIdResponseData> results;

        }

        public class GetMasterGameSettingsResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.ThirtPartySettings)]
            public ThirtPartyParam thirtPartySettings;

            [GNHashtableDataMember(code = GNParameterCode.MasterPlayerSettings)]
            public MasterPlayerSettingsParam masterPlayerSettings;

            [GNHashtableDataMember(code = GNParameterCode.EmailSettings)]
            public EmailSettingsParam emailSettings;

            [GNHashtableDataMember(code = GNParameterCode.PushNotificationSettings)]
            public PushNotificationSettingsParam pushNotificationSettings;

        }

        public class GetSecretInfoInformationResponseData
        {
            [StringDataMember(code = GNParameterCode.SecretKey)]
            public string secretKey;

            [StringDataMember(code = GNParameterCode.GameId)]
            public string gameId;

            [NumberDataMember(code = GNParameterCode.Role)]
            public int role;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.CreatorId)]
            public string creatorId;

            [BooleanDataMember(code = GNParameterCode.Remove)]
            public bool remove;

            [NumberDataMember(code = GNParameterCode.TsExpire)]
            public long tsExpire;

            [GNHashtableDataMember(code = GNParameterCode.Permission)]
            public PermissionParam permission;

        }

        public class SecretInfoWithSecretKeyResponseData
        {
            [StringDataMember(code = GNParameterCode.SecretKey)]
            public string secretKey;

        }

        public class GetSecretInfoListResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(SecretInfoWithSecretKeyResponseData))]
            public List<SecretInfoWithSecretKeyResponseData> results;

        }

        public class AdminAccountWithUserIdResponseData
        {
            [StringDataMember(code = GNParameterCode.UserId)]
            public string userId;

        }

        public class GrantAdminAccountResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(AdminAccountWithUserIdResponseData))]
            public List<AdminAccountWithUserIdResponseData> results;

        }

        public class LoginByAdminAccountResponseData
        {
            [StringDataMember(code = ParameterCode.AuthToken)]
            public string authToken;

        }

        public class GetServerLogResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(string))]
            public List<string> results;

        }

        public class GetUsernameAdminAccountResponseData
        {
            [StringDataMember(code = GNParameterCode.Username)]
            public string username;

        }

        public class AnalyticsItemResponseData
        {
            [NumberDataMember(code = GNParameterCode.CCU)]
            public int ccu;

            [NumberDataMember(code = GNParameterCode.DAU)]
            public int dau;

            [NumberDataMember(code = GNParameterCode.DAUSince0h)]
            public int dauSince0h;

            [NumberDataMember(code = GNParameterCode.DNU)]
            public int dnu;

            [NumberDataMember(code = GNParameterCode.DNUSince0h)]
            public int dnuSince0h;

            [NumberDataMember(code = GNParameterCode.DRT)]
            public int drt;

            [NumberDataMember(code = GNParameterCode.DRTSince0h)]
            public int drtSince0h;

            [NumberDataMember(code = GNParameterCode.MAU)]
            public int mau;

            [NumberDataMember(code = GNParameterCode.MAUSince0h1)]
            public int mauSince0h1;

            [NumberDataMember(code = GNParameterCode.MNU)]
            public int mnu;

            [NumberDataMember(code = GNParameterCode.MNUSince0h1)]
            public int mnuSince0h1;

            [NumberDataMember(code = GNParameterCode.MRT)]
            public int mrt;

            [NumberDataMember(code = GNParameterCode.MRTSince0h1)]
            public int mrtSince0h1;

            [NumberDataMember(code = GNParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        public class MemoryUsageResponseData
        {
            [NumberDataMember(code = GNParameterCode.FreeMemoryInBytes)]
            public double freeMemoryInBytes;

            [NumberDataMember(code = GNParameterCode.TotalMemoryInBytes)]
            public double totalMemoryInBytes;

        }

        public class StorageUsageResponseData
        {
            [StringDataMember(code = GNParameterCode.Name)]
            public string name;

            [NumberDataMember(code = GNParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            [NumberDataMember(code = GNParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

        }

        public class DatabaseSystemResponseData
        {
            [NumberDataMember(code = GNParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            [NumberDataMember(code = GNParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

            [NumberDataMember(code = GNParameterCode.TotalSizeInBytes)]
            public double totalSizeInBytes;

            [NumberDataMember(code = GNParameterCode.Collections)]
            public int collections;

            [NumberDataMember(code = GNParameterCode.Objects)]
            public int objects;

            [NumberDataMember(code = GNParameterCode.Indexes)]
            public int indexes;

        }

        public class CostResponseData
        {
            [NumberDataMember(code = GNParameterCode.RequestCount)]
            public int requestCount;

            [NumberDataMember(code = GNParameterCode.MatchmakingRequestCount)]
            public int matchmakingRequestCount;

            [NumberDataMember(code = GNParameterCode.CloudScriptGBs)]
            public double cloudScriptGBs;

            [NumberDataMember(code = GNParameterCode.StorageSizeInBytes)]
            public double storageSizeInBytes;

            [NumberDataMember(code = GNParameterCode.DataTransferSizeInBytes)]
            public long dataTransferSizeInBytes;

        }

        public class OperationSystemResponseData
        {
            [NumberDataMember(code = GNParameterCode.CpuUsage)]
            public double cpuUsage;

            [GNHashtableDataMember(code = GNParameterCode.MemoryUsage)]
            public MemoryUsageResponseData memoryUsage;

            [GNArrayDataMember(code = GNParameterCode.StorageUsage, elementCls = typeof(StorageUsageResponseData))]
            public List<StorageUsageResponseData>? storageUsage;

        }

        public class RequestCompleteErrorCodeResponseData
        {
            [NumberDataMember(code = GNParameterCode.ErrorCode)]
            public int errorCode;

            [NumberDataMember(code = GNParameterCode.Count)]
            public int count;

        }

        public class RequestCompleteResponseData
        {
            [StringDataMember(code = GNParameterCode.EventName)]
            public string eventName;

            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(RequestCompleteErrorCodeResponseData))]
            public List<RequestCompleteErrorCodeResponseData>? results;

        }

        public class GetAnalyticsResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.AnalyticsItem, isOptional = true)]
            public AnalyticsItemResponseData? analyticsItem;

            [GNArrayDataMember(code = GNParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            [GNHashtableDataMember(code = GNParameterCode.OperationSystem, isOptional = true)]
            public OperationSystemResponseData? operationSystem;

            [GNArrayDataMember(code = GNParameterCode.RequestComplete, elementCls = typeof(RequestCompleteResponseData), isOptional = true)]
            public List<RequestCompleteResponseData>? requestComplete;

            [GNHashtableDataMember(code = GNParameterCode.DatabaseSystem, isOptional = true)]
            public DatabaseSystemResponseData? databaseSystem;

            [GNHashtableDataMember(code = GNParameterCode.Cost, isOptional = true)]
            public CostResponseData? cost;

            [GNHashtableDataMember(code = GNParameterCode.MonthlyCost, isOptional = true)]
            public CostResponseData? monthlyCost;

        }

        public class ChildScriptResponseData
        {
            [StringDataMember(code = GNParameterCode.EventName)]
            public string eventName;

            [StringDataMember(code = GNParameterCode.Script)]
            public string script;

            [BooleanDataMember(code = GNParameterCode.HasEdit)]
            public bool hasEdit;

        }

        public class EventCallbackCloudScriptResponseData
        {
            [StringDataMember(code = GNParameterCode.Type)]
            public string type;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.Version)]
            public string version;

            [GNArrayDataMember(code = GNParameterCode.ChildScripts, elementCls = typeof(ChildScriptResponseData))]
            public List<ChildScriptResponseData> childScripts;

        }

        public class GetEventCallbackCloudScriptResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(EventCallbackCloudScriptResponseData))]
            public List<EventCallbackCloudScriptResponseData> results;

        }

        public class SetEventCallbackCloudScriptResponseData
        {
            [StringDataMember(code = GNParameterCode.Message)]
            public string errorMessage;

        }

        public class BackupStatisticsLeaderboardVersionResponseData
        {
            [StringDataMember(code = GNParameterCode.Version)]
            public string version;

            [StringDataMember(code = GNParameterCode.Log)]
            public string log;

            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

        }

        public class GetBackupStatisticsLeaderboardVersionResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(BackupStatisticsLeaderboardVersionResponseData))]
            public List<BackupStatisticsLeaderboardVersionResponseData> results;

        }

        public class CountryRegionResponseData
        {
            [StringDataMember(code = GNParameterCode.RegionCode)]
            public string regionCode;

            [StringDataMember(code = GNParameterCode.RegionName)]
            public string regionName;

            [NumberDataMember(code = GNParameterCode.CCU)]
            public int ccu;

            [NumberDataMember(code = GNParameterCode.Latitude, isOptional = true, defaultValue = 0)]
            public double? latitude;

            [NumberDataMember(code = GNParameterCode.Longitude, isOptional = true, defaultValue = 0)]
            public double? longitude;

        }

        public class CountryResponseData
        {
            [StringDataMember(code = GNParameterCode.CountryCode)]
            public string countryCode;

            [GNArrayDataMember(code = GNParameterCode.Regions, elementCls = typeof(CountryRegionResponseData))]
            public List<CountryRegionResponseData> regions;

        }

        public class GetServerGameDataResponseData
        {
            [NumberDataMember(code = GNParameterCode.MasterPlayerCount, isOptional = true)]
            public int? masterPlayerCount;

            [NumberDataMember(code = GNParameterCode.GamePlayerCount, isOptional = true)]
            public int? gamePlayerCount;

            [NumberDataMember(code = GNParameterCode.CharacterPlayerCount, isOptional = true)]
            public int? characterPlayerCount;

            [NumberDataMember(code = GNParameterCode.InventoryCount, isOptional = true)]
            public int? inventoryCount;

            [NumberDataMember(code = GNParameterCode.StoreInventoryCount, isOptional = true)]
            public int? storeInventoryCount;

            [NumberDataMember(code = GNParameterCode.GroupCount, isOptional = true)]
            public int? groupCount;

            [GNArrayDataMember(code = GNParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            [StringDataMember(code = GNParameterCode.Version, isOptional = true)]
            public string? version;

        }

        public class EmptyResponseData
        {

        }

    }

}
