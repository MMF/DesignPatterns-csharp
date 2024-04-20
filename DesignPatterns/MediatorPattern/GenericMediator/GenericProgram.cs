using DesignPatterns.MediatorPattern.GenericMediator.Handlers;

namespace DesignPatterns.MediatorPattern.GenericMediator;
public class GenericProgram
{
    public static async Task RunAsync()
    {
        // mediator (Can be resolved via Dependency Injection)
        var mediator = new Mediator();

        // register (Can be registered automatically via reflection)
        mediator.RegisterHandler<CreateCustomerMsg, CreateCustomerHandler>();


        // send
        var customer = new CreateCustomerMsg
        {
            Code = 1,
            Name = "John Doe",
            Email = "ccc@bbb.com"
        };

        var result = await mediator.Send(customer);
        Console.WriteLine($"Handler Result: {result.Message}");


    }
}
