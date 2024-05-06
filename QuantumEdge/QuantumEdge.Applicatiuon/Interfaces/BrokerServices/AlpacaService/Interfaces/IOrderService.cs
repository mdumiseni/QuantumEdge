using Alpaca.Markets;
using QuantumEdge.Application.Common.Model;

namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

public interface IOrderService
{
    Task<ResultSet<IOrder>> CreateNewOrder(string ticker, int numberOfShares);
    Task<IOrder?> GetOrder(string orderId);
    Task<IReadOnlyList<IOrder>> GetAllOrder();
    Task<ResultSet<IOrder>> SellOrder(string ticker, int numberOfShares);
}