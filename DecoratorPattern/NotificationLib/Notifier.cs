namespace NotificationLib
{
    public class Notifier : INotifier
    {
        private readonly string _email;

        public Notifier(string email)
        {
            _email = email;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Отправлено уведомление на email {_email}: {message}");
        }
    }
}
