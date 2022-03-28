using System;
using static System.Console;

namespace App
{
    class Program
    {
        //initialize
        static void Main(string[] args)
        { 
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

            CompteBanquaire compte = new CompteBanquaire(c1, "etudiant", 1000);
            // CompteBanquaire compte = new CompteBanquaire(c1, "etudiant", 19999);



            //faire un Retrait
            // compte.Retrait(10);
            WriteLine(compte.getMargeCredit());

            //faire un depot

            //faire un retrait qui me rends endette

            //faire un depot qui paye la dette

            //faire un retrait qui me rends en dette au dela de ma marge de credit (should crash)

            //[arbitrairement] temporairement changer la date limite pour payer a 1 minute (pour tester l'augmentation des interets)

            //ban user et faire un depot/retrait

            //[arbitrairement] unban le user pour pouvoir continuer a tester lol

            //tuer le client et faire un retrait

            //avec le meme dead client, essayer de faire un retrait qui me rends endette

            //[arbitrairement] revivre le client

            //s'endetter avec un retrait, tuer le client, et payer sa dette quand ye dead

            //[arbitrairement] revivre le client

            //avoir une dette

            //avec le timer a 1 minute pour les interets, changer de type de compte et check si les interests changent aussi
        
            //loan paye a temps augmente la cote de credit
        }
    }
}
