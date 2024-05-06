using Alpaca.Markets;
using AlpacaAccount.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;
using QuantumEdge.Application.Services.AlpacaService;

namespace QuantumEdge.Application;

public static class ServicesContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        var alpacaClient = Environments.Paper.GetAlpacaTradingClient(new SecretKey("",""));
        services.AddSingleton<IAssetsService>(new AssetService(alpacaClient));
        // services.AddTransient<IPositionService, PositionService>();
        // services.AddTransient<IOrderService, OrderService>();
        // services.AddTransient<IWishListService, WishListService>();
        return services;
    }

}