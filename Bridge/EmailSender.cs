using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge;

// Cette classe implémente l'interface IMessageSender et représente un expéditeur de messages par email.
// Elle fournit une implémentation concrète de la méthode Send qui affiche le message envoyé par email.
public class EmailSender : IMessageSender
{
    
    public void Send(string message)
    {
        Console.WriteLine($"Email envoyé : {message}");
    }
}

 

