using Alpaca.Markets;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Interfaces;
using QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Model;

namespace QuantumEdge.Application.Services.AlpacaService;

public class AccountService(IAlpacaTradingClient client) : IAccountService
{
    public async Task<AccountViewModel> GetAccountInformation()
    {
        var account = await client.GetAccountAsync();
        var accountChange = account.Equity - account.LastEquity;
        return new AccountViewModel(account.AccountNumber!, accountChange, account.Equity);
    }
}