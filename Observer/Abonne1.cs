using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class Abonne1 : Abonnement
    {
        public void Sinformer(Journaliste journaliste)
        {
            Console.WriteLine("Abonne1 a été informé du changement d'état du journaliste. Nouvel état : " +( (Journal1) journaliste ).State);
            //Il peut faire d'autres actions en fonction du nouvel état du journaliste, comme mettre à jour son interface utilisateur, envoyer une notification, etc.

            Console.WriteLine(
                "Abonne1 a mis à jour son interface utilisateur en fonction du nouvel état du journaliste.");
        }

    }
}
