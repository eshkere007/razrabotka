namespace MediatorPattern
{
    public interface IChatMediator
    {
        void AddUser(User user);
        void RemoveUser(User user);
        void SendMessage(string message, string receiverName, User sender);
    }
}
