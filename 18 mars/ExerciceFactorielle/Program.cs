using System;
using static System.Console;

namespace ExerciceFactorielle
{
    class Program
    {
        static void Main(string[] args)
        {
            farctorielleDe0A(10);
            ReadLine();
        }

        static void farctorielleDe0A(int loopUntil)
        {
            for (int i = 1; i <= loopUntil; i++)
                WriteLine($"{i}!={farctorielleDe(i)}");
        }

        static int farctorielleDe(int factor)
        {
            for (int j = (factor - 1); j > 0; j--)
                factor *= j;
            return factor;
        }
    }
}
