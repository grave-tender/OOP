using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Exercice2
    {
        int vitesse;

        public void deplacer(){
            vitesse += 100;
        }

        public void afficherVitesse(){ 
            Console.WriteLine($"la vitesse est: {vitesse}");
        }
    }
}
