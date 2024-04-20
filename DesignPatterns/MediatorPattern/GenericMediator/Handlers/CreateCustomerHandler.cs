using DesignPatterns.MediatorPattern.GenericMediator.Contracts;

namespace DesignPatterns.MediatorPattern.GenericMediator.Handlers;

public record CreateCustomerMsg : IRequest<CreateCustomerResult>
{
    public int Code { get; set; }
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
}

public record CreateCustomerResult
{
    public string Message { get; set; }
    public List<string> Errors { get; set; } = new();
}

public class CreateCustomerHandler : IRequestHandler<CreateCustomerMsg, CreateCustomerResult>
{
    public async Task<CreateCustomerResult> Handle(CreateCustomerMsg request)
    {
        Console.WriteLine("CreateCustomerHandler called.");
        Console.WriteLine($"Handling customer: {request.Name}, {request.Code}, {request.Email}");

        if (request.Name.StartsWith("J"))
        {
            return await Task.FromResult(new CreateCustomerResult
            {
                Message = "Customer name cannot start with J",
                Errors = new List<string> { "Name cannot start with J" }
            });
        }

        return await Task.FromResult(new CreateCustomerResult
        {
            Message = "Customer created successfully"
        });
    }
}
