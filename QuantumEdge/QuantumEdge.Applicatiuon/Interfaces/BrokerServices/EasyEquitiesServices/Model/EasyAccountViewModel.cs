namespace QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Model;

public record EasyAccountViewModel(
string AccountNumber,
Dictionary<string, string> AccountChange
);