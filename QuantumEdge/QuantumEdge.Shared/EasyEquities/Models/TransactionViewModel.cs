namespace QuantumEdge.Shared.EasyEquities.Models;

public class TransactionViewModel
{
    public List<LineItem> LineItem { get; set; } = new List<LineItem>();
}

public class LineItem
{
    public string Date { get; set; }
    public string Comment { get; set; }
    public string Value { get; set; }
}