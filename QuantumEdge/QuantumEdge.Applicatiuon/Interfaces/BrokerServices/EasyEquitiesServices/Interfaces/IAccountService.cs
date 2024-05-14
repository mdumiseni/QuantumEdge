using QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Interfaces;

public interface IAccountService
{
    Task<EasyAccountViewModel> GetAccountInformation();
}