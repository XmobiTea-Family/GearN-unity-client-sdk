namespace XmobiTea.GN.Entity.Models
{
    using XmobiTea.GN.Constant;
    using XmobiTea.GN.Entity.Request;

    public class MultiplayerRequestModels
    {
        public class CancelAllMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CancelAllMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.CancelAllMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public CancelAllMatchmakingTicketOperationRequest(MultiplayerModels.CancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCancelAllMatchmakingTicketOperationRequest : CancelAllMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerCancelAllMatchmakingTicketOperationRequest(MultiplayerModels.ServerCancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCancelAllMatchmakingTicketOperationRequest : CancelAllMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminCancelAllMatchmakingTicketOperationRequest(MultiplayerModels.AdminCancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CancelMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CancelMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.CancelMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public CancelMatchmakingTicketOperationRequest(MultiplayerModels.CancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCancelMatchmakingTicketOperationRequest : CancelMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerCancelMatchmakingTicketOperationRequest(MultiplayerModels.ServerCancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCancelMatchmakingTicketOperationRequest : CancelMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminCancelMatchmakingTicketOperationRequest(MultiplayerModels.AdminCancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class CreateMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CreateMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.CreateMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public CreateMatchmakingTicketOperationRequest(MultiplayerModels.CreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerCreateMatchmakingTicketOperationRequest : CreateMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerCreateMatchmakingTicketOperationRequest(MultiplayerModels.ServerCreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminCreateMatchmakingTicketOperationRequest : CreateMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminCreateMatchmakingTicketOperationRequest(MultiplayerModels.AdminCreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.GetMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.GetMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetMatchmakingTicketOperationRequest(MultiplayerModels.GetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetMatchmakingTicketOperationRequest : GetMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetMatchmakingTicketOperationRequest(MultiplayerModels.ServerGetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetMatchmakingTicketOperationRequest : GetMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetMatchmakingTicketOperationRequest(MultiplayerModels.AdminGetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetMatchOperationRequest : CustomOperationRequest<MultiplayerModels.GetMatchRequestData>
        {
            protected override int operationCode => OperationCode.GetMatch;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetMatchOperationRequest(MultiplayerModels.GetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetMatchOperationRequest : GetMatchOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetMatchOperationRequest(MultiplayerModels.ServerGetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetMatchOperationRequest : GetMatchOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetMatchOperationRequest(MultiplayerModels.AdminGetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetQueueStatisticsOperationRequest : CustomOperationRequest<MultiplayerModels.GetQueueStatisticsRequestData>
        {
            protected override int operationCode => OperationCode.GetQueueStatistics;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetQueueStatisticsOperationRequest(MultiplayerModels.GetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetQueueStatisticsOperationRequest : GetQueueStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetQueueStatisticsOperationRequest(MultiplayerModels.ServerGetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetQueueStatisticsOperationRequest : GetQueueStatisticsOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetQueueStatisticsOperationRequest(MultiplayerModels.AdminGetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class JoinMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.JoinMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.JoinMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public JoinMatchmakingTicketOperationRequest(MultiplayerModels.JoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerJoinMatchmakingTicketOperationRequest : JoinMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerJoinMatchmakingTicketOperationRequest(MultiplayerModels.ServerJoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminJoinMatchmakingTicketOperationRequest : JoinMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminJoinMatchmakingTicketOperationRequest(MultiplayerModels.AdminJoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class ListMatchmakingTicketsForPlayerOperationRequest : CustomOperationRequest<MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData>
        {
            protected override int operationCode => OperationCode.ListMatchmakingTicketsForPlayer;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public ListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerListMatchmakingTicketsForPlayerOperationRequest : ListMatchmakingTicketsForPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.ServerListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminListMatchmakingTicketsForPlayerOperationRequest : ListMatchmakingTicketsForPlayerOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.AdminListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAllMatchOperationRequest : CustomOperationRequest<MultiplayerModels.GetAllMatchRequestData>
        {
            protected override int operationCode => OperationCode.GetAllMatch;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetAllMatchOperationRequest(MultiplayerModels.GetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAllMatchOperationRequest : GetAllMatchOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetAllMatchOperationRequest(MultiplayerModels.ServerGetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAllMatchOperationRequest : GetAllMatchOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetAllMatchOperationRequest(MultiplayerModels.AdminGetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        public class GetAllMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.GetAllMatchmakingTicketRequestData>
        {
            protected override int operationCode => OperationCode.GetAllMatchmakingTicket;
            protected override bool operationEncrypted => true;
            protected override RequestType requestType => RequestType.Multiplayer;
            protected override RequestRole requestRole => RequestRole.Client;

            public GetAllMatchmakingTicketOperationRequest(MultiplayerModels.GetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class ServerGetAllMatchmakingTicketOperationRequest : GetAllMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Server;

            public ServerGetAllMatchmakingTicketOperationRequest(MultiplayerModels.ServerGetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        public class AdminGetAllMatchmakingTicketOperationRequest : GetAllMatchmakingTicketOperationRequest
        {
            protected override RequestRole requestRole => RequestRole.Admin;

            public AdminGetAllMatchmakingTicketOperationRequest(MultiplayerModels.AdminGetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }
}
