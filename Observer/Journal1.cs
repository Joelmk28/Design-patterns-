using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class Journal1 : Journaliste
    {
        public List<Abonnement> Abonnees { get; set; } = new List<Abonnement>(); //pour la relation on to many entre journaliste et abonnement (Observer et Observable ou  Subject)
        void Journaliste.Abonner(Abonnement abonnement)
        {
            this.Abonnees.Add(abonnement);//pour ajouter un abonnement à la liste des abonnés du journaliste
        }

        void Journaliste.Desaboner(Abonnement abonnement)
        {
            this.Abonnees.Remove(abonnement);//pour retirer un abonnement de la liste des abonnés du journaliste
        }

        void Journaliste.notifierLesAbonnees()
        {
            foreach (var abonne in Abonnees)
            {
                abonne.Sinformer(this); //pour informer tous les abonnés du journaliste en appelant la méthode Sinformer de chaque abonnement
            }
        }
    }
}
