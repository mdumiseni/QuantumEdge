using Alpaca.Markets;

namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

public interface IAssetsService
{
    Task<IReadOnlyList<IAsset>> GetAssetList();
    Task<bool> isAssetTradable(string ticker);
}