using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge;

    public class EmailSender : IMessageSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Email envoyé : {message}");
    }
}

 

