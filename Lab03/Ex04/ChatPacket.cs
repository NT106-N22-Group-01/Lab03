namespace Lab03.Ex04
{
	public class ChatPacket
	{
		public string Username { get; set; }
		public Cmd Command { get; set; }
		public string Content { get; set; }
	}
}