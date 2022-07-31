namespace DesignPatterns.FacadePattern.HrExample;

public class ClientProgram
{
    public static void Run()
    {
        var hrFacade = new HrFacade();
        var paySlip = hrFacade.GetPaySlipInfo(157, 2022, 7);

        Console.WriteLine(paySlip);
    }
}
