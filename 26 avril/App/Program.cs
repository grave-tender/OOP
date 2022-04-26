using System;
using static System.Console;

using Exercice1;
using Exercice2;
using Exercice3;

namespace App
{
    class Program
    {
        static void Main()
        {
            //Exercice 1
            Rectangle r = new();
            Triangle t = new();
            r.Dessiner();
            r.Colorier();
            t.Dessiner();
            r.Colorier();

            //Exercice 3
            Cheval cheval = new();
            Chien chien = new(true);
            ChienBerger chienBerger = new();

            cheval.Male = true;

            WriteLine(cheval.Male);
            WriteLine(chien.Male);
            WriteLine(chienBerger.Male);
        }
    }
}
