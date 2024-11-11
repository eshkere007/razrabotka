namespace NotificationLib
{
    public class FacebookNotifierDecorator : NotifierDecorator
    {
        private readonly string _facebookAccount;

        public FacebookNotifierDecorator(INotifier decoratedNotifier, string facebookAccount)
            : base(decoratedNotifier)
        {
            _facebookAccount = facebookAccount;
        }

        public override void Send(string message)
        {
            base.Send(message); // Отправляем email
            Console.WriteLine($"Отправлено сообщение на Facebook аккаунт {_facebookAccount}: {message}");
        }
    }

}
