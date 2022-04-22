using System;
using static System.Console;

namespace Li
{
    class Cercle:forme
    {
        double rayon;
        double surface;

        public Cercle() 
        {
        }
        public Cercle( double rayon)
        {
            this.rayon = rayon;

                }

        public double Rayon
        { get { return rayon; }
            set { rayon = value; }
        }

        public double Surface()
        {
            surface = (rayon * rayon * Math.PI);
            return surface;
        }

        public void Affiche()
        {
            WriteLine($"J'affiche a partir de forme de Cercle, surface :{surface}");
        }


    }
}
