//namespace XmobiTea.GN.Helper
//{
//	using BestHTTP.SocketIO;
//    using System;
//    using System.Text;

//    public class DecoderHelper
//	{
//		public Packet Decode(string data)
//		{
//			try
//			{
//				int offset = 0;

//				// look up packet type
//				int transportEventType = int.Parse(data.Substring(offset, 1));
//				var transportEvent = (TransportEventTypes)transportEventType;

//				var packetType = transportEventType == (int)TransportEventTypes.Message ? (SocketIOEventTypes)int.Parse(data.Substring(++offset, 1)) : SocketIOEventTypes.Unknown;

//				if (data.Length <= 2)
//				{
//					return new Packet(transportEvent, packetType, "/", string.Empty);
//				}

//				string nsp = null;

//				// look up namespace (if any)
//				if ('/' == data[offset + 1])
//				{
//					var builder = new StringBuilder();
//					while (offset < data.Length - 1 && data[++offset] != ',')
//					{
//						builder.Append(data[offset]);
//					}
//					nsp = builder.ToString();
//				}
//				else
//				{
//					nsp = "/";
//				}

//				var id = 0;
//				// look up id
//				char next = data[offset + 1];
//				if (next != ' ' && char.IsNumber(next))
//				{
//					StringBuilder builder = new StringBuilder();
//					while (offset < data.Length - 1)
//					{
//						char c = data[++offset];
//						if (char.IsNumber(c))
//						{
//							builder.Append(c);
//						}
//						else
//						{
//							--offset;
//							break;
//						}
//					}
//					id = int.Parse(builder.ToString());
//				}

//				//// look up json data
//				//if (++offset < data.Length - 1)
//				//{
//				//	try
//				//	{
//				//		new Packet().Decode

//				//		//#if SOCKET_IO_DEBUG
//				//		//xDebug.Log("[SocketIO] Parsing JSON: " + data.Substring(offset));
//				//		//#endif
//				//		packet.json = new JSONObject(data.Substring(offset));
//				//	}
//				//	catch (Exception ex)
//				//	{
//				//		Debug.LogException(ex);
//				//	}
//				//}

//				return new Packet(transportEvent, packetType, nsp, "", 0, id);

//			}
//			catch (Exception ex)
//			{
//				throw new Exception("Packet decoding failed: " + data, ex);
//			}
//		}
//	}
//}
