namespace BridgePatternLib
{
    public interface INotificationSender
    {
        void Send(string recipient, string message);
    }
}
