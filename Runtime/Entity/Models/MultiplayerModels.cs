namespace XmobiTea.GN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GN.Common;
    using XmobiTea.GN.Constant;

    public partial class MultiplayerModels
    {
        public class CancelAllMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        public class ServerCancelAllMatchmakingTicketRequestData : CancelAllMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCancelAllMatchmakingTicketRequestData : ServerCancelAllMatchmakingTicketRequestData
        {
        }


        public class CancelMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

        }

        public class ServerCancelMatchmakingTicketRequestData : CancelMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCancelMatchmakingTicketRequestData : ServerCancelMatchmakingTicketRequestData
        {
        }


        public class CreateMatchmakingTicketRequestData
        {
            [NumberDataMember(code = GNParameterCode.GiveUpAfterSeconds, mustInt = true, minValue = 20)]
            public int giveUpAfterSeconds;

            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNHashtableDataMember(code = GNParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

            [GNArrayDataMember(code = GNParameterCode.Members, isOptional = true, elementCls = typeof(string))]
            public List<string>? members;

        }

        public class ServerCreateMatchmakingTicketRequestData : CreateMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCreateMatchmakingTicketRequestData : ServerCreateMatchmakingTicketRequestData
        {
        }


        public class GetMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            [BooleanDataMember(code = GNParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;
        }

        public class ServerGetMatchmakingTicketRequestData : GetMatchmakingTicketRequestData
        {
        }

        public class AdminGetMatchmakingTicketRequestData : ServerGetMatchmakingTicketRequestData
        {
        }


        public class GetMatchRequestData
        {
            [StringDataMember(code = GNParameterCode.MatchId, minLength = 15, maxLength = 15)]
            public string matchId;

            [BooleanDataMember(code = GNParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

        }

        public class ServerGetMatchRequestData : GetMatchRequestData
        {

        }

        public class AdminGetMatchRequestData : ServerGetMatchRequestData
        {
        }

        public class GetAllMatchRequestData
        {
            [BooleanDataMember(code = GNParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetAllMatchRequestData : GetAllMatchRequestData
        {
        }

        public class AdminGetAllMatchRequestData : ServerGetAllMatchRequestData
        {
        }

        public class GetAllMatchmakingTicketRequestData
        {
            [NumberDataMember(code = GNParameterCode.Status, minValue = 1, maxValue = 5, mustInt = true, isOptional = true)]
            public int? status;

            [BooleanDataMember(code = GNParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            [NumberDataMember(code = GNParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = GNParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
            public int? limit;

        }

        public class ServerGetAllMatchmakingTicketRequestData : GetAllMatchmakingTicketRequestData
        {
        }

        public class AdminGetAllMatchmakingTicketRequestData : ServerGetAllMatchmakingTicketRequestData
        {
        }


        public class GetQueueStatisticsRequestData
        {
            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [NumberDataMember(code = GNParameterCode.TimeInSeconds, mustInt = true, minValue = 20)]
            public int timeInSeconds;

        }

        public class ServerGetQueueStatisticsRequestData : GetQueueStatisticsRequestData
        {

        }

        public class AdminGetQueueStatisticsRequestData : ServerGetQueueStatisticsRequestData
        {
        }


        public class JoinMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            [GNHashtableDataMember(code = GNParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

        }

        public class ServerJoinMatchmakingTicketRequestData : JoinMatchmakingTicketRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminJoinMatchmakingTicketRequestData : ServerJoinMatchmakingTicketRequestData
        {
        }


        public class ListMatchmakingTicketsForPlayerRequestData
        {
            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        public class ServerListMatchmakingTicketsForPlayerRequestData : ListMatchmakingTicketsForPlayerRequestData
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminListMatchmakingTicketsForPlayerRequestData : ServerListMatchmakingTicketsForPlayerRequestData
        {
        }


        public class CancelAllMatchmakingTicketResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        public class CreateMatchmakingTicketResponseData
        {
            [StringDataMember(code = GNParameterCode.TicketId)]
            public string ticketId;

        }

        public class MatchmakingTicketMember
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            [NumberDataMember(code = GNParameterCode.Status, mustInt = true)]
            public int status;

            [GNHashtableDataMember(code = GNParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        public class MatchmakingTicketResponseData
        {
            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.CreatorId, minLength = 10, maxLength = 10)]
            public string creatorId;

            [NumberDataMember(code = GNParameterCode.GiveUpAfterSeconds)]
            public int giveUpAfterSeconds;

            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [NumberDataMember(code = GNParameterCode.Status, mustInt = true)]
            public int status;

            [StringDataMember(code = GNParameterCode.MatchId, minLength = 15, maxLength = 15, isOptional = true)]
            public string? matchId;

            [GNArrayDataMember(code = GNParameterCode.Members, elementCls = typeof(MatchmakingTicketMember), isOptional = true)]
            public List<MatchmakingTicketMember>? members;

        }

        public class MatchmakingTicketWithTicketIdResponseData : MatchmakingTicketResponseData
        {
            [StringDataMember(code = GNParameterCode.TicketId)]
            public string ticketId;

        }

        public class GetMatchmakingTicketResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.MatchmakingTicket)]
            public MatchmakingTicketResponseData matchmakingTicket;

        }

        public class MatchMember
        {
            [StringDataMember(code = GNParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            [StringDataMember(code = GNParameterCode.TeamId)]
            public string teamId;

            [GNHashtableDataMember(code = GNParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        public class PortInfo
        {
            [StringDataMember(code = GNParameterCode.Name)]
            public string name;

            [NumberDataMember(code = GNParameterCode.PublicPort, mustInt = true, minValue = 0)]
            public ushort publicPort;

            [NumberDataMember(code = GNParameterCode.PrivatePort, mustInt = true, minValue = 0)]
            public ushort privatePort;

            [NumberDataMember(code = GNParameterCode.Protocol, mustInt = true, minValue = 1, maxValue = 2)]
            public ushort protocol;

        }

        public class ServerDetail
        {
            [StringDataMember(code = GNParameterCode.IpV4Address)]
            public string ipV4Address;

            [GNArrayDataMember(code = GNParameterCode.Ports, elementCls = typeof(PortInfo))]
            public List<PortInfo> ports;

        }

        public class MatchResponseData
        {
            [NumberDataMember(code = GNParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = GNParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNArrayDataMember(code = GNParameterCode.Members, elementCls = typeof(MatchMember), isOptional = true)]
            public List<MatchMember>? members;

            [NumberDataMember(code = GNParameterCode.TimeToMatchInSeconds)]
            public float timeToMatchInSeconds;

        }

        public class MatchWithMatchIdResponseData : MatchResponseData
        {
            [StringDataMember(code = GNParameterCode.MatchId)]
            public string matchId;

        }

        public class GetMatchResponseData
        {
            [GNHashtableDataMember(code = GNParameterCode.Match)]
            public MatchResponseData match;

        }

        public class GetQueueStatisticsResponseData
        {
            [NumberDataMember(code = GNParameterCode.PendingMemberCount, mustInt = true)]
            public int pendingMemberCount;

            [NumberDataMember(code = GNParameterCode.PendingTicketCount, mustInt = true)]
            public int pendingTicketCount;

            [NumberDataMember(code = GNParameterCode.AverageMatchmakingTimeInSeconds)]
            public float averageMatchmakingTimeInSeconds;

        }

        public class ListMatchmakingTicketsForPlayerResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        public class GetAllMatchResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MatchWithMatchIdResponseData), isOptional = true)]
            public List<MatchWithMatchIdResponseData>? results;

        }

        public class GetAllMatchmakingTicketResponseData
        {
            [GNArrayDataMember(code = GNParameterCode.Results, elementCls = typeof(MatchmakingTicketWithTicketIdResponseData), isOptional = true)]
            public List<MatchmakingTicketWithTicketIdResponseData>? results;

        }

        public class EmptyResponseData
        {
        }

    }
}
