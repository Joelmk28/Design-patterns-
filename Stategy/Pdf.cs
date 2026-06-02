using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Stategy
{
    public class Pdf : IOperation
    {
        public void EnregistrerSous()
        {
            // Logique pour enregistrer le document au format .pdf
            Console.WriteLine("Enregistrement du document au format .pdf");
        }   
    
    }
}
