using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Stategy
{
    //Contexte : La classe Document représente un document dans notre application de traitement de texte. Elle contient une référence à une instance de IOperation qui représente la stratégie d'enregistrement actuelle pour ce document. En utilisant le pattern Strategy, nous pouvons facilement changer la stratégie d'enregistrement pour un document en assignant une nouvelle instance de IOperation à la propriété Operation.
    public class Document
    {
        public IOperation Operation { get; private set; }
        public Document() {
        
            Operation = new Doc(); // Par défaut, on peut choisir une stratégie d'enregistrement par défaut
        }

        internal void SetOperation(IOperation operation)
        {
            this.Operation = operation; // Permet de changer la stratégie d'enregistrement à la volée
        }
        public void Enregistrer()
        {
            Operation.EnregistrerSous(); // Délègue l'appel à la stratégie d'enregistrement actuelle
        }
    }
}
