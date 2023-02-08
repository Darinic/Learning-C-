using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Workshop5.API.Domain.Entity;

namespace Workshop5.API.Infrastructure.Data
{
	public class DbDataContext : DbContext
	{
		public DbDataContext(DbContextOptions<DbDataContext> options)
		: base(options)
		{
		}

		public DbSet<Student> Students { get; set; }
	}
}
