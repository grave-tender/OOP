using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercice1 date = new(DateTime.Now);
            date.afficher();

            Exercice1 date2 = new(1998, 11, 18, 20, 00, 00);
            date2.afficher();
        }
    }
}
