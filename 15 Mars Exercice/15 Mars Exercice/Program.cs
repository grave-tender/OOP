using System;

namespace _15_Mars_Exercice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez les 3 chiffres:");
            int a = readInt();
            int b = readInt();
            int c = readInt();

            int max = calculateMax(a, b, c);

            Console.WriteLine("Le max est: " + max);
        }

        static int calculateMax(int a, int b, int c)
        {
            if (a > b && a > c) return a;
            if (b > c) return b;
            return c;
        }

        static int readInt()
        {
            int nb = 0;
            try
            {
                nb = Convert.ToInt32(Console.ReadLine());
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return nb;
        }
    }
}
