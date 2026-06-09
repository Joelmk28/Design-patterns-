using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    /// Cette classe représente une notification normale qui utilise un IMessageSender pour envoyer des messages.
    // Elle hérite de la classe abstraite Notification et implémente la méthode Notify pour envoyer des notifications normales en utilisant l'implémentation d'envoi de messages fournie par le IMessageSender.
    public class NormalNotification : Notification
    {
        public NormalNotification(IMessageSender sender)
            : base(sender)
        {
        }

        public override void Notify(string message)
        {
            Sender.Send(message);
        }
    }
    
}
