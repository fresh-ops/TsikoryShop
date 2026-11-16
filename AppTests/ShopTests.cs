using App;

namespace AppTests;

public class ShopTests
{
    [Test]
    public void MakeOrder_CostsZero_WhenEmpty()
    {
        var shop = new Shop();

        var order = shop.MakeOrder();

        Assert.That(order.TotalPrice, Is.EqualTo(0));
    }

    [Test]
    public void MakeOrder_Costs100_WhenOneEspresso()
    {
        var shop = new Shop();

        var order = shop.MakeOrder(MenuItem.Espresso);

        Assert.That(order.TotalPrice, Is.EqualTo(100));
    }
}
