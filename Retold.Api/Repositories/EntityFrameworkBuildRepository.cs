using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkBuildRepository : EntityFrameworkGenericRepository<Build>, IBuildRepository
	{
		public EntityFrameworkBuildRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
