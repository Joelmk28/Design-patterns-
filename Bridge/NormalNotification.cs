using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public  class NormalNotification : Notification
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
