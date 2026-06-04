using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Factory
{
    public class PayementFactory
    {
        //La classe clé du pattern Factory est la classe PayementFactory, qui est responsable de la création d'instances de différentes classes de paiement. Elle utilise une méthode statique GetPayement qui prend un paramètre de type string pour déterminer quel type de paiement doit être créé. En fonction de la valeur du paramètre, elle retourne une instance de la classe correspondante (PayementParCarte, PayementParMobilMoney ou PayementCash).
        //Si le type de paiement n'est pas supporté, elle lance une exception ArgumentException.
        // La classe maintenant la logique de création d'instances de différentes classes de paiement
       
        public static IPayement GetPayement(string type)
        {
            switch (type.ToLower())
            {
                case "1":
                    return new PayementParCarte();
                case "2":
                    return new PayementParMobilMoney();
                case "3":
                    return new PayementCash();
                default:
                    throw new ArgumentException("Type de paiement non supporté.");
            }
        }
    }
}
