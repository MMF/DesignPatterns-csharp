namespace DesignPatterns.ObserverPattern;

public class Customer : IOfferSubscriber
{
    public string Name { get; set; }

    public Customer(string name)
    {
        Name = name;
    }

    public void NewOffer(Dictionary<string, double> offers)
    {
        Console.WriteLine($"Customer [{Name}] received a new offer [Total = {offers.Count}]");
    }
}
