using Microsoft.EntityFrameworkCore;
using Retold.Api.Data;
using Retold.Api.Entities;
using Retold.Api.Repositories.Interfaces;
using Retold.Exceptions;

namespace Retold.Api.Repositories
{
	public class EntityFrameworkGenericRepository<T> : IGenericRepository<T> where T : EntityBase
	{
		protected DbSet<T> DbSet;
		protected DbContext dbContext;

		public EntityFrameworkGenericRepository(ApplicationDBContext appDbContext)
		{
			DbSet = appDbContext.Set<T>();
			dbContext = appDbContext;
		}

		public async Task<List<T>> GetAll()
		{
			return await DbSet.ToListAsync();
		}

		public async Task<T> GetById(int id)
		{
			var foundId = await DbSet.FindAsync(id);

			if (foundId is null)
			{
				throw new NotFoundException();
			}

			return foundId;
		}

		public async Task<T> Create(T model)
		{
			DbSet.Add(model);
			await dbContext.SaveChangesAsync();
			return model;
		}

		public async Task<T> Update(T model)
		{
			DbSet.Update(model);
			await dbContext.SaveChangesAsync();
			return model;
		}

		public async Task<T> Delete(int id)
		{
			var fileDeleted = await GetById(id);
			await DbSet.Where(model => model.Id == id).ExecuteDeleteAsync();
			return fileDeleted;
		}
	}
}