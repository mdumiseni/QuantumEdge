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
        var alpacaClient =
            Environments.Paper.GetAlpacaTradingClient(new SecretKey(configuration["AlpacaAccount:Api_Key"], configuration["AlpacaAccount:Api_Secret"]));
        services.AddSingleton<IAccountService>(_ => new AccountService(alpacaClient));
        return services;
    }

}