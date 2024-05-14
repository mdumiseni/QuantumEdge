using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuantumEdge.Application.Interfaces.MessagingService;
using QuantumEdge.Infrastructure.EntityFramework;

namespace QuantumEdge.Infrastructure;

public static class ServiceContainer
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<QuantumEdgeDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        
        services.AddTransient<IEmailService, EmailServices.MailKit>();
        
        return services;
    }

}
