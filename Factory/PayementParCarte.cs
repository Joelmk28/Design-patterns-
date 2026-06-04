using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class PayementParCarte : IPayement
    {
        public void Payer()
        {
            // Logique de paiement par carte
            Console.WriteLine("Paiement par carte effectué.");
        }
    }
}
