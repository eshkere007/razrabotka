namespace MediatorPattern
{
    public class User
    {
        public string Name { get; }
        private readonly IChatMediator _mediator;
        private readonly List<string> _messageHistory = new List<string>();

        public User(string name, IChatMediator mediator)
        {
            Name = name;
            _mediator = mediator;
        }

        public void SendMessage(string message, string receiverName)
        {
            Console.WriteLine($"{Name} -> {receiverName}: {message}");
            _mediator.SendMessage(message, receiverName, this);
        }

        public void ReceiveMessage(string message, string senderName)
        {
            string formattedMessage = $"{senderName} -> {Name}: {message}";
            _messageHistory.Add(formattedMessage);
            Console.WriteLine($"Сообщение для {Name}: {formattedMessage}");
        }

        public void ShowMessageHistory()
        {
            Console.WriteLine($"История сообщений для {Name}:");
            foreach (var msg in _messageHistory) Console.WriteLine(msg);
        }
    }
}
