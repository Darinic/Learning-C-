using AutoMapper;
using Workshop5.API.Core.Requests.Auth;
using Workshop5.API.Domain.Entity;

namespace Workshop5.API.Core.Mapping
{
	public class StudentMapping : Profile
	{
		public StudentMapping()
		{
			CreateMap<CreateStudentRequest, Student>();
		}
	}
}
