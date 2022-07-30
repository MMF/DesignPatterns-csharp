namespace DesignPatterns.StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
