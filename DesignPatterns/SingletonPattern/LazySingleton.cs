namespace DesignPatterns.SingletonPattern;

public sealed class LazySingleton
{
    private static readonly Lazy<LazySingleton> lazy = new Lazy<LazySingleton>(() => new LazySingleton());
    
    public static LazySingleton GetInstance()
    {
        return lazy.Value;
    }

    private LazySingleton() { }
}
