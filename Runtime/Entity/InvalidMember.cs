namespace XmobiTea.GN.Entity
{
    using System.Text;
    using XmobiTea.GN.Constant;

    public struct InvalidMember
    {
        public int code { get; private set; }
        public InvalidMemberType invalidMemberType { get; private set; }

        public InvalidMember(int code, InvalidMemberType invalidMemberType)
        {
            this.code = code;
            this.invalidMemberType = invalidMemberType;
        }

        public string toString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("Code: " + this.code + ", InvalidMemberType " + this.invalidMemberType);

            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return this.toString();
        }

    }

}
