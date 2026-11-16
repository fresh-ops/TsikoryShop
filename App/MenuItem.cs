namespace App;

public record MenuItem
{
    public static MenuItem Espresso => new MenuItem("Эспрессо", 100m);
    public static MenuItem Cappuccino => new MenuItem("Капучино", 150m);
    public static MenuItem Croissant => new MenuItem("Круассан", 120m);
    public static MenuItem Latte => new MenuItem("Латте", 200m);

    public string Name { get; }
    public decimal Price { get; }

    private MenuItem(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}

