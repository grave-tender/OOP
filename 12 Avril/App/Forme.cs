using System;
using static System.Console;

namespace Exercice3
{
    class Forme
    {
        //attributs
        string couleur;

        //constructeur
        protected Forme(string couleur) {
            this.couleur = couleur;
        }
        
        //methodess
        public double surface() {
            if (this.GetType().ToString().Contains("Cercle")){
                Cercle c = (Cercle) this;
                return c.rayon * Math.PI;
            }
            else if (this.GetType().ToString().Contains("Rectangle")){
                Rectangle r = (Rectangle) this;
                return r.largeur * r.longeur;
            }
            
            throw new Exception("what how");
        }

        public void afficher() => WriteLine($"la surface est {this.surface()}");
    }
}
