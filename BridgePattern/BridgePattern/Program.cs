using BridgePatternLib;

public class Program
{
    public static void Main(string[] args)
    {
        INotificationSender emailSender = new EmailSender();
        INotificationSender smsSender = new SmsSender();

        Notification emailTextNotification = new TextNotification(emailSender);
        emailTextNotification.Notify("eshkere007@gmail.com", "Купите наш продукт всегор за 999999 р!");

        Notification emailHtmlNotification = new HtmlNotification(emailSender);
        emailHtmlNotification.Notify("eshkere007@gmail.com", "Купите наш продукт всегор за 999999 р!");

        Notification smsTextNotification = new TextNotification(smsSender);
        smsTextNotification.Notify("1234567890", "В вашем регионе ожидается апокалипсис, будьте осторожны.");
    }
}
