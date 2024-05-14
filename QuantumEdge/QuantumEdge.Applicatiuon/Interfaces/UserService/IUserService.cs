using QuantumEdge.Application.Common.Model;
using QuantumEdge.Domain.Entities;

namespace QuantumEdge.Application.Interfaces.UserService;

public interface IUserService
{
    Task<ResultSet<ApplicationUser>> Register(ApplicationUser user);
}