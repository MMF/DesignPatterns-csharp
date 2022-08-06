namespace DesignPatterns.BuilderPattern.MealExample;

public abstract class Drink : IMealItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public IPacking Packing { get; } = new Bottle();
}

public class OrangeJuice : Drink
{
    public OrangeJuice()
    {
        Name = "Orange Juice";
        Price = 7;
    }
}

public class Pepsi : Drink
{
    public Pepsi()
    {
        Name = "Pepsi";
        Price = 6;
    }
}