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
}