using System.ComponentModel.DataAnnotations;

namespace QuantumEdge.Domain.Entities.Common;

public interface IBaseEntity<T>
{
    [Key]
    public T Id { get; set; }
    public DateTime CreatedOnDateTime { get; set; }
    public bool Deleted { get; set; }
}