using App;

namespace AppTests;

public class ShopTests
{
    [TestCase([new MenuItem[0]], ExpectedResult = 0)]
    [TestCase([new MenuItem[] { MenuItem.Espresso }], ExpectedResult = 100)]
    [TestCase([new MenuItem[] { MenuItem.Espresso, MenuItem.Espresso, MenuItem.Espresso }], ExpectedResult = 300)]
    public decimal MakeOrder_CalculatesTotalPrice(MenuItem[] items)
    {
        var shop = new Shop();
        var order = shop.MakeOrder(items);

        return order.TotalPrice;
    }
}
