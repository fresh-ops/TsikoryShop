using App;

namespace AppTests;

public class ShopTests
{
    public static IEnumerable<TestCaseData> MakeOrderTestCases()
    {
        yield return new TestCaseData([new MenuItem[0]]).Returns(0m);
        yield return new TestCaseData([new MenuItem[]{ MenuItem.Espresso }]).Returns(100m);
        yield return new TestCaseData([new MenuItem[]{ MenuItem.Espresso, MenuItem.Espresso, MenuItem.Espresso }]).Returns(300m);
        yield return new TestCaseData([new MenuItem[]{ MenuItem.Latte, MenuItem.Espresso, MenuItem.Croissant }]).Returns(420m);
    }

    [TestCaseSource(nameof(MakeOrderTestCases))]
    public decimal MakeOrder_CalculatesTotalPrice(MenuItem[] items)
    {
        var shop = new Shop();
        var order = shop.MakeOrder(items);

        return order.TotalPrice;
    }
}
