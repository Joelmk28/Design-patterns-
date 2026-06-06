using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Builder
{
    //Pour creer un objet de cette classe nous sommes obligés de passer par new Utilisateur()
    
    public class Utilisateur
    {
        public string ? Nom { get; set; }
        public string ? Prenom { get;  set; }
        public string ? Email { get;  set; }

        public Utilisateur() { }

        public static Builder builder() { return new Builder(); }
        
    }
}
