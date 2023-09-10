namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class GroupApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void addMember(GroupModels.AddMemberRequestData requestData, Action<GroupResponseModels.AddMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.AddMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void addSegment(GroupModels.AddSegmentRequestData requestData, Action<GroupResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.AddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(GroupModels.GetAvatarRequestData requestData, Action<GroupResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCatalogId(GroupModels.GetCatalogIdRequestData requestData, Action<GroupResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(GroupModels.GetCustomDataRequestData requestData, Action<GroupResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(GroupModels.GetDisplayNameRequestData requestData, Action<GroupResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupCurrency(GroupModels.GetGroupCurrencyRequestData requestData, Action<GroupResponseModels.GetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupData(GroupModels.GetGroupDataRequestData requestData, Action<GroupResponseModels.GetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupInformation(GroupModels.GetGroupInformationRequestData requestData, Action<GroupResponseModels.GetGroupInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupInventory(GroupModels.GetGroupInventoryRequestData requestData, Action<GroupResponseModels.GetGroupInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupMessage(GroupModels.GetGroupMessageRequestData requestData, Action<GroupResponseModels.GetGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupStatistics(GroupModels.GetGroupStatisticsRequestData requestData, Action<GroupResponseModels.GetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupsWithDisplayName(GroupModels.GetGroupsWithDisplayNameRequestData requestData, Action<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupsWithSegment(GroupModels.GetGroupsWithSegmentRequestData requestData, Action<GroupResponseModels.GetGroupsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getGroupsWithTag(GroupModels.GetGroupsWithTagRequestData requestData, Action<GroupResponseModels.GetGroupsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetGroupsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getMembers(GroupModels.GetMembersRequestData requestData, Action<GroupResponseModels.GetMembersOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetMembersOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getRemoveStatus(GroupModels.GetRemoveStatusRequestData requestData, Action<GroupResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(GroupModels.GetSegmentRequestData requestData, Action<GroupResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundGroup(GroupModels.GetStatisticsLeaderboardAroundGroupRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(GroupModels.GetStatisticsLeaderboardRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(GroupModels.GetTagRequestData requestData, Action<GroupResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(GroupModels.GetTsCreateRequestData requestData, Action<GroupResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void grantGroupItem(GroupModels.GrantGroupItemRequestData requestData, Action<GroupResponseModels.GrantGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.GrantGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeGroupItem(GroupModels.RemoveGroupItemRequestData requestData, Action<GroupResponseModels.RemoveGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.RemoveGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeMember(GroupModels.RemoveMemberRequestData requestData, Action<GroupResponseModels.RemoveMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.RemoveMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(GroupModels.RemoveSegmentRequestData requestData, Action<GroupResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.RemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(GroupModels.RemoveTagRequestData requestData, Action<GroupResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.RemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void sendGroupMessage(GroupModels.SendGroupMessageRequestData requestData, Action<GroupResponseModels.SendGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SendGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(GroupModels.SetAvatarRequestData requestData, Action<GroupResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(GroupModels.SetCustomDataRequestData requestData, Action<GroupResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(GroupModels.SetDisplayNameRequestData requestData, Action<GroupResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setGroupCurrency(GroupModels.SetGroupCurrencyRequestData requestData, Action<GroupResponseModels.SetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setGroupData(GroupModels.SetGroupDataRequestData requestData, Action<GroupResponseModels.SetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setGroupStatistics(GroupModels.SetGroupStatisticsRequestData requestData, Action<GroupResponseModels.SetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(GroupModels.SetRemoveStatusRequestData requestData, Action<GroupResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(GroupModels.SetTagRequestData requestData, Action<GroupResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new GroupRequestModels.SetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
				public void addMember(GroupModels.ServerAddMemberRequestData requestData, Action<GroupResponseModels.AddMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerAddMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void addSegment(GroupModels.ServerAddSegmentRequestData requestData, Action<GroupResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(GroupModels.ServerGetAvatarRequestData requestData, Action<GroupResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(GroupModels.ServerGetCatalogIdRequestData requestData, Action<GroupResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(GroupModels.ServerGetCustomDataRequestData requestData, Action<GroupResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(GroupModels.ServerGetDisplayNameRequestData requestData, Action<GroupResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupCurrency(GroupModels.ServerGetGroupCurrencyRequestData requestData, Action<GroupResponseModels.GetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupData(GroupModels.ServerGetGroupDataRequestData requestData, Action<GroupResponseModels.GetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupInformation(GroupModels.ServerGetGroupInformationRequestData requestData, Action<GroupResponseModels.GetGroupInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupInventory(GroupModels.ServerGetGroupInventoryRequestData requestData, Action<GroupResponseModels.GetGroupInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupMessage(GroupModels.ServerGetGroupMessageRequestData requestData, Action<GroupResponseModels.GetGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupStatistics(GroupModels.ServerGetGroupStatisticsRequestData requestData, Action<GroupResponseModels.GetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithDisplayName(GroupModels.ServerGetGroupsWithDisplayNameRequestData requestData, Action<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithSegment(GroupModels.ServerGetGroupsWithSegmentRequestData requestData, Action<GroupResponseModels.GetGroupsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithTag(GroupModels.ServerGetGroupsWithTagRequestData requestData, Action<GroupResponseModels.GetGroupsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetGroupsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getMembers(GroupModels.ServerGetMembersRequestData requestData, Action<GroupResponseModels.GetMembersOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetMembersOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(GroupModels.ServerGetRemoveStatusRequestData requestData, Action<GroupResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(GroupModels.ServerGetSegmentRequestData requestData, Action<GroupResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundGroup(GroupModels.ServerGetStatisticsLeaderboardAroundGroupRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(GroupModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(GroupModels.ServerGetTagRequestData requestData, Action<GroupResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(GroupModels.ServerGetTsCreateRequestData requestData, Action<GroupResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantGroupItem(GroupModels.ServerGrantGroupItemRequestData requestData, Action<GroupResponseModels.GrantGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerGrantGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeGroupItem(GroupModels.ServerRemoveGroupItemRequestData requestData, Action<GroupResponseModels.RemoveGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeMember(GroupModels.ServerRemoveMemberRequestData requestData, Action<GroupResponseModels.RemoveMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(GroupModels.ServerRemoveSegmentRequestData requestData, Action<GroupResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(GroupModels.ServerRemoveTagRequestData requestData, Action<GroupResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void sendGroupMessage(GroupModels.ServerSendGroupMessageRequestData requestData, Action<GroupResponseModels.SendGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSendGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(GroupModels.ServerSetAvatarRequestData requestData, Action<GroupResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(GroupModels.ServerSetCustomDataRequestData requestData, Action<GroupResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(GroupModels.ServerSetDisplayNameRequestData requestData, Action<GroupResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupCurrency(GroupModels.ServerSetGroupCurrencyRequestData requestData, Action<GroupResponseModels.SetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupData(GroupModels.ServerSetGroupDataRequestData requestData, Action<GroupResponseModels.SetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupStatistics(GroupModels.ServerSetGroupStatisticsRequestData requestData, Action<GroupResponseModels.SetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(GroupModels.ServerSetRemoveStatusRequestData requestData, Action<GroupResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(GroupModels.ServerSetTagRequestData requestData, Action<GroupResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.ServerSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

			public class AdminApi
			{
				public void addMember(GroupModels.AdminAddMemberRequestData requestData, Action<GroupResponseModels.AddMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminAddMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void addSegment(GroupModels.AdminAddSegmentRequestData requestData, Action<GroupResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(GroupModels.AdminGetAvatarRequestData requestData, Action<GroupResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(GroupModels.AdminGetCatalogIdRequestData requestData, Action<GroupResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(GroupModels.AdminGetCustomDataRequestData requestData, Action<GroupResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(GroupModels.AdminGetDisplayNameRequestData requestData, Action<GroupResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupCurrency(GroupModels.AdminGetGroupCurrencyRequestData requestData, Action<GroupResponseModels.GetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupData(GroupModels.AdminGetGroupDataRequestData requestData, Action<GroupResponseModels.GetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupInformation(GroupModels.AdminGetGroupInformationRequestData requestData, Action<GroupResponseModels.GetGroupInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupInventory(GroupModels.AdminGetGroupInventoryRequestData requestData, Action<GroupResponseModels.GetGroupInventoryOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupInventoryOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupMessage(GroupModels.AdminGetGroupMessageRequestData requestData, Action<GroupResponseModels.GetGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupStatistics(GroupModels.AdminGetGroupStatisticsRequestData requestData, Action<GroupResponseModels.GetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithDisplayName(GroupModels.AdminGetGroupsWithDisplayNameRequestData requestData, Action<GroupResponseModels.GetGroupsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithSegment(GroupModels.AdminGetGroupsWithSegmentRequestData requestData, Action<GroupResponseModels.GetGroupsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getGroupsWithTag(GroupModels.AdminGetGroupsWithTagRequestData requestData, Action<GroupResponseModels.GetGroupsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetGroupsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getMembers(GroupModels.AdminGetMembersRequestData requestData, Action<GroupResponseModels.GetMembersOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetMembersOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(GroupModels.AdminGetRemoveStatusRequestData requestData, Action<GroupResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(GroupModels.AdminGetSegmentRequestData requestData, Action<GroupResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundGroup(GroupModels.AdminGetStatisticsLeaderboardAroundGroupRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardAroundGroupOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetStatisticsLeaderboardAroundGroupOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(GroupModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<GroupResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(GroupModels.AdminGetTagRequestData requestData, Action<GroupResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(GroupModels.AdminGetTsCreateRequestData requestData, Action<GroupResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void grantGroupItem(GroupModels.AdminGrantGroupItemRequestData requestData, Action<GroupResponseModels.GrantGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminGrantGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeGroupItem(GroupModels.AdminRemoveGroupItemRequestData requestData, Action<GroupResponseModels.RemoveGroupItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveGroupItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeMember(GroupModels.AdminRemoveMemberRequestData requestData, Action<GroupResponseModels.RemoveMemberOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveMemberOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(GroupModels.AdminRemoveSegmentRequestData requestData, Action<GroupResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(GroupModels.AdminRemoveTagRequestData requestData, Action<GroupResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void sendGroupMessage(GroupModels.AdminSendGroupMessageRequestData requestData, Action<GroupResponseModels.SendGroupMessageOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSendGroupMessageOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(GroupModels.AdminSetAvatarRequestData requestData, Action<GroupResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(GroupModels.AdminSetCustomDataRequestData requestData, Action<GroupResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(GroupModels.AdminSetDisplayNameRequestData requestData, Action<GroupResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupCurrency(GroupModels.AdminSetGroupCurrencyRequestData requestData, Action<GroupResponseModels.SetGroupCurrencyOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetGroupCurrencyOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupData(GroupModels.AdminSetGroupDataRequestData requestData, Action<GroupResponseModels.SetGroupDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetGroupDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setGroupStatistics(GroupModels.AdminSetGroupStatisticsRequestData requestData, Action<GroupResponseModels.SetGroupStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetGroupStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(GroupModels.AdminSetRemoveStatusRequestData requestData, Action<GroupResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(GroupModels.AdminSetTagRequestData requestData, Action<GroupResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new GroupRequestModels.AdminSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

		}

		public static GroupApi group { get; } = new GroupApi();
	}

}
