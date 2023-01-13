namespace XmobiTea.GN.Entity
{
    public class OperationHelper
    {
        public static object ToSocketData(OperationRequest request)
        {
            var requestId = request.GetRequestId();

            if (requestId == -1)
                return new object[] {
                    request.GetOperationCode(),
                    (request.GetParameters() == null) ? null : request.GetParameters().ToData()
                };
            else
                return new object[] {
                    request.GetOperationCode(),
                    (request.GetParameters() == null) ? null : request.GetParameters().ToData(),
                    requestId
                };
        }

        public static object ToHttpData(OperationRequest request)
        {
            return null;
        }

    }

}
