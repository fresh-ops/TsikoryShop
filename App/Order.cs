namespace App;

public record Order(Guid Id)
{
    public List<OrderItem> Items { get;} = [];
    public decimal TotalPrice => Items.Sum(item => item.TotalPrice);

    public void Add(MenuItem item, int quantity)
    {
        if (quantity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(quantity));
        }

        var orderItem = new OrderItem(item, quantity);
        Items.Add(orderItem);
    }

    public override string ToString()
        => string.Join(Environment.NewLine, Items.Select(item => $"    {item}"));
}
