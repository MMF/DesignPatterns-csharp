namespace DesignPatterns.BuilderPattern.MealExample;

public abstract class Burger : IMealItem
{
    public string Name { get; set; }
    public double Price { get; set; }
    public IPacking Packing { get; } = new Wrapper();
}

public class ChickenBurger : Burger
{
    public ChickenBurger()
    {
        Name = "Chicken Burger";
        Price = 35;
    }
}

public class VegaBurger : Burger
{
    public VegaBurger()
    {
        Name = "Vega Burger";
        Price = 50;
    }
}