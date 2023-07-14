namespace AlibabaPBYS.Core.Interfaces.Repository;

public interface IBaseRepository<T> where T : class
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetById(int id);
}