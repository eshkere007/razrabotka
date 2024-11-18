namespace BridgePatternLib
{
    public class HtmlNotification : Notification
    {
        public HtmlNotification(INotificationSender sender) : base(sender)
        { }

        public override void Notify(string recipient, string message)
        {
            string htmlMessage = $"<html><body>{message}</body></html>";
            Console.WriteLine("HTML уведомление:");
            _sender.Send(recipient, htmlMessage);
        }
    }
}
