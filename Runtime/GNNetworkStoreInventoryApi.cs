namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class StoreInventoryApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void buyStoreItem(StoreInventoryModels.BuyStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.BuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.BuyStoreItemOperationResponse> buyStoreItemAsync(StoreInventoryModels.BuyStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.BuyStoreItemOperationRequest, StoreInventoryResponseModels.BuyStoreItemOperationResponse>(new StoreInventoryRequestModels.BuyStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStoreItemInformation(StoreInventoryModels.GetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> getStoreItemInformationAsync(StoreInventoryModels.GetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.GetStoreItemInformationOperationRequest, StoreInventoryResponseModels.GetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.GetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStoreItemsWithTag(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> getStoreItemsWithTagAsync(StoreInventoryModels.GetStoreItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.GetStoreItemsWithTagOperationRequest, StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse>(new StoreInventoryRequestModels.GetStoreItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createStoreItem(StoreInventoryModels.CreateStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.CreateStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.CreateStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.CreateStoreItemOperationResponse> createStoreItemAsync(StoreInventoryModels.CreateStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.CreateStoreItemOperationRequest, StoreInventoryResponseModels.CreateStoreItemOperationResponse>(new StoreInventoryRequestModels.CreateStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setRemoveStatus(StoreInventoryModels.SetRemoveStatusRequestData requestData, Action1<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(StoreInventoryModels.SetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.SetRemoveStatusOperationRequest, StoreInventoryResponseModels.SetRemoveStatusOperationResponse>(new StoreInventoryRequestModels.SetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void setStoreItemInformation(StoreInventoryModels.SetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.SetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> setStoreItemInformationAsync(StoreInventoryModels.SetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.SetStoreItemInformationOperationRequest, StoreInventoryResponseModels.SetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.SetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void validateAppleAppStoreReceipt(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> validateAppleAppStoreReceiptAsync(StoreInventoryModels.ValidateAppleAppStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ValidateAppleAppStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void validateFacebookStoreReceipt(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> validateFacebookStoreReceiptAsync(StoreInventoryModels.ValidateFacebookStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ValidateFacebookStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ValidateFacebookStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void validateGooglePlayStoreReceipt(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> validateGooglePlayStoreReceiptAsync(StoreInventoryModels.ValidateGooglePlayStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ValidateGooglePlayStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getCreateLeaderboard(StoreInventoryModels.GetCreateLeaderboardRequestData requestData, Action1<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(StoreInventoryModels.GetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.GetCreateLeaderboardOperationRequest, StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse>(new StoreInventoryRequestModels.GetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void presentStoreItem(StoreInventoryModels.PresentStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.PresentStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.PresentStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.PresentStoreItemOperationResponse> presentStoreItemAsync(StoreInventoryModels.PresentStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.PresentStoreItemOperationRequest, StoreInventoryResponseModels.PresentStoreItemOperationResponse>(new StoreInventoryRequestModels.PresentStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStoreLog(StoreInventoryModels.GetStoreLogRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.GetStoreLogOperationResponse> getStoreLogAsync(StoreInventoryModels.GetStoreLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.GetStoreLogOperationRequest, StoreInventoryResponseModels.GetStoreLogOperationResponse>(new StoreInventoryRequestModels.GetStoreLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getStoreUsed(StoreInventoryModels.GetStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.GetStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.GetStoreUsedOperationResponse> getStoreUsedAsync(StoreInventoryModels.GetStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.GetStoreUsedOperationRequest, StoreInventoryResponseModels.GetStoreUsedOperationResponse>(new StoreInventoryRequestModels.GetStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void removeStoreUsed(StoreInventoryModels.RemoveStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new StoreInventoryRequestModels.RemoveStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> removeStoreUsedAsync(StoreInventoryModels.RemoveStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.RemoveStoreUsedOperationRequest, StoreInventoryResponseModels.RemoveStoreUsedOperationResponse>(new StoreInventoryRequestModels.RemoveStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public class ServerApi
        {
            public void buyStoreItem(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerBuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.BuyStoreItemOperationResponse> buyStoreItemAsync(StoreInventoryModels.ServerBuyStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerBuyStoreItemOperationRequest, StoreInventoryResponseModels.BuyStoreItemOperationResponse>(new StoreInventoryRequestModels.ServerBuyStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreItemInformation(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> getStoreItemInformationAsync(StoreInventoryModels.ServerGetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerGetStoreItemInformationOperationRequest, StoreInventoryResponseModels.GetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.ServerGetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreItemsWithTag(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> getStoreItemsWithTagAsync(StoreInventoryModels.ServerGetStoreItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerGetStoreItemsWithTagOperationRequest, StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse>(new StoreInventoryRequestModels.ServerGetStoreItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createStoreItem(StoreInventoryModels.ServerCreateStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.CreateStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerCreateStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.CreateStoreItemOperationResponse> createStoreItemAsync(StoreInventoryModels.ServerCreateStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerCreateStoreItemOperationRequest, StoreInventoryResponseModels.CreateStoreItemOperationResponse>(new StoreInventoryRequestModels.ServerCreateStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, Action1<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(StoreInventoryModels.ServerSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerSetRemoveStatusOperationRequest, StoreInventoryResponseModels.SetRemoveStatusOperationResponse>(new StoreInventoryRequestModels.ServerSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setStoreItemInformation(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerSetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> setStoreItemInformationAsync(StoreInventoryModels.ServerSetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerSetStoreItemInformationOperationRequest, StoreInventoryResponseModels.SetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.ServerSetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateAppleAppStoreReceipt(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> validateAppleAppStoreReceiptAsync(StoreInventoryModels.ServerValidateAppleAppStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerValidateAppleAppStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ServerValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateFacebookStoreReceipt(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> validateFacebookStoreReceiptAsync(StoreInventoryModels.ServerValidateFacebookStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerValidateFacebookStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ServerValidateFacebookStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateGooglePlayStoreReceipt(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> validateGooglePlayStoreReceiptAsync(StoreInventoryModels.ServerValidateGooglePlayStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerValidateGooglePlayStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse>(new StoreInventoryRequestModels.ServerValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(StoreInventoryModels.ServerGetCreateLeaderboardRequestData requestData, Action1<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(StoreInventoryModels.ServerGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerGetCreateLeaderboardOperationRequest, StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse>(new StoreInventoryRequestModels.ServerGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void presentStoreItem(StoreInventoryModels.ServerPresentStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.PresentStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerPresentStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.PresentStoreItemOperationResponse> presentStoreItemAsync(StoreInventoryModels.ServerPresentStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerPresentStoreItemOperationRequest, StoreInventoryResponseModels.PresentStoreItemOperationResponse>(new StoreInventoryRequestModels.ServerPresentStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreLog(StoreInventoryModels.ServerGetStoreLogRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreLogOperationResponse> getStoreLogAsync(StoreInventoryModels.ServerGetStoreLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerGetStoreLogOperationRequest, StoreInventoryResponseModels.GetStoreLogOperationResponse>(new StoreInventoryRequestModels.ServerGetStoreLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreUsed(StoreInventoryModels.ServerGetStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerGetStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreUsedOperationResponse> getStoreUsedAsync(StoreInventoryModels.ServerGetStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerGetStoreUsedOperationRequest, StoreInventoryResponseModels.GetStoreUsedOperationResponse>(new StoreInventoryRequestModels.ServerGetStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeStoreUsed(StoreInventoryModels.ServerRemoveStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.ServerRemoveStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> removeStoreUsedAsync(StoreInventoryModels.ServerRemoveStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.ServerRemoveStoreUsedOperationRequest, StoreInventoryResponseModels.RemoveStoreUsedOperationResponse>(new StoreInventoryRequestModels.ServerRemoveStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void buyStoreItem(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.BuyStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminBuyStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.BuyStoreItemOperationResponse> buyStoreItemAsync(StoreInventoryModels.AdminBuyStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminBuyStoreItemOperationRequest, StoreInventoryResponseModels.BuyStoreItemOperationResponse>(new StoreInventoryRequestModels.AdminBuyStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreItemInformation(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreItemInformationOperationResponse> getStoreItemInformationAsync(StoreInventoryModels.AdminGetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminGetStoreItemInformationOperationRequest, StoreInventoryResponseModels.GetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.AdminGetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreItemsWithTag(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreItemsWithTagOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse> getStoreItemsWithTagAsync(StoreInventoryModels.AdminGetStoreItemsWithTagRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminGetStoreItemsWithTagOperationRequest, StoreInventoryResponseModels.GetStoreItemsWithTagOperationResponse>(new StoreInventoryRequestModels.AdminGetStoreItemsWithTagOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createStoreItem(StoreInventoryModels.AdminCreateStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.CreateStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminCreateStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.CreateStoreItemOperationResponse> createStoreItemAsync(StoreInventoryModels.AdminCreateStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminCreateStoreItemOperationRequest, StoreInventoryResponseModels.CreateStoreItemOperationResponse>(new StoreInventoryRequestModels.AdminCreateStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setRemoveStatus(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, Action1<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.SetRemoveStatusOperationResponse> setRemoveStatusAsync(StoreInventoryModels.AdminSetRemoveStatusRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminSetRemoveStatusOperationRequest, StoreInventoryResponseModels.SetRemoveStatusOperationResponse>(new StoreInventoryRequestModels.AdminSetRemoveStatusOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void setStoreItemInformation(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, Action1<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminSetStoreItemInformationOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.SetStoreItemInformationOperationResponse> setStoreItemInformationAsync(StoreInventoryModels.AdminSetStoreItemInformationRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminSetStoreItemInformationOperationRequest, StoreInventoryResponseModels.SetStoreItemInformationOperationResponse>(new StoreInventoryRequestModels.AdminSetStoreItemInformationOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateAppleAppStoreReceipt(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse> validateAppleAppStoreReceiptAsync(StoreInventoryModels.AdminValidateAppleAppStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminValidateAppleAppStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateAppleAppStoreReceiptOperationResponse>(new StoreInventoryRequestModels.AdminValidateAppleAppStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateFacebookStoreReceipt(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateFacebookStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse> validateFacebookStoreReceiptAsync(StoreInventoryModels.AdminValidateFacebookStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminValidateFacebookStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateFacebookStoreReceiptOperationResponse>(new StoreInventoryRequestModels.AdminValidateFacebookStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void validateGooglePlayStoreReceipt(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, Action1<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse> validateGooglePlayStoreReceiptAsync(StoreInventoryModels.AdminValidateGooglePlayStoreReceiptRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminValidateGooglePlayStoreReceiptOperationRequest, StoreInventoryResponseModels.ValidateGooglePlayStoreReceiptOperationResponse>(new StoreInventoryRequestModels.AdminValidateGooglePlayStoreReceiptOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getCreateLeaderboard(StoreInventoryModels.AdminGetCreateLeaderboardRequestData requestData, Action1<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse> getCreateLeaderboardAsync(StoreInventoryModels.AdminGetCreateLeaderboardRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminGetCreateLeaderboardOperationRequest, StoreInventoryResponseModels.GetCreateLeaderboardOperationResponse>(new StoreInventoryRequestModels.AdminGetCreateLeaderboardOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void presentStoreItem(StoreInventoryModels.AdminPresentStoreItemRequestData requestData, Action1<StoreInventoryResponseModels.PresentStoreItemOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminPresentStoreItemOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.PresentStoreItemOperationResponse> presentStoreItemAsync(StoreInventoryModels.AdminPresentStoreItemRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminPresentStoreItemOperationRequest, StoreInventoryResponseModels.PresentStoreItemOperationResponse>(new StoreInventoryRequestModels.AdminPresentStoreItemOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreLog(StoreInventoryModels.AdminGetStoreLogRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreLogOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreLogOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreLogOperationResponse> getStoreLogAsync(StoreInventoryModels.AdminGetStoreLogRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminGetStoreLogOperationRequest, StoreInventoryResponseModels.GetStoreLogOperationResponse>(new StoreInventoryRequestModels.AdminGetStoreLogOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getStoreUsed(StoreInventoryModels.AdminGetStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.GetStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminGetStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.GetStoreUsedOperationResponse> getStoreUsedAsync(StoreInventoryModels.AdminGetStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminGetStoreUsedOperationRequest, StoreInventoryResponseModels.GetStoreUsedOperationResponse>(new StoreInventoryRequestModels.AdminGetStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void removeStoreUsed(StoreInventoryModels.AdminRemoveStoreUsedRequestData requestData, Action1<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new StoreInventoryRequestModels.AdminRemoveStoreUsedOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<StoreInventoryResponseModels.RemoveStoreUsedOperationResponse> removeStoreUsedAsync(StoreInventoryModels.AdminRemoveStoreUsedRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<StoreInventoryRequestModels.AdminRemoveStoreUsedOperationRequest, StoreInventoryResponseModels.RemoveStoreUsedOperationResponse>(new StoreInventoryRequestModels.AdminRemoveStoreUsedOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static StoreInventoryApi storeInventory { get; }
    }

}
