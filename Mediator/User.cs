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
           Console.WriteLine("Message recu : "+ message + " de ma la part de " +Name);
        }
    }
}
