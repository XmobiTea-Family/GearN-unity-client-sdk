namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    public partial class AuthenticateModels
    {
        public class LoginByAccountRequestData
        {
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByAndroidDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string androidDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByAppleRequestData
        {
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByCustomDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByCustomIdRequestData
        {
            [StringDataMember(code = ParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string customId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByEditorDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string editorDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByFacebookRequestData
        {
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByGenericServiceRequestData
        {
            [StringDataMember(code = ParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string serviceName;

            [GNHashtableDataMember(code = ParameterCode.ServiceData, mustNonNull = true)]
            public GNHashtable serviceData;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByGoogleRequestData
        {
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [NumberDataMember(code = ParameterCode.Type, minValue = 1, maxValue = 2, mustInt = true)]
            public int type;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByGooglePlayGameServiceRequestData
        {
            [StringDataMember(code = ParameterCode.Token, minLength = 32, maxLength = 2048, mustNonNull = true)]
            public string token;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByGameCenterRequestData
        {
            [StringDataMember(code = ParameterCode.PlayerId, minLength = 2, maxLength = 64, mustNonNull = true)]
            public string playerId;

            [StringDataMember(code = ParameterCode.Name, minLength = 2, maxLength = 128, mustNonNull = true)]
            public string name;

            [StringDataMember(code = ParameterCode.PublicKeyUrl, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string publicKeyUrl;

            [StringDataMember(code = ParameterCode.Signature, minLength = 2, maxLength = 2048, mustNonNull = true)]
            public string signature;

            [StringDataMember(code = ParameterCode.Salt, minLength = 2, maxLength = 256, mustNonNull = true)]
            public string salt;

            [NumberDataMember(code = ParameterCode.Timestamp)]
            public long timestamp;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByiOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string iOSDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByLinuxDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string linuxDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByMacOSDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string macOSDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByWindowsDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class LoginByWindowsPhoneDeviceIdRequestData
        {
            [StringDataMember(code = ParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string windowsPhoneDeviceId;

            [BooleanDataMember(code = ParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
            public bool? createPlayerIfNotExists;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class RegisterAccountRequestData
        {
            [StringDataMember(code = ParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
            public string username;

            [StringDataMember(code = ParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
            public string password;

            [GNHashtableDataMember(code = ParameterCode.InfoRequestParam, mustNonNull = true)]
            public InfoRequestParam infoRequestParam;

        }

        public class RefreshAuthTokenRequestData
        {

        }

    }

    public partial class AuthenticateModels
    {
        public class InfoRequestParam
        {
            [BooleanDataMember(code = ParameterCode.External, isOptional = true, defaultValue = false)]
            public bool? external;

            [BooleanDataMember(code = ParameterCode.Segments, isOptional = true, defaultValue = false)]
            public bool? segments;

            [BooleanDataMember(code = ParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
            public bool? customDatas;

            [BooleanDataMember(code = ParameterCode.DisplayName, isOptional = true, defaultValue = false)]
            public bool? displayName;

            [BooleanDataMember(code = ParameterCode.Avatar, isOptional = true, defaultValue = false)]
            public bool? avatar;

            [BooleanDataMember(code = ParameterCode.TsCreate, isOptional = true, defaultValue = false)]
            public bool? tsCreate;

            [BooleanDataMember(code = ParameterCode.Tags, isOptional = true, defaultValue = false)]
            public bool? tags;

            [BooleanDataMember(code = ParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
            public bool? playerBan;

            [BooleanDataMember(code = ParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
            public bool? playerCurrencies;

            [BooleanDataMember(code = ParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
            public bool? playerStatistics;

            [BooleanDataMember(code = ParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
            public bool? playerDatas;

            [BooleanDataMember(code = ParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
            public bool? ipAddressCreate;

            [BooleanDataMember(code = ParameterCode.CountryCode, isOptional = true, defaultValue = false)]
            public bool? countryCode;

            [BooleanDataMember(code = ParameterCode.Email, isOptional = true, defaultValue = false)]
            public bool? email;

            [BooleanDataMember(code = ParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
            public bool? tsLastLogin;

            [BooleanDataMember(code = ParameterCode.PushNotifications, isOptional = true, defaultValue = false)]
            public bool? pushNotifications;

            [GNArrayDataMember(code = ParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerDataKeys;

            [GNArrayDataMember(code = ParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerCurrencyKeys;

            [GNArrayDataMember(code = ParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? playerStatisticsKeys;

            [GNArrayDataMember(code = ParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? customDataKeys;

            [GNArrayDataMember(code = ParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
            public List<string>? tagKeys;

        }

    }

    public partial class AuthenticateModels
    {
        public class AuthenticateResponseData : MasterPlayerModels.MasterPlayerWithUserIdResponseData
        {
            [BooleanDataMember(code = ParameterCode.NewlyCreated, isOptional = true)]
            public bool? newlyCreated;

            [StringDataMember(code = ParameterCode.AuthToken, isOptional = true)]
            public string? authToken;

            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;
        }

        public class GenericServiceAuthenticateResponseData : AuthenticateResponseData
        {
            [StringDataMember(code = ParameterCode.ErrorMessage, isOptional = true)]
            public string? errorMessage;

        }

        public class RefreshAuthTokenResponseData
        {
            [StringDataMember(code = ParameterCode.AuthToken, isOptional = true)]
            public string? authToken;

            [GNHashtableDataMember(code = ParameterCode.PlayerBan, isOptional = true)]
            public GenericModels.BanItem? playerBan;
        }


        public class EmptyResponseData
        {

        }

    }

}
