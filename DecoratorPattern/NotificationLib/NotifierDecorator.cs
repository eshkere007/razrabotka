namespace NotificationLib
{
    public class NotifierDecorator : INotifier
    {
        protected readonly INotifier _decoratedNotifier;

        public NotifierDecorator(INotifier decoratedNotifier)
        {
            _decoratedNotifier = decoratedNotifier;
        }

        public virtual void Send(string message)
        {
            _decoratedNotifier.Send(message);
        }
    }
}
