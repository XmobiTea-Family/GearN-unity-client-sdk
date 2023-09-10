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

			[StringDataMember(code = GNParameterCode.GameId, minLength = 2, maxLength = 32, mustNonNull = true)]
			public string gameId;

			[NumberDataMember(code = GNParameterCode.Role, mustInt = true)]
			public long role;

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

		}

		public class SetMasterGameSettingsRequestData
		{
			[GNHashtableDataMember(code = GNParameterCode.ThirtPartySettings, isOptional = true)]
			public ThirtPartyParam? thirtPartySettings;

			[GNHashtableDataMember(code = GNParameterCode.MasterPlayerSettings, isOptional = true)]
			public MasterPlayerSettingsParam? masterPlayerSettings;

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

			[BooleanDataMember(code = GNParameterCode.Remove)]
			public bool remove;

			[NumberDataMember(code = GNParameterCode.TsExpire)]
			public double tsExpire;

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

		}

		public class CharacterPlayerSettingsParam
		{
			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
			public List<CurrencySettingsParam>? playerCurrencySettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
			public List<StatisticsSettingsParam>? playerStatisticsSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
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
			public PermissionRulesParam? getContent;

			[GNHashtableDataMember(code = GNParameterCode.SetContentData, isOptional = true)]
			public PermissionRulesParam? setContent;

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

		}

		public class DataSettingsParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
			public string key;

			[NumberDataMember(code = GNParameterCode.Permission, mustInt = true)]
			public long permission;

		}

		public class FriendCatalogSettingsParam
		{
			[StringDataMember(code = GNParameterCode.CatalogId, minLength = 2, maxLength = 32)]
			public string catalogId;

			[BooleanDataMember(code = GNParameterCode.ForceAcceptFriend)]
			public bool forceAcceptFriend;

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

		}

		public class GamePlayerSettingsParam
		{
			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
			public List<CurrencySettingsParam>? playerCurrencySettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
			public List<StatisticsSettingsParam>? playerStatisticsSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
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

			[GNHashtableDataMember(code = GNParameterCode.sendGroupMessage, isOptional = true)]
			public PermissionRulesParam? sendGroupMessage;

			[GNHashtableDataMember(code = GNParameterCode.GetGroupMessage, isOptional = true)]
			public PermissionRulesParam? getGroupMessage;

			[GNHashtableDataMember(code = GNParameterCode.SetRemoveStatus, isOptional = true)]
			public PermissionRulesParam? setRemoveStatus;

			[GNHashtableDataMember(code = GNParameterCode.GetGroupsWithDisplayName, isOptional = true)]
			public PermissionRulesParam? getGroupsWithDisplayName;

		}

		public class GroupSettingsParam
		{
			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true)]
			public List<CurrencySettingsParam>? groupCurrencySettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
			public List<StatisticsSettingsParam>? groupStatisticsSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
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

		}

		public class InventorySettingsParam
		{
			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsSettings, elementCls = typeof(StatisticsSettingsParam), isOptional = true)]
			public List<StatisticsSettingsParam>? inventoryStatisticsSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatasSettings, elementCls = typeof(DataSettingsParam), isOptional = true)]
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
			public long itemType;

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

			[GNHashtableDataMember(code = GNParameterCode.GetExternal, isOptional = true)]
			public PermissionRulesParam? getExternal;

			[GNHashtableDataMember(code = GNParameterCode.GetPlayersWithDisplayName, isOptional = true)]
			public PermissionRulesParam? getPlayersWithDisplayName;

			[GNHashtableDataMember(code = GNParameterCode.GetEmail, isOptional = true)]
			public PermissionRulesParam? getEmail;

			[GNHashtableDataMember(code = GNParameterCode.SetEmail, isOptional = true)]
			public PermissionRulesParam? setEmail;

		}

		public class MasterPlayerSettingsParam
		{
			[GNArrayDataMember(code = GNParameterCode.GenericServiceSettings, elementCls = typeof(GenericServiceSettingsParam), isOptional = true )]
			public List<GenericServiceSettingsParam>? genericServiceSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerCurrencySettings, elementCls = typeof(CurrencySettingsParam), isOptional = true )]
			public List<CurrencySettingsParam>? playerCurrencySettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerStatisticsSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true )]
			public List<StatisticsSettingsParam>? playerStatisticsSettings;

			[GNArrayDataMember(code = GNParameterCode.PlayerDatasSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true )]
			public List<DataSettingsParam>? playerDatasSettings;

			[GNArrayDataMember(code = GNParameterCode.CustomDatasSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true )]
			public List<DataSettingsParam>? customDatasSettings;

			[GNArrayDataMember(code = GNParameterCode.TagsSettings, elementCls = typeof(CurrencySettingsParam), isOptional = true )]
			public List<TagSettingsParam>? tagsSettings;

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
			public long statisticsAggregationMethod;

			[NumberDataMember(code = GNParameterCode.MaximumValue, isOptional = true, defaultValue = 0)]
			public double? maximumValue;

			[NumberDataMember(code = GNParameterCode.MinimumValue, isOptional = true, defaultValue = 0)]
			public double? minimumValue;

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

		}

		public class TagSettingsParam
		{
			[StringDataMember(code = GNParameterCode.Key, minLength = 2, maxLength = 32)]
			public string key;

			[StringDataMember(code = GNParameterCode.DisplayName, isOptional = true)]
			public string? displayName;

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
			[StringDataMember(code = GNParameterCode.GoogleClientId, isOptional = true)]
			public string? googleClientId;

			[StringDataMember(code = GNParameterCode.PackageId, isOptional = true)]
			public string? packageId;

			[StringDataMember(code = GNParameterCode.PublicRSAKey, isOptional = true)]
			public string? publicRSAKey;

		}

		public class ThirtPartyParam
		{
			[GNHashtableDataMember(code = GNParameterCode.GoogleSettings, isOptional = true)]
			public ThirtPartyGoogleSettingsParam? googleSettings;

			[GNHashtableDataMember(code = GNParameterCode.FacebookSettings, isOptional = true)]
			public ThirtPartyFacebookSettingsParam? facebookSettings;

			[GNHashtableDataMember(code = GNParameterCode.AppleSettings, isOptional = true)]
			public ThirtPartyAppleSettingsParam? appleSettings;

		}

	}

	public partial class DashboardModels
	{

		public class ResponseData
		{

		}

	}

}
