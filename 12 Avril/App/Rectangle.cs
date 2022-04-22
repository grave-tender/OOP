using System;

namespace Exercice3
{
    class Rectangle : Forme
    {
        //attributs
        public double longeur, largeur;

        //constructeurs
        public Rectangle(double longeur, double largeur, string couleur) : base(couleur)
        {
            this.longeur = longeur;
            this.largeur = largeur;
        }

        //methodes
        // public double surface() => base.surface(this);

        // public void afficher() => base.afficher($"la surface est {base.surface()}");
    }
}
