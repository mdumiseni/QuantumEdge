namespace QuantumEdge.Application.Common.Model;

public class ResultSet<T>
{
    public string Message { get; set; } = string.Empty;
    public ResultStatus ResultStatus { get; set; }
    public T? Data { get; set; }
}