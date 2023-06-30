namespace DesignPatterns.MediatorPattern.ChatExample;
public class ChatProgram
{
    public static void Run()
    {
        var chatMediator = new ChatMediator();

        // create users
        var user1 = new ChatUser(chatMediator, "Ahmed");
        var user2 = new ChatUser(chatMediator, "Mohamed");
        var user3 = new ChatUser(chatMediator, "Karim");

        // add to mediator
        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        user1.SendMessage("Hello everyone!");
        user2.SendMessage("Hi there!");
    }
}
