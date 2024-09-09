using OOPSample.Console.Sales.Domain.Model.Entities;
namespace OOPSample.Sales.Domain.Model.Aggregates;
public class SalesOrder(int id)
{
    private List<SalesOrderItem> _items = [];
    private int Id { get; } = id;
    public void AddItem(int productId, int quantity)
    {
        _items.Add(new SalesOrderItem(Id, productId, quantity));
    }
}