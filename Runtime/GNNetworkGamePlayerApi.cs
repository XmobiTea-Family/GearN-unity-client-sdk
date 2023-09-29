namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public class GamePlayerApi
	{
		public ServerApi server { get; } = new ServerApi();

		public AdminApi admin { get; } = new AdminApi();

		public void addPlayerFriend(GamePlayerModels.AddPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void addSegment(GamePlayerModels.AddSegmentRequestData requestData, Action<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getAvatar(GamePlayerModels.GetAvatarRequestData requestData, Action<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCountryCode(GamePlayerModels.GetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCustomData(GamePlayerModels.GetCustomDataRequestData requestData, Action<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getDisplayName(GamePlayerModels.GetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getFriendStatisticsLeaderboard(GamePlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getIpAddressCreate(GamePlayerModels.GetIpAddressCreateRequestData requestData, Action<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getOnlineStatus(GamePlayerModels.GetOnlineStatusRequestData requestData, Action<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerBan(GamePlayerModels.GetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerCharacter(GamePlayerModels.GetPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerCurrency(GamePlayerModels.GetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerData(GamePlayerModels.GetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerFriend(GamePlayerModels.GetPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerGroup(GamePlayerModels.GetPlayerGroupRequestData requestData, Action<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerInformation(GamePlayerModels.GetPlayerInformationRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerInventory(GamePlayerModels.GetPlayerInventoryRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayerStatistics(GamePlayerModels.GetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithDisplayName(GamePlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithSegment(GamePlayerModels.GetPlayersWithSegmentRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getPlayersWithTag(GamePlayerModels.GetPlayersWithTagRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getSegment(GamePlayerModels.GetSegmentRequestData requestData, Action<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboard(GamePlayerModels.GetStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTag(GamePlayerModels.GetTagRequestData requestData, Action<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTsCreate(GamePlayerModels.GetTsCreateRequestData requestData, Action<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTsLastLogin(GamePlayerModels.GetTsLastLoginRequestData requestData, Action<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void grantGroup(GamePlayerModels.GrantGroupRequestData requestData, Action<GamePlayerResponseModels.GrantGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GrantGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void grantPlayerCharacter(GamePlayerModels.GrantPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GrantPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void grantPlayerItem(GamePlayerModels.GrantPlayerItemRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.GrantPlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void joinGroup(GamePlayerModels.JoinGroupRequestData requestData, Action<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void leaveGroup(GamePlayerModels.LeaveGroupRequestData requestData, Action<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removePlayerCharacter(GamePlayerModels.RemovePlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removePlayerFriend(GamePlayerModels.RemovePlayerFriendRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removePlayerItem(GamePlayerModels.RemovePlayerItemRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeSegment(GamePlayerModels.RemoveSegmentRequestData requestData, Action<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeTag(GamePlayerModels.RemoveTagRequestData requestData, Action<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setAvatar(GamePlayerModels.SetAvatarRequestData requestData, Action<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setCountryCode(GamePlayerModels.SetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setCustomData(GamePlayerModels.SetCustomDataRequestData requestData, Action<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setDisplayName(GamePlayerModels.SetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerBan(GamePlayerModels.SetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerCurrency(GamePlayerModels.SetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerData(GamePlayerModels.SetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setPlayerStatistics(GamePlayerModels.SetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setTag(GamePlayerModels.SetTagRequestData requestData, Action<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new GamePlayerRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}


		public class ServerApi
		{
			public void addPlayerFriend(GamePlayerModels.ServerAddPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void addSegment(GamePlayerModels.ServerAddSegmentRequestData requestData, Action<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(GamePlayerModels.ServerGetAvatarRequestData requestData, Action<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCountryCode(GamePlayerModels.ServerGetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(GamePlayerModels.ServerGetCustomDataRequestData requestData, Action<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(GamePlayerModels.ServerGetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboard(GamePlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getIpAddressCreate(GamePlayerModels.ServerGetIpAddressCreateRequestData requestData, Action<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOnlineStatus(GamePlayerModels.ServerGetOnlineStatusRequestData requestData, Action<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerBan(GamePlayerModels.ServerGetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCharacter(GamePlayerModels.ServerGetPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCurrency(GamePlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerData(GamePlayerModels.ServerGetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerFriend(GamePlayerModels.ServerGetPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerGroup(GamePlayerModels.ServerGetPlayerGroupRequestData requestData, Action<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInformation(GamePlayerModels.ServerGetPlayerInformationRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInventory(GamePlayerModels.ServerGetPlayerInventoryRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerStatistics(GamePlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithDisplayName(GamePlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithSegment(GamePlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithTag(GamePlayerModels.ServerGetPlayersWithTagRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(GamePlayerModels.ServerGetSegmentRequestData requestData, Action<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(GamePlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(GamePlayerModels.ServerGetTagRequestData requestData, Action<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(GamePlayerModels.ServerGetTsCreateRequestData requestData, Action<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsLastLogin(GamePlayerModels.ServerGetTsLastLoginRequestData requestData, Action<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantGroup(GamePlayerModels.ServerGrantGroupRequestData requestData, Action<GamePlayerResponseModels.GrantGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGrantGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantPlayerCharacter(GamePlayerModels.ServerGrantPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGrantPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantPlayerItem(GamePlayerModels.ServerGrantPlayerItemRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerGrantPlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void joinGroup(GamePlayerModels.ServerJoinGroupRequestData requestData, Action<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void leaveGroup(GamePlayerModels.ServerLeaveGroupRequestData requestData, Action<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerCharacter(GamePlayerModels.ServerRemovePlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerFriend(GamePlayerModels.ServerRemovePlayerFriendRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerItem(GamePlayerModels.ServerRemovePlayerItemRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(GamePlayerModels.ServerRemoveSegmentRequestData requestData, Action<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(GamePlayerModels.ServerRemoveTagRequestData requestData, Action<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(GamePlayerModels.ServerSetAvatarRequestData requestData, Action<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCountryCode(GamePlayerModels.ServerSetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(GamePlayerModels.ServerSetCustomDataRequestData requestData, Action<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(GamePlayerModels.ServerSetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerBan(GamePlayerModels.ServerSetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerCurrency(GamePlayerModels.ServerSetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerData(GamePlayerModels.ServerSetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerStatistics(GamePlayerModels.ServerSetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(GamePlayerModels.ServerSetTagRequestData requestData, Action<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

		public class AdminApi
		{
			public void addPlayerFriend(GamePlayerModels.AdminAddPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.AddPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void addSegment(GamePlayerModels.AdminAddSegmentRequestData requestData, Action<GamePlayerResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(GamePlayerModels.AdminGetAvatarRequestData requestData, Action<GamePlayerResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCountryCode(GamePlayerModels.AdminGetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.GetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(GamePlayerModels.AdminGetCustomDataRequestData requestData, Action<GamePlayerResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(GamePlayerModels.AdminGetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboardAroundPlayer(GamePlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboard(GamePlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getIpAddressCreate(GamePlayerModels.AdminGetIpAddressCreateRequestData requestData, Action<GamePlayerResponseModels.GetIpAddressCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOnlineStatus(GamePlayerModels.AdminGetOnlineStatusRequestData requestData, Action<GamePlayerResponseModels.GetOnlineStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetOnlineStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerBan(GamePlayerModels.AdminGetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.GetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCharacter(GamePlayerModels.AdminGetPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCurrency(GamePlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.GetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerData(GamePlayerModels.AdminGetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.GetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerFriend(GamePlayerModels.AdminGetPlayerFriendRequestData requestData, Action<GamePlayerResponseModels.GetPlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerGroup(GamePlayerModels.AdminGetPlayerGroupRequestData requestData, Action<GamePlayerResponseModels.GetPlayerGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInformation(GamePlayerModels.AdminGetPlayerInformationRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInventory(GamePlayerModels.AdminGetPlayerInventoryRequestData requestData, Action<GamePlayerResponseModels.GetPlayerInventoryOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerStatistics(GamePlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.GetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithDisplayName(GamePlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithSegment(GamePlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithTag(GamePlayerModels.AdminGetPlayersWithTagRequestData requestData, Action<GamePlayerResponseModels.GetPlayersWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(GamePlayerModels.AdminGetSegmentRequestData requestData, Action<GamePlayerResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundPlayer(GamePlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(GamePlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<GamePlayerResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(GamePlayerModels.AdminGetTagRequestData requestData, Action<GamePlayerResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(GamePlayerModels.AdminGetTsCreateRequestData requestData, Action<GamePlayerResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsLastLogin(GamePlayerModels.AdminGetTsLastLoginRequestData requestData, Action<GamePlayerResponseModels.GetTsLastLoginOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantGroup(GamePlayerModels.AdminGrantGroupRequestData requestData, Action<GamePlayerResponseModels.GrantGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGrantGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantPlayerCharacter(GamePlayerModels.AdminGrantPlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGrantPlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantPlayerItem(GamePlayerModels.AdminGrantPlayerItemRequestData requestData, Action<GamePlayerResponseModels.GrantPlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminGrantPlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void joinGroup(GamePlayerModels.AdminJoinGroupRequestData requestData, Action<GamePlayerResponseModels.JoinGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void leaveGroup(GamePlayerModels.AdminLeaveGroupRequestData requestData, Action<GamePlayerResponseModels.LeaveGroupOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerCharacter(GamePlayerModels.AdminRemovePlayerCharacterRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerCharacterOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerCharacterOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerFriend(GamePlayerModels.AdminRemovePlayerFriendRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerFriendOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerItem(GamePlayerModels.AdminRemovePlayerItemRequestData requestData, Action<GamePlayerResponseModels.RemovePlayerItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(GamePlayerModels.AdminRemoveSegmentRequestData requestData, Action<GamePlayerResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(GamePlayerModels.AdminRemoveTagRequestData requestData, Action<GamePlayerResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(GamePlayerModels.AdminSetAvatarRequestData requestData, Action<GamePlayerResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCountryCode(GamePlayerModels.AdminSetCountryCodeRequestData requestData, Action<GamePlayerResponseModels.SetCountryCodeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(GamePlayerModels.AdminSetCustomDataRequestData requestData, Action<GamePlayerResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(GamePlayerModels.AdminSetDisplayNameRequestData requestData, Action<GamePlayerResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerBan(GamePlayerModels.AdminSetPlayerBanRequestData requestData, Action<GamePlayerResponseModels.SetPlayerBanOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerCurrency(GamePlayerModels.AdminSetPlayerCurrencyRequestData requestData, Action<GamePlayerResponseModels.SetPlayerCurrencyOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerCurrencyOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerData(GamePlayerModels.AdminSetPlayerDataRequestData requestData, Action<GamePlayerResponseModels.SetPlayerDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerStatistics(GamePlayerModels.AdminSetPlayerStatisticsRequestData requestData, Action<GamePlayerResponseModels.SetPlayerStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetPlayerStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(GamePlayerModels.AdminSetTagRequestData requestData, Action<GamePlayerResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GamePlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

	}

	public static partial class GNNetwork
	{
		
		public static GamePlayerApi gamePlayer { get; }
	}

}
