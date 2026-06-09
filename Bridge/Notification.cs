using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// Cette classe abstraite représente une notification qui utilise un IMessageSender pour envoyer des messages.
    // Elle contient une référence à un IMessageSender et définit une méthode abstraite Notify qui doit être implémentée par les classes dérivées pour envoyer des notifications spécifiques.
    // En utilisant le pattern Bridge, cette classe permet de séparer l'abstraction de la notification de son implémentation d'envoi de messages, ce qui facilite la maintenance et l'extensibilité du code.
    public abstract class Notification
    {
        protected IMessageSender Sender;

        protected Notification(IMessageSender sender)
        {
            Sender = sender;
        }

        public abstract void Notify(string message);
    }
}
