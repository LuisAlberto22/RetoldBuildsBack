using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Retold.Api.Entities;
using System.Reflection;

namespace Retold.Api.Data
{
	public class ApplicationDBContext : IdentityDbContext<User>
	{
		public ApplicationDBContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
		}

	}
}
