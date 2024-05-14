using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.UserService;
using QuantumEdge.Domain.Entities;

namespace QuantumEdge.Application.Services.UserService;

public class UserService : IUserService
{
    public async Task<ResultSet<ApplicationUser>> Register(ApplicationUser user)
    {
        throw new NotImplementedException();
    }
}