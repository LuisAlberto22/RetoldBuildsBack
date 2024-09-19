﻿using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkCategoryRepository : EntityFrameworkGenericRepository<Category>, ICategoryRepository
	{
		public EntityFrameworkCategoryRepository(ApplicationDBContext appDbContext) : base(appDbContext)
		{
		}
	}
}
