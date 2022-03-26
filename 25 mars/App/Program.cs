using System;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Employe em1 = new Employe("Bob", "Eponge");

            em1.Nom = "BOB";
            em1.Prenom = "EPONGE";

            WriteLine("{0} {1}", em1.Nom, em1.Prenom);
            WriteLine("{0} {1}", em1.getNom(), em1.getPrenom());

            Point p = new Point(1,2);
            p.x = 3;
            p.y = 4;
            WriteLine("x: {0} y: {1}", p.x, p.y);


            Calcul calculateur = new Calcul();
            WriteLine(calculateur.Sum(1,2));
            WriteLine(calculateur.Sum(1.0,2.5));
            WriteLine(calculateur.Minus(5,2));
            WriteLine(calculateur.Multiply(5,2));
            WriteLine(calculateur.Divide(16,8));

            string example = "a";

            if(example.Equals("a")){
                int valeur = 1;
                WriteLine(valeur.GetType());
            }
            else {
                double valeur = 2.0;
                WriteLine(valeur.GetType());
            }
        }
    }
}
