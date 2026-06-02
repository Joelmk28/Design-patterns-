using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Stategy
{
    public class Doc : IOperation
    {
        public void EnregistrerSous()
        {
            // Logique pour enregistrer le document au format .docx
            Console.WriteLine("Enregistrement du document au format .docx");
        }
    }
}
