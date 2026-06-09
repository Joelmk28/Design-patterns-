using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public class UrgentNotification : Notification
    {
        public UrgentNotification(IMessageSender sender)
            : base(sender)
        {
        }

        public override void Notify(string message)
        {
            Sender.Send("[URGENT] " + message);
        }
    }
    
}
