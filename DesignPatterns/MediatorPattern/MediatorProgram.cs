using DesignPatterns.MediatorPattern.ChatExample;

namespace DesignPatterns.MediatorPattern;
public class MediatorProgram
{
    public static async Task RunAsync()
    {
        Console.WriteLine("Mediator pattern");

        ChatProgram.Run();

        Console.WriteLine();

        await GenericMediator.GenericProgram.RunAsync();
    }
}
