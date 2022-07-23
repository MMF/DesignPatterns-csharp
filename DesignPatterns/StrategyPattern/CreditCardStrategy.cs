namespace DesignPatterns.StrategyPattern;

public class CreditCardStrategy : IPaymentStrategy
{
    private string CardNumber { get; }
    private int Cvv { get; }
    private string ExpiryDate { get; }

    public CreditCardStrategy(string cardNumber, int cvv, string expiryDate)
    {
        CardNumber = cardNumber;
        Cvv = cvv;
        ExpiryDate = expiryDate;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} paid with credit Card.");
    }
}
