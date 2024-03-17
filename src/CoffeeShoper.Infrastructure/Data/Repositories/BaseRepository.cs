using CoffeeShoper.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoffeeShoper.Infrastructure.Data.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public TEntity Add(TEntity entity)
    {
        return _context.Set<TEntity>().Add(entity).Entity;
    }

    public void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public IEnumerable<TEntity> GetAll(params string[] includes)
    {
        var query = _context.Set<TEntity>().AsQueryable();

        foreach (var include in includes)
            query = query.Include(include);

        return query;
    }

    public IEnumerable<TEntity> GetAllReadOnly(params string[] includes)
    {
        var query = _context.Set<TEntity>().AsNoTracking();

        foreach (var include in includes)
            query = query.Include(include);

        return query;
    }

    public TEntity? GetById(int id)
    {
        return _context.Set<TEntity>().Find(id);
    }

    public TEntity Update(TEntity entity)
    {
        return _context.Set<TEntity>().Update(entity).Entity;
    }
}