using QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Interfaces;
using QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Model;

namespace QuantumEdge.Application.Services.EasyEquitiesService;

public class AccountService : IAccountService
{
    public async Task<EasyAccountViewModel> GetAccountInformation()
    {
        return new EasyAccountViewModel("EE-23JFF", new Dictionary<string, string>());
    }
}