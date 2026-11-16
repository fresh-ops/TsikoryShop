namespace App;

public class Shop
{
    private static readonly Dictionary<MenuItem, decimal> _menu = new()
    {
        { MenuItem.Espresso, 100m },
        { MenuItem.Cappuccino, 150m },
        { MenuItem.Croissant, 120m },
        { MenuItem.Latte, 200m }
    };

    public Order MakeOrder(params MenuItem[] items)
    {
        var orderItems = CreateOrderItems(items);
        var totalPrice = orderItems.Sum(item => item.Quantity * item.Price);

        return new Order(Guid.NewGuid(), orderItems, totalPrice);
    }

    internal static OrderItem[] CreateOrderItems(MenuItem[] items)
        => items.GroupBy(item => item)
            .Select(group => new OrderItem(group.Key, group.Count(), _menu[group.Key]))
            .ToArray();
}
