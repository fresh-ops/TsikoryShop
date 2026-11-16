namespace App;

public class Shop
{
    public Order MakeOrder(params MenuItem[] coffees)
       => new(Guid.NewGuid(), coffees, 0m);
}
