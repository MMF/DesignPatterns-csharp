using DesignPatterns.BuilderPattern;
using DesignPatterns.BuilderPattern.MealExample;

namespace DesignPatterns.BuilderPattern;

public class BuilderProgram
{
    public static void Run()
    {
        Console.WriteLine("Builder Pattern");

        CarExample.ClientProgram.Run();

        Console.WriteLine();

        Resturant.Run();
    }
}
