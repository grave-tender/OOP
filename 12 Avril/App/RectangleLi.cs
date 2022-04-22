using System;
using static System.Console;

namespace Li
{
    class Rectangle: forme
    {
        double longueur;
        double largeur;
        double surface;

        public Rectangle()
        {
            longueur = 0;
            largeur = 0;
            surface = 0;


        }
        public Rectangle(double longueur,double largeur)
        {
            this.longueur= longueur;
            this.largeur= largeur;
            surface = 0;
        }

        public double Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public double Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }


        public double Surface()
        {   surface = largeur * Longueur;
            return surface;
                }

        public void Affiche()
        {
            WriteLine($"J'affiche a partir de forme de Rectangle, surface :{surface}");
        }

    }
}
