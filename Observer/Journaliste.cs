using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public  interface Journaliste
    {
        public void Abonner(Abonnement abonnement); //ajout d'un observer 
        public void Desaboner(Abonnement abonnement); //retirer un obsever

        public void notifierLesAbonnees(); // envoyer les infos aux observers
    }
}
