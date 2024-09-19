using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkStatusRepository : EntityFrameworkGenericRepository<Status>, IStatusRepository
	{
		public EntityFrameworkStatusRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
