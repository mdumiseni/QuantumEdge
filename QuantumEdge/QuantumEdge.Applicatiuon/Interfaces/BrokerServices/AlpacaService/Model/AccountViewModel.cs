namespace QuantumEdge.Application.Interfaces.BrokerServices.AlpacaService.Model;

public record AccountViewModel(
    string AccountNumber,
    decimal? AccountChange,
    decimal? Equity);
