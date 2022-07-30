namespace DesignPatterns.StrategyPattern;

public class PayPalStrategy : IPaymentStrategy
{
    private string Username { get; }
    private string Password { get; }

    public PayPalStrategy(string username, string password)
    {
        Username = username;
        Password = password;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"{amount} paid with PayPal.");
    }
}
