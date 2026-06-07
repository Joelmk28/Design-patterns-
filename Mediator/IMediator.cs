using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Mediator
{
    //Le Pattern Mediator permet à plusieurs objets de communiquer entre eux sans se connaitre dirrectement
    public interface IMediator
    {
        void sendMessage(string message, User user);
    }
}
