using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;


public interface IPosition
{
    Task<ResultSet<Alpaca.Markets.IPosition>> GetPositionBySymbol(string symbol);
    Task<ResultSet<IReadOnlyList<Alpaca.Markets.IPosition>>> GetListOfPositionAsync();
}