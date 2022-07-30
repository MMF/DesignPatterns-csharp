namespace DesignPatterns.ObserverPattern;

public interface IOfferPublisher
{
    void Subscribe(IOfferSubscriber subscriber);
    void Unsubscribe(IOfferSubscriber subscriber);
}
