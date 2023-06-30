namespace DesignPatterns.MediatorPattern.ChatExample;
public interface IChatMediator
{
    void SendMessage(string message, IUser user);
    void AddUser(IUser user);
}