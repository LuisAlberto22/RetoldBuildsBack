using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkPantheonRepository : EntityFrameworkGenericRepository<Pantheon>, IPantheonRepository
	{
		public EntityFrameworkPantheonRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
