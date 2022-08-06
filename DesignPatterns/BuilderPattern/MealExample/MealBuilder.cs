namespace DesignPatterns.BuilderPattern.MealExample;

public class MealBuilder
{
    public Meal BuildVegMeal()
    {
        var meal = new Meal();
        meal.AddItem(new VegaBurger());
        meal.AddItem(new OrangeJuice());

        return meal;
    }

    public Meal BuildNonVegMeal()
    {
        var meal = new Meal();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Pepsi());

        return meal;
    }
}
