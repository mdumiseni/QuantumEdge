
using Alpaca.Markets;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

namespace AlpacaAccount.Services;

public class PositionService(IAlpacaTradingClient client) : IPositionService
{
    public async Task<ResultSet<Alpaca.Markets.IPosition>> GetPositionBySymbol(string symbol)
    {
        var position = await client.GetPositionAsync(symbol);
        return new ResultSet<Alpaca.Markets.IPosition>(){ ResultStatus = ResultStatus.Success, Data = position};
    }

    public async Task<ResultSet<IReadOnlyList<Alpaca.Markets.IPosition>>> GetListOfPositionAsync()
    {
        var positions = await client.ListPositionsAsync();
        return new ResultSet<IReadOnlyList<Alpaca.Markets.IPosition>>(){ ResultStatus = ResultStatus.Success, Data = positions};
    }
}