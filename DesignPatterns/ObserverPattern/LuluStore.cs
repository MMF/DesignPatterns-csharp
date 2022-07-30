namespace DesignPatterns.ObserverPattern;

public class LuluStore : IOfferPublisher
{
    private List<IOfferSubscriber> _subscribers = new();
    public Dictionary<string, double> Offers { get; set; } = new();

    public void Subscribe(IOfferSubscriber subscriber)
    {
        _subscribers.Add(subscriber);
    }

    public void Unsubscribe(IOfferSubscriber subscriber)
    {
        _subscribers.Remove(subscriber);
    }

    public void AddOffer(string productName, double price)
    {
        Offers.Add(productName, price);
        NotifySubscribers();
    }

    private void NotifySubscribers()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.NewOffer(Offers);
        }
    }
}
