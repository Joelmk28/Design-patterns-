using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Bridge
{
    public interface IMessageSender
    {
        void Send(string message);
    }
}
