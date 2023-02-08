namespace Workshop5.API.Core.Responses.Auth
{
	public class CreateStudentResponse
	{
		public string Message { get; set; }

		public bool IsSuccess { get; set; }

		public IEnumerable<string> Errors { get; set; }
	}
}
