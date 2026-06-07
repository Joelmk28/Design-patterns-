using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DesignPattern.Mediator
{
    public class User
    {
        private string Name {  get;}
        private readonly IMediator imediator;
        
        
        public User(string name)
        {
            Name = name;
        }
        public void sendMessage(string message, User receiver)
        {
            receiver.ReceiveMessage(message);
        }

        private void ReceiveMessage(string message)
        {
           Console.WriteLine(Name + " Vous avez un nouveau message : "+ message);
        }
    }
}
