
using AlibabaPBYS.Core.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace AlibabaPBYS.DataAccessLayer.Repository;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly ApplicationDBContext _dbContext;
    private readonly DbSet<T> _dbSet;
    public BaseRepository(ApplicationDBContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<T>();
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(T entity)
    {
        _dbSet.Remove(entity);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetById(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        var updatedEntity = _dbSet.Update(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}
