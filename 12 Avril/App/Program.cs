using System;
using static System.Console;
using Exercice4;
using Exercice5;
// using Exercice3;
// using Li;

namespace App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Point p = new(1);
            p.deplacer(0,2);
            WriteLine($"p's posX: {p.posX} posY: {p.posY} posZ {p.posZ}");

            Lampe l = new(true);
            l.Afficher();
        }
    }
}
