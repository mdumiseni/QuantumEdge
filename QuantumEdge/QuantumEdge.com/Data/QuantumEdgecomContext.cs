using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuantumEdge.com.Data;

namespace QuantumEdge.com.Data
{
    public class QuantumEdgecomContext(DbContextOptions<QuantumEdgecomContext> options) : IdentityDbContext<QuantumEdgeUser>(options)
    {
    }
}
