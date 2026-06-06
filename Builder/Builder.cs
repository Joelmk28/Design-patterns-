using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public class Builder
    {
        private readonly Utilisateur  utilisateur;

        public Builder(){
              utilisateur = new Utilisateur();
        }

        public Builder Nom(string Nom)
        {
            utilisateur.Nom = Nom;
            return this;
        }

        public Builder Prenom (string Prenom)
        {
            utilisateur.Prenom = Prenom;
            return this;
        }

        public Builder Email(string Email)
        {
            utilisateur.Email = Email;
            return this;
        }


        public Utilisateur Build()
        {
            return utilisateur;
        }


    }
}
