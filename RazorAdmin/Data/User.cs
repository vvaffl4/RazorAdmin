using RazorAdmin.Data;

namespace RazorAdmin.Data
{
	public class User
	{
		public string UserName { get; set; }
		public string Password { get; set; }
	}

	public static class Example
	{
		public static IEnumerable<User> Users = new User[]
		{
			new User{ UserName = "Admin", Password = "Admin!" },
			new User { UserName = "User1", Password = "User1!" },
			new User { UserName = "User2", Password = "User2!" },
			new User { UserName = "User3", Password = "User3!" },
			new User { UserName = "User4", Password = "User4!" }
		};
	}
}
