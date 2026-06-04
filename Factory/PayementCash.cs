using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class PayementCash : IPayement
    {
        public void Payer()
        {
            Console.WriteLine("Paiement en espèces effectué.");
        }
    }
}
