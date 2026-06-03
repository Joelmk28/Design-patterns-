using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Observer
{
    public class Journal1 : Journaliste
    {
        public int State
        {  //pour stocker l'état du journaliste, par exemple une nouvelle information ou un événement qui se produit

            get; 
            set;
    
        } 
        public void setStatte(int newState)
        {
            this.State = newState; //pour changer l'état du journaliste
            this.notifierLesAbonnees(); //pour notifier tous les abonnés du changement d'état du journaliste
        }


        public List<Abonnement> Abonnees { get; set; } = new List<Abonnement>(); //pour la relation on to many entre journaliste et abonnement (Observer et Observable ou  Subject)
        public void Abonner(Abonnement abonnement)
        {
            this.Abonnees.Add(abonnement);//pour ajouter un abonnement à la liste des abonnés du journaliste
        }


        public void Desaboner(Abonnement abonnement)
        {
            this.Abonnees.Remove(abonnement);//pour retirer un abonnement de la liste des abonnés du journaliste
        }

        
        public void notifierLesAbonnees()
        {
            foreach (var abonne in Abonnees)
            {
                abonne.Sinformer(this); //pour informer tous les abonnés du journaliste en appelant la méthode Sinformer de chaque abonnement
            }
        }
    }
}
