using System;
using System.Collections.Generic;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatMediator();

            var user1 = new User("Вася", mediator);
            var user2 = new User("Петя", mediator);
            var user3 = new User("Маша", mediator);

            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);

            Console.WriteLine();

            user1.SendMessage("Привет, Петя!", "Петя");
            user2.SendMessage("Привет, Маша!", "Маша");
            user3.SendMessage("Привет всем!", "Вася");
            user3.SendMessage("Привет, Антон!", "Антон");

            Console.WriteLine();

            user1.ShowMessageHistory();
            Console.WriteLine();
            user2.ShowMessageHistory();
            Console.WriteLine();
            user3.ShowMessageHistory();
            Console.WriteLine();

            mediator.RemoveUser(user2);
        }
    }
}

/*
Вывод:

Пользователь Вася добавлен в чат
Пользователь Петя добавлен в чат
Пользователь Маша добавлен в чат

Вася -> Петя: Привет, Петя!
Сообщение для Петя: Вася -> Петя: Привет, Петя!
Петя -> Маша: Привет, Маша!
Сообщение для Маша: Петя -> Маша: Привет, Маша!
Маша -> Вася: Привет всем!
Сообщение для Вася: Маша -> Вася: Привет всем!
Маша -> Антон: Привет, Антон!
Пользователь Антон не найден.

История сообщений для Вася:
Маша -> Вася: Привет всем!

История сообщений для Петя:
Вася -> Петя: Привет, Петя!

История сообщений для Маша:
Петя -> Маша: Привет, Маша!

Пользователь Петя покинул чат

*/