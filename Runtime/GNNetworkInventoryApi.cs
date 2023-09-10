namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public static partial class GNNetwork
	{
		public class InventoryApi
		{
			public ServerApi server { get; } = new ServerApi();

			public AdminApi admin { get; } = new AdminApi();

			public void addSegment(InventoryModels.AddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAmount(InventoryModels.GetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(InventoryModels.GetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCatalogId(InventoryModels.GetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getClassId(InventoryModels.GetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetClassIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(InventoryModels.GetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(InventoryModels.GetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemData(InventoryModels.GetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemInformation(InventoryModels.GetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemStatistics(InventoryModels.GetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithDisplayName(InventoryModels.GetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithSegment(InventoryModels.GetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithTag(InventoryModels.GetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemType(InventoryModels.GetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemTypeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOwner(InventoryModels.GetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getRemoveStatus(InventoryModels.GetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(InventoryModels.GetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundItem(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(InventoryModels.GetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(InventoryModels.GetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(InventoryModels.GetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.GetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(InventoryModels.RemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(InventoryModels.RemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAmount(InventoryModels.SetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(InventoryModels.SetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(InventoryModels.SetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(InventoryModels.SetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemData(InventoryModels.SetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemStatistics(InventoryModels.SetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setOwner(InventoryModels.SetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(InventoryModels.SetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(InventoryModels.SetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.SetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
			}


			public class ServerApi
			{
				public void addSegment(InventoryModels.ServerAddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAmount(InventoryModels.ServerGetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(InventoryModels.ServerGetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(InventoryModels.ServerGetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getClassId(InventoryModels.ServerGetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetClassIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(InventoryModels.ServerGetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(InventoryModels.ServerGetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemData(InventoryModels.ServerGetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemInformation(InventoryModels.ServerGetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemStatistics(InventoryModels.ServerGetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithDisplayName(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithSegment(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithTag(InventoryModels.ServerGetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemType(InventoryModels.ServerGetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemTypeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getOwner(InventoryModels.ServerGetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(InventoryModels.ServerGetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(InventoryModels.ServerGetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundItem(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(InventoryModels.ServerGetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(InventoryModels.ServerGetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(InventoryModels.ServerRemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(InventoryModels.ServerRemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAmount(InventoryModels.ServerSetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(InventoryModels.ServerSetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(InventoryModels.ServerSetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(InventoryModels.ServerSetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setItemData(InventoryModels.ServerSetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setItemStatistics(InventoryModels.ServerSetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setOwner(InventoryModels.ServerSetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(InventoryModels.ServerSetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(InventoryModels.ServerSetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

			public class AdminApi
			{
				public void addSegment(InventoryModels.AdminAddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAmount(InventoryModels.AdminGetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getAvatar(InventoryModels.AdminGetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCatalogId(InventoryModels.AdminGetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getClassId(InventoryModels.AdminGetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetClassIdOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getCustomData(InventoryModels.AdminGetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getDisplayName(InventoryModels.AdminGetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemData(InventoryModels.AdminGetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemInformation(InventoryModels.AdminGetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemInformationOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemStatistics(InventoryModels.AdminGetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithDisplayName(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithSegment(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemsWithTag(InventoryModels.AdminGetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getItemType(InventoryModels.AdminGetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemTypeOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getOwner(InventoryModels.AdminGetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getRemoveStatus(InventoryModels.AdminGetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getSegment(InventoryModels.AdminGetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboardAroundItem(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getStatisticsLeaderboard(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTag(InventoryModels.AdminGetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void getTsCreate(InventoryModels.AdminGetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeSegment(InventoryModels.AdminRemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void removeTag(InventoryModels.AdminRemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAmount(InventoryModels.AdminSetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAmountOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setAvatar(InventoryModels.AdminSetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setCustomData(InventoryModels.AdminSetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setDisplayName(InventoryModels.AdminSetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setItemData(InventoryModels.AdminSetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetItemDataOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setItemStatistics(InventoryModels.AdminSetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetItemStatisticsOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setOwner(InventoryModels.AdminSetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setRemoveStatus(InventoryModels.AdminSetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

				public void setTag(InventoryModels.AdminSetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> response = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
				{
					GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetTagOperationRequest(requestData, timeout), response, overrideAuthToken, overrideSecretKey, customTags);
				}

			}

		}

		public static InventoryApi inventory { get; } = new InventoryApi();
	}

}
