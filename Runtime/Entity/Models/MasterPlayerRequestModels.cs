namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Constant;
    using XmobiTea.GearN.Entity.Request;

    /// <summary>
    /// Defines typed request wrappers for master player operations.
    /// </summary>
    public class MasterPlayerRequestModels
    {
        /// <summary>
        /// Builds the add segment operation request.
        /// </summary>
        public class AddSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.AddSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddSegmentOperationRequest class.
            /// </summary>
            public AddSegmentOperationRequest(MasterPlayerModels.AddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add segment operation request.
        /// </summary>
        public class ServerAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddSegmentOperationRequest class.
            /// </summary>
            public ServerAddSegmentOperationRequest(MasterPlayerModels.ServerAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add segment operation request.
        /// </summary>
        public class AdminAddSegmentOperationRequest : AddSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddSegmentOperationRequest class.
            /// </summary>
            public AdminAddSegmentOperationRequest(MasterPlayerModels.AdminAddSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change account password operation request.
        /// </summary>
        public class ChangeAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangeAccountPasswordRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangeAccountPassword;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangeAccountPasswordOperationRequest class.
            /// </summary>
            public ChangeAccountPasswordOperationRequest(MasterPlayerModels.ChangeAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get avatar operation request.
        /// </summary>
        public class GetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.GetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetAvatarOperationRequest class.
            /// </summary>
            public GetAvatarOperationRequest(MasterPlayerModels.GetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get avatar operation request.
        /// </summary>
        public class ServerGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetAvatarOperationRequest class.
            /// </summary>
            public ServerGetAvatarOperationRequest(MasterPlayerModels.ServerGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get avatar operation request.
        /// </summary>
        public class AdminGetAvatarOperationRequest : GetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetAvatarOperationRequest class.
            /// </summary>
            public AdminGetAvatarOperationRequest(MasterPlayerModels.AdminGetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get country code operation request.
        /// </summary>
        public class GetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCountryCodeOperationRequest class.
            /// </summary>
            public GetCountryCodeOperationRequest(MasterPlayerModels.GetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get country code operation request.
        /// </summary>
        public class ServerGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCountryCodeOperationRequest class.
            /// </summary>
            public ServerGetCountryCodeOperationRequest(MasterPlayerModels.ServerGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get country code operation request.
        /// </summary>
        public class AdminGetCountryCodeOperationRequest : GetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCountryCodeOperationRequest class.
            /// </summary>
            public AdminGetCountryCodeOperationRequest(MasterPlayerModels.AdminGetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get custom data operation request.
        /// </summary>
        public class GetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCustomDataOperationRequest class.
            /// </summary>
            public GetCustomDataOperationRequest(MasterPlayerModels.GetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get custom data operation request.
        /// </summary>
        public class ServerGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCustomDataOperationRequest class.
            /// </summary>
            public ServerGetCustomDataOperationRequest(MasterPlayerModels.ServerGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get custom data operation request.
        /// </summary>
        public class AdminGetCustomDataOperationRequest : GetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCustomDataOperationRequest class.
            /// </summary>
            public AdminGetCustomDataOperationRequest(MasterPlayerModels.AdminGetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get display name operation request.
        /// </summary>
        public class GetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetDisplayNameOperationRequest class.
            /// </summary>
            public GetDisplayNameOperationRequest(MasterPlayerModels.GetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get display name operation request.
        /// </summary>
        public class ServerGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetDisplayNameOperationRequest(MasterPlayerModels.ServerGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get display name operation request.
        /// </summary>
        public class AdminGetDisplayNameOperationRequest : GetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetDisplayNameOperationRequest(MasterPlayerModels.AdminGetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get email operation request.
        /// </summary>
        public class GetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.GetEmailRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetEmail;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetEmailOperationRequest class.
            /// </summary>
            public GetEmailOperationRequest(MasterPlayerModels.GetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get email operation request.
        /// </summary>
        public class ServerGetEmailOperationRequest : GetEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetEmailOperationRequest class.
            /// </summary>
            public ServerGetEmailOperationRequest(MasterPlayerModels.ServerGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get email operation request.
        /// </summary>
        public class AdminGetEmailOperationRequest : GetEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetEmailOperationRequest class.
            /// </summary>
            public AdminGetEmailOperationRequest(MasterPlayerModels.AdminGetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get external operation request.
        /// </summary>
        public class GetExternalOperationRequest : CustomOperationRequest<MasterPlayerModels.GetExternalRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetExternal;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetExternalOperationRequest class.
            /// </summary>
            public GetExternalOperationRequest(MasterPlayerModels.GetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get external operation request.
        /// </summary>
        public class ServerGetExternalOperationRequest : GetExternalOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetExternalOperationRequest class.
            /// </summary>
            public ServerGetExternalOperationRequest(MasterPlayerModels.ServerGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get external operation request.
        /// </summary>
        public class AdminGetExternalOperationRequest : GetExternalOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetExternalOperationRequest class.
            /// </summary>
            public AdminGetExternalOperationRequest(MasterPlayerModels.AdminGetExternalRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get IP address create operation request.
        /// </summary>
        public class GetIpAddressCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetIpAddressCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetIpAddressCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetIpAddressCreateOperationRequest class.
            /// </summary>
            public GetIpAddressCreateOperationRequest(MasterPlayerModels.GetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get IP address create operation request.
        /// </summary>
        public class ServerGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetIpAddressCreateOperationRequest class.
            /// </summary>
            public ServerGetIpAddressCreateOperationRequest(MasterPlayerModels.ServerGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get IP address create operation request.
        /// </summary>
        public class AdminGetIpAddressCreateOperationRequest : GetIpAddressCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetIpAddressCreateOperationRequest class.
            /// </summary>
            public AdminGetIpAddressCreateOperationRequest(MasterPlayerModels.AdminGetIpAddressCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player ban operation request.
        /// </summary>
        public class GetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerBanOperationRequest class.
            /// </summary>
            public GetPlayerBanOperationRequest(MasterPlayerModels.GetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player ban operation request.
        /// </summary>
        public class ServerGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerBanOperationRequest class.
            /// </summary>
            public ServerGetPlayerBanOperationRequest(MasterPlayerModels.ServerGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player ban operation request.
        /// </summary>
        public class AdminGetPlayerBanOperationRequest : GetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerBanOperationRequest class.
            /// </summary>
            public AdminGetPlayerBanOperationRequest(MasterPlayerModels.AdminGetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player currency operation request.
        /// </summary>
        public class GetPlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerCurrencyOperationRequest class.
            /// </summary>
            public GetPlayerCurrencyOperationRequest(MasterPlayerModels.GetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player currency operation request.
        /// </summary>
        public class ServerGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerCurrencyOperationRequest class.
            /// </summary>
            public ServerGetPlayerCurrencyOperationRequest(MasterPlayerModels.ServerGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player currency operation request.
        /// </summary>
        public class AdminGetPlayerCurrencyOperationRequest : GetPlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerCurrencyOperationRequest class.
            /// </summary>
            public AdminGetPlayerCurrencyOperationRequest(MasterPlayerModels.AdminGetPlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player data operation request.
        /// </summary>
        public class GetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerDataOperationRequest class.
            /// </summary>
            public GetPlayerDataOperationRequest(MasterPlayerModels.GetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player data operation request.
        /// </summary>
        public class ServerGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerDataOperationRequest class.
            /// </summary>
            public ServerGetPlayerDataOperationRequest(MasterPlayerModels.ServerGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player data operation request.
        /// </summary>
        public class AdminGetPlayerDataOperationRequest : GetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerDataOperationRequest class.
            /// </summary>
            public AdminGetPlayerDataOperationRequest(MasterPlayerModels.AdminGetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player information operation request.
        /// </summary>
        public class GetPlayerInformationOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerInformationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerInformation;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerInformationOperationRequest class.
            /// </summary>
            public GetPlayerInformationOperationRequest(MasterPlayerModels.GetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player information operation request.
        /// </summary>
        public class ServerGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerInformationOperationRequest class.
            /// </summary>
            public ServerGetPlayerInformationOperationRequest(MasterPlayerModels.ServerGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player information operation request.
        /// </summary>
        public class AdminGetPlayerInformationOperationRequest : GetPlayerInformationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerInformationOperationRequest class.
            /// </summary>
            public AdminGetPlayerInformationOperationRequest(MasterPlayerModels.AdminGetPlayerInformationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get player statistics operation request.
        /// </summary>
        public class GetPlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayerStatisticsOperationRequest class.
            /// </summary>
            public GetPlayerStatisticsOperationRequest(MasterPlayerModels.GetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get player statistics operation request.
        /// </summary>
        public class ServerGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayerStatisticsOperationRequest class.
            /// </summary>
            public ServerGetPlayerStatisticsOperationRequest(MasterPlayerModels.ServerGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get player statistics operation request.
        /// </summary>
        public class AdminGetPlayerStatisticsOperationRequest : GetPlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayerStatisticsOperationRequest class.
            /// </summary>
            public AdminGetPlayerStatisticsOperationRequest(MasterPlayerModels.AdminGetPlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with apple operation request.
        /// </summary>
        public class GetPlayersWithAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithAppleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithApple;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithAppleOperationRequest class.
            /// </summary>
            public GetPlayersWithAppleOperationRequest(MasterPlayerModels.GetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with apple operation request.
        /// </summary>
        public class ServerGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithAppleOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithAppleOperationRequest(MasterPlayerModels.ServerGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with apple operation request.
        /// </summary>
        public class AdminGetPlayersWithAppleOperationRequest : GetPlayersWithAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithAppleOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithAppleOperationRequest(MasterPlayerModels.AdminGetPlayersWithAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with display name operation request.
        /// </summary>
        public class GetPlayersWithDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public GetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.GetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with display name operation request.
        /// </summary>
        public class ServerGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.ServerGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with display name operation request.
        /// </summary>
        public class AdminGetPlayersWithDisplayNameOperationRequest : GetPlayersWithDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithDisplayNameOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithDisplayNameOperationRequest(MasterPlayerModels.AdminGetPlayersWithDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with facebook operation request.
        /// </summary>
        public class GetPlayersWithFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithFacebookRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithFacebook;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithFacebookOperationRequest class.
            /// </summary>
            public GetPlayersWithFacebookOperationRequest(MasterPlayerModels.GetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with facebook operation request.
        /// </summary>
        public class ServerGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithFacebookOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithFacebookOperationRequest(MasterPlayerModels.ServerGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with facebook operation request.
        /// </summary>
        public class AdminGetPlayersWithFacebookOperationRequest : GetPlayersWithFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithFacebookOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithFacebookOperationRequest(MasterPlayerModels.AdminGetPlayersWithFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with generic service operation request.
        /// </summary>
        public class GetPlayersWithGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGenericServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithGenericService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithGenericServiceOperationRequest class.
            /// </summary>
            public GetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.GetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with generic service operation request.
        /// </summary>
        public class ServerGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithGenericServiceOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.ServerGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with generic service operation request.
        /// </summary>
        public class AdminGetPlayersWithGenericServiceOperationRequest : GetPlayersWithGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithGenericServiceOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithGenericServiceOperationRequest(MasterPlayerModels.AdminGetPlayersWithGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with google operation request.
        /// </summary>
        public class GetPlayersWithGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGoogleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithGoogle;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithGoogleOperationRequest class.
            /// </summary>
            public GetPlayersWithGoogleOperationRequest(MasterPlayerModels.GetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with google operation request.
        /// </summary>
        public class ServerGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithGoogleOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithGoogleOperationRequest(MasterPlayerModels.ServerGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with google operation request.
        /// </summary>
        public class AdminGetPlayersWithGoogleOperationRequest : GetPlayersWithGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithGoogleOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithGoogleOperationRequest(MasterPlayerModels.AdminGetPlayersWithGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with google play game service operation request.
        /// </summary>
        public class GetPlayersWithGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithGooglePlayGameService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public GetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.GetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with google play game service operation request.
        /// </summary>
        public class ServerGetPlayersWithGooglePlayGameServiceOperationRequest : GetPlayersWithGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerGetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with google play game service operation request.
        /// </summary>
        public class AdminGetPlayersWithGooglePlayGameServiceOperationRequest : GetPlayersWithGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminGetPlayersWithGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with game center operation request.
        /// </summary>
        public class GetPlayersWithGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithGameCenterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithGameCenter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithGameCenterOperationRequest class.
            /// </summary>
            public GetPlayersWithGameCenterOperationRequest(MasterPlayerModels.GetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with game center operation request.
        /// </summary>
        public class ServerGetPlayersWithGameCenterOperationRequest : GetPlayersWithGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithGameCenterOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithGameCenterOperationRequest(MasterPlayerModels.ServerGetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with game center operation request.
        /// </summary>
        public class AdminGetPlayersWithGameCenterOperationRequest : GetPlayersWithGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithGameCenterOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithGameCenterOperationRequest(MasterPlayerModels.AdminGetPlayersWithGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with segment operation request.
        /// </summary>
        public class GetPlayersWithSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public GetPlayersWithSegmentOperationRequest(MasterPlayerModels.GetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with segment operation request.
        /// </summary>
        public class ServerGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithSegmentOperationRequest(MasterPlayerModels.ServerGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with segment operation request.
        /// </summary>
        public class AdminGetPlayersWithSegmentOperationRequest : GetPlayersWithSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithSegmentOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithSegmentOperationRequest(MasterPlayerModels.AdminGetPlayersWithSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get players with tag operation request.
        /// </summary>
        public class GetPlayersWithTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPlayersWithTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPlayersWithTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPlayersWithTagOperationRequest class.
            /// </summary>
            public GetPlayersWithTagOperationRequest(MasterPlayerModels.GetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get players with tag operation request.
        /// </summary>
        public class ServerGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPlayersWithTagOperationRequest class.
            /// </summary>
            public ServerGetPlayersWithTagOperationRequest(MasterPlayerModels.ServerGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get players with tag operation request.
        /// </summary>
        public class AdminGetPlayersWithTagOperationRequest : GetPlayersWithTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPlayersWithTagOperationRequest class.
            /// </summary>
            public AdminGetPlayersWithTagOperationRequest(MasterPlayerModels.AdminGetPlayersWithTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get segment operation request.
        /// </summary>
        public class GetSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.GetSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetSegmentOperationRequest class.
            /// </summary>
            public GetSegmentOperationRequest(MasterPlayerModels.GetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get segment operation request.
        /// </summary>
        public class ServerGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetSegmentOperationRequest class.
            /// </summary>
            public ServerGetSegmentOperationRequest(MasterPlayerModels.ServerGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get segment operation request.
        /// </summary>
        public class AdminGetSegmentOperationRequest : GetSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetSegmentOperationRequest class.
            /// </summary>
            public AdminGetSegmentOperationRequest(MasterPlayerModels.AdminGetSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard around player operation request.
        /// </summary>
        public class GetStatisticsLeaderboardAroundPlayerOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboardAroundPlayer;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard around player operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard around player operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardAroundPlayerOperationRequest : GetStatisticsLeaderboardAroundPlayerOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardAroundPlayerOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardAroundPlayerOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardAroundPlayerRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get statistics leaderboard operation request.
        /// </summary>
        public class GetStatisticsLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public GetStatisticsLeaderboardOperationRequest(MasterPlayerModels.GetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics leaderboard operation request.
        /// </summary>
        public class ServerGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.ServerGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics leaderboard operation request.
        /// </summary>
        public class AdminGetStatisticsLeaderboardOperationRequest : GetStatisticsLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLeaderboardOperationRequest(MasterPlayerModels.AdminGetStatisticsLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get tag operation request.
        /// </summary>
        public class GetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTagOperationRequest class.
            /// </summary>
            public GetTagOperationRequest(MasterPlayerModels.GetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get tag operation request.
        /// </summary>
        public class ServerGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTagOperationRequest class.
            /// </summary>
            public ServerGetTagOperationRequest(MasterPlayerModels.ServerGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get tag operation request.
        /// </summary>
        public class AdminGetTagOperationRequest : GetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTagOperationRequest class.
            /// </summary>
            public AdminGetTagOperationRequest(MasterPlayerModels.AdminGetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp create operation request.
        /// </summary>
        public class GetTsCreateOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsCreateRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsCreate;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsCreateOperationRequest class.
            /// </summary>
            public GetTsCreateOperationRequest(MasterPlayerModels.GetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get timestamp create operation request.
        /// </summary>
        public class ServerGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTsCreateOperationRequest class.
            /// </summary>
            public ServerGetTsCreateOperationRequest(MasterPlayerModels.ServerGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get timestamp create operation request.
        /// </summary>
        public class AdminGetTsCreateOperationRequest : GetTsCreateOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTsCreateOperationRequest class.
            /// </summary>
            public AdminGetTsCreateOperationRequest(MasterPlayerModels.AdminGetTsCreateRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the get timestamp last login operation request.
        /// </summary>
        public class GetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.GetTsLastLoginRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetTsLastLogin;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetTsLastLoginOperationRequest class.
            /// </summary>
            public GetTsLastLoginOperationRequest(MasterPlayerModels.GetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get timestamp last login operation request.
        /// </summary>
        public class ServerGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetTsLastLoginOperationRequest class.
            /// </summary>
            public ServerGetTsLastLoginOperationRequest(MasterPlayerModels.ServerGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get timestamp last login operation request.
        /// </summary>
        public class AdminGetTsLastLoginOperationRequest : GetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetTsLastLoginOperationRequest class.
            /// </summary>
            public AdminGetTsLastLoginOperationRequest(MasterPlayerModels.AdminGetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link account operation request.
        /// </summary>
        public class LinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkAccountOperationRequest class.
            /// </summary>
            public LinkAccountOperationRequest(MasterPlayerModels.LinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link account operation request.
        /// </summary>
        public class ServerLinkAccountOperationRequest : LinkAccountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkAccountOperationRequest class.
            /// </summary>
            public ServerLinkAccountOperationRequest(MasterPlayerModels.ServerLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link account operation request.
        /// </summary>
        public class AdminLinkAccountOperationRequest : LinkAccountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkAccountOperationRequest class.
            /// </summary>
            public AdminLinkAccountOperationRequest(MasterPlayerModels.AdminLinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link android device ID operation request.
        /// </summary>
        public class LinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAndroidDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkAndroidDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public LinkAndroidDeviceIdOperationRequest(MasterPlayerModels.LinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link android device ID operation request.
        /// </summary>
        public class ServerLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link android device ID operation request.
        /// </summary>
        public class AdminLinkAndroidDeviceIdOperationRequest : LinkAndroidDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminLinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link apple operation request.
        /// </summary>
        public class LinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkAppleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkApple;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkAppleOperationRequest class.
            /// </summary>
            public LinkAppleOperationRequest(MasterPlayerModels.LinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link apple operation request.
        /// </summary>
        public class ServerLinkAppleOperationRequest : LinkAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkAppleOperationRequest class.
            /// </summary>
            public ServerLinkAppleOperationRequest(MasterPlayerModels.ServerLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link apple operation request.
        /// </summary>
        public class AdminLinkAppleOperationRequest : LinkAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkAppleOperationRequest class.
            /// </summary>
            public AdminLinkAppleOperationRequest(MasterPlayerModels.AdminLinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link custom device ID operation request.
        /// </summary>
        public class LinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkCustomDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public LinkCustomDeviceIdOperationRequest(MasterPlayerModels.LinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link custom device ID operation request.
        /// </summary>
        public class ServerLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link custom device ID operation request.
        /// </summary>
        public class AdminLinkCustomDeviceIdOperationRequest : LinkCustomDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminLinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link custom ID operation request.
        /// </summary>
        public class LinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkCustomIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkCustomId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkCustomIdOperationRequest class.
            /// </summary>
            public LinkCustomIdOperationRequest(MasterPlayerModels.LinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link custom ID operation request.
        /// </summary>
        public class ServerLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkCustomIdOperationRequest class.
            /// </summary>
            public ServerLinkCustomIdOperationRequest(MasterPlayerModels.ServerLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link custom ID operation request.
        /// </summary>
        public class AdminLinkCustomIdOperationRequest : LinkCustomIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkCustomIdOperationRequest class.
            /// </summary>
            public AdminLinkCustomIdOperationRequest(MasterPlayerModels.AdminLinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link editor device ID operation request.
        /// </summary>
        public class LinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkEditorDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkEditorDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public LinkEditorDeviceIdOperationRequest(MasterPlayerModels.LinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link editor device ID operation request.
        /// </summary>
        public class ServerLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link editor device ID operation request.
        /// </summary>
        public class AdminLinkEditorDeviceIdOperationRequest : LinkEditorDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminLinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link facebook operation request.
        /// </summary>
        public class LinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkFacebookRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkFacebook;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkFacebookOperationRequest class.
            /// </summary>
            public LinkFacebookOperationRequest(MasterPlayerModels.LinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link facebook operation request.
        /// </summary>
        public class ServerLinkFacebookOperationRequest : LinkFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkFacebookOperationRequest class.
            /// </summary>
            public ServerLinkFacebookOperationRequest(MasterPlayerModels.ServerLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link facebook operation request.
        /// </summary>
        public class AdminLinkFacebookOperationRequest : LinkFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkFacebookOperationRequest class.
            /// </summary>
            public AdminLinkFacebookOperationRequest(MasterPlayerModels.AdminLinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link generic service operation request.
        /// </summary>
        public class LinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGenericServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkGenericService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkGenericServiceOperationRequest class.
            /// </summary>
            public LinkGenericServiceOperationRequest(MasterPlayerModels.LinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link generic service operation request.
        /// </summary>
        public class ServerLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkGenericServiceOperationRequest class.
            /// </summary>
            public ServerLinkGenericServiceOperationRequest(MasterPlayerModels.ServerLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link generic service operation request.
        /// </summary>
        public class AdminLinkGenericServiceOperationRequest : LinkGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkGenericServiceOperationRequest class.
            /// </summary>
            public AdminLinkGenericServiceOperationRequest(MasterPlayerModels.AdminLinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link google operation request.
        /// </summary>
        public class LinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGoogleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkGoogle;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkGoogleOperationRequest class.
            /// </summary>
            public LinkGoogleOperationRequest(MasterPlayerModels.LinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link google operation request.
        /// </summary>
        public class ServerLinkGoogleOperationRequest : LinkGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkGoogleOperationRequest class.
            /// </summary>
            public ServerLinkGoogleOperationRequest(MasterPlayerModels.ServerLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link google operation request.
        /// </summary>
        public class AdminLinkGoogleOperationRequest : LinkGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkGoogleOperationRequest class.
            /// </summary>
            public AdminLinkGoogleOperationRequest(MasterPlayerModels.AdminLinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link google play game service operation request.
        /// </summary>
        public class LinkGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGooglePlayGameServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkGooglePlayGameService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public LinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.LinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link google play game service operation request.
        /// </summary>
        public class ServerLinkGooglePlayGameServiceOperationRequest : LinkGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public ServerLinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerLinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link google play game service operation request.
        /// </summary>
        public class AdminLinkGooglePlayGameServiceOperationRequest : LinkGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public AdminLinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminLinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link game center operation request.
        /// </summary>
        public class LinkGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkGameCenterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkGameCenter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkGameCenterOperationRequest class.
            /// </summary>
            public LinkGameCenterOperationRequest(MasterPlayerModels.LinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link game center operation request.
        /// </summary>
        public class ServerLinkGameCenterOperationRequest : LinkGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkGameCenterOperationRequest class.
            /// </summary>
            public ServerLinkGameCenterOperationRequest(MasterPlayerModels.ServerLinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link game center operation request.
        /// </summary>
        public class AdminLinkGameCenterOperationRequest : LinkGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkGameCenterOperationRequest class.
            /// </summary>
            public AdminLinkGameCenterOperationRequest(MasterPlayerModels.AdminLinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link iOS device ID operation request.
        /// </summary>
        public class LinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkiOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkiOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public LinkiOSDeviceIdOperationRequest(MasterPlayerModels.LinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link iOS device ID operation request.
        /// </summary>
        public class ServerLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link iOS device ID operation request.
        /// </summary>
        public class AdminLinkiOSDeviceIdOperationRequest : LinkiOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link linux device ID operation request.
        /// </summary>
        public class LinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkLinuxDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkLinuxDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public LinkLinuxDeviceIdOperationRequest(MasterPlayerModels.LinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link linux device ID operation request.
        /// </summary>
        public class ServerLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link linux device ID operation request.
        /// </summary>
        public class AdminLinkLinuxDeviceIdOperationRequest : LinkLinuxDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminLinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link macos device ID operation request.
        /// </summary>
        public class LinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkMacOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkMacOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public LinkMacOSDeviceIdOperationRequest(MasterPlayerModels.LinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link macos device ID operation request.
        /// </summary>
        public class ServerLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link macos device ID operation request.
        /// </summary>
        public class AdminLinkMacOSDeviceIdOperationRequest : LinkMacOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminLinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link windows device ID operation request.
        /// </summary>
        public class LinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkWindowsDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public LinkWindowsDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link windows device ID operation request.
        /// </summary>
        public class ServerLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link windows device ID operation request.
        /// </summary>
        public class AdminLinkWindowsDeviceIdOperationRequest : LinkWindowsDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the link windows phone device ID operation request.
        /// </summary>
        public class LinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.LinkWindowsPhoneDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the LinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public LinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.LinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped link windows phone device ID operation request.
        /// </summary>
        public class ServerLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerLinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public ServerLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped link windows phone device ID operation request.
        /// </summary>
        public class AdminLinkWindowsPhoneDeviceIdOperationRequest : LinkWindowsPhoneDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminLinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public AdminLinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminLinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove segment operation request.
        /// </summary>
        public class RemoveSegmentOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveSegmentRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveSegment;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveSegmentOperationRequest class.
            /// </summary>
            public RemoveSegmentOperationRequest(MasterPlayerModels.RemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove segment operation request.
        /// </summary>
        public class ServerRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveSegmentOperationRequest class.
            /// </summary>
            public ServerRemoveSegmentOperationRequest(MasterPlayerModels.ServerRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove segment operation request.
        /// </summary>
        public class AdminRemoveSegmentOperationRequest : RemoveSegmentOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveSegmentOperationRequest class.
            /// </summary>
            public AdminRemoveSegmentOperationRequest(MasterPlayerModels.AdminRemoveSegmentRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the remove tag operation request.
        /// </summary>
        public class RemoveTagOperationRequest : CustomOperationRequest<MasterPlayerModels.RemoveTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemoveTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemoveTagOperationRequest class.
            /// </summary>
            public RemoveTagOperationRequest(MasterPlayerModels.RemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove tag operation request.
        /// </summary>
        public class ServerRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemoveTagOperationRequest class.
            /// </summary>
            public ServerRemoveTagOperationRequest(MasterPlayerModels.ServerRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove tag operation request.
        /// </summary>
        public class AdminRemoveTagOperationRequest : RemoveTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemoveTagOperationRequest class.
            /// </summary>
            public AdminRemoveTagOperationRequest(MasterPlayerModels.AdminRemoveTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the reset account password operation request.
        /// </summary>
        public class ResetAccountPasswordOperationRequest : CustomOperationRequest<MasterPlayerModels.ResetAccountPasswordRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ResetAccountPassword;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ResetAccountPasswordOperationRequest class.
            /// </summary>
            public ResetAccountPasswordOperationRequest(MasterPlayerModels.ResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped reset account password operation request.
        /// </summary>
        public class ServerResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerResetAccountPasswordOperationRequest class.
            /// </summary>
            public ServerResetAccountPasswordOperationRequest(MasterPlayerModels.ServerResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped reset account password operation request.
        /// </summary>
        public class AdminResetAccountPasswordOperationRequest : ResetAccountPasswordOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminResetAccountPasswordOperationRequest class.
            /// </summary>
            public AdminResetAccountPasswordOperationRequest(MasterPlayerModels.AdminResetAccountPasswordRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set avatar operation request.
        /// </summary>
        public class SetAvatarOperationRequest : CustomOperationRequest<MasterPlayerModels.SetAvatarRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetAvatar;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetAvatarOperationRequest class.
            /// </summary>
            public SetAvatarOperationRequest(MasterPlayerModels.SetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set avatar operation request.
        /// </summary>
        public class ServerSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetAvatarOperationRequest class.
            /// </summary>
            public ServerSetAvatarOperationRequest(MasterPlayerModels.ServerSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set avatar operation request.
        /// </summary>
        public class AdminSetAvatarOperationRequest : SetAvatarOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetAvatarOperationRequest class.
            /// </summary>
            public AdminSetAvatarOperationRequest(MasterPlayerModels.AdminSetAvatarRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set country code operation request.
        /// </summary>
        public class SetCountryCodeOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCountryCodeRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCountryCode;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCountryCodeOperationRequest class.
            /// </summary>
            public SetCountryCodeOperationRequest(MasterPlayerModels.SetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set country code operation request.
        /// </summary>
        public class ServerSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetCountryCodeOperationRequest class.
            /// </summary>
            public ServerSetCountryCodeOperationRequest(MasterPlayerModels.ServerSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set country code operation request.
        /// </summary>
        public class AdminSetCountryCodeOperationRequest : SetCountryCodeOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetCountryCodeOperationRequest class.
            /// </summary>
            public AdminSetCountryCodeOperationRequest(MasterPlayerModels.AdminSetCountryCodeRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set custom data operation request.
        /// </summary>
        public class SetCustomDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetCustomDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetCustomData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetCustomDataOperationRequest class.
            /// </summary>
            public SetCustomDataOperationRequest(MasterPlayerModels.SetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set custom data operation request.
        /// </summary>
        public class ServerSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetCustomDataOperationRequest class.
            /// </summary>
            public ServerSetCustomDataOperationRequest(MasterPlayerModels.ServerSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set custom data operation request.
        /// </summary>
        public class AdminSetCustomDataOperationRequest : SetCustomDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetCustomDataOperationRequest class.
            /// </summary>
            public AdminSetCustomDataOperationRequest(MasterPlayerModels.AdminSetCustomDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set display name operation request.
        /// </summary>
        public class SetDisplayNameOperationRequest : CustomOperationRequest<MasterPlayerModels.SetDisplayNameRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetDisplayName;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetDisplayNameOperationRequest class.
            /// </summary>
            public SetDisplayNameOperationRequest(MasterPlayerModels.SetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set display name operation request.
        /// </summary>
        public class ServerSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetDisplayNameOperationRequest class.
            /// </summary>
            public ServerSetDisplayNameOperationRequest(MasterPlayerModels.ServerSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set display name operation request.
        /// </summary>
        public class AdminSetDisplayNameOperationRequest : SetDisplayNameOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetDisplayNameOperationRequest class.
            /// </summary>
            public AdminSetDisplayNameOperationRequest(MasterPlayerModels.AdminSetDisplayNameRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set email operation request.
        /// </summary>
        public class SetEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.SetEmailRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetEmail;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetEmailOperationRequest class.
            /// </summary>
            public SetEmailOperationRequest(MasterPlayerModels.SetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set email operation request.
        /// </summary>
        public class ServerSetEmailOperationRequest : SetEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetEmailOperationRequest class.
            /// </summary>
            public ServerSetEmailOperationRequest(MasterPlayerModels.ServerSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set email operation request.
        /// </summary>
        public class AdminSetEmailOperationRequest : SetEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetEmailOperationRequest class.
            /// </summary>
            public AdminSetEmailOperationRequest(MasterPlayerModels.AdminSetEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player ban operation request.
        /// </summary>
        public class SetPlayerBanOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerBanRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerBan;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerBanOperationRequest class.
            /// </summary>
            public SetPlayerBanOperationRequest(MasterPlayerModels.SetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set player ban operation request.
        /// </summary>
        public class ServerSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetPlayerBanOperationRequest class.
            /// </summary>
            public ServerSetPlayerBanOperationRequest(MasterPlayerModels.ServerSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set player ban operation request.
        /// </summary>
        public class AdminSetPlayerBanOperationRequest : SetPlayerBanOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetPlayerBanOperationRequest class.
            /// </summary>
            public AdminSetPlayerBanOperationRequest(MasterPlayerModels.AdminSetPlayerBanRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player currency operation request.
        /// </summary>
        public class ChangePlayerCurrencyOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangePlayerCurrencyRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerCurrency;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public ChangePlayerCurrencyOperationRequest(MasterPlayerModels.ChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change player currency operation request.
        /// </summary>
        public class ServerChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public ServerChangePlayerCurrencyOperationRequest(MasterPlayerModels.ServerChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change player currency operation request.
        /// </summary>
        public class AdminChangePlayerCurrencyOperationRequest : ChangePlayerCurrencyOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangePlayerCurrencyOperationRequest class.
            /// </summary>
            public AdminChangePlayerCurrencyOperationRequest(MasterPlayerModels.AdminChangePlayerCurrencyRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set player data operation request.
        /// </summary>
        public class SetPlayerDataOperationRequest : CustomOperationRequest<MasterPlayerModels.SetPlayerDataRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetPlayerData;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetPlayerDataOperationRequest class.
            /// </summary>
            public SetPlayerDataOperationRequest(MasterPlayerModels.SetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set player data operation request.
        /// </summary>
        public class ServerSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetPlayerDataOperationRequest class.
            /// </summary>
            public ServerSetPlayerDataOperationRequest(MasterPlayerModels.ServerSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set player data operation request.
        /// </summary>
        public class AdminSetPlayerDataOperationRequest : SetPlayerDataOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetPlayerDataOperationRequest class.
            /// </summary>
            public AdminSetPlayerDataOperationRequest(MasterPlayerModels.AdminSetPlayerDataRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the change player statistics operation request.
        /// </summary>
        public class ChangePlayerStatisticsOperationRequest : CustomOperationRequest<MasterPlayerModels.ChangePlayerStatisticsRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.ChangePlayerStatistics;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the ChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public ChangePlayerStatisticsOperationRequest(MasterPlayerModels.ChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped change player statistics operation request.
        /// </summary>
        public class ServerChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public ServerChangePlayerStatisticsOperationRequest(MasterPlayerModels.ServerChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped change player statistics operation request.
        /// </summary>
        public class AdminChangePlayerStatisticsOperationRequest : ChangePlayerStatisticsOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminChangePlayerStatisticsOperationRequest class.
            /// </summary>
            public AdminChangePlayerStatisticsOperationRequest(MasterPlayerModels.AdminChangePlayerStatisticsRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set tag operation request.
        /// </summary>
        public class SetTagOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTagRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTag;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTagOperationRequest class.
            /// </summary>
            public SetTagOperationRequest(MasterPlayerModels.SetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set tag operation request.
        /// </summary>
        public class ServerSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetTagOperationRequest class.
            /// </summary>
            public ServerSetTagOperationRequest(MasterPlayerModels.ServerSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set tag operation request.
        /// </summary>
        public class AdminSetTagOperationRequest : SetTagOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetTagOperationRequest class.
            /// </summary>
            public AdminSetTagOperationRequest(MasterPlayerModels.AdminSetTagRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the set timestamp last login operation request.
        /// </summary>
        public class SetTsLastLoginOperationRequest : CustomOperationRequest<MasterPlayerModels.SetTsLastLoginRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SetTsLastLogin;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SetTsLastLoginOperationRequest class.
            /// </summary>
            public SetTsLastLoginOperationRequest(MasterPlayerModels.SetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped set timestamp last login operation request.
        /// </summary>
        public class ServerSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSetTsLastLoginOperationRequest class.
            /// </summary>
            public ServerSetTsLastLoginOperationRequest(MasterPlayerModels.ServerSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped set timestamp last login operation request.
        /// </summary>
        public class AdminSetTsLastLoginOperationRequest : SetTsLastLoginOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSetTsLastLoginOperationRequest class.
            /// </summary>
            public AdminSetTsLastLoginOperationRequest(MasterPlayerModels.AdminSetTsLastLoginRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink account operation request.
        /// </summary>
        public class UnlinkAccountOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAccountRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkAccount;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkAccountOperationRequest class.
            /// </summary>
            public UnlinkAccountOperationRequest(MasterPlayerModels.UnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink account operation request.
        /// </summary>
        public class ServerUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkAccountOperationRequest class.
            /// </summary>
            public ServerUnlinkAccountOperationRequest(MasterPlayerModels.ServerUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink account operation request.
        /// </summary>
        public class AdminUnlinkAccountOperationRequest : UnlinkAccountOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkAccountOperationRequest class.
            /// </summary>
            public AdminUnlinkAccountOperationRequest(MasterPlayerModels.AdminUnlinkAccountRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink android device ID operation request.
        /// </summary>
        public class UnlinkAndroidDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAndroidDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkAndroidDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.UnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink android device ID operation request.
        /// </summary>
        public class ServerUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink android device ID operation request.
        /// </summary>
        public class AdminUnlinkAndroidDeviceIdOperationRequest : UnlinkAndroidDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkAndroidDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkAndroidDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkAndroidDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink apple operation request.
        /// </summary>
        public class UnlinkAppleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkAppleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkApple;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkAppleOperationRequest class.
            /// </summary>
            public UnlinkAppleOperationRequest(MasterPlayerModels.UnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink apple operation request.
        /// </summary>
        public class ServerUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkAppleOperationRequest class.
            /// </summary>
            public ServerUnlinkAppleOperationRequest(MasterPlayerModels.ServerUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink apple operation request.
        /// </summary>
        public class AdminUnlinkAppleOperationRequest : UnlinkAppleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkAppleOperationRequest class.
            /// </summary>
            public AdminUnlinkAppleOperationRequest(MasterPlayerModels.AdminUnlinkAppleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink custom device ID operation request.
        /// </summary>
        public class UnlinkCustomDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkCustomDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.UnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink custom device ID operation request.
        /// </summary>
        public class ServerUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink custom device ID operation request.
        /// </summary>
        public class AdminUnlinkCustomDeviceIdOperationRequest : UnlinkCustomDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkCustomDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkCustomDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink custom ID operation request.
        /// </summary>
        public class UnlinkCustomIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkCustomIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkCustomId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkCustomIdOperationRequest class.
            /// </summary>
            public UnlinkCustomIdOperationRequest(MasterPlayerModels.UnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink custom ID operation request.
        /// </summary>
        public class ServerUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkCustomIdOperationRequest class.
            /// </summary>
            public ServerUnlinkCustomIdOperationRequest(MasterPlayerModels.ServerUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink custom ID operation request.
        /// </summary>
        public class AdminUnlinkCustomIdOperationRequest : UnlinkCustomIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkCustomIdOperationRequest class.
            /// </summary>
            public AdminUnlinkCustomIdOperationRequest(MasterPlayerModels.AdminUnlinkCustomIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink editor device ID operation request.
        /// </summary>
        public class UnlinkEditorDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkEditorDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkEditorDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.UnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink editor device ID operation request.
        /// </summary>
        public class ServerUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink editor device ID operation request.
        /// </summary>
        public class AdminUnlinkEditorDeviceIdOperationRequest : UnlinkEditorDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkEditorDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkEditorDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkEditorDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink facebook operation request.
        /// </summary>
        public class UnlinkFacebookOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkFacebookRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkFacebook;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkFacebookOperationRequest class.
            /// </summary>
            public UnlinkFacebookOperationRequest(MasterPlayerModels.UnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink facebook operation request.
        /// </summary>
        public class ServerUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkFacebookOperationRequest class.
            /// </summary>
            public ServerUnlinkFacebookOperationRequest(MasterPlayerModels.ServerUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink facebook operation request.
        /// </summary>
        public class AdminUnlinkFacebookOperationRequest : UnlinkFacebookOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkFacebookOperationRequest class.
            /// </summary>
            public AdminUnlinkFacebookOperationRequest(MasterPlayerModels.AdminUnlinkFacebookRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink generic service operation request.
        /// </summary>
        public class UnlinkGenericServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGenericServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkGenericService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkGenericServiceOperationRequest class.
            /// </summary>
            public UnlinkGenericServiceOperationRequest(MasterPlayerModels.UnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink generic service operation request.
        /// </summary>
        public class ServerUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkGenericServiceOperationRequest class.
            /// </summary>
            public ServerUnlinkGenericServiceOperationRequest(MasterPlayerModels.ServerUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink generic service operation request.
        /// </summary>
        public class AdminUnlinkGenericServiceOperationRequest : UnlinkGenericServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkGenericServiceOperationRequest class.
            /// </summary>
            public AdminUnlinkGenericServiceOperationRequest(MasterPlayerModels.AdminUnlinkGenericServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink google operation request.
        /// </summary>
        public class UnlinkGoogleOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGoogleRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkGoogle;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkGoogleOperationRequest class.
            /// </summary>
            public UnlinkGoogleOperationRequest(MasterPlayerModels.UnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink google operation request.
        /// </summary>
        public class ServerUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkGoogleOperationRequest class.
            /// </summary>
            public ServerUnlinkGoogleOperationRequest(MasterPlayerModels.ServerUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink google operation request.
        /// </summary>
        public class AdminUnlinkGoogleOperationRequest : UnlinkGoogleOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkGoogleOperationRequest class.
            /// </summary>
            public AdminUnlinkGoogleOperationRequest(MasterPlayerModels.AdminUnlinkGoogleRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink google play game service operation request.
        /// </summary>
        public class UnlinkGooglePlayGameServiceOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkGooglePlayGameService;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public UnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.UnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink google play game service operation request.
        /// </summary>
        public class ServerUnlinkGooglePlayGameServiceOperationRequest : UnlinkGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public ServerUnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.ServerUnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink google play game service operation request.
        /// </summary>
        public class AdminUnlinkGooglePlayGameServiceOperationRequest : UnlinkGooglePlayGameServiceOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkGooglePlayGameServiceOperationRequest class.
            /// </summary>
            public AdminUnlinkGooglePlayGameServiceOperationRequest(MasterPlayerModels.AdminUnlinkGooglePlayGameServiceRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink game center operation request.
        /// </summary>
        public class UnlinkGameCenterOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkGameCenterRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkGameCenter;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkGameCenterOperationRequest class.
            /// </summary>
            public UnlinkGameCenterOperationRequest(MasterPlayerModels.UnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink game center operation request.
        /// </summary>
        public class ServerUnlinkGameCenterOperationRequest : UnlinkGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkGameCenterOperationRequest class.
            /// </summary>
            public ServerUnlinkGameCenterOperationRequest(MasterPlayerModels.ServerUnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink game center operation request.
        /// </summary>
        public class AdminUnlinkGameCenterOperationRequest : UnlinkGameCenterOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkGameCenterOperationRequest class.
            /// </summary>
            public AdminUnlinkGameCenterOperationRequest(MasterPlayerModels.AdminUnlinkGameCenterRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink iOS device ID operation request.
        /// </summary>
        public class UnlinkiOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkiOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkiOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink iOS device ID operation request.
        /// </summary>
        public class ServerUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink iOS device ID operation request.
        /// </summary>
        public class AdminUnlinkiOSDeviceIdOperationRequest : UnlinkiOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkiOSDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkiOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkiOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink linux device ID operation request.
        /// </summary>
        public class UnlinkLinuxDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkLinuxDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkLinuxDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.UnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink linux device ID operation request.
        /// </summary>
        public class ServerUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink linux device ID operation request.
        /// </summary>
        public class AdminUnlinkLinuxDeviceIdOperationRequest : UnlinkLinuxDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkLinuxDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkLinuxDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkLinuxDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink macos device ID operation request.
        /// </summary>
        public class UnlinkMacOSDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkMacOSDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkMacOSDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.UnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink macos device ID operation request.
        /// </summary>
        public class ServerUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink macos device ID operation request.
        /// </summary>
        public class AdminUnlinkMacOSDeviceIdOperationRequest : UnlinkMacOSDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkMacOSDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkMacOSDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkMacOSDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink windows device ID operation request.
        /// </summary>
        public class UnlinkWindowsDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkWindowsDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink windows device ID operation request.
        /// </summary>
        public class ServerUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink windows device ID operation request.
        /// </summary>
        public class AdminUnlinkWindowsDeviceIdOperationRequest : UnlinkWindowsDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkWindowsDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkWindowsDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }


        /// <summary>
        /// Builds the unlink windows phone device ID operation request.
        /// </summary>
        public class UnlinkWindowsPhoneDeviceIdOperationRequest : CustomOperationRequest<MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.UnlinkWindowsPhoneDeviceId;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the UnlinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public UnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.UnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped unlink windows phone device ID operation request.
        /// </summary>
        public class ServerUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerUnlinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public ServerUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.ServerUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped unlink windows phone device ID operation request.
        /// </summary>
        public class AdminUnlinkWindowsPhoneDeviceIdOperationRequest : UnlinkWindowsPhoneDeviceIdOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminUnlinkWindowsPhoneDeviceIdOperationRequest class.
            /// </summary>
            public AdminUnlinkWindowsPhoneDeviceIdOperationRequest(MasterPlayerModels.AdminUnlinkWindowsPhoneDeviceIdRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency leaderboard operation request.
        /// </summary>
        public class GetCurrencyLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCurrencyLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public GetCurrencyLeaderboardOperationRequest(MasterPlayerModels.GetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency leaderboard operation request.
        /// </summary>
        public class ServerGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLeaderboardOperationRequest(MasterPlayerModels.ServerGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency leaderboard operation request.
        /// </summary>
        public class AdminGetCurrencyLeaderboardOperationRequest : GetCurrencyLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLeaderboardOperationRequest(MasterPlayerModels.AdminGetCurrencyLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get last login leaderboard operation request.
        /// </summary>
        public class GetLastLoginLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetLastLoginLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetLastLoginLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public GetLastLoginLeaderboardOperationRequest(MasterPlayerModels.GetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get last login leaderboard operation request.
        /// </summary>
        public class ServerGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetLastLoginLeaderboardOperationRequest(MasterPlayerModels.ServerGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get last login leaderboard operation request.
        /// </summary>
        public class AdminGetLastLoginLeaderboardOperationRequest : GetLastLoginLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetLastLoginLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetLastLoginLeaderboardOperationRequest(MasterPlayerModels.AdminGetLastLoginLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get create leaderboard operation request.
        /// </summary>
        public class GetCreateLeaderboardOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCreateLeaderboardRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCreateLeaderboard;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCreateLeaderboardOperationRequest class.
            /// </summary>
            public GetCreateLeaderboardOperationRequest(MasterPlayerModels.GetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get create leaderboard operation request.
        /// </summary>
        public class ServerGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public ServerGetCreateLeaderboardOperationRequest(MasterPlayerModels.ServerGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get create leaderboard operation request.
        /// </summary>
        public class AdminGetCreateLeaderboardOperationRequest : GetCreateLeaderboardOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCreateLeaderboardOperationRequest class.
            /// </summary>
            public AdminGetCreateLeaderboardOperationRequest(MasterPlayerModels.AdminGetCreateLeaderboardRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get statistics log operation request.
        /// </summary>
        public class GetStatisticsLogOperationRequest : CustomOperationRequest<MasterPlayerModels.GetStatisticsLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetStatisticsLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetStatisticsLogOperationRequest class.
            /// </summary>
            public GetStatisticsLogOperationRequest(MasterPlayerModels.GetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get statistics log operation request.
        /// </summary>
        public class ServerGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetStatisticsLogOperationRequest class.
            /// </summary>
            public ServerGetStatisticsLogOperationRequest(MasterPlayerModels.ServerGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get statistics log operation request.
        /// </summary>
        public class AdminGetStatisticsLogOperationRequest : GetStatisticsLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetStatisticsLogOperationRequest class.
            /// </summary>
            public AdminGetStatisticsLogOperationRequest(MasterPlayerModels.AdminGetStatisticsLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get currency log operation request.
        /// </summary>
        public class GetCurrencyLogOperationRequest : CustomOperationRequest<MasterPlayerModels.GetCurrencyLogRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetCurrencyLog;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetCurrencyLogOperationRequest class.
            /// </summary>
            public GetCurrencyLogOperationRequest(MasterPlayerModels.GetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get currency log operation request.
        /// </summary>
        public class ServerGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetCurrencyLogOperationRequest class.
            /// </summary>
            public ServerGetCurrencyLogOperationRequest(MasterPlayerModels.ServerGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get currency log operation request.
        /// </summary>
        public class AdminGetCurrencyLogOperationRequest : GetCurrencyLogOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetCurrencyLogOperationRequest class.
            /// </summary>
            public AdminGetCurrencyLogOperationRequest(MasterPlayerModels.AdminGetCurrencyLogRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the send socket operation event operation request.
        /// </summary>
        public class SendSocketOperationEventOperationRequest : CustomOperationRequest<MasterPlayerModels.SendSocketOperationEventRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SendSocketOperationEvent;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SendSocketOperationEventOperationRequest class.
            /// </summary>
            public SendSocketOperationEventOperationRequest(MasterPlayerModels.SendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped send socket operation event operation request.
        /// </summary>
        public class ServerSendSocketOperationEventOperationRequest : SendSocketOperationEventOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSendSocketOperationEventOperationRequest class.
            /// </summary>
            public ServerSendSocketOperationEventOperationRequest(MasterPlayerModels.ServerSendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped send socket operation event operation request.
        /// </summary>
        public class AdminSendSocketOperationEventOperationRequest : SendSocketOperationEventOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSendSocketOperationEventOperationRequest class.
            /// </summary>
            public AdminSendSocketOperationEventOperationRequest(MasterPlayerModels.AdminSendSocketOperationEventRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the send email operation request.
        /// </summary>
        public class SendEmailOperationRequest : CustomOperationRequest<MasterPlayerModels.SendEmailRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SendEmail;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SendEmailOperationRequest class.
            /// </summary>
            public SendEmailOperationRequest(MasterPlayerModels.SendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped send email operation request.
        /// </summary>
        public class ServerSendEmailOperationRequest : SendEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSendEmailOperationRequest class.
            /// </summary>
            public ServerSendEmailOperationRequest(MasterPlayerModels.SendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped send email operation request.
        /// </summary>
        public class AdminSendEmailOperationRequest : SendEmailOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSendEmailOperationRequest class.
            /// </summary>
            public AdminSendEmailOperationRequest(MasterPlayerModels.AdminSendEmailRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the remove push notification operation request.
        /// </summary>
        public class RemovePushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.RemovePushNotificationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.RemovePushNotification;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the RemovePushNotificationOperationRequest class.
            /// </summary>
            public RemovePushNotificationOperationRequest(MasterPlayerModels.RemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped remove push notification operation request.
        /// </summary>
        public class ServerRemovePushNotificationOperationRequest : RemovePushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerRemovePushNotificationOperationRequest class.
            /// </summary>
            public ServerRemovePushNotificationOperationRequest(MasterPlayerModels.RemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped remove push notification operation request.
        /// </summary>
        public class AdminRemovePushNotificationOperationRequest : RemovePushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminRemovePushNotificationOperationRequest class.
            /// </summary>
            public AdminRemovePushNotificationOperationRequest(MasterPlayerModels.AdminRemovePushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the add push notification operation request.
        /// </summary>
        public class AddPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.AddPushNotificationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.AddPushNotification;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the AddPushNotificationOperationRequest class.
            /// </summary>
            public AddPushNotificationOperationRequest(MasterPlayerModels.AddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped add push notification operation request.
        /// </summary>
        public class ServerAddPushNotificationOperationRequest : AddPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerAddPushNotificationOperationRequest class.
            /// </summary>
            public ServerAddPushNotificationOperationRequest(MasterPlayerModels.AddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped add push notification operation request.
        /// </summary>
        public class AdminAddPushNotificationOperationRequest : AddPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminAddPushNotificationOperationRequest class.
            /// </summary>
            public AdminAddPushNotificationOperationRequest(MasterPlayerModels.AdminAddPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the get push notification operation request.
        /// </summary>
        public class GetPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.GetPushNotificationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.GetPushNotification;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the GetPushNotificationOperationRequest class.
            /// </summary>
            public GetPushNotificationOperationRequest(MasterPlayerModels.GetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped get push notification operation request.
        /// </summary>
        public class ServerGetPushNotificationOperationRequest : GetPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerGetPushNotificationOperationRequest class.
            /// </summary>
            public ServerGetPushNotificationOperationRequest(MasterPlayerModels.GetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped get push notification operation request.
        /// </summary>
        public class AdminGetPushNotificationOperationRequest : GetPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminGetPushNotificationOperationRequest class.
            /// </summary>
            public AdminGetPushNotificationOperationRequest(MasterPlayerModels.AdminGetPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the send push notification operation request.
        /// </summary>
        public class SendPushNotificationOperationRequest : CustomOperationRequest<MasterPlayerModels.SendPushNotificationRequestData>
        {
            /// <summary>
            /// Gets the operation code used by this request wrapper.
            /// </summary>
            protected override string operationCode => OperationCode.SendPushNotification;
            /// <summary>
            /// Gets the request type used by this request wrapper.
            /// </summary>
            protected override RequestType requestType => RequestType.MasterPlayer;
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Client;

            /// <summary>
            /// Initializes a new instance of the SendPushNotificationOperationRequest class.
            /// </summary>
            public SendPushNotificationOperationRequest(MasterPlayerModels.SendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the server-scoped send push notification operation request.
        /// </summary>
        public class ServerSendPushNotificationOperationRequest : SendPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Server;

            /// <summary>
            /// Initializes a new instance of the ServerSendPushNotificationOperationRequest class.
            /// </summary>
            public ServerSendPushNotificationOperationRequest(MasterPlayerModels.SendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

        /// <summary>
        /// Builds the admin-scoped send push notification operation request.
        /// </summary>
        public class AdminSendPushNotificationOperationRequest : SendPushNotificationOperationRequest
        {
            /// <summary>
            /// Gets the request role used by this request wrapper.
            /// </summary>
            protected override RequestRole role => RequestRole.Admin;

            /// <summary>
            /// Initializes a new instance of the AdminSendPushNotificationOperationRequest class.
            /// </summary>
            public AdminSendPushNotificationOperationRequest(MasterPlayerModels.AdminSendPushNotificationRequestData requestData, int timeout = OperationRequest.defaultTimeOut) : base(requestData, timeout) { }
        }

    }

}