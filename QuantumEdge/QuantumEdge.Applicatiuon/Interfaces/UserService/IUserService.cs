using QuantumEdge.Application.Common.Model;
using QuantumEdge.Domain.Entities;
using QuantumEdge.Domain.Entities.User;

namespace QuantumEdge.Application.Interfaces.UserService;

public interface IUserService
{
    Task<ResultSet<ApplicationUser>> Register(ApplicationUser user);
}