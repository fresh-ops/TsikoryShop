using App;

namespace AppTests;

public class OrderTests
{
    [Test]
    public void ToString_ShowsAllItems()
    {
        var order = new Order(Guid.NewGuid(), [MenuItem.Espresso, MenuItem.Croissant], 220m);

        var result = order.ToString();
        var expected = """
            Эспрессо x1 100
            Круассан x1 120
        """;

        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(0)]
    [TestCase(-1)]
    public void Add_Throws_WhenQuantityIsNotPositive(int quantity)
    {
        var order = new Order(Guid.NewGuid(), Array.Empty<OrderItem>(), 0m);

        Assert.Throws<ArgumentOutOfRangeException>(() => order.Add(MenuItem.Espresso, quantity));
    }
}
