namespace App;

public record Order(Guid Id, MenuItem[] Coffees, decimal TotalPrice)
{

}
