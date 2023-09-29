namespace XmobiTea.GN
{
	using System;
	using XmobiTea.GN.Common;
	using XmobiTea.GN.Entity;
	using XmobiTea.GN.Entity.Models;

	public class InventoryApi
	{
		public ServerApi server { get; } = new ServerApi();

		public AdminApi admin { get; } = new AdminApi();

		public void addSegment(InventoryModels.AddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.AddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getAmount(InventoryModels.GetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getAvatar(InventoryModels.GetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCatalogId(InventoryModels.GetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getClassId(InventoryModels.GetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getCustomData(InventoryModels.GetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getDisplayName(InventoryModels.GetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemData(InventoryModels.GetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemInformation(InventoryModels.GetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemStatistics(InventoryModels.GetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemsWithDisplayName(InventoryModels.GetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemsWithSegment(InventoryModels.GetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemsWithTag(InventoryModels.GetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getItemType(InventoryModels.GetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getOwner(InventoryModels.GetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getRemoveStatus(InventoryModels.GetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getSegment(InventoryModels.GetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboardAroundItem(InventoryModels.GetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getStatisticsLeaderboard(InventoryModels.GetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTag(InventoryModels.GetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void getTsCreate(InventoryModels.GetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.GetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeSegment(InventoryModels.RemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void removeTag(InventoryModels.RemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.RemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setAmount(InventoryModels.SetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setAvatar(InventoryModels.SetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setCustomData(InventoryModels.SetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setDisplayName(InventoryModels.SetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setItemData(InventoryModels.SetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setItemStatistics(InventoryModels.SetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setOwner(InventoryModels.SetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setRemoveStatus(InventoryModels.SetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}

		public void setTag(InventoryModels.SetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
		{
			GNNetwork.sendViaHttp(new InventoryRequestModels.SetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
		}


		public class ServerApi
		{
			public void addSegment(InventoryModels.ServerAddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAmount(InventoryModels.ServerGetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(InventoryModels.ServerGetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCatalogId(InventoryModels.ServerGetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getClassId(InventoryModels.ServerGetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(InventoryModels.ServerGetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(InventoryModels.ServerGetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemData(InventoryModels.ServerGetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemInformation(InventoryModels.ServerGetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemStatistics(InventoryModels.ServerGetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithDisplayName(InventoryModels.ServerGetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithSegment(InventoryModels.ServerGetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithTag(InventoryModels.ServerGetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemType(InventoryModels.ServerGetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOwner(InventoryModels.ServerGetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getRemoveStatus(InventoryModels.ServerGetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(InventoryModels.ServerGetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundItem(InventoryModels.ServerGetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(InventoryModels.ServerGetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(InventoryModels.ServerGetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(InventoryModels.ServerGetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(InventoryModels.ServerRemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(InventoryModels.ServerRemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAmount(InventoryModels.ServerSetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(InventoryModels.ServerSetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(InventoryModels.ServerSetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(InventoryModels.ServerSetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemData(InventoryModels.ServerSetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemStatistics(InventoryModels.ServerSetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setOwner(InventoryModels.ServerSetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(InventoryModels.ServerSetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(InventoryModels.ServerSetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.ServerSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

		public class AdminApi
		{
			public void addSegment(InventoryModels.AdminAddSegmentRequestData requestData, Action<InventoryResponseModels.AddSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminAddSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAmount(InventoryModels.AdminGetAmountRequestData requestData, Action<InventoryResponseModels.GetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getAvatar(InventoryModels.AdminGetAvatarRequestData requestData, Action<InventoryResponseModels.GetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCatalogId(InventoryModels.AdminGetCatalogIdRequestData requestData, Action<InventoryResponseModels.GetCatalogIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCatalogIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getClassId(InventoryModels.AdminGetClassIdRequestData requestData, Action<InventoryResponseModels.GetClassIdOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetClassIdOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getCustomData(InventoryModels.AdminGetCustomDataRequestData requestData, Action<InventoryResponseModels.GetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getDisplayName(InventoryModels.AdminGetDisplayNameRequestData requestData, Action<InventoryResponseModels.GetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemData(InventoryModels.AdminGetItemDataRequestData requestData, Action<InventoryResponseModels.GetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemInformation(InventoryModels.AdminGetItemInformationRequestData requestData, Action<InventoryResponseModels.GetItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemStatistics(InventoryModels.AdminGetItemStatisticsRequestData requestData, Action<InventoryResponseModels.GetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithDisplayName(InventoryModels.AdminGetItemsWithDisplayNameRequestData requestData, Action<InventoryResponseModels.GetItemsWithDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithSegment(InventoryModels.AdminGetItemsWithSegmentRequestData requestData, Action<InventoryResponseModels.GetItemsWithSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemsWithTag(InventoryModels.AdminGetItemsWithTagRequestData requestData, Action<InventoryResponseModels.GetItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getItemType(InventoryModels.AdminGetItemTypeRequestData requestData, Action<InventoryResponseModels.GetItemTypeOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetItemTypeOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getOwner(InventoryModels.AdminGetOwnerRequestData requestData, Action<InventoryResponseModels.GetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getRemoveStatus(InventoryModels.AdminGetRemoveStatusRequestData requestData, Action<InventoryResponseModels.GetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getSegment(InventoryModels.AdminGetSegmentRequestData requestData, Action<InventoryResponseModels.GetSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboardAroundItem(InventoryModels.AdminGetStatisticsLeaderboardAroundItemRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardAroundItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardAroundItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getStatisticsLeaderboard(InventoryModels.AdminGetStatisticsLeaderboardRequestData requestData, Action<InventoryResponseModels.GetStatisticsLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetStatisticsLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTag(InventoryModels.AdminGetTagRequestData requestData, Action<InventoryResponseModels.GetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void getTsCreate(InventoryModels.AdminGetTsCreateRequestData requestData, Action<InventoryResponseModels.GetTsCreateOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminGetTsCreateOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeSegment(InventoryModels.AdminRemoveSegmentRequestData requestData, Action<InventoryResponseModels.RemoveSegmentOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveSegmentOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void removeTag(InventoryModels.AdminRemoveTagRequestData requestData, Action<InventoryResponseModels.RemoveTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminRemoveTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAmount(InventoryModels.AdminSetAmountRequestData requestData, Action<InventoryResponseModels.SetAmountOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAmountOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setAvatar(InventoryModels.AdminSetAvatarRequestData requestData, Action<InventoryResponseModels.SetAvatarOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetAvatarOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setCustomData(InventoryModels.AdminSetCustomDataRequestData requestData, Action<InventoryResponseModels.SetCustomDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetCustomDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setDisplayName(InventoryModels.AdminSetDisplayNameRequestData requestData, Action<InventoryResponseModels.SetDisplayNameOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetDisplayNameOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemData(InventoryModels.AdminSetItemDataRequestData requestData, Action<InventoryResponseModels.SetItemDataOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetItemDataOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setItemStatistics(InventoryModels.AdminSetItemStatisticsRequestData requestData, Action<InventoryResponseModels.SetItemStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetItemStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setOwner(InventoryModels.AdminSetOwnerRequestData requestData, Action<InventoryResponseModels.SetOwnerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetOwnerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setRemoveStatus(InventoryModels.AdminSetRemoveStatusRequestData requestData, Action<InventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

			public void setTag(InventoryModels.AdminSetTagRequestData requestData, Action<InventoryResponseModels.SetTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
			{
				GNNetwork.sendViaHttp(new InventoryRequestModels.AdminSetTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
			}

		}

	}

	public static partial class GNNetwork
	{
		
		public static InventoryApi inventory { get; }
	}

}
