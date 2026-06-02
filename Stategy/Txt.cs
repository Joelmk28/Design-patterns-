using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Stategy
{
    public class Txt : IOperation
    {
        public void EnregistrerSous()
        {
           // Logique pour enregistrer le document au format .txt
            Console.WriteLine("Enregistrement du document au format .txt");
        }
    }
}
