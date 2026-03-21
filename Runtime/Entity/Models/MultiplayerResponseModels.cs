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
        public class CancelAllMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.CancelAllMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the cancel matchmaking ticket operation.
        /// </summary>
        public class CancelMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the create matchmaking ticket operation.
        /// </summary>
        public class CreateMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.CreateMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get matchmaking ticket operation.
        /// </summary>
        public class GetMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.GetMatchmakingTicketResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get match operation.
        /// </summary>
        public class GetMatchOperationResponse : CustomOperationResponse<MultiplayerModels.GetMatchResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get queue statistics operation.
        /// </summary>
        public class GetQueueStatisticsOperationResponse : CustomOperationResponse<MultiplayerModels.GetQueueStatisticsResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the join matchmaking ticket operation.
        /// </summary>
        public class JoinMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.EmptyResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the list matchmaking tickets for player operation.
        /// </summary>
        public class ListMatchmakingTicketsForPlayerOperationResponse : CustomOperationResponse<MultiplayerModels.ListMatchmakingTicketsForPlayerResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get all match operation.
        /// </summary>
        public class GetAllMatchOperationResponse : CustomOperationResponse<MultiplayerModels.GetAllMatchResponseData>
        {

        }

        /// <summary>
        /// Represents the typed response for the get all matchmaking ticket operation.
        /// </summary>
        public class GetAllMatchmakingTicketOperationResponse : CustomOperationResponse<MultiplayerModels.GetAllMatchmakingTicketResponseData>
        {

        }

    }

}