namespace DesignPatterns.BuilderPattern.HtmlExample;

public class ClientProgram
{
    public static void Run()
    {
        var builder = new WelcomePageBuilder();
        var page = builder.Build();
        Console.WriteLine(page);
    }
}
