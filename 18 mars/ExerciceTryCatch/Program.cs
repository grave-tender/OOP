using System;
using static System.Console;

namespace ExerciceTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int max = 500;

                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }
            catch (OverflowException ex)
            {
                WriteLine("T'as loop à l'infini: \n"+ex);
            }

        }
    }
}
