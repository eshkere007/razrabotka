namespace BridgePatternLib
{
    public abstract class Notification
    {
        protected INotificationSender _sender;

        protected Notification(INotificationSender sender)
        {
            _sender = sender;
        }

        public abstract void Notify(string recipient, string message);
    }

}
