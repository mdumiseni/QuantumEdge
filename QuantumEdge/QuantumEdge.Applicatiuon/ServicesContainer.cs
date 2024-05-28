using Alpaca.Markets;
using AlpacaAccount.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;
using QuantumEdge.Application.Interfaces.MessagingService;
using QuantumEdge.Application.Interfaces.UserService;
using QuantumEdge.Application.Services.AlpacaService;
using QuantumEdge.Application.Services.UserService;

namespace QuantumEdge.Application;

public static class ServicesContainer
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        var alpacaClient =
            Environments.Paper.GetAlpacaTradingClient(new SecretKey(configuration["AlpacaAccount:Api_Key"] ?? "", configuration["AlpacaAccount:Api_Secret"] ?? ""));
        services.AddSingleton<IAccountService>(_ => new AccountService(alpacaClient));
        
        services.AddTransient<UserEmailingService>();
        services.AddTransient<IUserService, UserService>();
        services
            .AddTransient<Interfaces.BrokerServices.EasyEquitiesServices.Interfaces.IAccountService, Services.EasyEquitiesService.AccountService >();
        return services;
    }

}