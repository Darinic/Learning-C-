using Workshop5.API.Core.Interfaces;
using Workshop5.API.Domain.Entity;
using Workshop5.API.Infrastructure.Data;

namespace Workshop5.API.Infrastructure.Repositories
{
	public class StudentRepository : IStudentRepository
	{
		private readonly DbDataContext _dbContext;

		public StudentRepository(DbDataContext dbContext)
		{
			_dbContext = dbContext;
		}

		public void Create(Student student)
		{
			student.Id = Guid.NewGuid();
			_dbContext.Students.Add(student);
			_dbContext.SaveChanges();
		}
	}
}
