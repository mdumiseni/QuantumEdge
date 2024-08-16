using QuantumEdge.Application.Common.Model;
using QuantumEdge.Shared.EasyEquities.Models;

namespace QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Interfaces;

public interface ITransactionService
{
    Task<ResultSet<string>> UploadTransactionHistory();

    Task<ResultSet<TransactionViewModel>> ReadTransaction(string filePath);
}