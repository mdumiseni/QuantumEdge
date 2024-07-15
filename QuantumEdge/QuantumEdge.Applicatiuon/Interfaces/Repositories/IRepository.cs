namespace QuantumEdge.Application.Interfaces.Repositories;

public interface IRepository<TEntity> where T : class
{

    Task<TEntity> GetById
}