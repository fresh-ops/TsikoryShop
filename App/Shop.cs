namespace App;

public class Shop
{
    public Order MakeOrder(params MenuItem[] items)
    {
        var order = new Order(Guid.NewGuid());

        foreach (var item in items)
        {
            order.Add(item, 1);
        }

        return order;
    }
}
