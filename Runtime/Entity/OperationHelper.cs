using XmobiTea.GN.Constant;

namespace XmobiTea.GN.Entity
{
    /// <summary>
    /// Utility class for handling operations and formatting data for socket or HTTP communication.
    /// </summary>
    public class OperationHelper
    {
        /// <summary>
        /// Converts an operation request to a format suitable for socket transmission.
        /// </summary>
        /// <param name="requestType">The type of the request (e.g., command, query).</param>
        /// <param name="role">The role of the request (e.g., client, admin).</param>
        /// <param name="request">The operation request to be formatted.</param>
        /// <returns>A formatted object array ready for socket transmission.</returns>
        public static object toSocketData(RequestType requestType, RequestRole role, OperationRequest request)
        {
            var requestId = request.getRequestId();

            if (requestId == -1)
                return new object[] {
                    requestType.ToString(),
                    request.getOperationCode(),
                    role.ToString(),
                    (request.getParameters() == null) ? null : request.getParameters().toData()
                };
            else
                return new object[] {
                    requestType.ToString(),
                    request.getOperationCode(),
                    role.ToString(),
                    (request.getParameters() == null) ? null : request.getParameters().toData(),
                    requestId
                };
        }

        /// <summary>
        /// Converts an operation request to a format suitable for HTTP transmission.
        /// </summary>
        /// <param name="requestType">The type of the request (e.g., command, query).</param>
        /// <param name="role">The role of the request (e.g., client, admin).</param>
        /// <param name="request">The operation request to be formatted.</param>
        /// <returns>A formatted object representing the HTTP request data.</returns>
        public static object toHttpData(RequestType requestType, RequestRole role, OperationRequest request)
        {
            // Implementation to format data for HTTP communication.
            return null;
        }
    }
}
