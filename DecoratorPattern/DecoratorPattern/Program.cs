using NotificationLib;

class Program
{
    static void Main(string[] args)
    {
        INotifier notifier = new Notifier("eshkere@gmail.com");

        notifier = new SmsNotifierDecorator(notifier, "+1234567890");

        notifier = new FacebookNotifierDecorator(notifier, "eshkere_facebook");

        notifier.Send("Это важное уведомление!");
    }
}
