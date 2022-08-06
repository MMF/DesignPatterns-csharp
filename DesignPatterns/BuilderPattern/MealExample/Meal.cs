namespace DesignPatterns.BuilderPattern.MealExample;

public class Meal
{
    private List<IMealItem> _items = new();

    public void AddItem(IMealItem item)
    {
        _items.Add(item);
    }

    public double GetCost()
    {
        return _items.Sum(i => i.Price);
    }

    public void ShowItems()
    {
        foreach (var item in _items)
        {
            Console.WriteLine($"{item.Name} : {item.Price} EGP : {item.Packing.Pack()}");
        }
    }
}
