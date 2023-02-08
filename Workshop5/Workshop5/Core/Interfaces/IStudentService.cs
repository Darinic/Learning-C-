using Workshop5.API.Core.Requests.Auth;
using Workshop5.API.Core.Responses.Auth;

namespace Workshop5.API.Core.Interfaces
{
	public interface IStudentService
	{
		Task<CreateStudentResponse> RegisterStudentAsync(CreateStudentRequest request);
	}
}
