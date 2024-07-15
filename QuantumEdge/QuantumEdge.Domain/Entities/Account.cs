using QuantumEdge.Domain.Entities.Common;

namespace QuantumEdge.Domain.Entities;

public class Account : IBaseEntity<Guid>
{
    public Guid Id { get; set; } = new Guid();
    public DateTime CreatedOnDateTime { get; set; }
    public DateTime ModifiedOnDateTime { get; set; }
    public bool Deleted { get; set; }
}