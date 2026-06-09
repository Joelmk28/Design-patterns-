using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS envoyé : {message}");
        }
    }
}
