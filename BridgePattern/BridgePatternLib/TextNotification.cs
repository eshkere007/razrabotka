namespace BridgePatternLib
{
    public class TextNotification : Notification
    {
        public TextNotification(INotificationSender sender) : base(sender)
        { }

        public override void Notify(string recipient, string message)
        {
            Console.WriteLine("Текстовое уведомление:");
            _sender.Send(recipient, message);
        }
    }

}
