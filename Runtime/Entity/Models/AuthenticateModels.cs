namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for authenticate operations.
    /// </summary>
    public partial class AuthenticateModels
    {
        /// <summary>
        /// Represents the request payload for the login by account operation.
        /// </summary>
        public class LoginByAccountRequestData
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
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by android device ID operation.
        /// </summary>
        public class LoginByAndroidDeviceIdRequestData
        {
            /// <summary>
            /// Stores the android device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by apple operation.
        /// </summary>
        public class LoginByAppleRequestData
        {
            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by custom device ID operation.
        /// </summary>
        public class LoginByCustomDeviceIdRequestData
        {
            /// <summary>
            /// Stores the custom device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by custom ID operation.
        /// </summary>
        public class LoginByCustomIdRequestData
        {
            /// <summary>
            /// Stores the custom ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by editor device ID operation.
        /// </summary>
        public class LoginByEditorDeviceIdRequestData
        {
            /// <summary>
            /// Stores the editor device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by facebook operation.
        /// </summary>
        public class LoginByFacebookRequestData
        {
            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by generic service operation.
        /// </summary>
        public class LoginByGenericServiceRequestData
        {
            /// <summary>
            /// Stores the service name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            /// <summary>
            /// Stores the service data value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.ServiceData, mustNonNull = true)]
            public GNHashtable serviceData;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by google operation.
        /// </summary>
        public class LoginByGoogleRequestData
        {
            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the type value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 2, mustInt = true)]
            public int type;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by google play game service operation.
        /// </summary>
        public class LoginByGooglePlayGameServiceRequestData
        {
            /// <summary>
            /// Stores the token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by game center operation.
        /// </summary>
        public class LoginByGameCenterRequestData
        {
            /// <summary>
            /// Stores the player ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PlayerId, minLength = 2, maxLength = 64, mustNonNull = true)]
            public string playerId;

            /// <summary>
            /// Stores the name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Name, minLength = 2, maxLength = 128, mustNonNull = true)]
            public string name;

            /// <summary>
            /// Stores the public key URL value.
            /// </summary>
            [StringDataMember(code = ParameterCode.PublicKeyUrl, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string publicKeyUrl;

            /// <summary>
            /// Stores the signature value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Signature, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string signature;

            /// <summary>
            /// Stores the salt value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Salt, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string salt;

            /// <summary>
            /// Stores the timestamp value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Timestamp)]
            public long timestamp;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by iOS device ID operation.
        /// </summary>
        public class LoginByiOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the iOS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by linux device ID operation.
        /// </summary>
        public class LoginByLinuxDeviceIdRequestData
        {
            /// <summary>
            /// Stores the linux device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by macos device ID operation.
        /// </summary>
        public class LoginByMacOSDeviceIdRequestData
        {
            /// <summary>
            /// Stores the mac OS device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by windows device ID operation.
        /// </summary>
        public class LoginByWindowsDeviceIdRequestData
        {
            /// <summary>
            /// Stores the windows device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the login by windows phone device ID operation.
        /// </summary>
        public class LoginByWindowsPhoneDeviceIdRequestData
        {
            /// <summary>
            /// Stores the windows phone device ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

            /// <summary>
            /// Stores the create player if not exists value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            /// <summary>
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the register account operation.
        /// </summary>
        public class RegisterAccountRequestData
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
            /// Stores the info request param value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        /// <summary>
        /// Represents the request payload for the refresh auth token operation.
        /// </summary>
        public class RefreshAuthTokenRequestData
        {

        }

    }

    /// <summary>
    /// Defines payload models for authenticate operations.
    /// </summary>
    public partial class AuthenticateModels
    {
        /// <summary>
        /// Represents the info request param component.
        /// </summary>
        public class InfoRequestParam
        {
            /// <summary>
            /// Stores the external value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.External, isOptional = true, defaultValue = false)]
            public bool? external;

            /// <summary>
            /// Stores the segments value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Segments, isOptional = true, defaultValue = false)]
            public bool? segments;

            /// <summary>
            /// Stores the custom datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
            public bool? customDatas;

            /// <summary>
            /// Stores the display name value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            /// <summary>
            /// Stores the avatar value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            /// <summary>
            /// Stores the tags value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            /// <summary>
            /// Stores the player ban value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
            public bool? playerBan;

            /// <summary>
            /// Stores the player currencies value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
            public bool? playerCurrencies;

            /// <summary>
            /// Stores the player statistics value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
            public bool? playerStatistics;

            /// <summary>
            /// Stores the player datas value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
            public bool? playerDatas;

            /// <summary>
            /// Stores the IP address create value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
            public bool? ipAddressCreate;

            /// <summary>
            /// Stores the country code value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.CountryCode, isOptional = true, defaultValue = false)]
            public bool? countryCode;

            /// <summary>
            /// Stores the email value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.Email, isOptional = true, defaultValue = false)]
            public bool? email;

            /// <summary>
            /// Stores the timestamp last login value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            /// <summary>
            /// Stores the push notifications value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.PushNotifications, isOptional = true, defaultValue = false)]
            public bool? pushNotifications;

            /// <summary>
            /// Stores the player data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

            /// <summary>
            /// Stores the player currency key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

            /// <summary>
            /// Stores the player statistics key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

            /// <summary>
            /// Stores the custom data key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            /// <summary>
            /// Stores the tag key collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

    }

    /// <summary>
    /// Defines payload models for authenticate operations.
    /// </summary>
    public partial class AuthenticateModels
    {
        /// <summary>
        /// Represents the response payload for the authenticate operation.
        /// </summary>
        public class AuthenticateResponseData : MasterPlayerModels.MasterPlayerWithUserIdResponseData
        {
            /// <summary>
            /// Stores the newly created value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.NewlyCreated, isOptional = true)]
            public bool? newlyCreated;

            /// <summary>
            /// Stores the auth token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AuthToken, isOptional = true)]
            public string? authToken;

            /// <summary>
            /// Stores the player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;
        }

        /// <summary>
        /// Represents the response payload for the generic service authenticate operation.
        /// </summary>
        public class GenericServiceAuthenticateResponseData : AuthenticateResponseData
        {
            /// <summary>
            /// Stores the error message value.
            /// </summary>
            [StringDataMember(code = ParameterCode.ErrorMessage, isOptional = true)]
            public string? errorMessage;

        }

        /// <summary>
        /// Represents the response payload for the refresh auth token operation.
        /// </summary>
        public class RefreshAuthTokenResponseData
        {
            /// <summary>
            /// Stores the auth token value.
            /// </summary>
            [StringDataMember(code = ParameterCode.AuthToken, isOptional = true)]
            public string? authToken;

            /// <summary>
            /// Stores the player ban value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;
        }


        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {

        }

    }

}