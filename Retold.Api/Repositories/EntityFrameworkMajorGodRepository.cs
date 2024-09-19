using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkMajorGodRepository : EntityFrameworkGenericRepository<MajorGod>, IMajorGodRepository
	{
		public EntityFrameworkMajorGodRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
