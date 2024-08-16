using ClosedXML.Excel;
using QuantumEdge.Application.Common.Model;
using QuantumEdge.Application.Interfaces.BrokerServices.EasyEquitiesServices.Interfaces;
using QuantumEdge.Shared.EasyEquities.Models;

namespace QuantumEdge.Application.Services.EasyEquitiesService;

public class TransactionService : ITransactionService
{
    public async Task<ResultSet<string>> UploadTransactionHistory()
    {
        throw new NotImplementedException();
    }

    public async Task<ResultSet<TransactionViewModel>> ReadTransaction(string filePath)
    {
        var transaction = new TransactionViewModel();
        
        using var workbook = new XLWorkbook(filePath);
        
        var workSheet = workbook.Worksheet(1);
        
        foreach (var row in workSheet.Rows())
        {
            transaction.LineItem.Add(new LineItem()
            {
                Date = row.Cell(1).GetValue<string>(),
                Comment = row.Cell(2).GetValue<string>(),
                Value = row.Cell(3).GetValue<string>()
            });
        }

        return new ResultSet<TransactionViewModel>()
        {
            Data = transaction,
            Message = $"Records returned {transaction.LineItem.Count}",
            ResultStatus = ResultStatus.Success
        };
    }
}