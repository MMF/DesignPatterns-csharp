namespace DesignPatterns.ObserverPattern;

public interface IOfferSubscriber
{
    void NewOffer(Dictionary<string, double> offers);
}
