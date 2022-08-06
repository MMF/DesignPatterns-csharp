namespace DesignPatterns.BuilderPattern.MealExample;

public interface IPacking
{
    public string Pack();
}

public class Wrapper : IPacking
{
    public string Pack()
    {
        return "Wrapper";
    }
}

public class Bottle : IPacking
{
    public string Pack()
    {
        return "Bottle";
    }
}