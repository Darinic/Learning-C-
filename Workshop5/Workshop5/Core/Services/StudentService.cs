using AutoMapper;
using Workshop5.API.Core.Interfaces;
using Workshop5.API.Core.Requests.Auth;
using Workshop5.API.Core.Responses.Auth;
using Workshop5.API.Domain.Entity;

namespace Workshop5.API.Core.Services
{
	public class StudentService : IStudentService
	{
		private readonly  IStudentRepository _studentRepository;
		private readonly IMapper _mapper;

		public StudentService(IStudentRepository studentRepository, IMapper mapper)
		{
			_studentRepository = studentRepository;
			_mapper = mapper;
		}

		public Task<CreateStudentResponse> RegisterStudentAsync(CreateStudentRequest request)
		{
			var student = _mapper.Map<Student>(request);
			_studentRepository.Create(student);

			return Task.FromResult(new CreateStudentResponse
			{
				IsSuccess = true,
				Message = "Student created successfully"
			});
		}
	}
}
