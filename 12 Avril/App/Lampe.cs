using System;
using static System.Console;

namespace Exercice5
{
    public class Lampe
    {
        protected bool etat;

        public Lampe(bool etat)
        { 
            this.etat = etat;
        }

        public void ON() => etat = true;

        public void OFF() => etat= false;

        public void Afficher() => WriteLine(etat ? "ouvert" : "ferme");
    }
}