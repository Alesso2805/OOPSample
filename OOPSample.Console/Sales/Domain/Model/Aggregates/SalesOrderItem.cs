namespace OOPSample.Console.Sales.Domain.Model.Aggregates;
public class SalesOrderItem(int salesOrderId, int productId, int
    quantity)
{
    public int Id { get; set; } = 0;
    public int SalesOrderId { get; set; } = salesOrderId;
    public int ProductId { get; set; } = productId;
    public int Quantity { get; set; } = quantity;
}