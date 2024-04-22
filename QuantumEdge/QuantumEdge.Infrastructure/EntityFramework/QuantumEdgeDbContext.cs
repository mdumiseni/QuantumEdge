using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumEdge.Infrastructure.EntityFramework;

public class QuantumEdgeDbContext : DbContext
{
    public QuantumEdgeDbContext(DbContextOptions<QuantumEdgeDbContext> options) : base(options)
    {
        
    }
}
