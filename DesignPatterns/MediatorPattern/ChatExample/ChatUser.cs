namespace DesignPatterns.MediatorPattern.ChatExample;
public class ChatUser : IUser
{
    private readonly IChatMediator _chatMediator;
    private readonly string _name;

    public ChatUser(IChatMediator chatMediator, string name)
    {
        _chatMediator = chatMediator;
        _name = name;
    }

    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"{_name} received message: {message}");
    }

    public void SendMessage(string message)
    {
        Console.WriteLine($"{_name} sends message: {message}");
        _chatMediator.SendMessage(message, this);
    }
}
