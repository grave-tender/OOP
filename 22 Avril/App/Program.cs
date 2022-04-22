using System;
using Exercice1;
using Exercice2;
using Exercice3;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p1 = new("Bob", DateTime.Now);
            Personne p2 = new("Leponge", DateTime.Now);

            Personne.Procreer(p1, p2);

            foreach (Personne enfant in Personne.Enfants)
            {
                WriteLine(enfant.Nom);
            }

            p2.EcrireDansConsole();
            WriteLine(p1.ToString());

            WriteLine(Comparer.Compare(p1, p2));

            Personne p3 = p1;

            WriteLine(Comparer.Compare(p1, p3));

            WriteLine(Comparer.Compare(null, p3));

            Employe e = new(p1, "astronaut");

            WriteLine(e.ToString());
        }
    }
}
