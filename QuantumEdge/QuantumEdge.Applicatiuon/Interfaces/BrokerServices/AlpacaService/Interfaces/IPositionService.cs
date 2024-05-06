using QuantumEdge.Application.Common.Model;
namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;


public interface IPositionService
{
    Task<ResultSet<Alpaca.Markets.IPosition>> GetPositionBySymbol(string symbol);
    Task<ResultSet<IReadOnlyList<Alpaca.Markets.IPosition>>> GetListOfPositionAsync();
}