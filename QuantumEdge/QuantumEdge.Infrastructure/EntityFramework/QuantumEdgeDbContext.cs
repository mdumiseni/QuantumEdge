using Microsoft.EntityFrameworkCore;
using QuantumEdge.Domain.Entities;
using QuantumEdge.Domain.Entities.User;

namespace QuantumEdge.Infrastructure.EntityFramework;

public class QuantumEdgeDbContext(DbContextOptions<QuantumEdgeDbContext> options) : DbContext(options)
{
    public DbSet<ApplicationUser> User { get; set; }
    public DbSet<Account> Account { get; set; }
}
