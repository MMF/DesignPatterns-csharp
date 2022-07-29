namespace DesignPatterns.SingletonPattern;

public class SingletonProgram
{
    public static void Run()
    {
        Console.WriteLine("Singleton Pattern");
        TestSimpleSingleton();
        TestThreadSafeSingleton();
        TestLazySingleton();
    }

    private static void TestSimpleSingleton()
    {
        var instance1 = Singleton.GetInstance();
        var instance2 = Singleton.GetInstance();

        if (instance1 == instance2)
            Console.WriteLine("Singleton worked!");
        else
            Console.WriteLine("Singleton failed!");
    }

    private static void TestThreadSafeSingleton()
    {
        var process1 = new Thread(() => CreateAnInstance());

        var process2 = new Thread(() => CreateAnInstance());

        process1.Start();
        process2.Start();

        Console.WriteLine("ThreadSafe Singleton worked!");
    }

    private static void CreateAnInstance()
    {
        var instance = ThreadSafeSingleton.GetInstance("A");
        Console.WriteLine(instance.Value);
    }

    private static void TestLazySingleton()
    {
        var instance1 = LazySingleton.GetInstance();
        var instance2 = LazySingleton.GetInstance();

        if (instance1 == instance2)
            Console.WriteLine("Singleton worked!");
        else
            Console.WriteLine("Singleton failed!");
    }
}
