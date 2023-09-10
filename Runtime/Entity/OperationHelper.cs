using XmobiTea.GN.Constant;

namespace XmobiTea.GN.Entity
{
    public class OperationHelper
    {
        public static object toSocketData(RequestType requestType, RequestRole requestRole, OperationRequest request)
        {
            var requestId = request.getRequestId();

            if (requestId == -1)
                return new object[] {
                    request.getOperationCode(),
                    (int)requestType,
                    (int)requestRole,
                    (request.getParameters() == null) ? null : request.getParameters().toData()
                };
            else
                return new object[] {
                    request.getOperationCode(),
                    (int)requestType,
                    (int)requestRole,
                    (request.getParameters() == null) ? null : request.getParameters().toData(),
                    requestId
                };
        }

        public static object toHttpData(RequestType requestType, RequestRole requestRole, OperationRequest request)
        {
            return null;
        }

    }

}
