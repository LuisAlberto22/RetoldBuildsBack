using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkTagRepository : EntityFrameworkGenericRepository<Tag>, ITagRepository
	{
		public EntityFrameworkTagRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
