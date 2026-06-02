//Considerons ce code comme application client de notre pattern Strategy, nous allons créer une classe Document qui utilise une instance de IOperation pour enregistrer le document dans le format souhaité.

    ﻿using System;
using System.Security.Cryptography.X509Certificates;
using DesignPattern.Stategy;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string documentContent = "Ceci est le contenu du document.";
            Console.WriteLine(documentContent);
Console.WriteLine("Choisissez le format d'enregistrement : 1. DOCX 2. PDF 3. TXT");

           string choice = Console.ReadLine();

            Document document = new Document();

            Console.WriteLine(choice);
            if (choice == "1")
            {
               
                document.SetOperation(new Doc());
                document.Enregistrer();

            }
            else if (choice == "2")
            {
              
                document.SetOperation(new Pdf());
                document.Enregistrer();
            }
            else if (choice == "3")
            {
               
                document.SetOperation(new Txt());
                document.Operation.EnregistrerSous();
            }


            else
            {
                Console.WriteLine("Format d'enregistrement non valide.");
            }

         
        }
    }
}