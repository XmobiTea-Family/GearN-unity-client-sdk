namespace XmobiTea.GearN.Entity.Models
{
    using System.Collections.Generic;
    using XmobiTea.GearN.Common;
    using XmobiTea.GearN.Constant;

    public partial class MultiplayerModels
    {
        public class CancelAllMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        public class ServerCancelAllMatchmakingTicketRequestData : CancelAllMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCancelAllMatchmakingTicketRequestData : ServerCancelAllMatchmakingTicketRequestData
        {
        }


        public class CancelMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

        }

        public class ServerCancelMatchmakingTicketRequestData : CancelMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCancelMatchmakingTicketRequestData : ServerCancelMatchmakingTicketRequestData
        {
        }


        public class CreateMatchmakingTicketRequestData
        {
            [NumberDataMember(code = ParameterCode.GiveUpAfterSeconds, mustInt = true, minValue = 20)]
            public int giveUpAfterSeconds;

            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNHashtableDataMember(code = ParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

            [GNArrayDataMember(code = ParameterCode.Members, isOptional = true, elementCls = typeof(string))]
            public List<string>? members;

        }

        public class ServerCreateMatchmakingTicketRequestData : CreateMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminCreateMatchmakingTicketRequestData : ServerCreateMatchmakingTicketRequestData
        {
        }


        public class GetMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
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
            [StringDataMember(code = ParameterCode.MatchId, minLength = 15, maxLength = 15)]
            public string matchId;

            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
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
            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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
            [NumberDataMember(code = ParameterCode.Status, minValue = 1, maxValue = 5, mustInt = true, isOptional = true)]
            public int? status;

            [BooleanDataMember(code = ParameterCode.ReturnMember, isOptional = true, defaultValue = false)]
            public bool? returnMember;

            [NumberDataMember(code = ParameterCode.Skip, defaultValue = 0, minValue = 0, mustInt = true, isOptional = true)]
            public int? skip;

            [NumberDataMember(code = ParameterCode.Limit, defaultValue = 10, minValue = 5, maxValue = 100, mustInt = true, isOptional = true)]
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
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [NumberDataMember(code = ParameterCode.TimeInSeconds, mustInt = true, minValue = 20)]
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
            [StringDataMember(code = ParameterCode.TicketId, minLength = 10, maxLength = 10)]
            public string ticketId;

            [GNHashtableDataMember(code = ParameterCode.Attribute, isOptional = true)]
            public GNHashtable? attribute;

        }

        public class ServerJoinMatchmakingTicketRequestData : JoinMatchmakingTicketRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminJoinMatchmakingTicketRequestData : ServerJoinMatchmakingTicketRequestData
        {
        }


        public class ListMatchmakingTicketsForPlayerRequestData
        {
            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

        }

        public class ServerListMatchmakingTicketsForPlayerRequestData : ListMatchmakingTicketsForPlayerRequestData
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

        }

        public class AdminListMatchmakingTicketsForPlayerRequestData : ServerListMatchmakingTicketsForPlayerRequestData
        {
        }


        public class CancelAllMatchmakingTicketResponseData
        {
            [GNArrayDataMember(code = ParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        public class CreateMatchmakingTicketResponseData
        {
            [StringDataMember(code = ParameterCode.TicketId)]
            public string ticketId;

        }

        public class MatchmakingTicketMember
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            [NumberDataMember(code = ParameterCode.Status, mustInt = true)]
            public int status;

            [GNHashtableDataMember(code = ParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        public class MatchmakingTicketResponseData
        {
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.CreatorId, minLength = 10, maxLength = 10)]
            public string creatorId;

            [NumberDataMember(code = ParameterCode.GiveUpAfterSeconds)]
            public int giveUpAfterSeconds;

            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [NumberDataMember(code = ParameterCode.Status, mustInt = true)]
            public int status;

            [StringDataMember(code = ParameterCode.MatchId, minLength = 15, maxLength = 15, isOptional = true)]
            public string? matchId;

            [GNArrayDataMember(code = ParameterCode.Members, elementCls = typeof(MatchmakingTicketMember), isOptional = true)]
            public List<MatchmakingTicketMember>? members;

        }

        public class MatchmakingTicketWithTicketIdResponseData : MatchmakingTicketResponseData
        {
            [StringDataMember(code = ParameterCode.TicketId)]
            public string ticketId;

        }

        public class GetMatchmakingTicketResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.MatchmakingTicket)]
            public MatchmakingTicketResponseData matchmakingTicket;

        }

        public class MatchMember
        {
            [StringDataMember(code = ParameterCode.UserId, minLength = 10, maxLength = 10)]
            public string userId;

            [StringDataMember(code = ParameterCode.TeamId)]
            public string teamId;

            [GNHashtableDataMember(code = ParameterCode.Attribute)]
            public GNHashtable attribute;

        }

        public class PortInfo
        {
            [StringDataMember(code = ParameterCode.Name)]
            public string name;

            [NumberDataMember(code = ParameterCode.PublicPort, mustInt = true, minValue = 0)]
            public ushort publicPort;

            [NumberDataMember(code = ParameterCode.PrivatePort, mustInt = true, minValue = 0)]
            public ushort privatePort;

            [NumberDataMember(code = ParameterCode.Protocol, mustInt = true, minValue = 1, maxValue = 2)]
            public ushort protocol;

        }

        public class ServerDetail
        {
            [StringDataMember(code = ParameterCode.IpV4Address)]
            public string ipV4Address;

            [GNArrayDataMember(code = ParameterCode.Ports, elementCls = typeof(PortInfo))]
            public List<PortInfo> ports;

        }

        public class MatchResponseData
        {
            [NumberDataMember(code = ParameterCode.TsCreate)]
            public long tsCreate;

            [StringDataMember(code = ParameterCode.QueueName, minLength = 6, maxLength = 32)]
            public string queueName;

            [GNArrayDataMember(code = ParameterCode.Members, elementCls = typeof(MatchMember), isOptional = true)]
            public List<MatchMember>? members;

            [NumberDataMember(code = ParameterCode.TimeToMatchInSeconds)]
            public float timeToMatchInSeconds;

        }

        public class MatchWithMatchIdResponseData : MatchResponseData
        {
            [StringDataMember(code = ParameterCode.MatchId)]
            public string matchId;

        }

        public class GetMatchResponseData
        {
            [GNHashtableDataMember(code = ParameterCode.Match)]
            public MatchResponseData match;

        }

        public class GetQueueStatisticsResponseData
        {
            [NumberDataMember(code = ParameterCode.PendingMemberCount, mustInt = true)]
            public int pendingMemberCount;

            [NumberDataMember(code = ParameterCode.PendingTicketCount, mustInt = true)]
            public int pendingTicketCount;

            [NumberDataMember(code = ParameterCode.AverageMatchmakingTimeInSeconds)]
            public float averageMatchmakingTimeInSeconds;

        }

        public class ListMatchmakingTicketsForPlayerResponseData
        {
            [GNArrayDataMember(code = ParameterCode.TicketIds, elementCls = typeof(string))]
            public List<string> ticketIds;

        }

        public class GetAllMatchResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MatchWithMatchIdResponseData), isOptional = true)]
            public List<MatchWithMatchIdResponseData>? results;

        }

        public class GetAllMatchmakingTicketResponseData
        {
            [GNArrayDataMember(code = ParameterCode.Results, elementCls = typeof(MatchmakingTicketWithTicketIdResponseData), isOptional = true)]
            public List<MatchmakingTicketWithTicketIdResponseData>? results;

        }

        public class EmptyResponseData
        {
        }

    }
}
