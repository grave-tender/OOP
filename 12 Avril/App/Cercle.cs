using System;

namespace Exercice3
{
    class Cercle : Forme
    {
        //attributs
        public double rayon;

        //constructeur
        public Cercle(double rayon, string couleur) : base(couleur)
        {
            this.rayon = rayon;
        }

        //methodes
        // public double surface() => base.surface(this);

        // public void afficher() => base.afficher($"le surface est{base.surface()}");
    }
}
