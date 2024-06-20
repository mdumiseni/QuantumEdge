using Microsoft.AspNetCore.Identity;
using QuantumEdge.Domain.Entities.Common;

namespace QuantumEdge.Domain.Entities.User;

public class ApplicationUser : IdentityUser<Guid>, IBaseEntity<Guid>
{
    public DateTime CreatedOnDateTime { get; set; }
    public bool Deleted { get; set; }
}