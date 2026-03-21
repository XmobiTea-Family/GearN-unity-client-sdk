namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for multiplayer operations.
    /// </summary>
    public class MultiplayerRequestModels
    {
        /// <summary>
        /// Builds the cancel all matchmaking ticket operation request.
        /// </summary>
        public class CancelAllMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CancelAllMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CancelAllMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CancelAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public CancelAllMatchmakingTicketOperationRequest(MultiplayerModels.CancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped cancel all matchmaking ticket operation request.
        /// </summary>
        public class ServerCancelAllMatchmakingTicketOperationRequest : CancelAllMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCancelAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerCancelAllMatchmakingTicketOperationRequest(MultiplayerModels.ServerCancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped cancel all matchmaking ticket operation request.
        /// </summary>
        public class AdminCancelAllMatchmakingTicketOperationRequest : CancelAllMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCancelAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminCancelAllMatchmakingTicketOperationRequest(MultiplayerModels.AdminCancelAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the cancel matchmaking ticket operation request.
        /// </summary>
        public class CancelMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CancelMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CancelMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CancelMatchmakingTicketOperationRequest class.
            /// </summary>
            public CancelMatchmakingTicketOperationRequest(MultiplayerModels.CancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped cancel matchmaking ticket operation request.
        /// </summary>
        public class ServerCancelMatchmakingTicketOperationRequest : CancelMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCancelMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerCancelMatchmakingTicketOperationRequest(MultiplayerModels.ServerCancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped cancel matchmaking ticket operation request.
        /// </summary>
        public class AdminCancelMatchmakingTicketOperationRequest : CancelMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCancelMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminCancelMatchmakingTicketOperationRequest(MultiplayerModels.AdminCancelMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the create matchmaking ticket operation request.
        /// </summary>
        public class CreateMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.CreateMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.CreateMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the CreateMatchmakingTicketOperationRequest class.
            /// </summary>
            public CreateMatchmakingTicketOperationRequest(MultiplayerModels.CreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped create matchmaking ticket operation request.
        /// </summary>
        public class ServerCreateMatchmakingTicketOperationRequest : CreateMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerCreateMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerCreateMatchmakingTicketOperationRequest(MultiplayerModels.ServerCreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped create matchmaking ticket operation request.
        /// </summary>
        public class AdminCreateMatchmakingTicketOperationRequest : CreateMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminCreateMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminCreateMatchmakingTicketOperationRequest(MultiplayerModels.AdminCreateMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get matchmaking ticket operation request.
        /// </summary>
        public class GetMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.GetMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetMatchmakingTicketOperationRequest class.
            /// </summary>
            public GetMatchmakingTicketOperationRequest(MultiplayerModels.GetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get matchmaking ticket operation request.
        /// </summary>
        public class ServerGetMatchmakingTicketOperationRequest : GetMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerGetMatchmakingTicketOperationRequest(MultiplayerModels.ServerGetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get matchmaking ticket operation request.
        /// </summary>
        public class AdminGetMatchmakingTicketOperationRequest : GetMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminGetMatchmakingTicketOperationRequest(MultiplayerModels.AdminGetMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get match operation request.
        /// </summary>
        public class GetMatchOperationRequest : CustomOperationRequest<MultiplayerModels.GetMatchRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetMatch;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetMatchOperationRequest class.
            /// </summary>
            public GetMatchOperationRequest(MultiplayerModels.GetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get match operation request.
        /// </summary>
        public class ServerGetMatchOperationRequest : GetMatchOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetMatchOperationRequest class.
            /// </summary>
            public ServerGetMatchOperationRequest(MultiplayerModels.ServerGetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get match operation request.
        /// </summary>
        public class AdminGetMatchOperationRequest : GetMatchOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetMatchOperationRequest class.
            /// </summary>
            public AdminGetMatchOperationRequest(MultiplayerModels.AdminGetMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get queue statistics operation request.
        /// </summary>
        public class GetQueueStatisticsOperationRequest : CustomOperationRequest<MultiplayerModels.GetQueueStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetQueueStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetQueueStatisticsOperationRequest class.
            /// </summary>
            public GetQueueStatisticsOperationRequest(MultiplayerModels.GetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get queue statistics operation request.
        /// </summary>
        public class ServerGetQueueStatisticsOperationRequest : GetQueueStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetQueueStatisticsOperationRequest class.
            /// </summary>
            public ServerGetQueueStatisticsOperationRequest(MultiplayerModels.ServerGetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get queue statistics operation request.
        /// </summary>
        public class AdminGetQueueStatisticsOperationRequest : GetQueueStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetQueueStatisticsOperationRequest class.
            /// </summary>
            public AdminGetQueueStatisticsOperationRequest(MultiplayerModels.AdminGetQueueStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the join matchmaking ticket operation request.
        /// </summary>
        public class JoinMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.JoinMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.JoinMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the JoinMatchmakingTicketOperationRequest class.
            /// </summary>
            public JoinMatchmakingTicketOperationRequest(MultiplayerModels.JoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped join matchmaking ticket operation request.
        /// </summary>
        public class ServerJoinMatchmakingTicketOperationRequest : JoinMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerJoinMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerJoinMatchmakingTicketOperationRequest(MultiplayerModels.ServerJoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped join matchmaking ticket operation request.
        /// </summary>
        public class AdminJoinMatchmakingTicketOperationRequest : JoinMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminJoinMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminJoinMatchmakingTicketOperationRequest(MultiplayerModels.AdminJoinMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the list matchmaking tickets for player operation request.
        /// </summary>
        public class ListMatchmakingTicketsForPlayerOperationRequest : CustomOperationRequest<MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ListMatchmakingTicketsForPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ListMatchmakingTicketsForPlayerOperationRequest class.
            /// </summary>
            public ListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.ListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped list matchmaking tickets for player operation request.
        /// </summary>
        public class ServerListMatchmakingTicketsForPlayerOperationRequest : ListMatchmakingTicketsForPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerListMatchmakingTicketsForPlayerOperationRequest class.
            /// </summary>
            public ServerListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.ServerListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped list matchmaking tickets for player operation request.
        /// </summary>
        public class AdminListMatchmakingTicketsForPlayerOperationRequest : ListMatchmakingTicketsForPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminListMatchmakingTicketsForPlayerOperationRequest class.
            /// </summary>
            public AdminListMatchmakingTicketsForPlayerOperationRequest(MultiplayerModels.AdminListMatchmakingTicketsForPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get all match operation request.
        /// </summary>
        public class GetAllMatchOperationRequest : CustomOperationRequest<MultiplayerModels.GetAllMatchRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAllMatch;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAllMatchOperationRequest class.
            /// </summary>
            public GetAllMatchOperationRequest(MultiplayerModels.GetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get all match operation request.
        /// </summary>
        public class ServerGetAllMatchOperationRequest : GetAllMatchOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAllMatchOperationRequest class.
            /// </summary>
            public ServerGetAllMatchOperationRequest(MultiplayerModels.ServerGetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get all match operation request.
        /// </summary>
        public class AdminGetAllMatchOperationRequest : GetAllMatchOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAllMatchOperationRequest class.
            /// </summary>
            public AdminGetAllMatchOperationRequest(MultiplayerModels.AdminGetAllMatchRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get all matchmaking ticket operation request.
        /// </summary>
        public class GetAllMatchmakingTicketOperationRequest : CustomOperationRequest<MultiplayerModels.GetAllMatchmakingTicketRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAllMatchmakingTicket;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.Multiplayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public GetAllMatchmakingTicketOperationRequest(MultiplayerModels.GetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get all matchmaking ticket operation request.
        /// </summary>
        public class ServerGetAllMatchmakingTicketOperationRequest : GetAllMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public ServerGetAllMatchmakingTicketOperationRequest(MultiplayerModels.ServerGetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get all matchmaking ticket operation request.
        /// </summary>
        public class AdminGetAllMatchmakingTicketOperationRequest : GetAllMatchmakingTicketOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAllMatchmakingTicketOperationRequest class.
            /// </summary>
            public AdminGetAllMatchmakingTicketOperationRequest(MultiplayerModels.AdminGetAllMatchmakingTicketRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }
}