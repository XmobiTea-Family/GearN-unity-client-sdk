namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    public partial class DashboardModels
    {
        public class ChangePasswordAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string currentPassword;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class GetAdminAccountListRequestData
        {
        }

        public class GetGameInformationRequestData
        {
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
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
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class GetSecretInfoListRequestData
        {
        }

        public class GetServerLogRequestData
        {
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 50, minValue = 5, maxValue = 200, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class CreateAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class CreateGameRequestData
        {
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

        }

        public class CreateSecretInfoRequestData
        {
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true, isOptional = true)]
            public string? secretKey;

            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? gameId;

            [NumberDataMember(code = ParameterCode.Role, mustInt = true, minValue = 1, maxValue = 3)]
            public int role;

            [GNHashtableDataMember(code = ParameterCode.PermissionParam, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        public class LoginByAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.Username, minLength = 4, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class RemoveAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class SetGameInformationRequestData
        {
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [StringDataMember(code = ParameterCode.GameName, isOptional = true)]
            public string? gameName;

            [StringDataMember(code = ParameterCode.GameDescription, isOptional = true)]
            public string? gameDescription;

            [StringDataMember(code = ParameterCode.GameIconUrl, isOptional = true)]
            public string? gameIconUrl;

            [GNHashtableDataMember(code = ParameterCode.GameSettings, isOptional = true)]
            public GameSettingsParam? gameSettings;

            [GNArrayDataMember(code = ParameterCode.MatchmakingQueueSettings, isOptional = true, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam>? matchmakingQueueSettings;

        }

        public class SetMasterGameSettingsRequestData
        {
            [GNHashtableDataMember(code = ParameterCode.ThirtPartySettings, isOptional = true)]
            public ThirtPartyParam? thirtPartySettings;

            [GNHashtableDataMember(code = ParameterCode.MasterPlayerSettings, isOptional = true)]
            public MasterPlayerSettingsParam? masterPlayerSettings;

            [GNHashtableDataMember(code = ParameterCode.EmailSettings, isOptional = true)]
            public EmailSettingsParam? emailSettings;

            [GNHashtableDataMember(code = ParameterCode.PushNotificationSettings, isOptional = true)]
            public PushNotificationSettingsParam? pushNotificationSettings;

        }

        public class SetPasswordAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        public class SetSecretInfoInformationRequestData
        {
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

            [BooleanDataMember(code = ParameterCode.Remove, isOptional = true)]
            public bool? remove;

            [NumberDataMember(code = ParameterCode.TsExpire, isOptional = true)]
            public long? tsExpire;

            [StringDataMember(code = ParameterCode.Description, isOptional = true)]
            public string? description;

            [GNHashtableDataMember(code = ParameterCode.PermissionParam, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        public class SetSecretKeyAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        public class GetUsernameAdminAccountRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        public class GetAnalyticsRequestData
        {
            [NumberDataMember(code = ParameterCode.Timestamp, minValue = 0, isOptional = true)]
            public long? timestamp;

            [BooleanDataMember(code = ParameterCode.AnalyticsItem, isOptional = true)]
            public bool? analyticsItem;

            [BooleanDataMember(code = ParameterCode.Country, isOptional = true)]
            public bool? country;

            [BooleanDataMember(code = ParameterCode.RequestComplete, isOptional = true)]
            public bool? requestComplete;

            [BooleanDataMember(code = ParameterCode.OperationSystem, isOptional = true)]
            public bool? operationSystem;

            [BooleanDataMember(code = ParameterCode.DatabaseSystem, isOptional = true)]
            public bool? databaseSystem;

            [BooleanDataMember(code = ParameterCode.LogDatabaseSystem, isOptional = true)]
            public bool? logDatabaseSystem;

            [BooleanDataMember(code = ParameterCode.Cost, isOptional = true)]
            public bool? cost;

            [BooleanDataMember(code = ParameterCode.MonthlyCost, isOptional = true)]
            public bool? monthlyCost;

        }

        public class GetEventCallbackCloudScriptRequestData
        {
        }

        public class SetEventCallbackCloudScriptRequestData
        {
            [StringDataMember(code = ParameterCode.EventName, minLength = 6, maxLength = 128, mustNonNull = true)]
            public string eventName;

            [StringDataMember(code = ParameterCode.Script, minLength = 6, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

        }

        public class ResetStatisticsLeaderboardRequestData
        {
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = ParameterCode.Version, minLength = 2, maxLength = 32)]
            public string version;

            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        public class DeleteInDatabaseRequestData
        {
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Id, minLength = 2, maxLength = 15)]
            public string id;

            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        public class GetBackupStatisticsLeaderboardVersionRequestData
        {
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

        }

        public class GetServerGameDataRequestData
        {
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            [BooleanDataMember(code = ParameterCode.MasterPlayerCount, isOptional = true)]
            public bool? masterPlayerCount;

            [BooleanDataMember(code = ParameterCode.GamePlayerCount, isOptional = true)]
            public bool? gamePlayerCount;

            [BooleanDataMember(code = ParameterCode.CharacterPlayerCount, isOptional = true)]
            public bool? characterPlayerCount;

            [BooleanDataMember(code = ParameterCode.InventoryCount, isOptional = true)]
            public bool? inventoryCount;

            [BooleanDataMember(code = ParameterCode.StoreInventoryCount, isOptional = true)]
            public bool? storeInventoryCount;

            [BooleanDataMember(code = ParameterCode.GroupCount, isOptional = true)]
            public bool? groupCount;

            [BooleanDataMember(code = ParameterCode.Country, isOptional = true)]
            public bool? country;

            [BooleanDataMember(code = ParameterCode.Version, isOptional = true)]
            public bool? version;

        }

    }

    public partial class DashboardModels
    {
        public class AuthenticatePermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.LoginByAccount, isOptional = true)]
            public PermissionRulesParam? loginByAccount;

            [GNHashtableDataMember(code = ParameterCode.LoginByAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByAndroidDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByApple, isOptional = true)]
            public PermissionRulesParam? loginByApple;

            [GNHashtableDataMember(code = ParameterCode.LoginByCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByCustomDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByCustomId, isOptional = true)]
            public PermissionRulesParam? loginByCustomId;

            [GNHashtableDataMember(code = ParameterCode.LoginByFacebook, isOptional = true)]
            public PermissionRulesParam? loginByFacebook;

            [GNHashtableDataMember(code = ParameterCode.LoginByGenericService, isOptional = true)]
            public PermissionRulesParam? loginByGenericService;

            [GNHashtableDataMember(code = ParameterCode.LoginByGoogle, isOptional = true)]
            public PermissionRulesParam? loginByGoogle;

            [GNHashtableDataMember(code = ParameterCode.LoginByGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? loginByGooglePlayGameService;

            [GNHashtableDataMember(code = ParameterCode.LoginByGameCenter, isOptional = true)]
            public PermissionRulesParam? loginByGameCenter;

            [GNHashtableDataMember(code = ParameterCode.LoginByiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByiOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = ParameterCode.RegisterAccount, isOptional = true)]
            public PermissionRulesParam? registerAccount;

            [GNHashtableDataMember(code = ParameterCode.LoginByEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByEditorDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByLinuxDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByMacOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LoginByWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsDeviceId;

            [GNHashtableDataMember(code = ParameterCode.RefreshAuthToken, isOptional = true)]
            public PermissionRulesParam? refreshAuthToken;
        }

        public class CharacterCatalogSettingsParam
        {
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

        }

        public class CharacterPlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = ParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            [GNHashtableDataMember(code = ParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            [GNHashtableDataMember(code = ParameterCode.CreatePlayerItem, isOptional = true)]
            public PermissionRulesParam? createPlayerItem;

            [GNHashtableDataMember(code = ParameterCode.CreateGroup, isOptional = true)]
            public PermissionRulesParam? createGroup;

            [GNHashtableDataMember(code = ParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            [GNHashtableDataMember(code = ParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            [GNHashtableDataMember(code = ParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            [GNHashtableDataMember(code = ParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class CharacterPlayerSettingsParam
        {
            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerGroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerFriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        public class ContentPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.GetContentData, isOptional = true)]
            public PermissionRulesParam? getContentData;

            [GNHashtableDataMember(code = ParameterCode.SetContentData, isOptional = true)]
            public PermissionRulesParam? setContentData;

            [GNHashtableDataMember(code = ParameterCode.CreateNewFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? createNewFileUploadInfo;

            [GNHashtableDataMember(code = ParameterCode.GetFileUploadInfoList, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfoList;

            [GNHashtableDataMember(code = ParameterCode.GetFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfo;

            [GNHashtableDataMember(code = ParameterCode.RemoveFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? removeFileUploadInfo;

            [GNHashtableDataMember(code = ParameterCode.RequestDownloadFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? requestDownloadFileUploadInfo;

        }

        public class CurrencySettingsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [NumberDataMember(code = ParameterCode.InitialValue)]
            public double initialValue;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        public class DataSettingsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = ParameterCode.DisplayName, minLength = 2, maxLength = 64)]
            public string displayName;

            [NumberDataMember(code = ParameterCode.Permission, mustInt = true)]
            public int permission;

        }

        public class FriendCatalogSettingsParam
        {
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [BooleanDataMember(code = ParameterCode.ForceAcceptFriend)]
            public bool forceAcceptFriend;

        }

        public class EmailSettingsParam
        {
            [StringDataMember(code = ParameterCode.SendFrom)]
            public string sendFrom;

            [BooleanDataMember(code = ParameterCode.Secure)]
            public bool secure;

            [StringDataMember(code = ParameterCode.Host)]
            public string host;

            [NumberDataMember(code = ParameterCode.Port)]
            public int port;

            [StringDataMember(code = ParameterCode.Username)]
            public string username;

            [StringDataMember(code = ParameterCode.Password)]
            public string password;
        }

        public class PushNotificationSettingsParam
        {
            [StringDataMember(code = ParameterCode.ProjectId)]
            public string projectId;

            [StringDataMember(code = ParameterCode.ClientEmail)]
            public string clientEmail;

            [StringDataMember(code = ParameterCode.PrivateKey)]
            public string privateKey;

        }

        public class GamePlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerCharacter, isOptional = true)]
            public PermissionRulesParam? getPlayerCharacter;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            [GNHashtableDataMember(code = ParameterCode.GetOnlineStatus, isOptional = true)]
            public PermissionRulesParam? getOnlineStatus;

            [GNHashtableDataMember(code = ParameterCode.CreateGroup, isOptional = true)]
            public PermissionRulesParam? createGroup;

            [GNHashtableDataMember(code = ParameterCode.CreatePlayerItem, isOptional = true)]
            public PermissionRulesParam? createPlayerItem;

            [GNHashtableDataMember(code = ParameterCode.CreatePlayerCharacter, isOptional = true)]
            public PermissionRulesParam? createPlayerCharacter;

            [GNHashtableDataMember(code = ParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            [GNHashtableDataMember(code = ParameterCode.RemovePlayerCharacter, isOptional = true)]
            public PermissionRulesParam? removePlayerCharacter;

            [GNHashtableDataMember(code = ParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            [GNHashtableDataMember(code = ParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class GamePlayerSettingsParam
        {
            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerCharacterCatalogSettings, elementCls = typeof(CharacterCatalogSettingsParam), isOptional = true)]
            public List<CharacterCatalogSettingsParam>? playerCharacterCatalogSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerGroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerFriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        public class GameSettingsParam
        {
            [GNHashtableDataMember(code = ParameterCode.GamePlayerSettings, isOptional = true)]
            public GamePlayerSettingsParam? gamePlayerSettings;

            [GNHashtableDataMember(code = ParameterCode.CharacterPlayerSettings, isOptional = true)]
            public CharacterPlayerSettingsParam? characterPlayerSettings;

            [GNHashtableDataMember(code = ParameterCode.GroupSettings, isOptional = true)]
            public GroupSettingsParam? groupSettings;

            [GNHashtableDataMember(code = ParameterCode.InventorySettings, isOptional = true)]
            public InventorySettingsParam? inventorySettings;

        }

        public class GenericServiceSettingsParam
        {
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 2, maxLength = 32)]
            public string serviceName;

        }

        public class GroupCatalogSettingsParam
        {
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [BooleanDataMember(code = ParameterCode.ForceAcceptMember)]
            public bool forceAcceptMember;

        }

        public class GroupPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = ParameterCode.ChangeGroupCurrency, isOptional = true)]
            public PermissionRulesParam? changeGroupCurrency;

            [GNHashtableDataMember(code = ParameterCode.GetGroupCurrency, isOptional = true)]
            public PermissionRulesParam? getGroupCurrency;

            [GNHashtableDataMember(code = ParameterCode.ChangeGroupStatistics, isOptional = true)]
            public PermissionRulesParam? changeGroupStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetGroupStatistics, isOptional = true)]
            public PermissionRulesParam? getGroupStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundGroup, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundGroup;

            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetGroupData, isOptional = true)]
            public PermissionRulesParam? setGroupData;

            [GNHashtableDataMember(code = ParameterCode.GetGroupData, isOptional = true)]
            public PermissionRulesParam? getGroupData;

            [GNHashtableDataMember(code = ParameterCode.GetGroupInformation, isOptional = true)]
            public PermissionRulesParam? getGroupInformation;

            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithSegment, isOptional = true)]
            public PermissionRulesParam? getGroupsWithSegment;

            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithTag, isOptional = true)]
            public PermissionRulesParam? getGroupsWithTag;

            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.GetGroupInventory, isOptional = true)]
            public PermissionRulesParam? getGroupInventory;

            [GNHashtableDataMember(code = ParameterCode.RemoveGroupItem, isOptional = true)]
            public PermissionRulesParam? removeGroupItem;

            [GNHashtableDataMember(code = ParameterCode.CreateGroupItem, isOptional = true)]
            public PermissionRulesParam? createGroupItem;

            [GNHashtableDataMember(code = ParameterCode.GetMembers, isOptional = true)]
            public PermissionRulesParam? getMembers;

            [GNHashtableDataMember(code = ParameterCode.AddMember, isOptional = true)]
            public PermissionRulesParam? addMember;

            [GNHashtableDataMember(code = ParameterCode.RemoveMember, isOptional = true)]
            public PermissionRulesParam? removeMember;

            [GNHashtableDataMember(code = ParameterCode.SendGroupMessage, isOptional = true)]
            public PermissionRulesParam? sendGroupMessage;

            [GNHashtableDataMember(code = ParameterCode.GetGroupMessage, isOptional = true)]
            public PermissionRulesParam? getGroupMessage;

            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getGroupsWithDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        public class GroupSettingsParam
        {
            [GNArrayDataMember(code = ParameterCode.GroupCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? groupCurrenciesSettings;

            [GNArrayDataMember(code = ParameterCode.GroupStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? groupStatisticsSettings;

            [GNArrayDataMember(code = ParameterCode.GroupDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? groupDatasSettings;

            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            [GNArrayDataMember(code = ParameterCode.GroupItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? groupItemCatalogSettings;

        }

        public class InventoryPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = ParameterCode.ChangeItemStatistics, isOptional = true)]
            public PermissionRulesParam? changeItemStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetItemStatistics, isOptional = true)]
            public PermissionRulesParam? getItemStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundItem, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundItem;

            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetItemData, isOptional = true)]
            public PermissionRulesParam? setItemData;

            [GNHashtableDataMember(code = ParameterCode.GetItemData, isOptional = true)]
            public PermissionRulesParam? getItemData;

            [GNHashtableDataMember(code = ParameterCode.GetItemInformation, isOptional = true)]
            public PermissionRulesParam? getItemInformation;

            [GNHashtableDataMember(code = ParameterCode.GetItemsWithSegment, isOptional = true)]
            public PermissionRulesParam? getItemsWithSegment;

            [GNHashtableDataMember(code = ParameterCode.GetItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getItemsWithTag;

            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            [GNHashtableDataMember(code = ParameterCode.GetClassId, isOptional = true)]
            public PermissionRulesParam? getClassId;

            [GNHashtableDataMember(code = ParameterCode.GetItemType, isOptional = true)]
            public PermissionRulesParam? getItemType;

            [GNHashtableDataMember(code = ParameterCode.GetAmount, isOptional = true)]
            public PermissionRulesParam? getAmount;

            [GNHashtableDataMember(code = ParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.SetAmount, isOptional = true)]
            public PermissionRulesParam? setAmount;

            [GNHashtableDataMember(code = ParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.GetItemsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getItemsWithDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

        }

        public class InventorySettingsParam
        {
            [GNArrayDataMember(code = ParameterCode.ItemStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? itemStatisticsSettings;

            [GNArrayDataMember(code = ParameterCode.ItemDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? itemDatasSettings;

            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        public class ItemCatalogSettingsParam
        {
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            [NumberDataMember(code = ParameterCode.ItemType, mustInt = true)]
            public int itemType;

            [GNArrayDataMember(code = ParameterCode.ItemClassSettings, elementCls = typeof(ItemClassSettingsParam))]
            public List<ItemClassSettingsParam> itemClassSettings;

        }

        public class ItemClassSettingsParam
        {
            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

        }

        public class MasterAdminPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.SetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? setMasterGameSettings;

            [GNHashtableDataMember(code = ParameterCode.CreateAdminAccount, isOptional = true)]
            public PermissionRulesParam? createAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.RemoveAdminAccount, isOptional = true)]
            public PermissionRulesParam? removeAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.SetPasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? setPasswordAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.SetSecretKeyAdminAccount, isOptional = true)]
            public PermissionRulesParam? setSecretKeyAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.SetGameInformation, isOptional = true)]
            public PermissionRulesParam? setGameInformation;

            [GNHashtableDataMember(code = ParameterCode.CreateGame, isOptional = true)]
            public PermissionRulesParam? createGame;

            [GNHashtableDataMember(code = ParameterCode.ChangePasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? changePasswordAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.GetAdminAccountList, isOptional = true)]
            public PermissionRulesParam? getAdminAccountList;

            [GNHashtableDataMember(code = ParameterCode.GetGameInformation, isOptional = true)]
            public PermissionRulesParam? getGameInformation;

            [GNHashtableDataMember(code = ParameterCode.GetGameList, isOptional = true)]
            public PermissionRulesParam? getGameList;

            [GNHashtableDataMember(code = ParameterCode.GetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? getMasterGameSettings;

            [GNHashtableDataMember(code = ParameterCode.GetServerLog, isOptional = true)]
            public PermissionRulesParam? getServerLog;

            [GNHashtableDataMember(code = ParameterCode.GetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? getSecretInfoInformation;

            [GNHashtableDataMember(code = ParameterCode.GetSecretInfoList, isOptional = true)]
            public PermissionRulesParam? getSecretInfoList;

            [GNHashtableDataMember(code = ParameterCode.CreateSecretInfo, isOptional = true)]
            public PermissionRulesParam? createSecretInfo;

            [GNHashtableDataMember(code = ParameterCode.SetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? setSecretInfoInformation;

            [GNHashtableDataMember(code = ParameterCode.GetUsernameAdminAccount, isOptional = true)]
            public PermissionRulesParam? getUsernameAdminAccount;

            [GNHashtableDataMember(code = ParameterCode.GetAnalytics, isOptional = true)]
            public PermissionRulesParam? getAnalytics;

            [GNHashtableDataMember(code = ParameterCode.GetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? getEventCallbackCloudScript;

            [GNHashtableDataMember(code = ParameterCode.SetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? setEventCallbackCloudScript;

            [GNHashtableDataMember(code = ParameterCode.ResetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? resetStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetBackupStatisticsLeaderboardVersion, isOptional = true)]
            public PermissionRulesParam? getBackupStatisticsLeaderboardVersion;

            [GNHashtableDataMember(code = ParameterCode.GetServerGameData, isOptional = true)]
            public PermissionRulesParam? getServerGameData;

        }

        public class MultiplayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.CancelAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelAllMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.CancelMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.CreateMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? createMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.GetMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.GetMatch, isOptional = true)]
            public PermissionRulesParam? getMatch;

            [GNHashtableDataMember(code = ParameterCode.GetQueueStatistics, isOptional = true)]
            public PermissionRulesParam? getQueueStatistics;

            [GNHashtableDataMember(code = ParameterCode.JoinMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? joinMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.ListMatchmakingTicketsForPlayer, isOptional = true)]
            public PermissionRulesParam? listMatchmakingTicketsForPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getAllMatchmakingTicket;

            [GNHashtableDataMember(code = ParameterCode.GetAllMatch, isOptional = true)]
            public PermissionRulesParam? getAllMatch;

        }

        public class MasterPlayerPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.LinkAccount, isOptional = true)]
            public PermissionRulesParam? linkAccount;

            [GNHashtableDataMember(code = ParameterCode.LinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? linkAndroidDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkApple, isOptional = true)]
            public PermissionRulesParam? linkApple;

            [GNHashtableDataMember(code = ParameterCode.LinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? linkCustomDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkCustomId, isOptional = true)]
            public PermissionRulesParam? linkCustomId;

            [GNHashtableDataMember(code = ParameterCode.LinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? linkEditorDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkFacebook, isOptional = true)]
            public PermissionRulesParam? linkFacebook;

            [GNHashtableDataMember(code = ParameterCode.LinkGenericService, isOptional = true)]
            public PermissionRulesParam? linkGenericService;

            [GNHashtableDataMember(code = ParameterCode.LinkGoogle, isOptional = true)]
            public PermissionRulesParam? linkGoogle;

            [GNHashtableDataMember(code = ParameterCode.LinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? linkGooglePlayGameService;

            [GNHashtableDataMember(code = ParameterCode.LinkGameCenter, isOptional = true)]
            public PermissionRulesParam? linkGameCenter;

            [GNHashtableDataMember(code = ParameterCode.LinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkiOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? linkLinuxDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkMacOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsDeviceId;

            [GNHashtableDataMember(code = ParameterCode.LinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkAccount, isOptional = true)]
            public PermissionRulesParam? unlinkAccount;

            [GNHashtableDataMember(code = ParameterCode.UnlinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkAndroidDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkApple, isOptional = true)]
            public PermissionRulesParam? unlinkApple;

            [GNHashtableDataMember(code = ParameterCode.UnlinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkCustomId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkEditorDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkFacebook, isOptional = true)]
            public PermissionRulesParam? unlinkFacebook;

            [GNHashtableDataMember(code = ParameterCode.UnlinkGenericService, isOptional = true)]
            public PermissionRulesParam? unlinkGenericService;

            [GNHashtableDataMember(code = ParameterCode.UnlinkGoogle, isOptional = true)]
            public PermissionRulesParam? unlinkGoogle;

            [GNHashtableDataMember(code = ParameterCode.UnlinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? unlinkGooglePlayGameService;

            [GNHashtableDataMember(code = ParameterCode.UnlinkGameCenter, isOptional = true)]
            public PermissionRulesParam? unlinkGameCenter;

            [GNHashtableDataMember(code = ParameterCode.UnlinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkiOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkLinuxDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkMacOSDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsDeviceId;

            [GNHashtableDataMember(code = ParameterCode.UnlinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsPhoneDeviceId;

            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            [GNHashtableDataMember(code = ParameterCode.SetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? setTsLastLogin;

            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            [GNHashtableDataMember(code = ParameterCode.ChangeAccountPassword, isOptional = true)]
            public PermissionRulesParam? changeAccountPassword;

            [GNHashtableDataMember(code = ParameterCode.ResetAccountPassword, isOptional = true)]
            public PermissionRulesParam? resetAccountPassword;

            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithApple, isOptional = true)]
            public PermissionRulesParam? getPlayersWithApple;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithFacebook, isOptional = true)]
            public PermissionRulesParam? getPlayersWithFacebook;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGoogle, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGoogle;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGenericService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGenericService;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGooglePlayGameService;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGameCenter, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGameCenter;

            [GNHashtableDataMember(code = ParameterCode.GetExternal, isOptional = true)]
            public PermissionRulesParam? getExternal;

            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            [GNHashtableDataMember(code = ParameterCode.GetEmail, isOptional = true)]
            public PermissionRulesParam? getEmail;

            [GNHashtableDataMember(code = ParameterCode.SetEmail, isOptional = true)]
            public PermissionRulesParam? setEmail;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

            [GNHashtableDataMember(code = ParameterCode.SendSocketOperationEvent, isOptional = true)]
            public PermissionRulesParam? sendSocketOperationEvent;

            [GNHashtableDataMember(code = ParameterCode.SendEmail, isOptional = true)]
            public PermissionRulesParam? sendEmail;

            [GNHashtableDataMember(code = ParameterCode.SendPushNotification, isOptional = true)]
            public PermissionRulesParam? sendPushNotification;

            [GNHashtableDataMember(code = ParameterCode.AddPushNotification, isOptional = true)]
            public PermissionRulesParam? addPushNotification;

            [GNHashtableDataMember(code = ParameterCode.RemovePushNotification, isOptional = true)]
            public PermissionRulesParam? removePushNotification;

            [GNHashtableDataMember(code = ParameterCode.GetPushNotification, isOptional = true)]
            public PermissionRulesParam? getPushNotification;

        }

        public class MasterPlayerSettingsParam
        {
            [GNArrayDataMember(code = ParameterCode.GenericServiceSettings, elementCls = typeof(GenericServiceSettingsParam), isOptional = true)]
            public List<GenericServiceSettingsParam>? genericServiceSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        public class CloudScriptPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.ExecuteFunction, isOptional = true)]
            public PermissionRulesParam? executeFunction;

            [GNHashtableDataMember(code = ParameterCode.AddFunction, isOptional = true)]
            public PermissionRulesParam? addFunction;

            [GNHashtableDataMember(code = ParameterCode.GetFunctions, isOptional = true)]
            public PermissionRulesParam? getFunctions;

            [GNHashtableDataMember(code = ParameterCode.GetFunction, isOptional = true)]
            public PermissionRulesParam? getFunction;

            [GNHashtableDataMember(code = ParameterCode.EditFunction, isOptional = true)]
            public PermissionRulesParam? editFunction;

        }

        public class PermissionParam
        {
            [GNHashtableDataMember(code = ParameterCode.Authenticate, isOptional = true)]
            public AuthenticatePermissionRulesParam? authenticate;

            [GNHashtableDataMember(code = ParameterCode.MasterPlayer, isOptional = true)]
            public MasterPlayerPermissionRulesParam? masterPlayer;

            [GNHashtableDataMember(code = ParameterCode.GamePlayer, isOptional = true)]
            public GamePlayerPermissionRulesParam? gamePlayer;

            [GNHashtableDataMember(code = ParameterCode.CharacterPlayer, isOptional = true)]
            public CharacterPlayerPermissionRulesParam? characterPlayer;

            [GNHashtableDataMember(code = ParameterCode.Content, isOptional = true)]
            public ContentPermissionRulesParam? content;

            [GNHashtableDataMember(code = ParameterCode.Group, isOptional = true)]
            public GroupPermissionRulesParam? group;

            [GNHashtableDataMember(code = ParameterCode.Inventory, isOptional = true)]
            public InventoryPermissionRulesParam? inventory;

            [GNHashtableDataMember(code = ParameterCode.StoreInventory, isOptional = true)]
            public StoreInventoryPermissionRulesParam? storeInventory;

            [GNHashtableDataMember(code = ParameterCode.MasterAdmin, isOptional = true)]
            public MasterAdminPermissionRulesParam? masterAdmin;

            [GNHashtableDataMember(code = ParameterCode.Multiplayer, isOptional = true)]
            public MultiplayerPermissionRulesParam? multiplayer;

            [GNHashtableDataMember(code = ParameterCode.CloudScript, isOptional = true)]
            public CloudScriptPermissionRulesParam? cloudScript;

        }

        public class PermissionRulesParam
        {
            [BooleanDataMember(code = ParameterCode.SelfEnable, isOptional = true)]
            public bool? selfEnable;

            [BooleanDataMember(code = ParameterCode.OtherSelfEnable, isOptional = true)]
            public bool? otherSelfEnable;

            [BooleanDataMember(code = ParameterCode.AdminSelfEnable, isOptional = true)]
            public bool? adminSelfEnable;

            [BooleanDataMember(code = ParameterCode.ServerSelfEnable, isOptional = true)]
            public bool? serverSelfEnable;

        }

        public class StatisticsSettingsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [NumberDataMember(code = ParameterCode.StatisticsAggregationMethod, mustInt = true)]
            public int statisticsAggregationMethod;

            [NumberDataMember(code = ParameterCode.MaximumValue, isOptional = true, defaultValue = 0)]
            public double? maximumValue;

            [NumberDataMember(code = ParameterCode.MinimumValue, isOptional = true, defaultValue = 0)]
            public double? minimumValue;

            [NumberDataMember(code = ParameterCode.InitialValue)]
            public double initialValue;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        public class StoreInventoryPermissionRulesParam
        {
            [GNHashtableDataMember(code = ParameterCode.BuyStoreItem, isOptional = true)]
            public PermissionRulesParam? buyStoreItem;

            [GNHashtableDataMember(code = ParameterCode.GetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? getStoreItemInformation;

            [GNHashtableDataMember(code = ParameterCode.GetStoreItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getStoreItemsWithTag;

            [GNHashtableDataMember(code = ParameterCode.CreateStoreItem, isOptional = true)]
            public PermissionRulesParam? createStoreItem;

            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            [GNHashtableDataMember(code = ParameterCode.SetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? setStoreItemInformation;

            [GNHashtableDataMember(code = ParameterCode.ValidateAppleAppStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateAppleAppStoreReceipt;

            [GNHashtableDataMember(code = ParameterCode.ValidateGooglePlayStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateGooglePlayStoreReceipt;

            [GNHashtableDataMember(code = ParameterCode.ValidateFacebookStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateFacebookStoreReceipt;

            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            [GNHashtableDataMember(code = ParameterCode.PresentStoreItem, isOptional = true)]
            public PermissionRulesParam? presentStoreItem;

            [GNHashtableDataMember(code = ParameterCode.GetStoreLog, isOptional = true)]
            public PermissionRulesParam? getStoreLog;

            [GNHashtableDataMember(code = ParameterCode.GetStoreUsed, isOptional = true)]
            public PermissionRulesParam? getStoreUsed;

            [GNHashtableDataMember(code = ParameterCode.RemoveStoreUsed, isOptional = true)]
            public PermissionRulesParam? removeStoreUsed;

        }

        public class TagSettingsParam
        {
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        public class ThirtPartyAppleSettingsParam
        {
            [StringDataMember(code = ParameterCode.AppleClientId)]
            public string appleClientId;

            [BooleanDataMember(code = ParameterCode.SandboxEnable)]
            public bool sandboxEnable;

        }

        public class ThirtPartyFacebookSettingsParam
        {
            [StringDataMember(code = ParameterCode.FacebookAppId)]
            public string facebookAppId;

            [StringDataMember(code = ParameterCode.FacebookAppToken)]
            public string facebookAppToken;

            [StringDataMember(code = ParameterCode.FacebookInappSecret)]
            public string facebookInappSecret;

        }

        public class ThirtPartyGoogleSettingsParam
        {
            [StringDataMember(code = ParameterCode.GoogleClientId)]
            public string googleClientId;

            [StringDataMember(code = ParameterCode.PackageId)]
            public string packageId;

            [StringDataMember(code = ParameterCode.PublicRSAKey)]
            public string publicRSAKey;

        }

        public class ThirtPartyGameCenterSettingsParam
        {
            [StringDataMember(code = ParameterCode.PackageId)]
            public string packageId;

        }

        public class ThirtPartyGooglePlayGameSettingsParam
        {
            [StringDataMember(code = ParameterCode.RedirectUri)]
            public string redirectUri;

            [StringDataMember(code = ParameterCode.ClientId)]
            public string clientId;

            [StringDataMember(code = ParameterCode.ClientSecret)]
            public string clientSecret;

            [StringDataMember(code = ParameterCode.ApplicationId)]
            public string applicationId;

        }

        public class ThirtPartyParam
        {
            [GNHashtableDataMember(code = ParameterCode.GoogleSettings, isOptional = true)]
            public ThirtPartyGoogleSettingsParam? googleSettings;

            [GNHashtableDataMember(code = ParameterCode.FacebookSettings, isOptional = true)]
            public ThirtPartyFacebookSettingsParam? facebookSettings;

            [GNHashtableDataMember(code = ParameterCode.AppleSettings, isOptional = true)]
            public ThirtPartyAppleSettingsParam? appleSettings;

            [GNHashtableDataMember(code = ParameterCode.GooglePlayGameSettings, isOptional = true)]
            public ThirtPartyGooglePlayGameSettingsParam? googlePlayGameSettings;

            [GNHashtableDataMember(code = ParameterCode.GameCenterSettings, isOptional = true)]
            public ThirtPartyGameCenterSettingsParam? gameCenterSettings;

        }

    }

    public partial class DashboardModels
    {
        public class AdminAccountResponseData
        {
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

            [StringDataMember(code = ParameterCode.Username)]
            public string username;

            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

        }

        public class GetAdminAccountListResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(AdminAccountResponseData))]
            public List<AdminAccountResponseData> results;
        }

        public class SizeParam
        {
            [NumberDataMember(code = ParameterCode.Min, minValue = 1, mustInt = true)]
            public int min;

            [NumberDataMember(code = ParameterCode.Max, minValue = 1, mustInt = true)]
            public int max;

        }

        public class TeamParam
        {
            [StringDataMember(code = ParameterCode.TeamId, minLength = 1, maxLength = 32)]
            public string teamId;

            [GNHashtableDataMember(code = ParameterCode.TeamSize)]
            public SizeParam teamSize;

        }

        public class LinearExpansionsParam
        {
            [NumberDataMember(code = ParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            [NumberDataMember(code = ParameterCode.Delta, isOptional = true)]
            public int? delta;

            [NumberDataMember(code = ParameterCode.Limit, isOptional = true)]
            public int? limit;

        }

        public class CustomExpansionsParam
        {
            [NumberDataMember(code = ParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            [GNArrayDataMember(code = ParameterCode.OverrideValue, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideValue;

            [GNArrayDataMember(code = ParameterCode.OverrideMin, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMin;

            [GNArrayDataMember(code = ParameterCode.OverrideMax, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMax;

        }

        public class AdvancedSettingsParam
        {
            [NumberDataMember(code = ParameterCode.SecondsUntilOptional, minValue = 1)]
            public int secondsUntilOptional;

            [NumberDataMember(code = ParameterCode.ExpansionType, minValue = 1, maxValue = 3, isOptional = true, mustInt = true)]
            public int? expansionType;

            [GNHashtableDataMember(code = ParameterCode.LinearExpansions, isOptional = true)]
            public LinearExpansionsParam? linearExpansions;

            [GNHashtableDataMember(code = ParameterCode.CustomExpansions, isOptional = true)]
            public CustomExpansionsParam? customExpansions;

        }

        public class RuleParam
        {
            [StringDataMember(code = ParameterCode.Name, minLength = 1, maxLength = 32)]
            public string name;

            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 8, mustInt = true)]
            public int type;

            [NumberDataMember(code = ParameterCode.AttributeSource, minValue = 1, maxValue = 2, isOptional = true)]
            public int? attributeSource;

            [StringDataMember(code = ParameterCode.AttributePath, minLength = 1, maxLength = 32, isOptional = true)]
            public string? attributePath;

            [DataMember(code = ParameterCode.DefaultValue, isOptional = true)]
            public object? defaultValue;

            [NumberDataMember(code = ParameterCode.CompairType, minValue = 1, maxValue = 2, isOptional = true, mustInt = true)]
            public int? compairType;

            [NumberDataMember(code = ParameterCode.AllowedDifference, minValue = 0, isOptional = true)]
            public int? allowedDifference;

            [NumberDataMember(code = ParameterCode.Min, isOptional = true)]
            public int? min;

            [NumberDataMember(code = ParameterCode.Max, isOptional = true)]
            public int? max;

            [GNHashtableDataMember(code = ParameterCode.AdvancedSettings, isOptional = true)]
            public AdvancedSettingsParam? advancedSettings;

        }

        public class ServerAllocationParam
        {
            [BooleanDataMember(code = ParameterCode.Enable)]
            public bool enable;

        }

        public class MatchmakingQueueSettingsParam
        {
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNHashtableDataMember(code = ParameterCode.MatchSize)]
            public SizeParam matchSize;

            [GNHashtableDataMember(code = ParameterCode.TicketSize)]
            public SizeParam ticketSize;

            [GNHashtableDataMember(code = ParameterCode.ServerAllocation)]
            public ServerAllocationParam serverAllocation;

            [GNArrayDataMember(code = ParameterCode.Teams, isOptional = true, elementCls = typeof(TeamParam))]
            public List<TeamParam>? teams;

            [GNArrayDataMember(code = ParameterCode.Rules, isOptional = true, elementCls = typeof(RuleParam))]
            public List<RuleParam>? rules;

            [BooleanDataMember(code = ParameterCode.Remove, isOptional = true)]
            public bool? remove;
        }

        public class GetGameInformationResponseData
        {
            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.CreatorId)]
            public string creatorId;

            [StringDataMember(code = ParameterCode.GameDescription)]
            public string gameDescription;

            [StringDataMember(code = ParameterCode.GameIconUrl)]
            public string gameIconUrl;

            [GNHashtableDataMember(code = ParameterCode.GameSettings)]
            public GameSettingsParam gameSettings;

            [GNArrayDataMember(code = ParameterCode.MatchmakingQueueSettings, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam> matchmakingQueueSettings;

        }

        public class GameWithGameIdResponseData
        {
            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

        }

        public class GetGameListResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GameWithGameIdResponseData))]
            public List<GameWithGameIdResponseData> results;

        }

        public class GetMasterGameSettingsResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.ThirtPartySettings)]
            public ThirtPartyParam thirtPartySettings;

            [GNHashtableDataMember(code = ParameterCode.MasterPlayerSettings)]
            public MasterPlayerSettingsParam masterPlayerSettings;

            [GNHashtableDataMember(code = ParameterCode.EmailSettings)]
            public EmailSettingsParam emailSettings;

            [GNHashtableDataMember(code = ParameterCode.PushNotificationSettings)]
            public PushNotificationSettingsParam pushNotificationSettings;

        }

        public class GetSecretInfoInformationResponseData
        {
            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

            [NumberDataMember(code = ParameterCode.Role)]
            public int role;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.CreatorId)]
            public string creatorId;

            [BooleanDataMember(code = ParameterCode.Remove)]
            public bool remove;

            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            [GNHashtableDataMember(code = ParameterCode.PermissionParam)]
            public PermissionParam permissionParam;

        }

        public class SecretInfoWithSecretKeyResponseData
        {
            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

        }

        public class GetSecretInfoListResponseData
        {
            [GNArrayDataMember(code = ParameterCode.AdminSecretKeys, elementCls = typeof(SecretInfoWithSecretKeyResponseData))]
            public List<SecretInfoWithSecretKeyResponseData> adminSecretKeys;

            [GNArrayDataMember(code = ParameterCode.ServerSecretKeys, elementCls = typeof(SecretInfoWithSecretKeyResponseData))]
            public List<SecretInfoWithSecretKeyResponseData> serverSecretKeys;

            [GNArrayDataMember(code = ParameterCode.PlayerSecretKeys, elementCls = typeof(SecretInfoWithSecretKeyResponseData))]
            public List<SecretInfoWithSecretKeyResponseData> playerSecretKeys;

        }

        public class AdminAccountWithUserIdResponseData
        {
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        public class CreateAdminAccountResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(AdminAccountWithUserIdResponseData))]
            public List<AdminAccountWithUserIdResponseData> results;

        }

        public class LoginByAdminAccountResponseData
        {
            [StringDataMember(code = ParameterCode.AuthToken)]
            public string authToken;

        }

        public class GetServerLogResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(string))]
            public List<string> results;

        }

        public class GetUsernameAdminAccountResponseData
        {
            [StringDataMember(code = ParameterCode.Username)]
            public string username;

        }

        public class AnalyticsItemResponseData
        {
            [NumberDataMember(code = ParameterCode.CCU)]
            public int ccu;

            [NumberDataMember(code = ParameterCode.DAU)]
            public int dau;

            [NumberDataMember(code = ParameterCode.DAUSince0h)]
            public int dauSince0h;

            [NumberDataMember(code = ParameterCode.DNU)]
            public int dnu;

            [NumberDataMember(code = ParameterCode.DNUSince0h)]
            public int dnuSince0h;

            [NumberDataMember(code = ParameterCode.DRT)]
            public int drt;

            [NumberDataMember(code = ParameterCode.DRTSince0h)]
            public int drtSince0h;

            [NumberDataMember(code = ParameterCode.MAU)]
            public int mau;

            [NumberDataMember(code = ParameterCode.MAUSince0h1)]
            public int mauSince0h1;

            [NumberDataMember(code = ParameterCode.MNU)]
            public int mnu;

            [NumberDataMember(code = ParameterCode.MNUSince0h1)]
            public int mnuSince0h1;

            [NumberDataMember(code = ParameterCode.MRT)]
            public int mrt;

            [NumberDataMember(code = ParameterCode.MRTSince0h1)]
            public int mrtSince0h1;

            [NumberDataMember(code = ParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        public class MemoryUsageResponseData
        {
            [NumberDataMember(code = ParameterCode.FreeMemoryInBytes)]
            public double freeMemoryInBytes;

            [NumberDataMember(code = ParameterCode.TotalMemoryInBytes)]
            public double totalMemoryInBytes;

        }

        public class StorageUsageResponseData
        {
            [StringDataMember(code = ParameterCode.Name)]
            public string name;

            [NumberDataMember(code = ParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            [NumberDataMember(code = ParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

        }

        public class DatabaseSystemResponseData
        {
            [NumberDataMember(code = ParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            [NumberDataMember(code = ParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

            [NumberDataMember(code = ParameterCode.TotalSizeInBytes)]
            public double totalSizeInBytes;

            [NumberDataMember(code = ParameterCode.Collections)]
            public int collections;

            [NumberDataMember(code = ParameterCode.Objects)]
            public int objects;

            [NumberDataMember(code = ParameterCode.Indexes)]
            public int indexes;

        }

        public class CostResponseData
        {
            [NumberDataMember(code = ParameterCode.RequestCount)]
            public int requestCount;

            [NumberDataMember(code = ParameterCode.MatchmakingRequestCount)]
            public int matchmakingRequestCount;

            [NumberDataMember(code = ParameterCode.CloudScriptGBs)]
            public double cloudScriptGBs;

            [NumberDataMember(code = ParameterCode.StorageSizeInBytes)]
            public double storageSizeInBytes;

            [NumberDataMember(code = ParameterCode.DataTransferSizeInBytes)]
            public long dataTransferSizeInBytes;

        }

        public class OperationSystemResponseData
        {
            [NumberDataMember(code = ParameterCode.CpuUsage)]
            public double cpuUsage;

            [GNHashtableDataMember(code = ParameterCode.MemoryUsage)]
            public MemoryUsageResponseData memoryUsage;

            [GNArrayDataMember(code = ParameterCode.StorageUsage, elementCls = typeof(StorageUsageResponseData))]
            public List<StorageUsageResponseData>? storageUsage;

        }

        public class RequestCompleteErrorCodeResponseData
        {
            [NumberDataMember(code = ParameterCode.ErrorCode)]
            public int errorCode;

            [NumberDataMember(code = ParameterCode.Count)]
            public int count;

        }

        public class RequestCompleteResponseData
        {
            [StringDataMember(code = ParameterCode.EventName)]
            public string eventName;

            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(RequestCompleteErrorCodeResponseData))]
            public List<RequestCompleteErrorCodeResponseData>? results;

        }

        public class GetAnalyticsResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.AnalyticsItem, isOptional = true)]
            public AnalyticsItemResponseData? analyticsItem;

            [GNArrayDataMember(code = ParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            [GNHashtableDataMember(code = ParameterCode.OperationSystem, isOptional = true)]
            public OperationSystemResponseData? operationSystem;

            [GNArrayDataMember(code = ParameterCode.RequestComplete, elementCls = typeof(RequestCompleteResponseData), isOptional = true)]
            public List<RequestCompleteResponseData>? requestComplete;

            [GNHashtableDataMember(code = ParameterCode.DatabaseSystem, isOptional = true)]
            public DatabaseSystemResponseData? databaseSystem;

            [GNHashtableDataMember(code = ParameterCode.LogDatabaseSystem, isOptional = true)]
            public DatabaseSystemResponseData? logDatabaseSystem;

            [GNHashtableDataMember(code = ParameterCode.Cost, isOptional = true)]
            public CostResponseData? cost;

            [GNHashtableDataMember(code = ParameterCode.MonthlyCost, isOptional = true)]
            public CostResponseData? monthlyCost;

        }

        public class ChildScriptResponseData
        {
            [StringDataMember(code = ParameterCode.EventName)]
            public string eventName;

            [StringDataMember(code = ParameterCode.Script)]
            public string script;

            [BooleanDataMember(code = ParameterCode.HasEdit)]
            public bool hasEdit;

        }

        public class EventCallbackCloudScriptResponseData
        {
            [StringDataMember(code = ParameterCode.Type)]
            public string type;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            [GNArrayDataMember(code = ParameterCode.ChildScripts, elementCls = typeof(ChildScriptResponseData))]
            public List<ChildScriptResponseData> childScripts;

        }

        public class GetEventCallbackCloudScriptResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(EventCallbackCloudScriptResponseData))]
            public List<EventCallbackCloudScriptResponseData> results;

        }

        public class SetEventCallbackCloudScriptResponseData
        {
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        public class BackupStatisticsLeaderboardVersionResponseData
        {
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            [StringDataMember(code = ParameterCode.Log)]
            public string log;

            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

        }

        public class GetBackupStatisticsLeaderboardVersionResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(BackupStatisticsLeaderboardVersionResponseData))]
            public List<BackupStatisticsLeaderboardVersionResponseData> results;

        }

        public class CountryRegionResponseData
        {
            [StringDataMember(code = ParameterCode.RegionCode)]
            public string regionCode;

            [StringDataMember(code = ParameterCode.RegionName)]
            public string regionName;

            [NumberDataMember(code = ParameterCode.CCU)]
            public int ccu;

            [NumberDataMember(code = ParameterCode.Latitude, isOptional = true, defaultValue = 0)]
            public double? latitude;

            [NumberDataMember(code = ParameterCode.Longitude, isOptional = true, defaultValue = 0)]
            public double? longitude;

        }

        public class CountryResponseData
        {
            [StringDataMember(code = ParameterCode.CountryCode)]
            public string countryCode;

            [GNArrayDataMember(code = ParameterCode.Regions, elementCls = typeof(CountryRegionResponseData))]
            public List<CountryRegionResponseData> regions;

        }

        public class GetServerGameDataResponseData
        {
            [NumberDataMember(code = ParameterCode.MasterPlayerCount, isOptional = true)]
            public int? masterPlayerCount;

            [NumberDataMember(code = ParameterCode.GamePlayerCount, isOptional = true)]
            public int? gamePlayerCount;

            [NumberDataMember(code = ParameterCode.CharacterPlayerCount, isOptional = true)]
            public int? characterPlayerCount;

            [NumberDataMember(code = ParameterCode.InventoryCount, isOptional = true)]
            public int? inventoryCount;

            [NumberDataMember(code = ParameterCode.StoreInventoryCount, isOptional = true)]
            public int? storeInventoryCount;

            [NumberDataMember(code = ParameterCode.GroupCount, isOptional = true)]
            public int? groupCount;

            [GNArrayDataMember(code = ParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            [StringDataMember(code = ParameterCode.Version, isOptional = true)]
            public string? version;

        }

        public class EmptyResponseData
        {

        }

    }

}
