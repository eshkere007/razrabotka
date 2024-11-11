namespace NotificationLib
{
    public class SmsNotifierDecorator : NotifierDecorator
    {
        private readonly string _phoneNumber;

        public SmsNotifierDecorator(INotifier decoratedNotifier, string phoneNumber)
            : base(decoratedNotifier)
        {
            _phoneNumber = phoneNumber;
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"Отправлено SMS на {_phoneNumber}: {message}");
        }
    }

}
