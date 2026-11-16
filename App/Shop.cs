namespace App;

public class Shop
{
    public Order MakeOrder(params Coffee[] coffees)
       => new(Guid.NewGuid(), coffees, 0m);
}
