namespace DesignPatterns.StrategyPattern;

public class PaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext()
    {
        
    }

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public void SetStrategy(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }
    
    public void Pay(decimal amount)
    {
        Console.WriteLine("Executing payment...");
        _paymentStrategy.Pay(amount);
    }
}
