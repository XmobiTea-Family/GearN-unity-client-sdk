namespace XmobiTea.GearN.Entity
{
    using System.Text;
    using XmobiTea.GearN.Constant;

    /// <summary>
    /// Represents an invalid member with its code and type of invalidation.
    /// </summary>
    public struct InvalidMember
    {
        /// <summary>
        /// Gets the code identifying the invalid member.
        /// </summary>
        public string code { get; private set; }

        /// <summary>
        /// Gets the type of invalidation for the member.
        /// </summary>
        public InvalidMemberType invalidMemberType { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidMember"/> struct.
        /// </summary>
        /// <param name="code">The code identifying the invalid member.</param>
        /// <param name="invalidMemberType">The type of invalidation.</param>
        public InvalidMember(string code, InvalidMemberType invalidMemberType)
        {
            this.code = code;
            this.invalidMemberType = invalidMemberType;
        }

        /// <summary>
        /// Converts the invalid member to a string representation.
        /// </summary>
        /// <returns>A string describing the invalid member.</returns>
        public string toString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.Append("Code: " + this.code + ", InvalidMemberType: " + this.invalidMemberType);
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Overrides the default ToString method.
        /// </summary>
        /// <returns>A string describing the invalid member.</returns>
        public override string ToString()
        {
            return this.toString();
        }
    }
}
