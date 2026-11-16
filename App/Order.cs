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

        var index = Items.FindIndex(orderItem => orderItem.Type == item);
        if (index >= 0)
        {
            var existing = Items[index];
            Items[index] = existing with { Quantity = existing.Quantity + quantity };
        }
        else
        {
            Items.Add(new OrderItem(item, quantity));
        }
    }

    public override string ToString()
        => string.Join(Environment.NewLine, Items.Select(item => $"    {item}"));
}
