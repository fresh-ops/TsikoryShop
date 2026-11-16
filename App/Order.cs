namespace App;

public record Order(Guid Id, MenuItem[] Items, decimal TotalPrice)
{

}
