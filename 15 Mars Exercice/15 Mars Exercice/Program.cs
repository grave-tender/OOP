using System;

namespace _15_Mars_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez les 3 chiffres:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = calculateMax(a, b, c);

            Console.WriteLine("Le max est: " + max);
        }

        static int calculateMax(int a, int b, int c)
        {
            if (a > b && a > c) return a;
            if (b > c) return b;
            return c;
        }
    }
}
