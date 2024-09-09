namespace OOPSample.Console.Sales.Domain.Model.Aggregates;
public class SalesOrder(int id, int customerId)
{
    private readonly List<SalesOrderItem> _items = [];
    public int CustomerId { get; } = customerId;
    private int Id { get; } = id;
    public void AddItem(int productId, int quantity, double unitPrice)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity,
            unitPrice));
    }
    public double CalculateTotalPrice()
    {
        return _items.Sum(x => x.CalculateItemPrice());
    }
}