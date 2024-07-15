using QuantumEdge.Application.Interfaces.Repositories;
using QuantumEdge.Domain.Entities.User;
using QuantumEdge.Infrastructure.EntityFramework;

namespace QuantumEdge.Infrastructure.Repositories;

public class UserRepository(QuantumEdgeDbContext context) : Repository<ApplicationUser>(context), IUserRepository
{
    
}