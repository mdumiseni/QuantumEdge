using QuantumEdge.Application.Common.Model;

namespace QuantumEdge.Application.Interfaces.WorldClockService;

public interface IWorldClockService
{
    Task<ResultSet<Dictionary<string, DateTime>>> GetLocationDateTime(string currentLocation, string destinationTimeZone);
}