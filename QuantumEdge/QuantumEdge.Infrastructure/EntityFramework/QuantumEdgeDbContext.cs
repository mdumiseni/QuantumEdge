using Microsoft.EntityFrameworkCore;
using QuantumEdge.Domain.Entities;

namespace QuantumEdge.Infrastructure.EntityFramework;

public class QuantumEdgeDbContext : DbContext
{
    public QuantumEdgeDbContext(DbContextOptions<QuantumEdgeDbContext> options) : base(options)
    {
        
    }
    public DbSet<ApplicationUser> User { get; set; }
    public DbSet<Account> Account { get; set; }
}
