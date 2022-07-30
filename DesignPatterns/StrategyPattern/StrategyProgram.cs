namespace DesignPatterns.StrategyPattern;

public class StrategyProgram
{
    public static void Run()
    {
        Console.WriteLine("Strategy Pattern");

        var paymentContext = new PaymentContext();

        paymentContext.SetStrategy(new CreditCardStrategy("4508750015741019", 123, "01/22"));
        paymentContext.Pay(100);

        paymentContext.SetStrategy(new PayPalStrategy("test", "P@ssword123"));
        paymentContext.Pay(200);
    }
}
