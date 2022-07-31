using DesignPatterns.AdapterPattern.NewsFeedExample;
using DesignPatterns.AdapterPattern.PhoneChargerExample;

namespace DesignPatterns.AdapterPattern;

public class AdapterProgram
{
    public static void Run()
    {
        PhoneChargerProgram.Run();

        Console.WriteLine();

        NewsReaderClient.Run();
    }
}
