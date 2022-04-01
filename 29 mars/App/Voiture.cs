using System;

namespace App
{
    class Voiture
    {
        string compagnie;
        uint vitesse = 0;
        uint nbRoues = 4;

        public Voiture(string compagnie){
            this.compagnie = compagnie;
        }

        public Voiture(string compagnie, uint nbRoues){
            this.compagnie = compagnie;
            this.nbRoues = nbRoues;
        }

        public void accelerer() => vitesse++;

        public void deccelerer() => vitesse--;

        public void afficherVitesse(){ 
            Console.WriteLine($"la vitesse est: {vitesse}");
        }
    }
}
