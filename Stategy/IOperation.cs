using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Stategy
{
    //Imaginons que nous avons une application de traitement de texte qui permet aux utilisateurs d'enregistrer leurs documents dans différents
    //formats tels que .docx, .pdf, .txt, etc. Nous pouvons utiliser le pattern Strategy pour encapsuler les différentes stratégies d'enregistrement sous différents formats.
    //Au lieu de faire des conditions pour déterminer quel format d'enregistrement utiliser, nous pouvons créer une interface IOperation qui définit une méthode EnregistrerSous() et implémenter cette interface pour chaque format d'enregistrement.
    //C'est cela que l'on appelle le pattern Strategy, il permet de séparer les différentes stratégies d'implémentation et
    //de les rendre interchangeables.
    public interface IOperation
    {
        public void EnregistrerSous();
    }
}
