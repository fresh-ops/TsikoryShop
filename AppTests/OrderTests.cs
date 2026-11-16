using App;

namespace AppTests;

public class OrderTests
{
    [Test]
    public void ToString_ShowsAllItems()
    {
        var order = new Order(Guid.NewGuid());
        order.Add(MenuItem.Espresso, 1);
        order.Add(MenuItem.Croissant, 1);

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
        var order = new Order(Guid.NewGuid());
        order.Add(MenuItem.Espresso, 1);

        Assert.Throws<ArgumentOutOfRangeException>(() => order.Add(MenuItem.Espresso, quantity));
        Assert.That(order.TotalPrice, Is.EqualTo(MenuItem.Espresso.Price));
    }

    [Test]
    public void ToString_CollapsesItems()
    {
        var order = new Order(Guid.NewGuid());
        order.Add(MenuItem.Espresso, 1);
        order.Add(MenuItem.Espresso, 2);

        var result = order.ToString();
        var expected = """
            Эспрессо x3 300
        """;

        Assert.That(result, Is.EqualTo(expected));
    }
}
