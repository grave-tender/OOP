using System;
using static System.Console;

namespace ExerciceFactorielle
{
    class Program
    {
        static void Main(string[] args)
        {
            farctorielleDe0A(10);
        }

        /// <summary>
        /// Passe par chaque nombre jusqua X et appelle la fonction factoriellee
        /// </summary>
        static void farctorielleDe0A(int loopUntil)
        {
            for (int i = 1; i <= loopUntil; i++)
                WriteLine($"{i}!={factorielleDe(i)}");
        }

        /// <summary>
        /// Calcule la factoriellee d'un nombre donné
        /// </summary>
        static int factorielleDe(int factor)
        {
            for (int j = (factor - 1); j > 0; j--)
                factor *= j;
            return factor;
        }
    }
}
