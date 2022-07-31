namespace DesignPatterns.FacadePattern;

public class FacadeProgram
{
    public static void Run()
    {
        Console.WriteLine("Facade Pattern");
        VideoConverterExample.ClientProgram.Run();

        Console.WriteLine();

        HrExample.ClientProgram.Run();
    }
}
