namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public class MasterPlayerApi
	{
		public ServerApi server { get; } = new ServerApi();

		public AdminApi admin { get; } = new AdminApi();

		public void addSegment(MasterPlayerModels.AddSegmentRequestData requestData, Action<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void changeAccountPassword(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, Action<MasterPlayerResponseModels.ChangeAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ChangeAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getAvatar(MasterPlayerModels.GetAvatarRequestData requestData, Action<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCountryCode(MasterPlayerModels.GetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCustomData(MasterPlayerModels.GetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getDisplayName(MasterPlayerModels.GetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getEmail(MasterPlayerModels.GetEmailRequestData requestData, Action<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getExternal(MasterPlayerModels.GetExternalRequestData requestData, Action<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getIpAddressCreate(MasterPlayerModels.GetIpAddressCreateRequestData requestData, Action<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerBan(MasterPlayerModels.GetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerCurrency(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerData(MasterPlayerModels.GetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerInformation(MasterPlayerModels.GetPlayerInformationRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerStatistics(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithApple(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithDisplayName(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithFacebook(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithGenericService(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithGoogle(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithSegment(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithTag(MasterPlayerModels.GetPlayersWithTagRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getSegment(MasterPlayerModels.GetSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboard(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTag(MasterPlayerModels.GetTagRequestData requestData, Action<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTsCreate(MasterPlayerModels.GetTsCreateRequestData requestData, Action<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTsLastLogin(MasterPlayerModels.GetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkAccount(MasterPlayerModels.LinkAccountRequestData requestData, Action<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkAndroidDeviceId(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkApple(MasterPlayerModels.LinkAppleRequestData requestData, Action<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkCustomDeviceId(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkCustomId(MasterPlayerModels.LinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkEditorDeviceId(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkFacebook(MasterPlayerModels.LinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkGenericService(MasterPlayerModels.LinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkGoogle(MasterPlayerModels.LinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkiOSDeviceId(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkLinuxDeviceId(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkMacOSDeviceId(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkWindowsDeviceId(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void linkWindowsPhoneDeviceId(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.LinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeSegment(MasterPlayerModels.RemoveSegmentRequestData requestData, Action<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeTag(MasterPlayerModels.RemoveTagRequestData requestData, Action<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void resetAccountPassword(MasterPlayerModels.ResetAccountPasswordRequestData requestData, Action<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setAvatar(MasterPlayerModels.SetAvatarRequestData requestData, Action<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setCountryCode(MasterPlayerModels.SetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setCustomData(MasterPlayerModels.SetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setDisplayName(MasterPlayerModels.SetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setEmail(MasterPlayerModels.SetEmailRequestData requestData, Action<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerBan(MasterPlayerModels.SetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerCurrency(MasterPlayerModels.SetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerData(MasterPlayerModels.SetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerStatistics(MasterPlayerModels.SetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setTag(MasterPlayerModels.SetTagRequestData requestData, Action<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setTsLastLogin(MasterPlayerModels.SetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.SetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkAccount(MasterPlayerModels.UnlinkAccountRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkAndroidDeviceId(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkApple(MasterPlayerModels.UnlinkAppleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkCustomDeviceId(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkCustomId(MasterPlayerModels.UnlinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkEditorDeviceId(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkFacebook(MasterPlayerModels.UnlinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkGenericService(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkGoogle(MasterPlayerModels.UnlinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkiOSDeviceId(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkLinuxDeviceId(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkMacOSDeviceId(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkWindowsDeviceId(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new MasterPlayerRequestModels.UnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}


		public class ServerApi
		{
			public void addSegment(MasterPlayerModels.ServerAddSegmentRequestData requestData, Action<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(MasterPlayerModels.ServerGetAvatarRequestData requestData, Action<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCountryCode(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(MasterPlayerModels.ServerGetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getEmail(MasterPlayerModels.ServerGetEmailRequestData requestData, Action<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getExternal(MasterPlayerModels.ServerGetExternalRequestData requestData, Action<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getIpAddressCreate(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, Action<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerBan(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCurrency(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerData(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInformation(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerStatistics(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithApple(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithDisplayName(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithFacebook(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithGenericService(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithGoogle(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithSegment(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithTag(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(MasterPlayerModels.ServerGetSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(MasterPlayerModels.ServerGetTagRequestData requestData, Action<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(MasterPlayerModels.ServerGetTsCreateRequestData requestData, Action<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsLastLogin(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkAccount(MasterPlayerModels.ServerLinkAccountRequestData requestData, Action<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkAndroidDeviceId(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkApple(MasterPlayerModels.ServerLinkAppleRequestData requestData, Action<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkCustomDeviceId(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkCustomId(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkEditorDeviceId(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkFacebook(MasterPlayerModels.ServerLinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkGenericService(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkGoogle(MasterPlayerModels.ServerLinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkiOSDeviceId(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkLinuxDeviceId(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkMacOSDeviceId(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkWindowsDeviceId(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkWindowsPhoneDeviceId(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, Action<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(MasterPlayerModels.ServerRemoveTagRequestData requestData, Action<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void resetAccountPassword(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, Action<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(MasterPlayerModels.ServerSetAvatarRequestData requestData, Action<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCountryCode(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(MasterPlayerModels.ServerSetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setEmail(MasterPlayerModels.ServerSetEmailRequestData requestData, Action<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerBan(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerCurrency(MasterPlayerModels.ServerSetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerData(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerStatistics(MasterPlayerModels.ServerSetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(MasterPlayerModels.ServerSetTagRequestData requestData, Action<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTsLastLogin(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerSetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkAccount(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkAndroidDeviceId(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkApple(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkCustomDeviceId(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkCustomId(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkEditorDeviceId(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkFacebook(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkGenericService(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkGoogle(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkiOSDeviceId(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkLinuxDeviceId(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkMacOSDeviceId(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkWindowsDeviceId(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.ServerUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

		public class AdminApi
		{
			public void addSegment(MasterPlayerModels.AdminAddSegmentRequestData requestData, Action<MasterPlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(MasterPlayerModels.AdminGetAvatarRequestData requestData, Action<MasterPlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCountryCode(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(MasterPlayerModels.AdminGetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getEmail(MasterPlayerModels.AdminGetEmailRequestData requestData, Action<MasterPlayerResponseModels.GetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getExternal(MasterPlayerModels.AdminGetExternalRequestData requestData, Action<MasterPlayerResponseModels.GetExternalOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetExternalOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getIpAddressCreate(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, Action<MasterPlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerBan(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCurrency(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerData(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInformation(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerStatistics(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithApple(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithDisplayName(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithFacebook(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithGenericService(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithGoogle(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithSegment(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithTag(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, Action<MasterPlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(MasterPlayerModels.AdminGetSegmentRequestData requestData, Action<MasterPlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundPlayer(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<MasterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(MasterPlayerModels.AdminGetTagRequestData requestData, Action<MasterPlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(MasterPlayerModels.AdminGetTsCreateRequestData requestData, Action<MasterPlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsLastLogin(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkAccount(MasterPlayerModels.AdminLinkAccountRequestData requestData, Action<MasterPlayerResponseModels.LinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkAndroidDeviceId(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkApple(MasterPlayerModels.AdminLinkAppleRequestData requestData, Action<MasterPlayerResponseModels.LinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkCustomDeviceId(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkCustomId(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.LinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkEditorDeviceId(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkFacebook(MasterPlayerModels.AdminLinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.LinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkGenericService(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.LinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkGoogle(MasterPlayerModels.AdminLinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.LinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkiOSDeviceId(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkLinuxDeviceId(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkMacOSDeviceId(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkWindowsDeviceId(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void linkWindowsPhoneDeviceId(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.LinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminLinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, Action<MasterPlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(MasterPlayerModels.AdminRemoveTagRequestData requestData, Action<MasterPlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void resetAccountPassword(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, Action<MasterPlayerResponseModels.ResetAccountPasswordOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminResetAccountPasswordOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(MasterPlayerModels.AdminSetAvatarRequestData requestData, Action<MasterPlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCountryCode(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, Action<MasterPlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(MasterPlayerModels.AdminSetCustomDataRequestData requestData, Action<MasterPlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, Action<MasterPlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setEmail(MasterPlayerModels.AdminSetEmailRequestData requestData, Action<MasterPlayerResponseModels.SetEmailOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetEmailOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerBan(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerCurrency(MasterPlayerModels.AdminSetPlayerCurrencyRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerData(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerStatistics(MasterPlayerModels.AdminSetPlayerStatisticsRequestData requestData, Action<MasterPlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(MasterPlayerModels.AdminSetTagRequestData requestData, Action<MasterPlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTsLastLogin(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, Action<MasterPlayerResponseModels.SetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminSetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkAccount(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAccountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAccountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkAndroidDeviceId(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAndroidDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAndroidDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkApple(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkAppleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkAppleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkCustomDeviceId(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkCustomDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkCustomId(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkCustomIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkCustomIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkEditorDeviceId(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkEditorDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkEditorDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkFacebook(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, Action<MasterPlayerResponseModels.UnlinkFacebookOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkFacebookOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkGenericService(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGenericServiceOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGenericServiceOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkGoogle(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, Action<MasterPlayerResponseModels.UnlinkGoogleOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkGoogleOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkiOSDeviceId(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkiOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkiOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkLinuxDeviceId(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkLinuxDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkLinuxDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkMacOSDeviceId(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkMacOSDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkMacOSDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkWindowsDeviceId(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkWindowsDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void unlinkWindowsPhoneDeviceId(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, Action<MasterPlayerResponseModels.UnlinkWindowsPhoneDeviceIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new MasterPlayerRequestModels.AdminUnlinkWindowsPhoneDeviceIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

	}

	public static partial class GNNetwork
	{
		
		public static MasterPlayerApi masterPlayer { get; }
	}

}
