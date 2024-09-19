using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkVideoRepository : EntityFrameworkGenericRepository<Video>, IVideoRepository
	{
		public EntityFrameworkVideoRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
