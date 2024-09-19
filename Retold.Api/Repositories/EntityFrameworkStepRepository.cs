using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkStepRepository : EntityFrameworkGenericRepository<Step>, IStepRepository
	{
		public EntityFrameworkStepRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
