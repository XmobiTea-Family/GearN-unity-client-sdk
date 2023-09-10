namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class CharacterPlayerApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void addPlayerFriend(CharacterPlayerModels.AddPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AddPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void addSegment(CharacterPlayerModels.AddSegmentRequestData requestData, Action<CharacterPlayerResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(CharacterPlayerModels.GetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCatalogId(CharacterPlayerModels.GetCatalogIdRequestData requestData, Action<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCountryCode(CharacterPlayerModels.GetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(CharacterPlayerModels.GetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(CharacterPlayerModels.GetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.GetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getFriendStatisticsLeaderboard(CharacterPlayerModels.GetFriendStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getIpAddressCreate(CharacterPlayerModels.GetIpAddressCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetIpAddressCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOwner(CharacterPlayerModels.GetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerBan(CharacterPlayerModels.GetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerCurrency(CharacterPlayerModels.GetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerData(CharacterPlayerModels.GetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerFriend(CharacterPlayerModels.GetPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerGroup(CharacterPlayerModels.GetPlayerGroupRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInformation(CharacterPlayerModels.GetPlayerInformationRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerInventory(CharacterPlayerModels.GetPlayerInventoryRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayerStatistics(CharacterPlayerModels.GetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithDisplayName(CharacterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithSegment(CharacterPlayerModels.GetPlayersWithSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getPlayersWithTag(CharacterPlayerModels.GetPlayersWithTagRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetPlayersWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getRemoveStatus(CharacterPlayerModels.GetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(CharacterPlayerModels.GetSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(CharacterPlayerModels.GetStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(CharacterPlayerModels.GetTagRequestData requestData, Action<CharacterPlayerResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(CharacterPlayerModels.GetTsCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsLastLogin(CharacterPlayerModels.GetTsLastLoginRequestData requestData, Action<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GetTsLastLoginOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantGroup(CharacterPlayerModels.GrantGroupRequestData requestData, Action<CharacterPlayerResponseModels.GrantGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GrantGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantPlayerItem(CharacterPlayerModels.GrantPlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.GrantPlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.GrantPlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void joinGroup(CharacterPlayerModels.JoinGroupRequestData requestData, Action<CharacterPlayerResponseModels.JoinGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.JoinGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void leaveGroup(CharacterPlayerModels.LeaveGroupRequestData requestData, Action<CharacterPlayerResponseModels.LeaveGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.LeaveGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerFriend(CharacterPlayerModels.RemovePlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemovePlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removePlayerItem(CharacterPlayerModels.RemovePlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemovePlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(CharacterPlayerModels.RemoveSegmentRequestData requestData, Action<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(CharacterPlayerModels.RemoveTagRequestData requestData, Action<CharacterPlayerResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.RemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(CharacterPlayerModels.SetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCountryCode(CharacterPlayerModels.SetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(CharacterPlayerModels.SetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(CharacterPlayerModels.SetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setOwner(CharacterPlayerModels.SetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerBan(CharacterPlayerModels.SetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerCurrency(CharacterPlayerModels.SetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerData(CharacterPlayerModels.SetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setPlayerStatistics(CharacterPlayerModels.SetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(CharacterPlayerModels.SetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(CharacterPlayerModels.SetTagRequestData requestData, Action<CharacterPlayerResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.SetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
				public void addPlayerFriend(CharacterPlayerModels.ServerAddPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerAddPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void addSegment(CharacterPlayerModels.ServerAddSegmentRequestData requestData, Action<CharacterPlayerResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(CharacterPlayerModels.ServerGetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(CharacterPlayerModels.ServerGetCatalogIdRequestData requestData, Action<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCountryCode(CharacterPlayerModels.ServerGetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(CharacterPlayerModels.ServerGetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(CharacterPlayerModels.ServerGetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFriendStatisticsLeaderboard(CharacterPlayerModels.ServerGetFriendStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getIpAddressCreate(CharacterPlayerModels.ServerGetIpAddressCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetIpAddressCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getOwner(CharacterPlayerModels.ServerGetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerBan(CharacterPlayerModels.ServerGetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerCurrency(CharacterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerData(CharacterPlayerModels.ServerGetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerFriend(CharacterPlayerModels.ServerGetPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerGroup(CharacterPlayerModels.ServerGetPlayerGroupRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerInformation(CharacterPlayerModels.ServerGetPlayerInformationRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerInventory(CharacterPlayerModels.ServerGetPlayerInventoryRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerStatistics(CharacterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithDisplayName(CharacterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithSegment(CharacterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithTag(CharacterPlayerModels.ServerGetPlayersWithTagRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetPlayersWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(CharacterPlayerModels.ServerGetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(CharacterPlayerModels.ServerGetSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(CharacterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(CharacterPlayerModels.ServerGetTagRequestData requestData, Action<CharacterPlayerResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(CharacterPlayerModels.ServerGetTsCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsLastLogin(CharacterPlayerModels.ServerGetTsLastLoginRequestData requestData, Action<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGetTsLastLoginOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantGroup(CharacterPlayerModels.ServerGrantGroupRequestData requestData, Action<CharacterPlayerResponseModels.GrantGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGrantGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantPlayerItem(CharacterPlayerModels.ServerGrantPlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.GrantPlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerGrantPlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void joinGroup(CharacterPlayerModels.ServerJoinGroupRequestData requestData, Action<CharacterPlayerResponseModels.JoinGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerJoinGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void leaveGroup(CharacterPlayerModels.ServerLeaveGroupRequestData requestData, Action<CharacterPlayerResponseModels.LeaveGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerLeaveGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removePlayerFriend(CharacterPlayerModels.ServerRemovePlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemovePlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removePlayerItem(CharacterPlayerModels.ServerRemovePlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemovePlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(CharacterPlayerModels.ServerRemoveSegmentRequestData requestData, Action<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(CharacterPlayerModels.ServerRemoveTagRequestData requestData, Action<CharacterPlayerResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(CharacterPlayerModels.ServerSetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCountryCode(CharacterPlayerModels.ServerSetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(CharacterPlayerModels.ServerSetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(CharacterPlayerModels.ServerSetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setOwner(CharacterPlayerModels.ServerSetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerBan(CharacterPlayerModels.ServerSetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerCurrency(CharacterPlayerModels.ServerSetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerData(CharacterPlayerModels.ServerSetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerStatistics(CharacterPlayerModels.ServerSetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(CharacterPlayerModels.ServerSetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(CharacterPlayerModels.ServerSetTagRequestData requestData, Action<CharacterPlayerResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.ServerSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

			public class AdminApi
			{
				public void addPlayerFriend(CharacterPlayerModels.AdminAddPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.AddPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminAddPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void addSegment(CharacterPlayerModels.AdminAddSegmentRequestData requestData, Action<CharacterPlayerResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(CharacterPlayerModels.AdminGetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(CharacterPlayerModels.AdminGetCatalogIdRequestData requestData, Action<CharacterPlayerResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCountryCode(CharacterPlayerModels.AdminGetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.GetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(CharacterPlayerModels.AdminGetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(CharacterPlayerModels.AdminGetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFriendStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getFriendStatisticsLeaderboard(CharacterPlayerModels.AdminGetFriendStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetFriendStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetFriendStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getIpAddressCreate(CharacterPlayerModels.AdminGetIpAddressCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetIpAddressCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetIpAddressCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getOwner(CharacterPlayerModels.AdminGetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerBan(CharacterPlayerModels.AdminGetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerCurrency(CharacterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerData(CharacterPlayerModels.AdminGetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerFriend(CharacterPlayerModels.AdminGetPlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerGroup(CharacterPlayerModels.AdminGetPlayerGroupRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerInformation(CharacterPlayerModels.AdminGetPlayerInformationRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerInventory(CharacterPlayerModels.AdminGetPlayerInventoryRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayerStatistics(CharacterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithDisplayName(CharacterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithSegment(CharacterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getPlayersWithTag(CharacterPlayerModels.AdminGetPlayersWithTagRequestData requestData, Action<CharacterPlayerResponseModels.GetPlayersWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetPlayersWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(CharacterPlayerModels.AdminGetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(CharacterPlayerModels.AdminGetSegmentRequestData requestData, Action<CharacterPlayerResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundPlayer(CharacterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardAroundPlayerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(CharacterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<CharacterPlayerResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(CharacterPlayerModels.AdminGetTagRequestData requestData, Action<CharacterPlayerResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(CharacterPlayerModels.AdminGetTsCreateRequestData requestData, Action<CharacterPlayerResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsLastLogin(CharacterPlayerModels.AdminGetTsLastLoginRequestData requestData, Action<CharacterPlayerResponseModels.GetTsLastLoginOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGetTsLastLoginOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantGroup(CharacterPlayerModels.AdminGrantGroupRequestData requestData, Action<CharacterPlayerResponseModels.GrantGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGrantGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantPlayerItem(CharacterPlayerModels.AdminGrantPlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.GrantPlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminGrantPlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void joinGroup(CharacterPlayerModels.AdminJoinGroupRequestData requestData, Action<CharacterPlayerResponseModels.JoinGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminJoinGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void leaveGroup(CharacterPlayerModels.AdminLeaveGroupRequestData requestData, Action<CharacterPlayerResponseModels.LeaveGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminLeaveGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removePlayerFriend(CharacterPlayerModels.AdminRemovePlayerFriendRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerFriendOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemovePlayerFriendOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removePlayerItem(CharacterPlayerModels.AdminRemovePlayerItemRequestData requestData, Action<CharacterPlayerResponseModels.RemovePlayerItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemovePlayerItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(CharacterPlayerModels.AdminRemoveSegmentRequestData requestData, Action<CharacterPlayerResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(CharacterPlayerModels.AdminRemoveTagRequestData requestData, Action<CharacterPlayerResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(CharacterPlayerModels.AdminSetAvatarRequestData requestData, Action<CharacterPlayerResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCountryCode(CharacterPlayerModels.AdminSetCountryCodeRequestData requestData, Action<CharacterPlayerResponseModels.SetCountryCodeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetCountryCodeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(CharacterPlayerModels.AdminSetCustomDataRequestData requestData, Action<CharacterPlayerResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(CharacterPlayerModels.AdminSetDisplayNameRequestData requestData, Action<CharacterPlayerResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setOwner(CharacterPlayerModels.AdminSetOwnerRequestData requestData, Action<CharacterPlayerResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerBan(CharacterPlayerModels.AdminSetPlayerBanRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerBanOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerBanOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerCurrency(CharacterPlayerModels.AdminSetPlayerCurrencyRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerData(CharacterPlayerModels.AdminSetPlayerDataRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setPlayerStatistics(CharacterPlayerModels.AdminSetPlayerStatisticsRequestData requestData, Action<CharacterPlayerResponseModels.SetPlayerStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetPlayerStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(CharacterPlayerModels.AdminSetRemoveStatusRequestData requestData, Action<CharacterPlayerResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(CharacterPlayerModels.AdminSetTagRequestData requestData, Action<CharacterPlayerResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new CharacterPlayerRequestModels.AdminSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

		}

		public static CharacterPlayerApi characterPlayer { get; } = new CharacterPlayerApi();
	}

}
