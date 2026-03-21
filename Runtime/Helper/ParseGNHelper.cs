namespace XmobiTea.GearN.Helper
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;

    using IDictionary = System.Collections.IDictionary;
    using IEnumerable = System.Collections.IEnumerable;
    using IList = System.Collections.IList;

    /// <summary>
    /// Parses lightweight JSON text into dictionary and list structures used by the SDK.
    /// </summary>
    public class Parser : IDisposable
    {
        /// <summary>
        /// Stores the JSON value.
        /// </summary>
        private StringReader json;

        /// <summary>
        /// Initializes a new instance of the Parser class.
        /// </summary>
        private Parser(string jsonString)
        {
            this.json = new StringReader(jsonString);
        }

        /// <summary>
        /// Parses.
        /// </summary>
        public static object Parse(string jsonString)
        {
            using (var parser = new Parser(jsonString))
                return parser.ParseValue();
        }

        /// <summary>
        /// Disposes.
        /// </summary>
        public void Dispose()
        {
            this.json.Dispose();
            this.json = (StringReader)null;
        }

        /// <summary>
        /// Parses object.
        /// </summary>
        private Dictionary<string, object> ParseObject()
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            this.json.Read();
            while (true)
            {
                Parser.TOKEN nextToken;
                do
                {
                    nextToken = this.NextToken;
                    switch (nextToken)
                    {
                        case Parser.TOKEN.NONE:
                            goto label_3;
                        case Parser.TOKEN.CURLY_OPEN:
                            goto label_5;
                        case Parser.TOKEN.CURLY_CLOSE:
                            goto label_4;
                        default:
                            continue;
                    }
                }
                while (nextToken == Parser.TOKEN.COMMA);
            label_5:
                string index = this.ParseString();
                if (index != null)
                {
                    if (this.NextToken == Parser.TOKEN.COLON)
                    {
                        this.json.Read();
                        dictionary[index] = this.ParseValue();
                    }
                    else
                        goto label_8;
                }
                else
                    goto label_6;
            }
        label_3:
            return (Dictionary<string, object>)null;
        label_4:
            return dictionary;
        label_6:
            return (Dictionary<string, object>)null;
        label_8:
            return (Dictionary<string, object>)null;
        }

        /// <summary>
        /// Parses array.
        /// </summary>
        private List<object> ParseArray()
        {
            List<object> objectList = new List<object>();
            this.json.Read();
            bool flag = true;
            while (flag)
            {
                var nextToken = this.NextToken;
                switch (nextToken)
                {
                    case Parser.TOKEN.NONE:
                        return (List<object>)null;
                    case Parser.TOKEN.SQUARED_CLOSE:
                        flag = false;
                        continue;
                    case Parser.TOKEN.COMMA:
                        continue;
                    default:
                        object byToken = this.ParseByToken(nextToken);
                        objectList.Add(byToken);
                        continue;
                }
            }
            return objectList;
        }

        /// <summary>
        /// Parses value.
        /// </summary>
        private object ParseValue()
        {
            return this.ParseByToken(this.NextToken);
        }

        /// <summary>
        /// Parses by token.
        /// </summary>
        private object ParseByToken(Parser.TOKEN token)
        {
            switch (token)
            {
                case Parser.TOKEN.CURLY_OPEN:
                    return (object)this.ParseObject();
                case Parser.TOKEN.SQUARED_OPEN:
                    return (object)this.ParseArray();
                case Parser.TOKEN.STRING:
                    return (object)this.ParseString();
                case Parser.TOKEN.NUMBER:
                    return this.ParseNumber();
                case Parser.TOKEN.TRUE:
                    return (object)true;
                case Parser.TOKEN.FALSE:
                    return (object)false;
                case Parser.TOKEN.NULL:
                    return (object)null;
                default:
                    return (object)null;
            }
        }

        /// <summary>
        /// Parses string.
        /// </summary>
        private string ParseString()
        {
            StringBuilder stringBuilder1 = new StringBuilder();
            this.json.Read();
            bool flag = true;
            while (flag)
            {
                if (this.json.Peek() == -1)
                    break;
                char nextChar1 = this.NextChar;
                switch (nextChar1)
                {
                    case '"':
                        flag = false;
                        continue;
                    case '\\':
                        if (this.json.Peek() == -1)
                        {
                            flag = false;
                            continue;
                        }
                        char nextChar2 = this.NextChar;
                        switch (nextChar2)
                        {
                            case '"':
                            case '/':
                            case '\\':
                                stringBuilder1.Append(nextChar2);
                                continue;
                            case 'b':
                                stringBuilder1.Append('\b');
                                continue;
                            case 'f':
                                stringBuilder1.Append('\f');
                                continue;
                            case 'n':
                                stringBuilder1.Append('\n');
                                continue;
                            case 'r':
                                stringBuilder1.Append('\r');
                                continue;
                            case 't':
                                stringBuilder1.Append('\t');
                                continue;
                            case 'u':
                                StringBuilder stringBuilder2 = new StringBuilder();
                                for (int index = 0; index < 4; ++index)
                                    stringBuilder2.Append(this.NextChar);
                                stringBuilder1.Append((char)Convert.ToInt32(stringBuilder2.ToString(), 16));
                                continue;
                            default:
                                continue;
                        }
                    default:
                        stringBuilder1.Append(nextChar1);
                        continue;
                }
            }
            return stringBuilder1.ToString();
        }

        /// <summary>
        /// Parses number.
        /// </summary>
        private object ParseNumber()
        {
            double result;
            double.TryParse(this.NextWord, NumberStyles.Any, (IFormatProvider)CultureInfo.InvariantCulture, out result);
            return (object)result;
        }

        /// <summary>
        /// Executes the eat whitespace operation.
        /// </summary>
        private void EatWhitespace()
        {
            while (" \t\n\r".IndexOf(this.PeekChar) != -1)
            {
                this.json.Read();
                if (this.json.Peek() == -1)
                    break;
            }
        }

        private char PeekChar
        {
            get
            {
                return Convert.ToChar(this.json.Peek());
            }
        }

        private char NextChar
        {
            get
            {
                return Convert.ToChar(this.json.Read());
            }
        }

        private string NextWord
        {
            get
            {
                StringBuilder stringBuilder = new StringBuilder();
                while (" \t\n\r{}[],:\"".IndexOf(this.PeekChar) == -1)
                {
                    stringBuilder.Append(this.NextChar);
                    if (this.json.Peek() == -1)
                        break;
                }
                return stringBuilder.ToString();
            }
        }

        private Parser.TOKEN NextToken
        {
            get
            {
                this.EatWhitespace();
                if (this.json.Peek() == -1)
                    return Parser.TOKEN.NONE;
                switch (this.PeekChar)
                {
                    case '"':
                        return Parser.TOKEN.STRING;
                    case ',':
                        this.json.Read();
                        return Parser.TOKEN.COMMA;
                    case '-':
                    case '0':
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case 'I':
                    case 'N':
                        return Parser.TOKEN.NUMBER;
                    case ':':
                        return Parser.TOKEN.COLON;
                    case '[':
                        return Parser.TOKEN.SQUARED_OPEN;
                    case ']':
                        this.json.Read();
                        return Parser.TOKEN.SQUARED_CLOSE;
                    case '{':
                        return Parser.TOKEN.CURLY_OPEN;
                    case '}':
                        this.json.Read();
                        return Parser.TOKEN.CURLY_CLOSE;
                    default:
                        switch (this.NextWord)
                        {
                            case "false":
                                return Parser.TOKEN.FALSE;
                            case "true":
                                return Parser.TOKEN.TRUE;
                            case "null":
                                return Parser.TOKEN.NULL;
                            default:
                                return Parser.TOKEN.NONE;
                        }
                }
            }
        }

        /// <summary>
        /// Defines the available TOKEN values.
        /// </summary>
        private enum TOKEN
        {
            NONE,
            CURLY_OPEN,
            CURLY_CLOSE,
            SQUARED_OPEN,
            SQUARED_CLOSE,
            COLON,
            COMMA,
            STRING,
            NUMBER,
            TRUE,
            FALSE,
            NULL,
        }
    }

    /// <summary>
    /// Represents the serializer component.
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// Stores the builder value.
        /// </summary>
        private StringBuilder builder;

        /// <summary>
        /// Initializes a new instance of the Serializer class.
        /// </summary>
        private Serializer()
        {
            this.builder = new StringBuilder();
        }

        /// <summary>
        /// Executes the serialize operation.
        /// </summary>
        public static string Serialize(object obj)
        {
            var serializer = new Serializer();
            serializer.SerializeValue(obj);
            return serializer.builder.ToString();
        }

        /// <summary>
        /// Executes the serialize value operation.
        /// </summary>
        private void SerializeValue(object value)
        {
            //if (value is IGSData)
            //    value = (object)((IGSData)value).BaseData;
            if (value == null)
                this.builder.Append("null");
            else if (value is string str)
                this.SerializeString(str);
            else if (value is bool)
                this.builder.Append(value.ToString().ToLower());
            else if (value is IList anArray)
                this.SerializeArray(anArray);
            else if (value is IDictionary dictionary)
                this.SerializeObject(dictionary);
            else if (value is char)
                this.SerializeString(value.ToString());
            else
                this.SerializeOther(value);
        }

        /// <summary>
        /// Executes the serialize object operation.
        /// </summary>
        private void SerializeObject(IDictionary obj)
        {
            bool flag = true;
            this.builder.Append('{');
            foreach (object key in (IEnumerable)obj.Keys)
            {
                if (!flag)
                    this.builder.Append(',');
                this.SerializeString(key.ToString());
                this.builder.Append(':');
                this.SerializeValue(obj[key]);
                flag = false;
            }
            this.builder.Append('}');
        }

        /// <summary>
        /// Executes the serialize array operation.
        /// </summary>
        private void SerializeArray(IList anArray)
        {
            this.builder.Append('[');
            bool flag = true;
            foreach (object an in (IEnumerable)anArray)
            {
                if (!flag)
                    this.builder.Append(',');
                this.SerializeValue(an);
                flag = false;
            }
            this.builder.Append(']');
        }

        /// <summary>
        /// Executes the serialize string operation.
        /// </summary>
        private void SerializeString(string str)
        {
            this.builder.Append('"');
            foreach (char ch in str.ToCharArray())
            {
                switch (ch)
                {
                    case '\b':
                        this.builder.Append("\\b");
                        break;
                    case '\t':
                        this.builder.Append("\\t");
                        break;
                    case '\n':
                        this.builder.Append("\\n");
                        break;
                    case '\f':
                        this.builder.Append("\\f");
                        break;
                    case '\r':
                        this.builder.Append("\\r");
                        break;
                    case '"':
                        this.builder.Append("\\\"");
                        break;
                    case '\\':
                        this.builder.Append("\\\\");
                        break;
                    default:
                        int int32 = Convert.ToInt32(ch);
                        if (int32 >= 32 && int32 <= 126)
                        {
                            this.builder.Append(ch);
                            break;
                        }
                        this.builder.Append("\\u" + Convert.ToString(int32, 16).PadLeft(4, '0'));
                        break;
                }
            }
            this.builder.Append('"');
        }

        /// <summary>
        /// Executes the serialize other operation.
        /// </summary>
        private void SerializeOther(object value)
        {
            switch (value)
            {
                case float _:
                case int _:
                case uint _:
                case long _:
                case double _:
                case sbyte _:
                case byte _:
                case short _:
                case ushort _:
                case ulong _:
                case Decimal _:
                    this.builder.AppendFormat((IFormatProvider)CultureInfo.InvariantCulture, "{0}", value);
                    break;
                default:
                    this.SerializeString(value.ToString());
                    break;
            }
        }

    }

}