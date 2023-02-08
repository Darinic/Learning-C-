using Workshop5.API.Core.Responses.Auth;
using Workshop5.API.Domain.Entity;

namespace Workshop5.API.Core.Interfaces
{
	public interface IJwtService
	{
		public JwtResponse BuildJwt(Student student);
	}
}
