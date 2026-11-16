namespace App;

public record Order(Guid Id, Coffee[] Coffees, decimal TotalPrice)
{

}
