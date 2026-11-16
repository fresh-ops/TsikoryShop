namespace App;

public record OrderItem(MenuItem Type, int Quantity, decimal Price)
{
    public override string ToString()
    {
        var name = Type switch
        {
            MenuItem.Espresso => "Эспрессо",
            MenuItem.Cappuccino => "Капучино",
            MenuItem.Croissant => "Круассан",
            MenuItem.Latte => "Латте",
            _ => throw new ArgumentOutOfRangeException(nameof(Type), Type, null)
        };

        return $"{name} x{Quantity} {Quantity * Price}";
    }
}

