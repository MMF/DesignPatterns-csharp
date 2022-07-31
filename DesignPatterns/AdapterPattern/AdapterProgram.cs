using DesignPatterns.AdapterPattern.NewsFeedExample;
using DesignPatterns.AdapterPattern.PhoneChargerExample;

namespace DesignPatterns.AdapterPattern;

public class AdapterProgram
{
    public static void Run()
    {
        Console.WriteLine("Adapter Pattern");
        
        PhoneChargerProgram.Run();

        Console.WriteLine();

        NewsReaderClient.Run();
    }
}
