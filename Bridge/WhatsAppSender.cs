using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class WhatsAppSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"WhatsApp envoyé : {message}");
        }
    }
}
