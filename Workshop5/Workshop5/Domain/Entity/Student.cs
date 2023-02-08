namespace Workshop5.API.Domain.Entity
{
	public class Student
	{
		public string Username { get; set; }

		public string PasswordHash { get; set; }

		public string PasswordSalt { get; set; }

		public Guid Id { get; set; }
	}
}
