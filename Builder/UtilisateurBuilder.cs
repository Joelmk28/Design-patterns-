using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    public static class UtilisateurBuilder
    {
        public static Utilisateur Build(string nom, string prenom, string email)
        {
            return new Utilisateur
            {
                Nom = nom,
                Prenom = prenom,
                Email = email
            };
        }
    }
}
