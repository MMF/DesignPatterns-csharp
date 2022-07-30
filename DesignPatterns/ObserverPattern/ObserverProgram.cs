namespace DesignPatterns.ObserverPattern;

public class ObserverProgram
{
    public static void Run()
    {
        Console.WriteLine("Observer Pattern");

        var luluStore = new LuluStore();
        luluStore.AddOffer("Cheese", 1.5);

        var c1 = new Customer("Mohamad");
        var c2 = new Customer("Ahmed");
        var c3 = new Customer("Ali");

        luluStore.Subscribe(c1);
        luluStore.Subscribe(c2);

        luluStore.AddOffer("Rice", 4);
        Console.WriteLine();
        
        luluStore.Subscribe(c3);
        luluStore.AddOffer("Shoes", 12);
    }
}
