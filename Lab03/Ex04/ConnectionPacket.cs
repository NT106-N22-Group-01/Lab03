namespace Lab03
{
	public class UserConnectionPacket
	{
		public string Username { get; set; }
		public bool IsJoining { get; set; }
		public List<string> Users { get; set; }
	}
}
