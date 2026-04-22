namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Defines payload models for multiplayer operations.
    /// </summary>
    public partial class MultiplayerModels
    {
        /// <summary>
        /// Represents the request payload for the cancel all matchmaking ticket operation.
        /// </summary>
        public class CancelAllMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the cancel all matchmaking ticket operation.
        /// </summary>
        public class ServerCancelAllMatchmakingTicketRequestData : CancelAllMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the cancel all matchmaking ticket operation.
        /// </summary>
        public class AdminCancelAllMatchmakingTicketRequestData : ServerCancelAllMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the cancel matchmaking ticket operation.
        /// </summary>
        public class CancelMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the ticket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the cancel matchmaking ticket operation.
        /// </summary>
        public class ServerCancelMatchmakingTicketRequestData : CancelMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the cancel matchmaking ticket operation.
        /// </summary>
        public class AdminCancelMatchmakingTicketRequestData : ServerCancelMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the create matchmaking ticket operation.
        /// </summary>
        public class CreateMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the give up after seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.GiveUpAfterSeconds, mustInt = true, minValue = 20)]
            public int giveUpAfterSeconds;

            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            /// <summary>
            /// Stores the attribute value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

            /// <summary>
            /// Stores the members value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Members, isOptional = true, elementCls = typeof(string))]
            public List<string>? members;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the create matchmaking ticket operation.
        /// </summary>
        public class ServerCreateMatchmakingTicketRequestData : CreateMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the create matchmaking ticket operation.
        /// </summary>
        public class AdminCreateMatchmakingTicketRequestData : ServerCreateMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the get matchmaking ticket operation.
        /// </summary>
        public class GetMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the ticket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            /// <summary>
            /// Stores the return member value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;
        }

        /// <summary>
        /// Represents the server-scoped request payload for the get matchmaking ticket operation.
        /// </summary>
        public class ServerGetMatchmakingTicketRequestData : GetMatchmakingTicketRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get matchmaking ticket operation.
        /// </summary>
        public class AdminGetMatchmakingTicketRequestData : ServerGetMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the get match operation.
        /// </summary>
        public class GetMatchRequestData
        {
            /// <summary>
            /// Stores the match ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MatchId, minLength = 15, maxLength = 15)]
            public string matchId;

            /// <summary>
            /// Stores the return member value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get match operation.
        /// </summary>
        public class ServerGetMatchRequestData : GetMatchRequestData
        {

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get match operation.
        /// </summary>
        public class AdminGetMatchRequestData : ServerGetMatchRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get all match operation.
        /// </summary>
        public class GetAllMatchRequestData
        {
            /// <summary>
            /// Stores the return member value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get all match operation.
        /// </summary>
        public class ServerGetAllMatchRequestData : GetAllMatchRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get all match operation.
        /// </summary>
        public class AdminGetAllMatchRequestData : ServerGetAllMatchRequestData
        {
        }

        /// <summary>
        /// Represents the request payload for the get all matchmaking ticket operation.
        /// </summary>
        public class GetAllMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status, minValue = 1, maxValue = 5, mustInt = true, isOptional = true)]
            public int? status;

            /// <summary>
            /// Stores the return member value.
            /// </summary>
            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            /// <summary>
            /// Stores the skip value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            /// <summary>
            /// Stores the limit value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get all matchmaking ticket operation.
        /// </summary>
        public class ServerGetAllMatchmakingTicketRequestData : GetAllMatchmakingTicketRequestData
        {
        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get all matchmaking ticket operation.
        /// </summary>
        public class AdminGetAllMatchmakingTicketRequestData : ServerGetAllMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the get queue statistics operation.
        /// </summary>
        public class GetQueueStatisticsRequestData
        {
            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            /// <summary>
            /// Stores the time in seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TimeInSeconds, mustInt = true, minValue = 20)]
            public int timeInSeconds;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the get queue statistics operation.
        /// </summary>
        public class ServerGetQueueStatisticsRequestData : GetQueueStatisticsRequestData
        {

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the get queue statistics operation.
        /// </summary>
        public class AdminGetQueueStatisticsRequestData : ServerGetQueueStatisticsRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the join matchmaking ticket operation.
        /// </summary>
        public class JoinMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the ticket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            /// <summary>
            /// Stores the attribute value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the join matchmaking ticket operation.
        /// </summary>
        public class ServerJoinMatchmakingTicketRequestData : JoinMatchmakingTicketRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the join matchmaking ticket operation.
        /// </summary>
        public class AdminJoinMatchmakingTicketRequestData : ServerJoinMatchmakingTicketRequestData
        {
        }


        /// <summary>
        /// Represents the request payload for the list matchmaking tickets for player operation.
        /// </summary>
        public class ListMatchmakingTicketsForPlayerRequestData
        {
            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        /// <summary>
        /// Represents the server-scoped request payload for the list matchmaking tickets for player operation.
        /// </summary>
        public class ServerListMatchmakingTicketsForPlayerRequestData : ListMatchmakingTicketsForPlayerRequestData
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        /// <summary>
        /// Represents the admin-scoped request payload for the list matchmaking tickets for player operation.
        /// </summary>
        public class AdminListMatchmakingTicketsForPlayerRequestData : ServerListMatchmakingTicketsForPlayerRequestData
        {
        }


        /// <summary>
        /// Represents the response payload for the cancel all matchmaking ticket operation.
        /// </summary>
        public class CancelAllMatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the ticket ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        /// <summary>
        /// Represents the response payload for the create matchmaking ticket operation.
        /// </summary>
        public class CreateMatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the ticket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TicketId)]
            public string ticketId;

        }

        /// <summary>
        /// Represents the matchmaking ticket member component.
        /// </summary>
        public class MatchmakingTicketMember
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status, mustInt = true)]
            public int status;

            /// <summary>
            /// Stores the attribute value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        /// <summary>
        /// Represents the response payload for the matchmaking ticket operation.
        /// </summary>
        public class MatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the creator ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.CreatorId, minLength = 10, maxLength = 10)]
            public string creatorId;

            /// <summary>
            /// Stores the give up after seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.GiveUpAfterSeconds)]
            public int giveUpAfterSeconds;

            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            /// <summary>
            /// Stores the status value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status, mustInt = true)]
            public int status;

            /// <summary>
            /// Stores the match ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MatchId, minLength = 15, maxLength = 15, isOptional = true)]
            public string? matchId;

            /// <summary>
            /// Stores the members value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Members, elementCls = typeof(MatchmakingTicketMember), isOptional = true)]
            public List<MatchmakingTicketMember>? members;

        }

        /// <summary>
        /// Represents the response payload for the matchmaking ticket with ticket ID operation.
        /// </summary>
        public class MatchmakingTicketWithTicketIdResponseData : MatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the ticket ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TicketId)]
            public string ticketId;

        }

        /// <summary>
        /// Represents the response payload for the get matchmaking ticket operation.
        /// </summary>
        public class GetMatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the matchmaking ticket value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.MatchmakingTicket)]
            public MatchmakingTicketResponseData matchmakingTicket;

        }

        /// <summary>
        /// Represents the match member component.
        /// </summary>
        public class MatchMember
        {
            /// <summary>
            /// Stores the user ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            /// <summary>
            /// Stores the team ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.TeamId)]
            public string teamId;

            /// <summary>
            /// Stores the attribute value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        /// <summary>
        /// Represents the port info component.
        /// </summary>
        public class PortInfo
        {
            /// <summary>
            /// Stores the name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.Name)]
            public string name;

            /// <summary>
            /// Stores the public port value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PublicPort, mustInt = true, minValue = 0)]
            public ushort publicPort;

            /// <summary>
            /// Stores the private port value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PrivatePort, mustInt = true, minValue = 0)]
            public ushort privatePort;

            /// <summary>
            /// Stores the protocol value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Protocol, mustInt = true, minValue = 1, maxValue = 2)]
            public ushort protocol;

        }

        /// <summary>
        /// Represents the server detail component.
        /// </summary>
        public class ServerDetail
        {
            /// <summary>
            /// Stores the IP V 4 address value.
            /// </summary>
            [StringDataMember(code = ParameterCode.IpV4Address)]
            public string ipV4Address;

            /// <summary>
            /// Stores the ports value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Ports, elementCls = typeof(PortInfo))]
            public List<PortInfo> ports;

        }

        /// <summary>
        /// Represents the response payload for the match operation.
        /// </summary>
        public class MatchResponseData
        {
            /// <summary>
            /// Stores the timestamp create value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            /// <summary>
            /// Stores the queue name value.
            /// </summary>
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            /// <summary>
            /// Stores the members value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Members, elementCls = typeof(MatchMember), isOptional = true)]
            public List<MatchMember>? members;

            /// <summary>
            /// Stores the time to match in seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.TimeToMatchInSeconds)]
            public float timeToMatchInSeconds;

            /// <summary>
            /// Stores the time to match in seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.Status, mustInt = true)]
            public int status;

        }

        /// <summary>
        /// Represents the response payload for the match with match ID operation.
        /// </summary>
        public class MatchWithMatchIdResponseData : MatchResponseData
        {
            /// <summary>
            /// Stores the match ID value.
            /// </summary>
            [StringDataMember(code = ParameterCode.MatchId)]
            public string matchId;

        }

        /// <summary>
        /// Represents the response payload for the get match operation.
        /// </summary>
        public class GetMatchResponseData
        {
            /// <summary>
            /// Stores the match value.
            /// </summary>
            [GNHashtableDataMember(code = ParameterCode.Match)]
            public MatchResponseData match;

        }

        /// <summary>
        /// Represents the response payload for the get queue statistics operation.
        /// </summary>
        public class GetQueueStatisticsResponseData
        {
            /// <summary>
            /// Stores the pending member count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PendingMemberCount, mustInt = true)]
            public int pendingMemberCount;

            /// <summary>
            /// Stores the pending ticket count value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.PendingTicketCount, mustInt = true)]
            public int pendingTicketCount;

            /// <summary>
            /// Stores the average matchmaking time in seconds value.
            /// </summary>
            [NumberDataMember(code = ParameterCode.AverageMatchmakingTimeInSeconds)]
            public float averageMatchmakingTimeInSeconds;

        }

        /// <summary>
        /// Represents the response payload for the list matchmaking tickets for player operation.
        /// </summary>
        public class ListMatchmakingTicketsForPlayerResponseData
        {
            /// <summary>
            /// Stores the ticket ID collection.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        /// <summary>
        /// Represents the response payload for the get all match operation.
        /// </summary>
        public class GetAllMatchResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MatchWithMatchIdResponseData), isOptional = true)]
            public List<MatchWithMatchIdResponseData>? results;

        }

        /// <summary>
        /// Represents the response payload for the get all matchmaking ticket operation.
        /// </summary>
        public class GetAllMatchmakingTicketResponseData
        {
            /// <summary>
            /// Stores the results value.
            /// </summary>
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MatchmakingTicketWithTicketIdResponseData), isOptional = true)]
            public List<MatchmakingTicketWithTicketIdResponseData>? results;

        }

        /// <summary>
        /// Represents the response payload for the empty operation.
        /// </summary>
        public class EmptyResponseData
        {
        }

    }
}