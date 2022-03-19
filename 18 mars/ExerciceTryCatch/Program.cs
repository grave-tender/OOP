using System;
using static System.Console;

namespace ExerciceTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {

            //THIS WILL NEVER WORK NOR THROW ANYTHING, IT WILL JUST LOOP, ASK NAÏM FOR MORE
            try
            {
                int max = 500;

                for (byte i = 0; i < max; i++)
                {
                    WriteLine(i);
                }
            }
            catch (System.Exception ex)
            {
                WriteLine("Exception caught: \n"+ex);
            }

        }
    }
}
