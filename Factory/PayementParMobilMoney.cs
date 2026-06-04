using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class PayementParMobilMoney : IPayement
    {
            public void Payer()
            {
                // Logique de paiement par Mobile Money
                Console.WriteLine("Paiement par Mobile Money effectué.");
        }
    }
}
