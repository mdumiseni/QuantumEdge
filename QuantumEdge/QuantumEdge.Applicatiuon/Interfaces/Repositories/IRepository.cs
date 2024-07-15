using System.Linq.Expressions;

namespace QuantumEdge.Application.Interfaces.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetById<TId>(TId id);
    Task<IEnumerable<TEntity>> GetAll();
    Task<IEnumerable<TEntity>?> GetAllByExpression(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> GetObjectByExpression(Expression<Func<TEntity, bool>> predicate);
    Task Add(TEntity entity);
    Task Update(TEntity entity);
}