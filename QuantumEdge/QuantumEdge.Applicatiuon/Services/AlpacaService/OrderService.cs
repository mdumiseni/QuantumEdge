using Alpaca.Markets;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;

namespace AlpacaAccount.Services;

public class OrderService(IAlpacaTradingClient client) : IOrderService
{
    public async Task<ResultSet<IOrder>> CreateNewOrder(string ticker, int numberOfShares)
    {
        var isTradable = await isAssetTradable(ticker);
        if (!isTradable)
            return new ResultSet<IOrder>() { ResultStatus = ResultStatus.Error, Message = $"{ticker} is not tradable" };
        
        var result = await client.PostOrderAsync(MarketOrder.Buy(ticker, numberOfShares ));
        return new ResultSet<IOrder>() { ResultStatus = ResultStatus.Success, Message = "Successfully place a new trade", Data = result };
    }

    public async Task<IOrder?> GetOrder(string ticker)
    {
        var closedOrders = await client.ListOrdersAsync(
            new ListOrdersRequest
            {
                LimitOrderNumber = 100,
                OrderStatusFilter = OrderStatusFilter.Closed
            });
       return closedOrders.Where(order => order.Symbol.Equals(ticker))?.FirstOrDefault();
    }

    public async Task<IReadOnlyList<IOrder>> GetAllOrder()
    {
        var closedOrders = await client.ListOrdersAsync(
            new ListOrdersRequest
            {
                LimitOrderNumber = 100,
                OrderStatusFilter = OrderStatusFilter.Closed
            });
        return closedOrders;
    }

    public async Task<ResultSet<IOrder>> SellOrder(string ticker, int numberOfShares)
    {
        var isTradable = await isAssetTradable(ticker);
        if (!isTradable)
            return new ResultSet<IOrder> { ResultStatus = ResultStatus.Error, Message = $"{ticker} is not tradable" };
        
        var result = await client.PostOrderAsync(MarketOrder.Sell(ticker, numberOfShares ));
        return new ResultSet<IOrder>{ ResultStatus = ResultStatus.Success, Message = "Successfully place a new trade", Data = result };
    }

    public static void HandleTradeUpdate(ITradeUpdate update)
    {
        if (update.Order.ClientOrderId.Equals("my_client_order_id"))
        {
            Console.WriteLine($"Update for {update.Order.ClientOrderId}. Event: {update.Event}");
        }
    }
    
    private async Task<bool> isAssetTradable(string ticker)
    {
        try
        {
            var asset = await client.GetAssetAsync(ticker);
            return asset.IsTradable;
        }
        catch (Exception e)
        {
            Console.WriteLine($"{ticker} is not found.");
            return false;
        }
    }
}