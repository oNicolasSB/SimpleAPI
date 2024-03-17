namespace CoffeeShoper.Domain;

public interface IBaseRepository<TEntity>
{
    IEnumerable<TEntity> GetAll(params string[] includes);
    IEnumerable<TEntity> GetAllReadOnly(params string[] includes);
    TEntity? GetById(int id);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    void Delete(TEntity entity);
}