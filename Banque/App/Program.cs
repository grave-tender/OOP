using System;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            //try catch bad dates input
            Client c1 = new Client(
                "Leon",
                "Carlos",
                new DateTime(1998, 11, 28),
                "(123)456-7890",
                30000,
                true,
                false,
                false
            );

            WriteLine(c1.getAge());

            CompteBanquaire compte = new CompteBanquaire(c1, "epargne", 0);
        }
    }
}
