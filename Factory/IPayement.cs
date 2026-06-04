using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    //C'est la classe mere dans la logique sans design parterne; ici c'est une interface
    //On peut aussi passer une classe abstract 
    public interface IPayement
    {
        void Payer();
    }
}
