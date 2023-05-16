using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Lab03.Ex04
{
	public class ChatPacketSerializationBinder : ISerializationBinder
	{
		public Type BindToType(string assemblyName, string typeName)
		{
			if (typeName == "ChatPacket")
			{
				return typeof(ChatPacket);
			}
			return null;
		}

		public void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			assemblyName = null;
			if (serializedType == typeof(ChatPacket))
			{
				typeName = "ChatPacket";
			}
			else
			{
				typeName = null;
			}
		}
	}

	public static class Common {
		public static ArraySegment<byte> ObjectToArraySegment(object obj)
		{
			var serializerSettings = new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Objects,
				SerializationBinder = new ChatPacketSerializationBinder()
			};
			var json = JsonConvert.SerializeObject(obj, serializerSettings);
			var bytes = Encoding.Unicode.GetBytes(json);
			return new ArraySegment<byte>(bytes, 0, bytes.Length);
		}

		public static object ArraySegmentToObject(ArraySegment<byte> segment)
		{
			var serializerSettings = new JsonSerializerSettings
			{
				TypeNameHandling = TypeNameHandling.Objects,
				SerializationBinder = new ChatPacketSerializationBinder()
			};
			var json = Encoding.Unicode.GetString(segment.Array, segment.Offset, segment.Count);
			return JsonConvert.DeserializeObject(json, serializerSettings);
		}

		public static string SerializeImage(Image image)
		{
			string base64String;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				image.Save(memoryStream, image.RawFormat);

				base64String = Convert.ToBase64String(memoryStream.ToArray());

			}
			return base64String;
		}

		public static Image DeserializeImage(string base64String)
		{
			byte[] imageBytes = Convert.FromBase64String(base64String);

			using (MemoryStream memoryStream = new MemoryStream(imageBytes))
			{
				Image image = Image.FromStream(memoryStream);
				return image;
			}
		}
	}
}
