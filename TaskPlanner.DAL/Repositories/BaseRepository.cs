using FonTech.Domain.Interface.Repositories;

namespace TaskPlanner.DAL.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _dbContext;
    public BaseRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public IQueryable<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>();
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        if (entity == null)
        {
            new ArgumentNullException("Entity is Null");
        }

        await _dbContext.AddAsync<TEntity>(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        if (entity == null)
        {
            new ArgumentNullException("Entity is Null");
        }

        _dbContext.Update<TEntity>(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> RemoveAsync(TEntity entity)
    {
        if (entity == null)
        {
            new ArgumentNullException("Entity is Null");
        }
        _dbContext.Remove<TEntity>(entity);
        await _dbContext.SaveChangesAsync();
        return entity;
    }
}