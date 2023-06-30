namespace DesignPatterns.MediatorPattern.ChatExample;
public class ChatMediator : IChatMediator
{
    private List<IUser> _users = new List<IUser>();

    public void AddUser(IUser user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, IUser user)
    {
        foreach (var u in _users)
        {
            if (u != user)
            {
                user.ReceiveMessage(message);
            }
        }
    }
}
