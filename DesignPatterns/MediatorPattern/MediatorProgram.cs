using DesignPatterns.MediatorPattern.ChatExample;

namespace DesignPatterns.MediatorPattern;
public class MediatorProgram
{
    public static void Run()
    {
        Console.WriteLine("Mediator pattern");

        ChatProgram.Run();
    }
}
