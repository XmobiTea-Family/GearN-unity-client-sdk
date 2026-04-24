namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for dashboard operations.
    /// </summary>
    public partial class DashboardModels
    {
        /// <summary>
        /// Represents the request payload for the change password admin account operation.
        /// </summary>
        public class ChangePasswordAdminAccountRequestData
        {
            /// <summary>
            /// Stores the current password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CurrentPassword, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string currentPassword;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        /// <summary>
        /// Represents the request payload for the get admin account list operation.
        /// </summary>
        public class GetAdminAccountListRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get game information operation.
        /// </summary>
        public class GetGameInformationRequestData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

        }

        /// <summary>
        /// Represents the request payload for the get game list operation.
        /// </summary>
        public class GetGameListRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get master game settings operation.
        /// </summary>
        public class GetMasterGameSettingsRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get secret info information operation.
        /// </summary>
        public class GetSecretInfoInformationRequestData
        {
            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        /// <summary>
        /// Represents the request payload for the get secret info list operation.
        /// </summary>
        public class GetSecretInfoListRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get server log operation.
        /// </summary>
        public class GetServerLogRequestData
        {
            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 50, minValue = 5, maxValue = 200, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the request payload for the create admin account operation.
        /// </summary>
        public class CreateAdminAccountRequestData
        {
            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        /// <summary>
        /// Represents the request payload for the create game operation.
        /// </summary>
        public class CreateGameRequestData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

        }

        /// <summary>
        /// Represents the request payload for the create secret info operation.
        /// </summary>
        public class CreateSecretInfoRequestData
        {
            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true, isOptional = true)]
            public string? secretKey;

            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? gameId;

            /// <summary>
            /// Stores the permission param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PermissionParam, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        /// <summary>
        /// Represents the request payload for the login by admin account operation.
        /// </summary>
        public class LoginByAdminAccountRequestData
        {
            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username, minLength = 4, maxLength = 32, mustNonNull = true)]
            public string username;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        /// <summary>
        /// Represents the request payload for the remove admin account operation.
        /// </summary>
        public class RemoveAdminAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        /// <summary>
        /// Represents the request payload for the set game information operation.
        /// </summary>
        public class SetGameInformationRequestData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            /// <summary>
            /// Stores the game name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameName, isOptional = true)]
            public string? gameName;

            /// <summary>
            /// Stores the game description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameDescription, isOptional = true)]
            public string? gameDescription;

            /// <summary>
            /// Stores the game icon URL value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameIconUrl, isOptional = true)]
            public string? gameIconUrl;

            /// <summary>
            /// Stores the game settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GameSettings, isOptional = true)]
            public GameSettingsParam? gameSettings;

            /// <summary>
            /// Stores the matchmaking queue settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.MatchmakingQueueSettings, isOptional = true, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam>? matchmakingQueueSettings;

        }

        /// <summary>
        /// Represents the request payload for the set master game settings operation.
        /// </summary>
        public class SetMasterGameSettingsRequestData
        {
            /// <summary>
            /// Stores the thirt party settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ThirtPartySettings, isOptional = true)]
            public ThirtPartyParam? thirtPartySettings;

            /// <summary>
            /// Stores the master player settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MasterPlayerSettings, isOptional = true)]
            public MasterPlayerSettingsParam? masterPlayerSettings;

            /// <summary>
            /// Stores the email settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.EmailSettings, isOptional = true)]
            public EmailSettingsParam? emailSettings;

            /// <summary>
            /// Stores the push notification settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PushNotificationSettings, isOptional = true)]
            public PushNotificationSettingsParam? pushNotificationSettings;

        }

        /// <summary>
        /// Represents the request payload for the set password admin account operation.
        /// </summary>
        public class SetPasswordAdminAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

        }

        /// <summary>
        /// Represents the request payload for the set secret info information operation.
        /// </summary>
        public class SetSecretInfoInformationRequestData
        {
            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

            /// <summary>
            /// Stores the remove value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Remove, isOptional = true)]
            public bool? remove;

            /// <summary>
            /// Stores the timestamp expire value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsExpire, isOptional = true)]
            public long? tsExpire;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description, isOptional = true)]
            public string? description;

            /// <summary>
            /// Stores the permission param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PermissionParam, isOptional = true)]
            public PermissionParam? permissionParam;

        }

        /// <summary>
        /// Represents the request payload for the set secret key admin account operation.
        /// </summary>
        public class SetSecretKeyAdminAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string secretKey;

        }

        /// <summary>
        /// Represents the request payload for the get username admin account operation.
        /// </summary>
        public class GetUsernameAdminAccountRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10, mustNonNull = true)]
            public string userId;

        }

        /// <summary>
        /// Represents the request payload for the get analytics operation.
        /// </summary>
        public class GetAnalyticsRequestData
        {
            /// <summary>
            /// Stores the timestamp value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Timestamp, minValue = 0, isOptional = true)]
            public long? timestamp;

            /// <summary>
            /// Stores the analytics item value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.AnalyticsItem, isOptional = true)]
            public bool? analyticsItem;

            /// <summary>
            /// Stores the country value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Country, isOptional = true)]
            public bool? country;

            /// <summary>
            /// Stores the request complete value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.RequestComplete, isOptional = true)]
            public bool? requestComplete;

            /// <summary>
            /// Stores the operation system value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.OperationSystem, isOptional = true)]
            public bool? operationSystem;

            /// <summary>
            /// Stores the database system value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.DatabaseSystem, isOptional = true)]
            public bool? databaseSystem;

            /// <summary>
            /// Stores the log database system value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.LogDatabaseSystem, isOptional = true)]
            public bool? logDatabaseSystem;

            /// <summary>
            /// Stores the cost value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Cost, isOptional = true)]
            public bool? cost;

            /// <summary>
            /// Stores the monthly cost value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.MonthlyCost, isOptional = true)]
            public bool? monthlyCost;

        }

        /// <summary>
        /// Represents the request payload for the get event callback cloud script operation.
        /// </summary>
        public class GetEventCallbackCloudScriptRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the set event callback cloud script operation.
        /// </summary>
        public class SetEventCallbackCloudScriptRequestData
        {
            /// <summary>
            /// Stores the event name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EventName, minLength = 6, maxLength = 128, mustNonNull = true)]
            public string eventName;

            /// <summary>
            /// Stores the script value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Script, minLength = 6, maxLength = int.MaxValue, mustNonNull = true)]
            public string script;

        }

        /// <summary>
        /// Represents the request payload for the reset statistics leaderboard operation.
        /// </summary>
        public class ResetStatisticsLeaderboardRequestData
        {
            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, minLength = 2, maxLength = 32)]
            public string version;

            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32, mustNonNull = true, isOptional = true)]
            public string? catalogId;

        }

        /// <summary>
        /// Represents the request payload for the delete in database operation.
        /// </summary>
        public class DeleteInDatabaseRequestData
        {
            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Id, minLength = 2, maxLength = 15)]
            public string id;

            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log, minLength = 1, maxLength = 256, mustNonNull = true, isOptional = true)]
            public string? log;

        }

        /// <summary>
        /// Represents the request payload for the get backup statistics leaderboard version operation.
        /// </summary>
        public class GetBackupStatisticsLeaderboardVersionRequestData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

        }

        /// <summary>
        /// Represents the request payload for the get server game data operation.
        /// </summary>
        public class GetServerGameDataRequestData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
            public string gameId;

            /// <summary>
            /// Stores the master player count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.MasterPlayerCount, isOptional = true)]
            public bool? masterPlayerCount;

            /// <summary>
            /// Stores the game player count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GamePlayerCount, isOptional = true)]
            public bool? gamePlayerCount;

            /// <summary>
            /// Stores the character player count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CharacterPlayerCount, isOptional = true)]
            public bool? characterPlayerCount;

            /// <summary>
            /// Stores the inventory count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.InventoryCount, isOptional = true)]
            public bool? inventoryCount;

            /// <summary>
            /// Stores the store inventory count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.StoreInventoryCount, isOptional = true)]
            public bool? storeInventoryCount;

            /// <summary>
            /// Stores the group count value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.GroupCount, isOptional = true)]
            public bool? groupCount;

            /// <summary>
            /// Stores the country value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Country, isOptional = true)]
            public bool? country;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Version, isOptional = true)]
            public bool? version;

        }

    }

    /// <summary>
    /// Defines payload models for dashboard operations.
    /// </summary>
    public partial class DashboardModels
    {
        /// <summary>
        /// Represents the authenticate permission rules param component.
        /// </summary>
        public class AuthenticatePermissionRulesParam
        {
            /// <summary>
            /// Stores the login by account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByAccount, isOptional = true)]
            public PermissionRulesParam? loginByAccount;

            /// <summary>
            /// Stores the login by android device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByAndroidDeviceId;

            /// <summary>
            /// Stores the login by apple value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByApple, isOptional = true)]
            public PermissionRulesParam? loginByApple;

            /// <summary>
            /// Stores the login by custom device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByCustomDeviceId;

            /// <summary>
            /// Stores the login by custom ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByCustomId, isOptional = true)]
            public PermissionRulesParam? loginByCustomId;

            /// <summary>
            /// Stores the login by facebook value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByFacebook, isOptional = true)]
            public PermissionRulesParam? loginByFacebook;

            /// <summary>
            /// Stores the login by generic service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByGenericService, isOptional = true)]
            public PermissionRulesParam? loginByGenericService;

            /// <summary>
            /// Stores the login by google value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByGoogle, isOptional = true)]
            public PermissionRulesParam? loginByGoogle;

            /// <summary>
            /// Stores the login by google play game service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? loginByGooglePlayGameService;

            /// <summary>
            /// Stores the login by game center value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByGameCenter, isOptional = true)]
            public PermissionRulesParam? loginByGameCenter;

            /// <summary>
            /// Stores the login by iOS device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByiOSDeviceId;

            /// <summary>
            /// Stores the login by windows phone device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsPhoneDeviceId;

            /// <summary>
            /// Stores the register account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RegisterAccount, isOptional = true)]
            public PermissionRulesParam? registerAccount;

            /// <summary>
            /// Stores the login by editor device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByEditorDeviceId;

            /// <summary>
            /// Stores the login by linux device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByLinuxDeviceId;

            /// <summary>
            /// Stores the login by macos device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByMacOSDeviceId;

            /// <summary>
            /// Stores the login by windows device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LoginByWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? loginByWindowsDeviceId;

            /// <summary>
            /// Stores the refresh auth token value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RefreshAuthToken, isOptional = true)]
            public PermissionRulesParam? refreshAuthToken;
        }

        /// <summary>
        /// Represents the character catalog settings param component.
        /// </summary>
        public class CharacterCatalogSettingsParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

        }

        /// <summary>
        /// Represents the character player permission rules param component.
        /// </summary>
        public class CharacterPlayerPermissionRulesParam
        {
            /// <summary>
            /// Stores the add segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            /// <summary>
            /// Stores the remove segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            /// <summary>
            /// Stores the get segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            /// <summary>
            /// Stores the set tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            /// <summary>
            /// Stores the remove tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            /// <summary>
            /// Stores the get tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            /// <summary>
            /// Stores the get display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            /// <summary>
            /// Stores the set display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            /// <summary>
            /// Stores the get timestamp create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            /// <summary>
            /// Stores the get IP address create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            /// <summary>
            /// Stores the get timestamp last login value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            /// <summary>
            /// Stores the set player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            /// <summary>
            /// Stores the get player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            /// <summary>
            /// Stores the set country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            /// <summary>
            /// Stores the get country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            /// <summary>
            /// Stores the set avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            /// <summary>
            /// Stores the get avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            /// <summary>
            /// Stores the change player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            /// <summary>
            /// Stores the get player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            /// <summary>
            /// Stores the change player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            /// <summary>
            /// Stores the get player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            /// <summary>
            /// Stores the get statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            /// <summary>
            /// Stores the get statistics leaderboard around player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            /// <summary>
            /// Stores the get custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            /// <summary>
            /// Stores the set custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            /// <summary>
            /// Stores the set player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            /// <summary>
            /// Stores the get player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            /// <summary>
            /// Stores the get player information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            /// <summary>
            /// Stores the get players with segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            /// <summary>
            /// Stores the get players with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            /// <summary>
            /// Stores the get catalog ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            /// <summary>
            /// Stores the get owner value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            /// <summary>
            /// Stores the get remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            /// <summary>
            /// Stores the get player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            /// <summary>
            /// Stores the get player group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            /// <summary>
            /// Stores the get player inventory value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            /// <summary>
            /// Stores the remove player item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            /// <summary>
            /// Stores the create player item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreatePlayerItem, isOptional = true)]
            public PermissionRulesParam? createPlayerItem;

            /// <summary>
            /// Stores the create group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateGroup, isOptional = true)]
            public PermissionRulesParam? createGroup;

            /// <summary>
            /// Stores the join group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            /// <summary>
            /// Stores the leave group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            /// <summary>
            /// Stores the set owner value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            /// <summary>
            /// Stores the add player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            /// <summary>
            /// Stores the remove player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            /// <summary>
            /// Stores the get players with display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            /// <summary>
            /// Stores the set remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            /// <summary>
            /// Stores the get friend statistics leaderboard around player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            /// <summary>
            /// Stores the get friend statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            /// <summary>
            /// Stores the get currency leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the get last login leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            /// <summary>
            /// Stores the get statistics log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            /// <summary>
            /// Stores the get currency log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        /// <summary>
        /// Represents the character player settings param component.
        /// </summary>
        public class CharacterPlayerSettingsParam
        {
            /// <summary>
            /// Stores the player currencies settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            /// <summary>
            /// Stores the player statistics settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            /// <summary>
            /// Stores the player datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            /// <summary>
            /// Stores the custom datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            /// <summary>
            /// Stores the tags settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            /// <summary>
            /// Stores the player group catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerGroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            /// <summary>
            /// Stores the player item catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            /// <summary>
            /// Stores the player friend catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerFriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        /// <summary>
        /// Represents the content permission rules param component.
        /// </summary>
        public class ContentPermissionRulesParam
        {
            /// <summary>
            /// Stores the get content data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetContentData, isOptional = true)]
            public PermissionRulesParam? getContentData;

            /// <summary>
            /// Stores the set content data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetContentData, isOptional = true)]
            public PermissionRulesParam? setContentData;

            /// <summary>
            /// Stores the create new file upload info value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateNewFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? createNewFileUploadInfo;

            /// <summary>
            /// Stores the get file upload info list value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFileUploadInfoList, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfoList;

            /// <summary>
            /// Stores the get file upload info value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? getFileUploadInfo;

            /// <summary>
            /// Stores the remove file upload info value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? removeFileUploadInfo;

            /// <summary>
            /// Stores the request download file upload info value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RequestDownloadFileUploadInfo, isOptional = true)]
            public PermissionRulesParam? requestDownloadFileUploadInfo;

        }

        /// <summary>
        /// Represents the currency settings param component.
        /// </summary>
        public class CurrencySettingsParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            /// <summary>
            /// Stores the initial value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.InitialValue)]
            public double initialValue;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the index value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        /// <summary>
        /// Represents the data settings param component.
        /// </summary>
        public class DataSettingsParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.DisplayName, minLength = 2, maxLength = 64)]
            public string displayName;

            /// <summary>
            /// Stores the permission value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Permission, mustInt = true)]
            public int permission;

        }

        /// <summary>
        /// Represents the friend catalog settings param component.
        /// </summary>
        public class FriendCatalogSettingsParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the force accept friend value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceAcceptFriend)]
            public bool forceAcceptFriend;

        }

        /// <summary>
        /// Represents the email settings param component.
        /// </summary>
        public class EmailSettingsParam
        {
            /// <summary>
            /// Stores the send from value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SendFrom)]
            public string sendFrom;

            /// <summary>
            /// Stores the secure value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Secure)]
            public bool secure;

            /// <summary>
            /// Stores the host value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Host)]
            public string host;

            /// <summary>
            /// Stores the port value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Port)]
            public int port;

            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username)]
            public string username;

            /// <summary>
            /// Stores the password value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Password)]
            public string password;
        }

        /// <summary>
        /// Represents the push notification settings param component.
        /// </summary>
        public class PushNotificationSettingsParam
        {
            /// <summary>
            /// Stores the project ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ProjectId)]
            public string projectId;

            /// <summary>
            /// Stores the client email value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClientEmail)]
            public string clientEmail;

            /// <summary>
            /// Stores the private key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PrivateKey)]
            public string privateKey;

        }

        /// <summary>
        /// Represents the game player permission rules param component.
        /// </summary>
        public class GamePlayerPermissionRulesParam
        {
            /// <summary>
            /// Stores the add segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            /// <summary>
            /// Stores the remove segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            /// <summary>
            /// Stores the get segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            /// <summary>
            /// Stores the set tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            /// <summary>
            /// Stores the remove tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            /// <summary>
            /// Stores the get tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            /// <summary>
            /// Stores the get display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            /// <summary>
            /// Stores the set display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            /// <summary>
            /// Stores the get timestamp create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            /// <summary>
            /// Stores the get IP address create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            /// <summary>
            /// Stores the get timestamp last login value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            /// <summary>
            /// Stores the set player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            /// <summary>
            /// Stores the get player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            /// <summary>
            /// Stores the set country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            /// <summary>
            /// Stores the get country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            /// <summary>
            /// Stores the set avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            /// <summary>
            /// Stores the get avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            /// <summary>
            /// Stores the change player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            /// <summary>
            /// Stores the get player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            /// <summary>
            /// Stores the change player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            /// <summary>
            /// Stores the get player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            /// <summary>
            /// Stores the get statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            /// <summary>
            /// Stores the get statistics leaderboard around player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            /// <summary>
            /// Stores the get custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            /// <summary>
            /// Stores the set custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            /// <summary>
            /// Stores the set player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            /// <summary>
            /// Stores the get player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            /// <summary>
            /// Stores the get player information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            /// <summary>
            /// Stores the get players with segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            /// <summary>
            /// Stores the get players with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            /// <summary>
            /// Stores the get player character value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerCharacter, isOptional = true)]
            public PermissionRulesParam? getPlayerCharacter;

            /// <summary>
            /// Stores the get player inventory value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerInventory, isOptional = true)]
            public PermissionRulesParam? getPlayerInventory;

            /// <summary>
            /// Stores the get player group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerGroup, isOptional = true)]
            public PermissionRulesParam? getPlayerGroup;

            /// <summary>
            /// Stores the get player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerFriend, isOptional = true)]
            public PermissionRulesParam? getPlayerFriend;

            /// <summary>
            /// Stores the remove player item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePlayerItem, isOptional = true)]
            public PermissionRulesParam? removePlayerItem;

            /// <summary>
            /// Stores the get online status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetOnlineStatus, isOptional = true)]
            public PermissionRulesParam? getOnlineStatus;

            /// <summary>
            /// Stores the create group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateGroup, isOptional = true)]
            public PermissionRulesParam? createGroup;

            /// <summary>
            /// Stores the create player item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreatePlayerItem, isOptional = true)]
            public PermissionRulesParam? createPlayerItem;

            /// <summary>
            /// Stores the create player character value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreatePlayerCharacter, isOptional = true)]
            public PermissionRulesParam? createPlayerCharacter;

            /// <summary>
            /// Stores the add player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddPlayerFriend, isOptional = true)]
            public PermissionRulesParam? addPlayerFriend;

            /// <summary>
            /// Stores the remove player friend value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePlayerFriend, isOptional = true)]
            public PermissionRulesParam? removePlayerFriend;

            /// <summary>
            /// Stores the remove player character value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePlayerCharacter, isOptional = true)]
            public PermissionRulesParam? removePlayerCharacter;

            /// <summary>
            /// Stores the join group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.JoinGroup, isOptional = true)]
            public PermissionRulesParam? joinGroup;

            /// <summary>
            /// Stores the leave group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LeaveGroup, isOptional = true)]
            public PermissionRulesParam? leaveGroup;

            /// <summary>
            /// Stores the get players with display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            /// <summary>
            /// Stores the get friend statistics leaderboard around player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboardAroundPlayer;

            /// <summary>
            /// Stores the get friend statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFriendStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getFriendStatisticsLeaderboard;

            /// <summary>
            /// Stores the get currency leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the get statistics log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            /// <summary>
            /// Stores the get currency log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        /// <summary>
        /// Represents the game player settings param component.
        /// </summary>
        public class GamePlayerSettingsParam
        {
            /// <summary>
            /// Stores the player currencies settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            /// <summary>
            /// Stores the player statistics settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            /// <summary>
            /// Stores the player datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            /// <summary>
            /// Stores the custom datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            /// <summary>
            /// Stores the tags settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            /// <summary>
            /// Stores the player character catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCharacterCatalogSettings, elementCls = typeof(CharacterCatalogSettingsParam), isOptional = true)]
            public List<CharacterCatalogSettingsParam>? playerCharacterCatalogSettings;

            /// <summary>
            /// Stores the player group catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerGroupCatalogSettings, elementCls = typeof(GroupCatalogSettingsParam), isOptional = true)]
            public List<GroupCatalogSettingsParam>? playerGroupCatalogSettings;

            /// <summary>
            /// Stores the player item catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? playerItemCatalogSettings;

            /// <summary>
            /// Stores the player friend catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerFriendCatalogSettings, elementCls = typeof(FriendCatalogSettingsParam), isOptional = true)]
            public List<FriendCatalogSettingsParam>? playerFriendCatalogSettings;

        }

        /// <summary>
        /// Represents the game settings param component.
        /// </summary>
        public class GameSettingsParam
        {
            /// <summary>
            /// Stores the game player settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GamePlayerSettings, isOptional = true)]
            public GamePlayerSettingsParam? gamePlayerSettings;

            /// <summary>
            /// Stores the character player settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CharacterPlayerSettings, isOptional = true)]
            public CharacterPlayerSettingsParam? characterPlayerSettings;

            /// <summary>
            /// Stores the group settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GroupSettings, isOptional = true)]
            public GroupSettingsParam? groupSettings;

            /// <summary>
            /// Stores the inventory settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InventorySettings, isOptional = true)]
            public InventorySettingsParam? inventorySettings;

        }

        /// <summary>
        /// Represents the generic service settings param component.
        /// </summary>
        public class GenericServiceSettingsParam
        {
            /// <summary>
            /// Stores the service name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 2, maxLength = 32)]
            public string serviceName;

        }

        /// <summary>
        /// Represents the group catalog settings param component.
        /// </summary>
        public class GroupCatalogSettingsParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the force accept member value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ForceAcceptMember)]
            public bool forceAcceptMember;

        }

        /// <summary>
        /// Represents the group permission rules param component.
        /// </summary>
        public class GroupPermissionRulesParam
        {
            /// <summary>
            /// Stores the add segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            /// <summary>
            /// Stores the remove segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            /// <summary>
            /// Stores the get segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            /// <summary>
            /// Stores the set tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            /// <summary>
            /// Stores the remove tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            /// <summary>
            /// Stores the get tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            /// <summary>
            /// Stores the get display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            /// <summary>
            /// Stores the set display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            /// <summary>
            /// Stores the get timestamp create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            /// <summary>
            /// Stores the set avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            /// <summary>
            /// Stores the get avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            /// <summary>
            /// Stores the change group currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangeGroupCurrency, isOptional = true)]
            public PermissionRulesParam? changeGroupCurrency;

            /// <summary>
            /// Stores the get group currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupCurrency, isOptional = true)]
            public PermissionRulesParam? getGroupCurrency;

            /// <summary>
            /// Stores the change group statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangeGroupStatistics, isOptional = true)]
            public PermissionRulesParam? changeGroupStatistics;

            /// <summary>
            /// Stores the get group statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupStatistics, isOptional = true)]
            public PermissionRulesParam? getGroupStatistics;

            /// <summary>
            /// Stores the get statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            /// <summary>
            /// Stores the get statistics leaderboard around group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundGroup, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundGroup;

            /// <summary>
            /// Stores the get custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            /// <summary>
            /// Stores the set custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            /// <summary>
            /// Stores the set group data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetGroupData, isOptional = true)]
            public PermissionRulesParam? setGroupData;

            /// <summary>
            /// Stores the get group data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupData, isOptional = true)]
            public PermissionRulesParam? getGroupData;

            /// <summary>
            /// Stores the get group information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupInformation, isOptional = true)]
            public PermissionRulesParam? getGroupInformation;

            /// <summary>
            /// Stores the get groups with segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithSegment, isOptional = true)]
            public PermissionRulesParam? getGroupsWithSegment;

            /// <summary>
            /// Stores the get groups with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithTag, isOptional = true)]
            public PermissionRulesParam? getGroupsWithTag;

            /// <summary>
            /// Stores the get catalog ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            /// <summary>
            /// Stores the get remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            /// <summary>
            /// Stores the get group inventory value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupInventory, isOptional = true)]
            public PermissionRulesParam? getGroupInventory;

            /// <summary>
            /// Stores the remove group item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveGroupItem, isOptional = true)]
            public PermissionRulesParam? removeGroupItem;

            /// <summary>
            /// Stores the create group item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateGroupItem, isOptional = true)]
            public PermissionRulesParam? createGroupItem;

            /// <summary>
            /// Stores the get members value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetMembers, isOptional = true)]
            public PermissionRulesParam? getMembers;

            /// <summary>
            /// Stores the add member value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddMember, isOptional = true)]
            public PermissionRulesParam? addMember;

            /// <summary>
            /// Stores the remove member value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveMember, isOptional = true)]
            public PermissionRulesParam? removeMember;

            /// <summary>
            /// Stores the send group message value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SendGroupMessage, isOptional = true)]
            public PermissionRulesParam? sendGroupMessage;

            /// <summary>
            /// Stores the get group message value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupMessage, isOptional = true)]
            public PermissionRulesParam? getGroupMessage;

            /// <summary>
            /// Stores the set remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            /// <summary>
            /// Stores the get groups with display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGroupsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getGroupsWithDisplayName;

            /// <summary>
            /// Stores the get currency leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the get statistics log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            /// <summary>
            /// Stores the get currency log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

        }

        /// <summary>
        /// Represents the group settings param component.
        /// </summary>
        public class GroupSettingsParam
        {
            /// <summary>
            /// Stores the group currencies settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? groupCurrenciesSettings;

            /// <summary>
            /// Stores the group statistics settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? groupStatisticsSettings;

            /// <summary>
            /// Stores the group datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? groupDatasSettings;

            /// <summary>
            /// Stores the custom datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            /// <summary>
            /// Stores the tags settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

            /// <summary>
            /// Stores the group item catalog settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GroupItemCatalogSettings, elementCls = typeof(ItemCatalogSettingsParam), isOptional = true)]
            public List<ItemCatalogSettingsParam>? groupItemCatalogSettings;

        }

        /// <summary>
        /// Represents the inventory permission rules param component.
        /// </summary>
        public class InventoryPermissionRulesParam
        {
            /// <summary>
            /// Stores the add segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            /// <summary>
            /// Stores the remove segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            /// <summary>
            /// Stores the get segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            /// <summary>
            /// Stores the set tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            /// <summary>
            /// Stores the remove tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            /// <summary>
            /// Stores the get tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            /// <summary>
            /// Stores the get display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            /// <summary>
            /// Stores the set display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            /// <summary>
            /// Stores the get timestamp create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            /// <summary>
            /// Stores the set avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            /// <summary>
            /// Stores the get avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            /// <summary>
            /// Stores the change item statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangeItemStatistics, isOptional = true)]
            public PermissionRulesParam? changeItemStatistics;

            /// <summary>
            /// Stores the get item statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemStatistics, isOptional = true)]
            public PermissionRulesParam? getItemStatistics;

            /// <summary>
            /// Stores the get statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            /// <summary>
            /// Stores the get statistics leaderboard around item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundItem, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundItem;

            /// <summary>
            /// Stores the get custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            /// <summary>
            /// Stores the set custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            /// <summary>
            /// Stores the set item data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetItemData, isOptional = true)]
            public PermissionRulesParam? setItemData;

            /// <summary>
            /// Stores the get item data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemData, isOptional = true)]
            public PermissionRulesParam? getItemData;

            /// <summary>
            /// Stores the get item information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemInformation, isOptional = true)]
            public PermissionRulesParam? getItemInformation;

            /// <summary>
            /// Stores the get items with segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemsWithSegment, isOptional = true)]
            public PermissionRulesParam? getItemsWithSegment;

            /// <summary>
            /// Stores the get items with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getItemsWithTag;

            /// <summary>
            /// Stores the get catalog ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCatalogId, isOptional = true)]
            public PermissionRulesParam? getCatalogId;

            /// <summary>
            /// Stores the get class ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetClassId, isOptional = true)]
            public PermissionRulesParam? getClassId;

            /// <summary>
            /// Stores the get item type value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemType, isOptional = true)]
            public PermissionRulesParam? getItemType;

            /// <summary>
            /// Stores the get amount value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAmount, isOptional = true)]
            public PermissionRulesParam? getAmount;

            /// <summary>
            /// Stores the get owner value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetOwner, isOptional = true)]
            public PermissionRulesParam? getOwner;

            /// <summary>
            /// Stores the get remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? getRemoveStatus;

            /// <summary>
            /// Stores the set amount value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAmount, isOptional = true)]
            public PermissionRulesParam? setAmount;

            /// <summary>
            /// Stores the set owner value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetOwner, isOptional = true)]
            public PermissionRulesParam? setOwner;

            /// <summary>
            /// Stores the set remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            /// <summary>
            /// Stores the get items with display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetItemsWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getItemsWithDisplayName;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the get statistics log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

        }

        /// <summary>
        /// Represents the inventory settings param component.
        /// </summary>
        public class InventorySettingsParam
        {
            /// <summary>
            /// Stores the item statistics settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? itemStatisticsSettings;

            /// <summary>
            /// Stores the item datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? itemDatasSettings;

            /// <summary>
            /// Stores the custom datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            /// <summary>
            /// Stores the tags settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        /// <summary>
        /// Represents the item catalog settings param component.
        /// </summary>
        public class ItemCatalogSettingsParam
        {
            /// <summary>
            /// Stores the catalog ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CatalogId, minLength = 2, maxLength = 32)]
            public string catalogId;

            /// <summary>
            /// Stores the item type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.ItemType, mustInt = true)]
            public int itemType;

            /// <summary>
            /// Stores the item class settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ItemClassSettings, elementCls = typeof(ItemClassSettingsParam))]
            public List<ItemClassSettingsParam> itemClassSettings;

        }

        /// <summary>
        /// Represents the item class settings param component.
        /// </summary>
        public class ItemClassSettingsParam
        {
            /// <summary>
            /// Stores the class ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClassId, minLength = 2, maxLength = 32)]
            public string classId;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

        }

        /// <summary>
        /// Represents the dashboard permission rules param component.
        /// </summary>
        public class DashboardPermissionRulesParam
        {
            /// <summary>
            /// Stores the set master game settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? setMasterGameSettings;

            /// <summary>
            /// Stores the create admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateAdminAccount, isOptional = true)]
            public PermissionRulesParam? createAdminAccount;

            /// <summary>
            /// Stores the remove admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveAdminAccount, isOptional = true)]
            public PermissionRulesParam? removeAdminAccount;

            /// <summary>
            /// Stores the set password admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? setPasswordAdminAccount;

            /// <summary>
            /// Stores the set secret key admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetSecretKeyAdminAccount, isOptional = true)]
            public PermissionRulesParam? setSecretKeyAdminAccount;

            /// <summary>
            /// Stores the set game information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetGameInformation, isOptional = true)]
            public PermissionRulesParam? setGameInformation;

            /// <summary>
            /// Stores the create game value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateGame, isOptional = true)]
            public PermissionRulesParam? createGame;

            /// <summary>
            /// Stores the change password admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePasswordAdminAccount, isOptional = true)]
            public PermissionRulesParam? changePasswordAdminAccount;

            /// <summary>
            /// Stores the get admin account list value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAdminAccountList, isOptional = true)]
            public PermissionRulesParam? getAdminAccountList;

            /// <summary>
            /// Stores the get game information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGameInformation, isOptional = true)]
            public PermissionRulesParam? getGameInformation;

            /// <summary>
            /// Stores the get game list value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetGameList, isOptional = true)]
            public PermissionRulesParam? getGameList;

            /// <summary>
            /// Stores the get master game settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetMasterGameSettings, isOptional = true)]
            public PermissionRulesParam? getMasterGameSettings;

            /// <summary>
            /// Stores the get server log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetServerLog, isOptional = true)]
            public PermissionRulesParam? getServerLog;

            /// <summary>
            /// Stores the get secret info information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? getSecretInfoInformation;

            /// <summary>
            /// Stores the get secret info list value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSecretInfoList, isOptional = true)]
            public PermissionRulesParam? getSecretInfoList;

            /// <summary>
            /// Stores the create secret info value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateSecretInfo, isOptional = true)]
            public PermissionRulesParam? createSecretInfo;

            /// <summary>
            /// Stores the set secret info information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetSecretInfoInformation, isOptional = true)]
            public PermissionRulesParam? setSecretInfoInformation;

            /// <summary>
            /// Stores the get username admin account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetUsernameAdminAccount, isOptional = true)]
            public PermissionRulesParam? getUsernameAdminAccount;

            /// <summary>
            /// Stores the get analytics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAnalytics, isOptional = true)]
            public PermissionRulesParam? getAnalytics;

            /// <summary>
            /// Stores the get event callback cloud script value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? getEventCallbackCloudScript;

            /// <summary>
            /// Stores the set event callback cloud script value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetEventCallbackCloudScript, isOptional = true)]
            public PermissionRulesParam? setEventCallbackCloudScript;

            /// <summary>
            /// Stores the reset statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ResetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? resetStatisticsLeaderboard;

            /// <summary>
            /// Stores the get backup statistics leaderboard version value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetBackupStatisticsLeaderboardVersion, isOptional = true)]
            public PermissionRulesParam? getBackupStatisticsLeaderboardVersion;

            /// <summary>
            /// Stores the get server game data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetServerGameData, isOptional = true)]
            public PermissionRulesParam? getServerGameData;

        }

        /// <summary>
        /// Represents the multiplayer permission rules param component.
        /// </summary>
        public class MultiplayerPermissionRulesParam
        {
            /// <summary>
            /// Indicates whether cancel all matchmaking ticket.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CancelAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelAllMatchmakingTicket;

            /// <summary>
            /// Indicates whether cancel matchmaking ticket.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CancelMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? cancelMatchmakingTicket;

            /// <summary>
            /// Stores the create matchmaking ticket value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? createMatchmakingTicket;

            /// <summary>
            /// Stores the get matchmaking ticket value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getMatchmakingTicket;

            /// <summary>
            /// Stores the get match value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetMatch, isOptional = true)]
            public PermissionRulesParam? getMatch;

            /// <summary>
            /// Stores the get queue statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetQueueStatistics, isOptional = true)]
            public PermissionRulesParam? getQueueStatistics;

            /// <summary>
            /// Stores the join matchmaking ticket value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.JoinMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? joinMatchmakingTicket;

            /// <summary>
            /// Stores the list matchmaking tickets for player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ListMatchmakingTicketsForPlayer, isOptional = true)]
            public PermissionRulesParam? listMatchmakingTicketsForPlayer;

            /// <summary>
            /// Stores the get all matchmaking ticket value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAllMatchmakingTicket, isOptional = true)]
            public PermissionRulesParam? getAllMatchmakingTicket;

            /// <summary>
            /// Stores the get all match value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAllMatch, isOptional = true)]
            public PermissionRulesParam? getAllMatch;

        }

        /// <summary>
        /// Represents the master player permission rules param component.
        /// </summary>
        public class MasterPlayerPermissionRulesParam
        {
            /// <summary>
            /// Stores the link account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkAccount, isOptional = true)]
            public PermissionRulesParam? linkAccount;

            /// <summary>
            /// Stores the link android device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? linkAndroidDeviceId;

            /// <summary>
            /// Stores the link apple value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkApple, isOptional = true)]
            public PermissionRulesParam? linkApple;

            /// <summary>
            /// Stores the link custom device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? linkCustomDeviceId;

            /// <summary>
            /// Stores the link custom ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkCustomId, isOptional = true)]
            public PermissionRulesParam? linkCustomId;

            /// <summary>
            /// Stores the link editor device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? linkEditorDeviceId;

            /// <summary>
            /// Stores the link facebook value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkFacebook, isOptional = true)]
            public PermissionRulesParam? linkFacebook;

            /// <summary>
            /// Stores the link generic service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkGenericService, isOptional = true)]
            public PermissionRulesParam? linkGenericService;

            /// <summary>
            /// Stores the link google value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkGoogle, isOptional = true)]
            public PermissionRulesParam? linkGoogle;

            /// <summary>
            /// Stores the link google play game service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? linkGooglePlayGameService;

            /// <summary>
            /// Stores the link game center value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkGameCenter, isOptional = true)]
            public PermissionRulesParam? linkGameCenter;

            /// <summary>
            /// Stores the link iOS device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkiOSDeviceId;

            /// <summary>
            /// Stores the link linux device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? linkLinuxDeviceId;

            /// <summary>
            /// Stores the link macos device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? linkMacOSDeviceId;

            /// <summary>
            /// Stores the link windows device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsDeviceId;

            /// <summary>
            /// Stores the link windows phone device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? linkWindowsPhoneDeviceId;

            /// <summary>
            /// Stores the unlink account value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkAccount, isOptional = true)]
            public PermissionRulesParam? unlinkAccount;

            /// <summary>
            /// Stores the unlink android device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkAndroidDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkAndroidDeviceId;

            /// <summary>
            /// Stores the unlink apple value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkApple, isOptional = true)]
            public PermissionRulesParam? unlinkApple;

            /// <summary>
            /// Stores the unlink custom device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkCustomDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomDeviceId;

            /// <summary>
            /// Stores the unlink custom ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkCustomId, isOptional = true)]
            public PermissionRulesParam? unlinkCustomId;

            /// <summary>
            /// Stores the unlink editor device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkEditorDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkEditorDeviceId;

            /// <summary>
            /// Stores the unlink facebook value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkFacebook, isOptional = true)]
            public PermissionRulesParam? unlinkFacebook;

            /// <summary>
            /// Stores the unlink generic service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkGenericService, isOptional = true)]
            public PermissionRulesParam? unlinkGenericService;

            /// <summary>
            /// Stores the unlink google value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkGoogle, isOptional = true)]
            public PermissionRulesParam? unlinkGoogle;

            /// <summary>
            /// Stores the unlink google play game service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? unlinkGooglePlayGameService;

            /// <summary>
            /// Stores the unlink game center value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkGameCenter, isOptional = true)]
            public PermissionRulesParam? unlinkGameCenter;

            /// <summary>
            /// Stores the unlink iOS device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkiOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkiOSDeviceId;

            /// <summary>
            /// Stores the unlink linux device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkLinuxDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkLinuxDeviceId;

            /// <summary>
            /// Stores the unlink macos device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkMacOSDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkMacOSDeviceId;

            /// <summary>
            /// Stores the unlink windows device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkWindowsDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsDeviceId;

            /// <summary>
            /// Stores the unlink windows phone device ID value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UnlinkWindowsPhoneDeviceId, isOptional = true)]
            public PermissionRulesParam? unlinkWindowsPhoneDeviceId;

            /// <summary>
            /// Stores the add segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddSegment, isOptional = true)]
            public PermissionRulesParam? addSegment;

            /// <summary>
            /// Stores the remove segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveSegment, isOptional = true)]
            public PermissionRulesParam? removeSegment;

            /// <summary>
            /// Stores the get segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetSegment, isOptional = true)]
            public PermissionRulesParam? getSegment;

            /// <summary>
            /// Stores the set tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetTag, isOptional = true)]
            public PermissionRulesParam? setTag;

            /// <summary>
            /// Stores the remove tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveTag, isOptional = true)]
            public PermissionRulesParam? removeTag;

            /// <summary>
            /// Stores the get tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTag, isOptional = true)]
            public PermissionRulesParam? getTag;

            /// <summary>
            /// Stores the get display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetDisplayName, isOptional = true)]
            public PermissionRulesParam? getDisplayName;

            /// <summary>
            /// Stores the set display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetDisplayName, isOptional = true)]
            public PermissionRulesParam? setDisplayName;

            /// <summary>
            /// Stores the get timestamp create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsCreate, isOptional = true)]
            public PermissionRulesParam? getTsCreate;

            /// <summary>
            /// Stores the get IP address create value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetIpAddressCreate, isOptional = true)]
            public PermissionRulesParam? getIpAddressCreate;

            /// <summary>
            /// Stores the set timestamp last login value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.UpdateTsLastLogin, isOptional = true)]
            public PermissionRulesParam? updateTsLastLogin;

            /// <summary>
            /// Stores the get timestamp last login value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetTsLastLogin, isOptional = true)]
            public PermissionRulesParam? getTsLastLogin;

            /// <summary>
            /// Stores the set player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerBan, isOptional = true)]
            public PermissionRulesParam? setPlayerBan;

            /// <summary>
            /// Stores the get player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerBan, isOptional = true)]
            public PermissionRulesParam? getPlayerBan;

            /// <summary>
            /// Stores the set country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCountryCode, isOptional = true)]
            public PermissionRulesParam? setCountryCode;

            /// <summary>
            /// Stores the get country code value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCountryCode, isOptional = true)]
            public PermissionRulesParam? getCountryCode;

            /// <summary>
            /// Stores the change account password value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangeAccountPassword, isOptional = true)]
            public PermissionRulesParam? changeAccountPassword;

            /// <summary>
            /// Stores the reset account password value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ResetAccountPassword, isOptional = true)]
            public PermissionRulesParam? resetAccountPassword;

            /// <summary>
            /// Stores the set avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetAvatar, isOptional = true)]
            public PermissionRulesParam? setAvatar;

            /// <summary>
            /// Stores the get avatar value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetAvatar, isOptional = true)]
            public PermissionRulesParam? getAvatar;

            /// <summary>
            /// Stores the change player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerCurrency, isOptional = true)]
            public PermissionRulesParam? changePlayerCurrency;

            /// <summary>
            /// Stores the get player currency value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerCurrency, isOptional = true)]
            public PermissionRulesParam? getPlayerCurrency;

            /// <summary>
            /// Stores the change player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ChangePlayerStatistics, isOptional = true)]
            public PermissionRulesParam? changePlayerStatistics;

            /// <summary>
            /// Stores the get player statistics value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerStatistics, isOptional = true)]
            public PermissionRulesParam? getPlayerStatistics;

            /// <summary>
            /// Stores the get statistics leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboard, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboard;

            /// <summary>
            /// Stores the get statistics leaderboard around player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLeaderboardAroundPlayer, isOptional = true)]
            public PermissionRulesParam? getStatisticsLeaderboardAroundPlayer;

            /// <summary>
            /// Stores the get custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCustomData, isOptional = true)]
            public PermissionRulesParam? getCustomData;

            /// <summary>
            /// Stores the set custom data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetCustomData, isOptional = true)]
            public PermissionRulesParam? setCustomData;

            /// <summary>
            /// Stores the set player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetPlayerData, isOptional = true)]
            public PermissionRulesParam? setPlayerData;

            /// <summary>
            /// Stores the get player data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerData, isOptional = true)]
            public PermissionRulesParam? getPlayerData;

            /// <summary>
            /// Stores the get player information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayerInformation, isOptional = true)]
            public PermissionRulesParam? getPlayerInformation;

            /// <summary>
            /// Stores the get players with apple value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithApple, isOptional = true)]
            public PermissionRulesParam? getPlayersWithApple;

            /// <summary>
            /// Stores the get players with facebook value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithFacebook, isOptional = true)]
            public PermissionRulesParam? getPlayersWithFacebook;

            /// <summary>
            /// Stores the get players with google value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGoogle, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGoogle;

            /// <summary>
            /// Stores the get players with generic service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGenericService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGenericService;

            /// <summary>
            /// Stores the get players with segment value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithSegment, isOptional = true)]
            public PermissionRulesParam? getPlayersWithSegment;

            /// <summary>
            /// Stores the get players with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithTag, isOptional = true)]
            public PermissionRulesParam? getPlayersWithTag;

            /// <summary>
            /// Stores the get players with google play game service value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGooglePlayGameService, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGooglePlayGameService;

            /// <summary>
            /// Stores the get players with game center value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithGameCenter, isOptional = true)]
            public PermissionRulesParam? getPlayersWithGameCenter;

            /// <summary>
            /// Stores the get external value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetExternal, isOptional = true)]
            public PermissionRulesParam? getExternal;

            /// <summary>
            /// Stores the get players with display name value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPlayersWithDisplayName, isOptional = true)]
            public PermissionRulesParam? getPlayersWithDisplayName;

            /// <summary>
            /// Stores the get email value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetEmail, isOptional = true)]
            public PermissionRulesParam? getEmail;

            /// <summary>
            /// Stores the set email value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetEmail, isOptional = true)]
            public PermissionRulesParam? setEmail;

            /// <summary>
            /// Stores the get currency leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCurrencyLeaderboard;

            /// <summary>
            /// Stores the get last login leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetLastLoginLeaderboard, isOptional = true)]
            public PermissionRulesParam? getLastLoginLeaderboard;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the get statistics log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStatisticsLog, isOptional = true)]
            public PermissionRulesParam? getStatisticsLog;

            /// <summary>
            /// Stores the get currency log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCurrencyLog, isOptional = true)]
            public PermissionRulesParam? getCurrencyLog;

            /// <summary>
            /// Stores the send socket operation event value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SendSocketOperationEvent, isOptional = true)]
            public PermissionRulesParam? sendSocketOperationEvent;

            /// <summary>
            /// Stores the send email value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SendEmail, isOptional = true)]
            public PermissionRulesParam? sendEmail;

            /// <summary>
            /// Stores the send push notification value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SendPushNotification, isOptional = true)]
            public PermissionRulesParam? sendPushNotification;

            /// <summary>
            /// Stores the add push notification value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddPushNotification, isOptional = true)]
            public PermissionRulesParam? addPushNotification;

            /// <summary>
            /// Stores the remove push notification value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemovePushNotification, isOptional = true)]
            public PermissionRulesParam? removePushNotification;

            /// <summary>
            /// Stores the get push notification value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetPushNotification, isOptional = true)]
            public PermissionRulesParam? getPushNotification;

        }

        /// <summary>
        /// Represents the master player settings param component.
        /// </summary>
        public class MasterPlayerSettingsParam
        {
            /// <summary>
            /// Stores the generic service settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.GenericServiceSettings, elementCls = typeof(GenericServiceSettingsParam), isOptional = true)]
            public List<GenericServiceSettingsParam>? genericServiceSettings;

            /// <summary>
            /// Stores the player currencies settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrenciesSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
            public List<CurrencySettingsParam>? playerCurrenciesSettings;

            /// <summary>
            /// Stores the player statistics settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
            public List<StatisticsSettingsParam>? playerStatisticsSettings;

            /// <summary>
            /// Stores the player datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? playerDatasSettings;

            /// <summary>
            /// Stores the custom datas settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
            public List<DataSettingsParam>? customDatasSettings;

            /// <summary>
            /// Stores the tags settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagsSettings, elementCls = typeof(TagSettingsParam), isOptional = true)]
            public List<TagSettingsParam>? tagsSettings;

        }

        /// <summary>
        /// Represents the cloud script permission rules param component.
        /// </summary>
        public class CloudScriptPermissionRulesParam
        {
            /// <summary>
            /// Stores the execute function value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ExecuteFunction, isOptional = true)]
            public PermissionRulesParam? executeFunction;

            /// <summary>
            /// Stores the add function value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AddFunction, isOptional = true)]
            public PermissionRulesParam? addFunction;

            /// <summary>
            /// Stores the get functions value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFunctions, isOptional = true)]
            public PermissionRulesParam? getFunctions;

            /// <summary>
            /// Stores the get function value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetFunction, isOptional = true)]
            public PermissionRulesParam? getFunction;

            /// <summary>
            /// Stores the edit function value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.EditFunction, isOptional = true)]
            public PermissionRulesParam? editFunction;

        }

        /// <summary>
        /// Represents the permission param component.
        /// </summary>
        public class PermissionParam
        {
            /// <summary>
            /// Stores the authenticate value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Authenticate, isOptional = true)]
            public AuthenticatePermissionRulesParam? authenticate;

            /// <summary>
            /// Stores the master player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MasterPlayer, isOptional = true)]
            public MasterPlayerPermissionRulesParam? masterPlayer;

            /// <summary>
            /// Stores the game player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GamePlayer, isOptional = true)]
            public GamePlayerPermissionRulesParam? gamePlayer;

            /// <summary>
            /// Stores the character player value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CharacterPlayer, isOptional = true)]
            public CharacterPlayerPermissionRulesParam? characterPlayer;

            /// <summary>
            /// Stores the content value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Content, isOptional = true)]
            public ContentPermissionRulesParam? content;

            /// <summary>
            /// Stores the group value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Group, isOptional = true)]
            public GroupPermissionRulesParam? group;

            /// <summary>
            /// Stores the inventory value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Inventory, isOptional = true)]
            public InventoryPermissionRulesParam? inventory;

            /// <summary>
            /// Stores the store inventory value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.StoreInventory, isOptional = true)]
            public StoreInventoryPermissionRulesParam? storeInventory;

            /// <summary>
            /// Stores the dashboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Dashboard, isOptional = true)]
            public DashboardPermissionRulesParam? dashboard;

            /// <summary>
            /// Stores the multiplayer value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Multiplayer, isOptional = true)]
            public MultiplayerPermissionRulesParam? multiplayer;

            /// <summary>
            /// Stores the cloud script value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CloudScript, isOptional = true)]
            public CloudScriptPermissionRulesParam? cloudScript;

        }

        /// <summary>
        /// Represents the permission rules param component.
        /// </summary>
        public class PermissionRulesParam
        {
            /// <summary>
            /// Stores the self enable value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.SelfEnable, isOptional = true)]
            public bool? selfEnable;

            /// <summary>
            /// Stores the other self enable value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.OtherSelfEnable, isOptional = true)]
            public bool? otherSelfEnable;

            /// <summary>
            /// Stores the admin self enable value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.AdminSelfEnable, isOptional = true)]
            public bool? adminSelfEnable;

            /// <summary>
            /// Stores the server self enable value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ServerSelfEnable, isOptional = true)]
            public bool? serverSelfEnable;

        }

        /// <summary>
        /// Represents the statistics settings param component.
        /// </summary>
        public class StatisticsSettingsParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            /// <summary>
            /// Stores the statistics aggregation method value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StatisticsAggregationMethod, mustInt = true)]
            public int statisticsAggregationMethod;

            /// <summary>
            /// Stores the maximum value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MaximumValue, isOptional = true, defaultValue = 0)]
            public double? maximumValue;

            /// <summary>
            /// Stores the minimum value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MinimumValue, isOptional = true, defaultValue = 0)]
            public double? minimumValue;

            /// <summary>
            /// Stores the initial value value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.InitialValue)]
            public double initialValue;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the index value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        /// <summary>
        /// Represents the store inventory permission rules param component.
        /// </summary>
        public class StoreInventoryPermissionRulesParam
        {
            /// <summary>
            /// Stores the buy store item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.BuyStoreItem, isOptional = true)]
            public PermissionRulesParam? buyStoreItem;

            /// <summary>
            /// Stores the get store item information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? getStoreItemInformation;

            /// <summary>
            /// Stores the get store items with tag value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStoreItemsWithTag, isOptional = true)]
            public PermissionRulesParam? getStoreItemsWithTag;

            /// <summary>
            /// Stores the create store item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CreateStoreItem, isOptional = true)]
            public PermissionRulesParam? createStoreItem;

            /// <summary>
            /// Stores the set remove status value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetRemoveStatus, isOptional = true)]
            public PermissionRulesParam? setRemoveStatus;

            /// <summary>
            /// Stores the set store item information value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.SetStoreItemInformation, isOptional = true)]
            public PermissionRulesParam? setStoreItemInformation;

            /// <summary>
            /// Stores the validate apple app store receipt value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ValidateAppleAppStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateAppleAppStoreReceipt;

            /// <summary>
            /// Stores the validate google play store receipt value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ValidateGooglePlayStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateGooglePlayStoreReceipt;

            /// <summary>
            /// Stores the validate facebook store receipt value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ValidateFacebookStoreReceipt, isOptional = true)]
            public PermissionRulesParam? validateFacebookStoreReceipt;

            /// <summary>
            /// Stores the get create leaderboard value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetCreateLeaderboard, isOptional = true)]
            public PermissionRulesParam? getCreateLeaderboard;

            /// <summary>
            /// Stores the present store item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PresentStoreItem, isOptional = true)]
            public PermissionRulesParam? presentStoreItem;

            /// <summary>
            /// Stores the get store log value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStoreLog, isOptional = true)]
            public PermissionRulesParam? getStoreLog;

            /// <summary>
            /// Stores the get store used value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GetStoreUsed, isOptional = true)]
            public PermissionRulesParam? getStoreUsed;

            /// <summary>
            /// Stores the remove store used value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.RemoveStoreUsed, isOptional = true)]
            public PermissionRulesParam? removeStoreUsed;

        }

        /// <summary>
        /// Represents the tag settings param component.
        /// </summary>
        public class TagSettingsParam
        {
            /// <summary>
            /// Stores the key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Key, minLength = 2, maxLength = 32)]
            public string key;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the index value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Index)]
            public bool index;

        }

        /// <summary>
        /// Represents the thirt party apple settings param component.
        /// </summary>
        public class ThirtPartyAppleSettingsParam
        {
            /// <summary>
            /// Stores the apple client ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AppleClientId)]
            public string appleClientId;

            /// <summary>
            /// Stores the sandbox enable value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.SandboxEnable)]
            public bool sandboxEnable;

        }

        /// <summary>
        /// Represents the thirt party facebook settings param component.
        /// </summary>
        public class ThirtPartyFacebookSettingsParam
        {
            /// <summary>
            /// Stores the facebook app ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookAppId)]
            public string facebookAppId;

            /// <summary>
            /// Stores the facebook app token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookAppToken)]
            public string facebookAppToken;

            /// <summary>
            /// Stores the facebook inapp secret value.
            /// </summary>
            [StringDataMember(code = ParameterCode.FacebookInappSecret)]
            public string facebookInappSecret;

        }

        /// <summary>
        /// Represents the thirt party google settings param component.
        /// </summary>
        public class ThirtPartyGoogleSettingsParam
        {
            /// <summary>
            /// Stores the google client ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GoogleClientId)]
            public string googleClientId;

            /// <summary>
            /// Stores the package ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PackageId)]
            public string packageId;

            /// <summary>
            /// Stores the public RSA key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PublicRSAKey)]
            public string publicRSAKey;

        }

        /// <summary>
        /// Represents the thirt party game center settings param component.
        /// </summary>
        public class ThirtPartyGameCenterSettingsParam
        {
            /// <summary>
            /// Stores the package ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PackageId)]
            public string packageId;

        }

        /// <summary>
        /// Represents the thirt party google play game settings param component.
        /// </summary>
        public class ThirtPartyGooglePlayGameSettingsParam
        {
            /// <summary>
            /// Stores the redirect URI value.
            /// </summary>
            [StringDataMember(code = ParameterCode.RedirectUri)]
            public string redirectUri;

            /// <summary>
            /// Stores the client ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClientId)]
            public string clientId;

            /// <summary>
            /// Stores the client secret value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ClientSecret)]
            public string clientSecret;

            /// <summary>
            /// Stores the application ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ApplicationId)]
            public string applicationId;

        }

        /// <summary>
        /// Represents the thirt party param component.
        /// </summary>
        public class ThirtPartyParam
        {
            /// <summary>
            /// Stores the google settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GoogleSettings, isOptional = true)]
            public ThirtPartyGoogleSettingsParam? googleSettings;

            /// <summary>
            /// Stores the facebook settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.FacebookSettings, isOptional = true)]
            public ThirtPartyFacebookSettingsParam? facebookSettings;

            /// <summary>
            /// Stores the apple settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AppleSettings, isOptional = true)]
            public ThirtPartyAppleSettingsParam? appleSettings;

            /// <summary>
            /// Stores the google play game settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GooglePlayGameSettings, isOptional = true)]
            public ThirtPartyGooglePlayGameSettingsParam? googlePlayGameSettings;

            /// <summary>
            /// Stores the game center settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GameCenterSettings, isOptional = true)]
            public ThirtPartyGameCenterSettingsParam? gameCenterSettings;

        }

    }

    /// <summary>
    /// Defines payload models for dashboard operations.
    /// </summary>
    public partial class DashboardModels
    {
        /// <summary>
        /// Represents the response payload for the admin account operation.
        /// </summary>
        public class AdminAccountResponseData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username)]
            public string username;

            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

        }

        /// <summary>
        /// Represents the response payload for the get admin account list operation.
        /// </summary>
        public class GetAdminAccountListResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(AdminAccountResponseData))]
            public List<AdminAccountResponseData> results;
        }

        /// <summary>
        /// Represents the size param component.
        /// </summary>
        public class SizeParam
        {
            /// <summary>
            /// Stores the min value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Min, minValue = 1, mustInt = true)]
            public int min;

            /// <summary>
            /// Stores the max value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Max, minValue = 1, mustInt = true)]
            public int max;

        }

        /// <summary>
        /// Represents the team param component.
        /// </summary>
        public class TeamParam
        {
            /// <summary>
            /// Stores the team ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TeamId, minLength = 1, maxLength = 32)]
            public string teamId;

            /// <summary>
            /// Stores the team size value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.TeamSize)]
            public SizeParam teamSize;

        }

        /// <summary>
        /// Represents the linear expansions param component.
        /// </summary>
        public class LinearExpansionsParam
        {
            /// <summary>
            /// Stores the seconds between expansions value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            /// <summary>
            /// Stores the delta value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Delta, isOptional = true)]
            public int? delta;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the custom expansions param component.
        /// </summary>
        public class CustomExpansionsParam
        {
            /// <summary>
            /// Stores the seconds between expansions value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.SecondsBetweenExpansions, minValue = 1)]
            public int secondsBetweenExpansions;

            /// <summary>
            /// Stores the override value value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.OverrideValue, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideValue;

            /// <summary>
            /// Stores the override min value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.OverrideMin, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMin;

            /// <summary>
            /// Stores the override max value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.OverrideMax, isOptional = true, elementCls = typeof(object))]
            public List<object>? overrideMax;

        }

        /// <summary>
        /// Represents the advanced settings param component.
        /// </summary>
        public class AdvancedSettingsParam
        {
            /// <summary>
            /// Stores the seconds until optional value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.SecondsUntilOptional, minValue = 1)]
            public int secondsUntilOptional;

            /// <summary>
            /// Stores the expansion type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.ExpansionType, minValue = 1, maxValue = 3, isOptional = true, mustInt = true)]
            public int? expansionType;

            /// <summary>
            /// Stores the linear expansions value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LinearExpansions, isOptional = true)]
            public LinearExpansionsParam? linearExpansions;

            /// <summary>
            /// Stores the custom expansions value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.CustomExpansions, isOptional = true)]
            public CustomExpansionsParam? customExpansions;

        }

        /// <summary>
        /// Represents the rule param component.
        /// </summary>
        public class RuleParam
        {
            /// <summary>
            /// Stores the name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Name, minLength = 1, maxLength = 32)]
            public string name;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 8, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the attribute source value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AttributeSource, minValue = 1, maxValue = 2, isOptional = true)]
            public int? attributeSource;

            /// <summary>
            /// Stores the attribute path value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AttributePath, minLength = 1, maxLength = 32, isOptional = true)]
            public string? attributePath;

            /// <summary>
            /// Stores the default value value.
            /// </summary>
            [DataMember(code = ParameterCode.DefaultValue, isOptional = true)]
            public object? defaultValue;

            /// <summary>
            /// Stores the compair type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CompairType, minValue = 1, maxValue = 2, isOptional = true, mustInt = true)]
            public int? compairType;

            /// <summary>
            /// Indicates whether allowed difference.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AllowedDifference, minValue = 0, isOptional = true)]
            public int? allowedDifference;

            /// <summary>
            /// Stores the min value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Min, isOptional = true)]
            public int? min;

            /// <summary>
            /// Stores the max value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Max, isOptional = true)]
            public int? max;

            /// <summary>
            /// Stores the advanced settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AdvancedSettings, isOptional = true)]
            public AdvancedSettingsParam? advancedSettings;

        }

        /// <summary>
        /// Represents the server allocation param component.
        /// </summary>
        public class ServerAllocationParam
        {
            /// <summary>
            /// Indicates whether enable.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Enable)]
            public bool enable;

        }

        /// <summary>
        /// Represents the matchmaking queue settings param component.
        /// </summary>
        public class MatchmakingQueueSettingsParam
        {
            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            /// <summary>
            /// Stores the match size value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MatchSize)]
            public SizeParam matchSize;

            /// <summary>
            /// Stores the ticket size value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.TicketSize)]
            public SizeParam ticketSize;

            /// <summary>
            /// Stores the server allocation value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ServerAllocation)]
            public ServerAllocationParam serverAllocation;

            /// <summary>
            /// Stores the teams value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Teams, isOptional = true, elementCls = typeof(TeamParam))]
            public List<TeamParam>? teams;

            /// <summary>
            /// Stores the rules value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Rules, isOptional = true, elementCls = typeof(RuleParam))]
            public List<RuleParam>? rules;

            /// <summary>
            /// Stores the remove value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Remove, isOptional = true)]
            public bool? remove;
        }

        /// <summary>
        /// Represents the response payload for the get game information operation.
        /// </summary>
        public class GetGameInformationResponseData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the creator ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CreatorId)]
            public string creatorId;

            /// <summary>
            /// Stores the game description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameDescription)]
            public string gameDescription;

            /// <summary>
            /// Stores the game icon URL value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameIconUrl)]
            public string gameIconUrl;

            /// <summary>
            /// Stores the game settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.GameSettings)]
            public GameSettingsParam gameSettings;

            /// <summary>
            /// Stores the matchmaking queue settings value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.MatchmakingQueueSettings, elementCls = typeof(MatchmakingQueueSettingsParam))]
            public List<MatchmakingQueueSettingsParam> matchmakingQueueSettings;

        }

        /// <summary>
        /// Represents the response payload for the game with game ID operation.
        /// </summary>
        public class GameWithGameIdResponseData
        {
            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

        }

        /// <summary>
        /// Represents the response payload for the get game list operation.
        /// </summary>
        public class GetGameListResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(GameWithGameIdResponseData))]
            public List<GameWithGameIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the get master game settings operation.
        /// </summary>
        public class GetMasterGameSettingsResponseData
        {
            /// <summary>
            /// Stores the thirt party settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ThirtPartySettings)]
            public ThirtPartyParam thirtPartySettings;

            /// <summary>
            /// Stores the master player settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MasterPlayerSettings)]
            public MasterPlayerSettingsParam masterPlayerSettings;

            /// <summary>
            /// Stores the email settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.EmailSettings)]
            public EmailSettingsParam emailSettings;

            /// <summary>
            /// Stores the push notification settings value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PushNotificationSettings)]
            public PushNotificationSettingsParam pushNotificationSettings;

        }

        /// <summary>
        /// Represents the response payload for the get secret info information operation.
        /// </summary>
        public class GetSecretInfoInformationResponseData
        {
            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

            /// <summary>
            /// Stores the game ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.GameId)]
            public string gameId;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the creator ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CreatorId)]
            public string creatorId;

            /// <summary>
            /// Stores the remove value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Remove)]
            public bool remove;

            /// <summary>
            /// Stores the timestamp expire value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsExpire)]
            public long tsExpire;

            /// <summary>
            /// Stores the description value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Description)]
            public string description;

            /// <summary>
            /// Stores the permission param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PermissionParam)]
            public PermissionParam permissionParam;

        }

        /// <summary>
        /// Represents the response payload for the secret info with secret key operation.
        /// </summary>
        public class SecretInfoWithSecretKeyResponseData
        {
            /// <summary>
            /// Stores the secret key value.
            /// </summary>
            [StringDataMember(code = ParameterCode.SecretKey)]
            public string secretKey;

        }

        /// <summary>
        /// Represents the response payload for the get secret info list operation.
        /// </summary>
        public class GetSecretInfoListResponseData
        {
            /// <summary>
            /// Stores the secret key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.SecretKeys, elementCls = typeof(SecretInfoWithSecretKeyResponseData))]
            public List<SecretInfoWithSecretKeyResponseData> secretKeys;

        }

        /// <summary>
        /// Represents the response payload for the admin account with user ID operation.
        /// </summary>
        public class AdminAccountWithUserIdResponseData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId)]
            public string userId;

        }

        /// <summary>
        /// Represents the response payload for the create admin account operation.
        /// </summary>
        public class CreateAdminAccountResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(AdminAccountWithUserIdResponseData))]
            public List<AdminAccountWithUserIdResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the login by admin account operation.
        /// </summary>
        public class LoginByAdminAccountResponseData
        {
            /// <summary>
            /// Stores the auth token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AuthToken)]
            public string authToken;

        }

        /// <summary>
        /// Represents the response payload for the get server log operation.
        /// </summary>
        public class GetServerLogResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(string))]
            public List<string> results;

        }

        /// <summary>
        /// Represents the response payload for the get username admin account operation.
        /// </summary>
        public class GetUsernameAdminAccountResponseData
        {
            /// <summary>
            /// Indicates whether username.
            /// </summary>
            [StringDataMember(code = ParameterCode.Username)]
            public string username;

        }

        /// <summary>
        /// Represents the response payload for the analytics item operation.
        /// </summary>
        public class AnalyticsItemResponseData
        {
            /// <summary>
            /// Stores the ccu value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CCU)]
            public int ccu;

            /// <summary>
            /// Stores the dau value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DAU)]
            public int dau;

            /// <summary>
            /// Stores the dau since 0 h value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DAUSince0h)]
            public int dauSince0h;

            /// <summary>
            /// Stores the dnu value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DNU)]
            public int dnu;

            /// <summary>
            /// Stores the dnu since 0 h value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DNUSince0h)]
            public int dnuSince0h;

            /// <summary>
            /// Stores the drt value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DRT)]
            public int drt;

            /// <summary>
            /// Stores the drt since 0 h value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DRTSince0h)]
            public int drtSince0h;

            /// <summary>
            /// Stores the mau value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MAU)]
            public int mau;

            /// <summary>
            /// Stores the mau since 0 h 1 value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MAUSince0h1)]
            public int mauSince0h1;

            /// <summary>
            /// Stores the mnu value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MNU)]
            public int mnu;

            /// <summary>
            /// Stores the mnu since 0 h 1 value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MNUSince0h1)]
            public int mnuSince0h1;

            /// <summary>
            /// Stores the mrt value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MRT)]
            public int mrt;

            /// <summary>
            /// Stores the mrt since 0 h 1 value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MRTSince0h1)]
            public int mrtSince0h1;

            /// <summary>
            /// Stores the analytics price value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AnalyticsPrice)]
            public double analyticsPrice;

        }

        /// <summary>
        /// Represents the response payload for the memory usage operation.
        /// </summary>
        public class MemoryUsageResponseData
        {
            /// <summary>
            /// Stores the free memory in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FreeMemoryInBytes)]
            public double freeMemoryInBytes;

            /// <summary>
            /// Stores the total memory in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TotalMemoryInBytes)]
            public double totalMemoryInBytes;

        }

        /// <summary>
        /// Represents the response payload for the storage usage operation.
        /// </summary>
        public class StorageUsageResponseData
        {
            /// <summary>
            /// Stores the name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Name)]
            public string name;

            /// <summary>
            /// Stores the fs total size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            /// <summary>
            /// Stores the fs used size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

        }

        /// <summary>
        /// Represents the response payload for the database system operation.
        /// </summary>
        public class DatabaseSystemResponseData
        {
            /// <summary>
            /// Stores the fs total size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FsTotalSizeInBytes)]
            public double fsTotalSizeInBytes;

            /// <summary>
            /// Stores the fs used size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.FsUsedSizeInBytes)]
            public double fsUsedSizeInBytes;

            /// <summary>
            /// Stores the total size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TotalSizeInBytes)]
            public double totalSizeInBytes;

            /// <summary>
            /// Stores the collections value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Collections)]
            public int collections;

            /// <summary>
            /// Stores the objects value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Objects)]
            public int objects;

            /// <summary>
            /// Stores the indexes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Indexes)]
            public int indexes;

        }

        /// <summary>
        /// Represents the response payload for the cost operation.
        /// </summary>
        public class CostResponseData
        {
            /// <summary>
            /// Stores the request count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.RequestCount)]
            public int requestCount;

            /// <summary>
            /// Stores the matchmaking request count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MatchmakingRequestCount)]
            public int matchmakingRequestCount;

            /// <summary>
            /// Stores the cloud script G bs value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CloudScriptGBs)]
            public double cloudScriptGBs;

            /// <summary>
            /// Stores the storage size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StorageSizeInBytes)]
            public double storageSizeInBytes;

            /// <summary>
            /// Stores the data transfer size in bytes value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.DataTransferSizeInBytes)]
            public long dataTransferSizeInBytes;

        }

        /// <summary>
        /// Represents the response payload for the operation system operation.
        /// </summary>
        public class OperationSystemResponseData
        {
            /// <summary>
            /// Stores the cpu usage value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CpuUsage)]
            public double cpuUsage;

            /// <summary>
            /// Stores the memory usage value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MemoryUsage)]
            public MemoryUsageResponseData memoryUsage;

            /// <summary>
            /// Stores the storage usage value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.StorageUsage, elementCls = typeof(StorageUsageResponseData))]
            public List<StorageUsageResponseData>? storageUsage;

        }

        /// <summary>
        /// Represents the response payload for the request complete error code operation.
        /// </summary>
        public class RequestCompleteErrorCodeResponseData
        {
            /// <summary>
            /// Stores the error code value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.ErrorCode)]
            public int errorCode;

            /// <summary>
            /// Stores the count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Count)]
            public int count;

        }

        /// <summary>
        /// Represents the response payload for the request complete operation.
        /// </summary>
        public class RequestCompleteResponseData
        {
            /// <summary>
            /// Stores the event name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EventName)]
            public string eventName;

            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(RequestCompleteErrorCodeResponseData))]
            public List<RequestCompleteErrorCodeResponseData>? results;

        }

        /// <summary>
        /// Represents the response payload for the get analytics operation.
        /// </summary>
        public class GetAnalyticsResponseData
        {
            /// <summary>
            /// Stores the analytics item value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.AnalyticsItem, isOptional = true)]
            public AnalyticsItemResponseData? analyticsItem;

            /// <summary>
            /// Stores the country value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            /// <summary>
            /// Stores the operation system value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.OperationSystem, isOptional = true)]
            public OperationSystemResponseData? operationSystem;

            /// <summary>
            /// Stores the request complete value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.RequestComplete, elementCls = typeof(RequestCompleteResponseData), isOptional = true)]
            public List<RequestCompleteResponseData>? requestComplete;

            /// <summary>
            /// Stores the database system value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.DatabaseSystem, isOptional = true)]
            public DatabaseSystemResponseData? databaseSystem;

            /// <summary>
            /// Stores the log database system value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.LogDatabaseSystem, isOptional = true)]
            public DatabaseSystemResponseData? logDatabaseSystem;

            /// <summary>
            /// Stores the cost value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Cost, isOptional = true)]
            public CostResponseData? cost;

            /// <summary>
            /// Stores the monthly cost value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MonthlyCost, isOptional = true)]
            public CostResponseData? monthlyCost;

        }

        /// <summary>
        /// Represents the response payload for the child script operation.
        /// </summary>
        public class ChildScriptResponseData
        {
            /// <summary>
            /// Stores the event name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EventName)]
            public string eventName;

            /// <summary>
            /// Stores the script value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Script)]
            public string script;

            /// <summary>
            /// Indicates whether has edit.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.HasEdit)]
            public bool hasEdit;

        }

        /// <summary>
        /// Represents the response payload for the event callback cloud script operation.
        /// </summary>
        public class EventCallbackCloudScriptResponseData
        {
            /// <summary>
            /// Stores the type value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Type)]
            public string type;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            /// <summary>
            /// Stores the child scripts value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.ChildScripts, elementCls = typeof(ChildScriptResponseData))]
            public List<ChildScriptResponseData> childScripts;

        }

        /// <summary>
        /// Represents the response payload for the get event callback cloud script operation.
        /// </summary>
        public class GetEventCallbackCloudScriptResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(EventCallbackCloudScriptResponseData))]
            public List<EventCallbackCloudScriptResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the set event callback cloud script operation.
        /// </summary>
        public class SetEventCallbackCloudScriptResponseData
        {
            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage)]
            public string errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the backup statistics leaderboard version operation.
        /// </summary>
        public class BackupStatisticsLeaderboardVersionResponseData
        {
            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version)]
            public string version;

            /// <summary>
            /// Stores the log value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Log)]
            public string log;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

        }

        /// <summary>
        /// Represents the response payload for the get backup statistics leaderboard version operation.
        /// </summary>
        public class GetBackupStatisticsLeaderboardVersionResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(BackupStatisticsLeaderboardVersionResponseData))]
            public List<BackupStatisticsLeaderboardVersionResponseData> results;

        }

        /// <summary>
        /// Represents the response payload for the country region operation.
        /// </summary>
        public class CountryRegionResponseData
        {
            /// <summary>
            /// Stores the region code value.
            /// </summary>
            [StringDataMember(code = ParameterCode.RegionCode)]
            public string regionCode;

            /// <summary>
            /// Stores the region name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.RegionName)]
            public string regionName;

            /// <summary>
            /// Stores the ccu value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CCU)]
            public int ccu;

            /// <summary>
            /// Stores the latitude value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Latitude, isOptional = true, defaultValue = 0)]
            public double? latitude;

            /// <summary>
            /// Stores the longitude value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Longitude, isOptional = true, defaultValue = 0)]
            public double? longitude;

        }

        /// <summary>
        /// Represents the response payload for the country operation.
        /// </summary>
        public class CountryResponseData
        {
            /// <summary>
            /// Stores the country code value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CountryCode)]
            public string countryCode;

            /// <summary>
            /// Stores the regions value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Regions, elementCls = typeof(CountryRegionResponseData))]
            public List<CountryRegionResponseData> regions;

        }

        /// <summary>
        /// Represents the response payload for the get server game data operation.
        /// </summary>
        public class GetServerGameDataResponseData
        {
            /// <summary>
            /// Stores the master player count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.MasterPlayerCount, isOptional = true)]
            public int? masterPlayerCount;

            /// <summary>
            /// Stores the game player count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.GamePlayerCount, isOptional = true)]
            public int? gamePlayerCount;

            /// <summary>
            /// Stores the character player count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.CharacterPlayerCount, isOptional = true)]
            public int? characterPlayerCount;

            /// <summary>
            /// Stores the inventory count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.InventoryCount, isOptional = true)]
            public int? inventoryCount;

            /// <summary>
            /// Stores the store inventory count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.StoreInventoryCount, isOptional = true)]
            public int? storeInventoryCount;

            /// <summary>
            /// Stores the group count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.GroupCount, isOptional = true)]
            public int? groupCount;

            /// <summary>
            /// Stores the country value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Country, elementCls = typeof(CountryResponseData), isOptional = true)]
            public List<CountryResponseData>? country;

            /// <summary>
            /// Stores the version value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Version, isOptional = true)]
            public string? version;

        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}