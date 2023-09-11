namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Constant;

	public partial class AuthenticateModels
	{
		public class LoginByAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string username;

			[StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string password;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByAndroidDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.AndroidDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string androidDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByAppleRequestData
		{
			[StringDataMember(code = GNParameterCode.Token, minLength = 32, maxLength = 512, mustNonNull = true)]
			public string token;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByCustomDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.CustomDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByCustomIdRequestData
		{
			[StringDataMember(code = GNParameterCode.CustomId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string customId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByEditorDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.EditorDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string editorDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByFacebookRequestData
		{
			[StringDataMember(code = GNParameterCode.Token, minLength = 32, maxLength = 512, mustNonNull = true)]
			public string token;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByGenericServiceRequestData
		{
			[StringDataMember(code = GNParameterCode.ServiceName, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string serviceName;

			[StringDataMember(code = GNParameterCode.ServiceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string serviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByGoogleRequestData
		{
			[StringDataMember(code = GNParameterCode.Token, minLength = 32, maxLength = 512, mustNonNull = true)]
			public string token;

			[NumberDataMember(code = GNParameterCode.Type, minValue = 1, maxValue = 2, mustInt = true)]
			public long type;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByiOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.iOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string iOSDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByLinuxDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.LinuxDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string linuxDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByMacOSDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.MacOSDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string macOSDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByWindowsDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.WindowsDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class LoginByWindowsPhoneDeviceIdRequestData
		{
			[StringDataMember(code = GNParameterCode.WindowsPhoneDeviceId, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string windowsPhoneDeviceId;

			[BooleanDataMember(code = GNParameterCode.CreatePlayerIfNotExists, isOptional = true, defaultValue = false)]
			public bool? createPlayerIfNotExists;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

		public class RegisterAccountRequestData
		{
			[StringDataMember(code = GNParameterCode.Username, minLength = 6, maxLength = 32, mustNonNull = true)]
			public string username;

			[StringDataMember(code = GNParameterCode.Password, minLength = 6, maxLength = 64, mustNonNull = true)]
			public string password;

			[GNHashtableDataMember(code = GNParameterCode.InfoRequestParam, mustNonNull = true)]
			public InfoRequestParam infoRequestParam;

		}

	}

	public partial class AuthenticateModels
	{
		public class InfoRequestParam
		{
			[BooleanDataMember(code = GNParameterCode.External, isOptional = true, defaultValue = false)]
			public bool? external;

			[BooleanDataMember(code = GNParameterCode.Segments, isOptional = true, defaultValue = false)]
			public bool? segments;

			[BooleanDataMember(code = GNParameterCode.CustomDatas, isOptional = true, defaultValue = false)]
			public bool? customDatas;

			[BooleanDataMember(code = GNParameterCode.DisplayName, isOptional = true, defaultValue = false)]
			public bool? displayName;

			[BooleanDataMember(code = GNParameterCode.Avatar, isOptional = true, defaultValue = false)]
			public bool? avatar;

			[BooleanDataMember(code = GNParameterCode.TsCreate, isOptional = true, defaultValue = false)]
			public bool? tsCreate;

			[BooleanDataMember(code = GNParameterCode.Tags, isOptional = true, defaultValue = false)]
			public bool? tags;

			[BooleanDataMember(code = GNParameterCode.PlayerBan, isOptional = true, defaultValue = false)]
			public bool? playerBan;

			[BooleanDataMember(code = GNParameterCode.PlayerCurrencies, isOptional = true, defaultValue = false)]
			public bool? playerCurrencies;

			[BooleanDataMember(code = GNParameterCode.PlayerStatistics, isOptional = true, defaultValue = false)]
			public bool? playerStatistics;

			[BooleanDataMember(code = GNParameterCode.PlayerDatas, isOptional = true, defaultValue = false)]
			public bool? playerDatas;

			[BooleanDataMember(code = GNParameterCode.IpAddressCreate, isOptional = true, defaultValue = false)]
			public bool? ipAddressCreate;

			[BooleanDataMember(code = GNParameterCode.CountryCode, isOptional = true, defaultValue = false)]
			public bool? countryCode;

			[BooleanDataMember(code = GNParameterCode.Email, isOptional = true, defaultValue = false)]
			public bool? email;

			[BooleanDataMember(code = GNParameterCode.TsLastLogin, isOptional = true, defaultValue = false)]
			public bool? tsLastLogin;

			[GNArrayDataMember(code = GNParameterCode.PlayerDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerDataKeys;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencyKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerCurrencyKeys;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? playerStatisticsKeys;

			[GNArrayDataMember(code = GNParameterCode.CustomDataKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? customDataKeys;

			[GNArrayDataMember(code = GNParameterCode.TagKeys, isOptional = true, elementCls = typeof(string))]
			public List<string>? tagKeys;

		}

	}

	public partial class AuthenticateModels
	{
		public class AuthenticateResponseData : MasterPlayerModels.MasterPlayerWithUserIdResponseData
        {
			[BooleanDataMember(code = GNParameterCode.NewlyCreated, isOptional = true)]
			public bool? newlyCreated;

		}

        public class EmptyResponseData
        {

        }

	}

}
