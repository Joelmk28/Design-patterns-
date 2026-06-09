using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    // Cette interface représente l'abstraction de l'envoi de messages.
    // Elle définit une méthode Send qui prend un message en paramètre.
    public interface IMessageSender
    {
        void Send(string message);
    }
}
