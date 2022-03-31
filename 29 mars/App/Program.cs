using System;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice1.afficher();
            Exercice2 exercice2 = new Exercice2();
            exercice2.deplacer();
            exercice2.afficherVitesse();
        }
    }
}
