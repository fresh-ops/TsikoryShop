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
}