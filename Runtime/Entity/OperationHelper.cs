using XmobiTea.GN.Constant;

namespace XmobiTea.GN.Entity
{
    public class OperationHelper
    {
        public static object ToSocketData(RequestType requestType, RequestRole requestRole, OperationRequest request)
        {
            var requestId = request.GetRequestId();

            if (requestId == -1)
                return new object[] {
                    request.GetOperationCode(),
                    (int)requestType,
                    (int)requestRole,
                    (request.GetParameters() == null) ? null : request.GetParameters().ToData()
                };
            else
                return new object[] {
                    request.GetOperationCode(),
                    (int)requestType,
                    (int)requestRole,
                    (request.GetParameters() == null) ? null : request.GetParameters().ToData(),
                    requestId
                };
        }

        public static object ToHttpData(RequestType requestType, RequestRole requestRole, OperationRequest request)
        {
            return null;
        }

    }

}
