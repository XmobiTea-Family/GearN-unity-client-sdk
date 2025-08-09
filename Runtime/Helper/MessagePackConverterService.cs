namespace XmobiTea.GearN.Helper
{
    using XmobiTea.Binary;
    using XmobiTea.Binary.MessagePack;

    public static class MessagePackConverterService
    {
        private static IBinaryConverter binaryConverter { get; }

        static MessagePackConverterService()
        {
            MessagePackConverterService.binaryConverter = new BinaryConverter();
        }

        public static byte[] serialize<T>(T tObj) => MessagePackConverterService.binaryConverter.Serialize<T>(tObj);

        public static T deserialize<T>(byte[] data) => MessagePackConverterService.binaryConverter.Deserialize<T>(data);

    }

}
