using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// Cette classe implémente l'interface IMessageSender et représente un expéditeur de messages par SMS.
    public class SmsSender : IMessageSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS envoyé : {message}");
        }
    }
}
