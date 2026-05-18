namespace XmobiTea.GearN.Entity.Models
{
    using XmobiTea.GearN.Entity.Response;

    /// <summary>
    /// Defines typed response wrappers for multiplayer operations.
    /// </summary>
    public class MultiplayerResponseModels
    {
        /// <summary>
        /// Represents the typed response for the cancel all matchmaking ticket operation.
        /// </summary>
        public class CancelAllMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.CancelAllMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the cancel matchmaking ticket operation.
        /// </summary>
        public class CancelMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the create matchmaking ticket operation.
        /// </summary>
        public class CreateMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.CreateMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get matchmaking ticket operation.
        /// </summary>
        public class GetMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.GetMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get match operation.
        /// </summary>
        public class GetMatchOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.GetMatchResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get queue statistics operation.
        /// </summary>
        public class GetQueueStatisticsOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.GetQueueStatisticsResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the join matchmaking ticket operation.
        /// </summary>
        public class JoinMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the list matchmaking tickets for player operation.
        /// </summary>
        public class ListMatchmakingTicketsForPlayerOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.ListMatchmakingTicketsForPlayerResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get all match operation.
        /// </summary>
        public class GetAllMatchOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.GetAllMatchResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get all matchmaking ticket operation.
        /// </summary>
        public class GetAllMatchmakingTicketOperationResponse : CustomOperationResponseAbstract<MultiplayerModels.GetAllMatchmakingTicketResponseData>
        {

        }

    }

}