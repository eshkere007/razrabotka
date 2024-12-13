using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new List<User>();

        public void AddUser(User user)
        {
            _users.Add(user);
            Console.WriteLine($"Пользователь {user.Name} добавлен в чат");
        }

        public void RemoveUser(User user)
        {
            _users.Remove(user);
            Console.WriteLine($"Пользователь {user.Name} покинул чат");
        }

        public void SendMessage(string message, string receiverName, User sender)
        {
            var receiver = _users.Find(user => user.Name == receiverName);

            if (receiver != null) receiver.ReceiveMessage(message, sender.Name);
            else Console.WriteLine($"Пользователь {receiverName} не найден.");
        }
    }

}
