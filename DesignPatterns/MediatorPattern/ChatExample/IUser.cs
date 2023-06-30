namespace DesignPatterns.MediatorPattern.ChatExample;

public interface IUser
{
    void SendMessage(string message);
    void ReceiveMessage(string message);
}