namespace XmobiTea.GearN
{
    using System.Threading.Tasks;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Entity;
    using XmobiTea.GearN.Entity.Models;

    public class MultiplayerApi
    {
        public ServerApi server { get; } = new ServerApi();

        public AdminApi admin { get; } = new AdminApi();

        public void cancelAllMatchmakingTicket(MultiplayerModels.CancelAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.CancelAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> cancelAllMatchmakingTicketAsync(MultiplayerModels.CancelAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.CancelAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.CancelAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void cancelMatchmakingTicket(MultiplayerModels.CancelMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.CancelMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> cancelMatchmakingTicketAsync(MultiplayerModels.CancelMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.CancelMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.CancelMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void createMatchmakingTicket(MultiplayerModels.CreateMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.CreateMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> createMatchmakingTicketAsync(MultiplayerModels.CreateMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.CreateMatchmakingTicketOperationRequest, MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.CreateMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getMatchmakingTicket(MultiplayerModels.GetMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.GetMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> getMatchmakingTicketAsync(MultiplayerModels.GetMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.GetMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.GetMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getMatch(MultiplayerModels.GetMatchRequestData requestData, Action1<MultiplayerResponseModels.GetMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.GetMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.GetMatchOperationResponse> getMatchAsync(MultiplayerModels.GetMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.GetMatchOperationRequest, MultiplayerResponseModels.GetMatchOperationResponse>(new MultiplayerRequestModels.GetMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getQueueStatistics(MultiplayerModels.GetQueueStatisticsRequestData requestData, Action1<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.GetQueueStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> getQueueStatisticsAsync(MultiplayerModels.GetQueueStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.GetQueueStatisticsOperationRequest, MultiplayerResponseModels.GetQueueStatisticsOperationResponse>(new MultiplayerRequestModels.GetQueueStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void joinMatchmakingTicket(MultiplayerModels.JoinMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.JoinMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> joinMatchmakingTicketAsync(MultiplayerModels.JoinMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.JoinMatchmakingTicketOperationRequest, MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.JoinMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void listMatchmakingTicketsForPlayer(MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData requestData, Action1<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.ListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> listMatchmakingTicketsForPlayerAsync(MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ListMatchmakingTicketsForPlayerOperationRequest, MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse>(new MultiplayerRequestModels.ListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAllMatch(MultiplayerModels.GetAllMatchRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.GetAllMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.GetAllMatchOperationResponse> getAllMatchAsync(MultiplayerModels.GetAllMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.GetAllMatchOperationRequest, MultiplayerResponseModels.GetAllMatchOperationResponse>(new MultiplayerRequestModels.GetAllMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }

        public void getAllMatchmakingTicket(MultiplayerModels.GetAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            GNNetwork.sendViaHttp(new MultiplayerRequestModels.GetAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
        }

        public Task<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> getAllMatchmakingTicketAsync(MultiplayerModels.GetAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
        {
            return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.GetAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.GetAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
        }


        public class ServerApi
        {
            public void cancelAllMatchmakingTicket(MultiplayerModels.ServerCancelAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerCancelAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> cancelAllMatchmakingTicketAsync(MultiplayerModels.ServerCancelAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerCancelAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerCancelAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void cancelMatchmakingTicket(MultiplayerModels.ServerCancelMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerCancelMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> cancelMatchmakingTicketAsync(MultiplayerModels.ServerCancelMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerCancelMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerCancelMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createMatchmakingTicket(MultiplayerModels.ServerCreateMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerCreateMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> createMatchmakingTicketAsync(MultiplayerModels.ServerCreateMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerCreateMatchmakingTicketOperationRequest, MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerCreateMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMatchmakingTicket(MultiplayerModels.ServerGetMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerGetMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> getMatchmakingTicketAsync(MultiplayerModels.ServerGetMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerGetMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerGetMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMatch(MultiplayerModels.ServerGetMatchRequestData requestData, Action1<MultiplayerResponseModels.GetMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerGetMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetMatchOperationResponse> getMatchAsync(MultiplayerModels.ServerGetMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerGetMatchOperationRequest, MultiplayerResponseModels.GetMatchOperationResponse>(new MultiplayerRequestModels.ServerGetMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getQueueStatistics(MultiplayerModels.ServerGetQueueStatisticsRequestData requestData, Action1<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerGetQueueStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> getQueueStatisticsAsync(MultiplayerModels.ServerGetQueueStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerGetQueueStatisticsOperationRequest, MultiplayerResponseModels.GetQueueStatisticsOperationResponse>(new MultiplayerRequestModels.ServerGetQueueStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinMatchmakingTicket(MultiplayerModels.ServerJoinMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerJoinMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> joinMatchmakingTicketAsync(MultiplayerModels.ServerJoinMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerJoinMatchmakingTicketOperationRequest, MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerJoinMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void listMatchmakingTicketsForPlayer(MultiplayerModels.ServerListMatchmakingTicketsForPlayerRequestData requestData, Action1<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> listMatchmakingTicketsForPlayerAsync(MultiplayerModels.ServerListMatchmakingTicketsForPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerListMatchmakingTicketsForPlayerOperationRequest, MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse>(new MultiplayerRequestModels.ServerListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAllMatch(MultiplayerModels.ServerGetAllMatchRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerGetAllMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetAllMatchOperationResponse> getAllMatchAsync(MultiplayerModels.ServerGetAllMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerGetAllMatchOperationRequest, MultiplayerResponseModels.GetAllMatchOperationResponse>(new MultiplayerRequestModels.ServerGetAllMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAllMatchmakingTicket(MultiplayerModels.ServerGetAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.ServerGetAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> getAllMatchmakingTicketAsync(MultiplayerModels.ServerGetAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.ServerGetAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.ServerGetAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

        public class AdminApi
        {
            public void cancelAllMatchmakingTicket(MultiplayerModels.AdminCancelAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminCancelAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse> cancelAllMatchmakingTicketAsync(MultiplayerModels.AdminCancelAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminCancelAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminCancelAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void cancelMatchmakingTicket(MultiplayerModels.AdminCancelMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminCancelMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse> cancelMatchmakingTicketAsync(MultiplayerModels.AdminCancelMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminCancelMatchmakingTicketOperationRequest, MultiplayerResponseModels.CancelMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminCancelMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void createMatchmakingTicket(MultiplayerModels.AdminCreateMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminCreateMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse> createMatchmakingTicketAsync(MultiplayerModels.AdminCreateMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminCreateMatchmakingTicketOperationRequest, MultiplayerResponseModels.CreateMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminCreateMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMatchmakingTicket(MultiplayerModels.AdminGetMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminGetMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetMatchmakingTicketOperationResponse> getMatchmakingTicketAsync(MultiplayerModels.AdminGetMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminGetMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminGetMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getMatch(MultiplayerModels.AdminGetMatchRequestData requestData, Action1<MultiplayerResponseModels.GetMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminGetMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetMatchOperationResponse> getMatchAsync(MultiplayerModels.AdminGetMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminGetMatchOperationRequest, MultiplayerResponseModels.GetMatchOperationResponse>(new MultiplayerRequestModels.AdminGetMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getQueueStatistics(MultiplayerModels.AdminGetQueueStatisticsRequestData requestData, Action1<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminGetQueueStatisticsOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetQueueStatisticsOperationResponse> getQueueStatisticsAsync(MultiplayerModels.AdminGetQueueStatisticsRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminGetQueueStatisticsOperationRequest, MultiplayerResponseModels.GetQueueStatisticsOperationResponse>(new MultiplayerRequestModels.AdminGetQueueStatisticsOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void joinMatchmakingTicket(MultiplayerModels.AdminJoinMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminJoinMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse> joinMatchmakingTicketAsync(MultiplayerModels.AdminJoinMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminJoinMatchmakingTicketOperationRequest, MultiplayerResponseModels.JoinMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminJoinMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void listMatchmakingTicketsForPlayer(MultiplayerModels.AdminListMatchmakingTicketsForPlayerRequestData requestData, Action1<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse> listMatchmakingTicketsForPlayerAsync(MultiplayerModels.AdminListMatchmakingTicketsForPlayerRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminListMatchmakingTicketsForPlayerOperationRequest, MultiplayerResponseModels.ListMatchmakingTicketsForPlayerOperationResponse>(new MultiplayerRequestModels.AdminListMatchmakingTicketsForPlayerOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAllMatch(MultiplayerModels.AdminGetAllMatchRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminGetAllMatchOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetAllMatchOperationResponse> getAllMatchAsync(MultiplayerModels.AdminGetAllMatchRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminGetAllMatchOperationRequest, MultiplayerResponseModels.GetAllMatchOperationResponse>(new MultiplayerRequestModels.AdminGetAllMatchOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

            public void getAllMatchmakingTicket(MultiplayerModels.AdminGetAllMatchmakingTicketRequestData requestData, Action1<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> onResponse = null, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                GNNetwork.sendViaHttp(new MultiplayerRequestModels.AdminGetAllMatchmakingTicketOperationRequest(requestData, timeout), onResponse, overrideAuthToken, overrideSecretKey, customTags);
            }

            public Task<MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse> getAllMatchmakingTicketAsync(MultiplayerModels.AdminGetAllMatchmakingTicketRequestData requestData, string overrideAuthToken = null, string overrideSecretKey = null, GNHashtable customTags = null, int timeout = OperationRequest.defaultTimeOut)
            {
                return GNNetwork.sendViaHttpAsync<MultiplayerRequestModels.AdminGetAllMatchmakingTicketOperationRequest, MultiplayerResponseModels.GetAllMatchmakingTicketOperationResponse>(new MultiplayerRequestModels.AdminGetAllMatchmakingTicketOperationRequest(requestData, timeout), overrideAuthToken, overrideSecretKey, customTags);
            }

        }

    }

    public static partial class GNNetwork
    {

        public static MultiplayerApi multiplayer { get; }
    }

}
