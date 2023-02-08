using Workshop5.API.Core.Requests.Auth;
using Workshop5.API.Core.Responses.Auth;
using Workshop5.API.Domain.Entity;

namespace Workshop5.API.Core.Interfaces
{
	public interface IStudentRepository
	{
		void Create(Student student);
	}
}
