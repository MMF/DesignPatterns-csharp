namespace DesignPatterns.BuilderPattern.MealExample;

public class Resturant
{
    public static void Run()
    {
        var mealBuilder = new MealBuilder();

        var meal = mealBuilder.BuildVegMeal();
        Console.WriteLine($"Veg Meal : {meal.GetCost()} EGP");
        meal.ShowItems();
    }
}
