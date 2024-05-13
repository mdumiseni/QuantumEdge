using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

public interface IAccountService
{
    Task<AccountViewModel> GetAccountInformation();
}