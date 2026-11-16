namespace App;

public record Order(Guid Id, OrderItem[] Items, decimal TotalPrice)
{
    public Order(Guid id, MenuItem[] items, decimal totalPrice)
        : this(id, Shop.CreateOrderItems(items), totalPrice)
    {
    }

    public override string ToString()
        => string.Join(Environment.NewLine, Items.Select(item => $"    {item}"));
}
