using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Exercice1
    {
        // int Annee { get; set; }
        // int Mois { get; set; }
        // int Jour { get; set; }
        // int Heure { get; set; }
        // int Minute { get; set; }
        // int Seconde { get; set; }

        // public Exercice1(DateTime date){ 
        //     Annee = date.Year;
        //     Mois = date.Month;
        //     Jour = date.Day;
        //     Heure = date.Hour;
        //     Minute = date.Minute;
        //     Seconde = date.Second;
        // }

        public static void afficher() {
            DateTime date = DateTime.Now;
            Console.WriteLine("La date de today est:\nAnnee: {0}\nMois: {1}\nJour: {2}", date.Year, date.Month, date.Day);
        }
    }
}
