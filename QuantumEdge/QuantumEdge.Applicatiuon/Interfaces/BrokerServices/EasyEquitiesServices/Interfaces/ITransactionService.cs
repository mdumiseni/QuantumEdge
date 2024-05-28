using QuantumEdge.Application.Common.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Interfaces;

public interface ITransactionService
{
    Task<ResultSet<string>> UploadTransactionHistory();
}