namespace Retold.Api.Repositories.Interfaces
{
	public interface IGenericRepository<T> where T : class
    {
        Task<T> Create(T model);
        Task<T> Delete(int id);
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Update(T model);
    }
}