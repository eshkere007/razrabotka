﻿namespace BridgePatternLib
{
    public class SmsSender : INotificationSender
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine($"SMS для {recipient}: {message}");
        }
    }
}
