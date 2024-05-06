using Alpaca.Markets;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

namespace QuantumEdge.Application.Services.AlpacaService;

public class AssetService(IAlpacaTradingClient client) : IAssetsService
{
    public async Task<IReadOnlyList<IAsset>> GetAssetList()
    {
        var assets = await client.ListAssetsAsync(
            new AssetsRequest { AssetStatus = AssetStatus.Active });
        return assets;
    }
    
    public async Task<bool> isAssetTradeable(string ticker)
    {
        try
        {
            var asset = await client.GetAssetAsync(ticker);
            return asset.IsTradable;
        }
        catch (Exception e)
        {
            Console.WriteLine($"{ticker} is not found.");
            return false;
        }
    }
}