namespace Lab03.Ex04
{
	public class ChatPacket
	{
		public string Username { get; set; }
		public Cmd Command { get; set; }
		public string Content { get; set; }
	}

	public class DirectMessagePacket
	{
		public DirectMessagePacket() { }
		public DirectMessagePacket(string toUsername, Message message)
		{
			ToUsername = toUsername;
			Message = message;
		}

		public string ToUsername { get; set; }
		public Message Message { get; set; }
	}

	public class Message
	{
		public Message(string content, bool isImage)
		{
			Content = content;
			IsImage = isImage;
		}
		public Message() { }
		public string Content { get; set; }
		public bool IsImage { get; set; }
	}
}