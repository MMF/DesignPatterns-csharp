namespace DesignPatterns.BuilderPattern.MealExample;

public interface IMealItem
{
    public string Name { get; set; }
    public double Price { get; set; }

    public IPacking Packing { get; }
}
