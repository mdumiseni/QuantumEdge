using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using QuantumEdge.Application.Interfaces.Repositories;
using QuantumEdge.Infrastructure.EntityFramework;

namespace QuantumEdge.Infrastructure.Repositories;

public class Repository<TEntity>(QuantumEdgeDbContext context) : IRepository<TEntity> where TEntity : class
{
    public async Task<TEntity?> GetById<TId>(TId id) => await context.Set<TEntity>().FindAsync(id) ;

    public async Task<IEnumerable<TEntity>> GetAll() => await context.Set<TEntity>().ToListAsync();

    public async Task<IEnumerable<TEntity>?> GetAllByExpression(Expression<Func<TEntity, bool>> predicate)
        => await context.Set<TEntity>().Where(predicate).ToListAsync();

    public async Task<TEntity?> GetObjectByExpression(Expression<Func<TEntity, bool>> predicate)
        => await context.Set<TEntity>().Where(predicate).FirstOrDefaultAsync();

    public async Task Add(TEntity entity)
        => context.Entry(entity).State = EntityState.Added;

    public async Task Update(TEntity entity)
        => context.Entry(entity).State = EntityState.Modified;
}