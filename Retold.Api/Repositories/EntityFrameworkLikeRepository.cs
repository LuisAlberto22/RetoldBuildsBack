using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkLikeRepository : EntityFrameworkGenericRepository<Like>, ILikeRepository
	{
		public EntityFrameworkLikeRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
