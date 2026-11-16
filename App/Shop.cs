namespace App;

public class Shop
{
    private readonly Dictionary<MenuItem, decimal> _menu = new()
    {
        { MenuItem.Espresso, 100m },
        { MenuItem.Cappuccino, 150m },
        { MenuItem.Latte, 200m },
        { MenuItem.Croissant, 120m }
    };
    public Order MakeOrder(params MenuItem[] items)
    {
        var totalPrice = items.Sum(item => _menu[item]);

        return new Order(Guid.NewGuid(), items, totalPrice);
    }
}
