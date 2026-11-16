namespace App;

public record OrderItem(MenuItem Type, int Quantity)
{
    public decimal TotalPrice => Quantity * Type.Price;

    public override string ToString()
        => $"{Type.Name} x{Quantity} {Quantity * Type.Price}";
}

