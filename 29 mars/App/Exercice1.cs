using System;

namespace App
{
    public class Exercice1
    {
        uint annee;
        uint mois;
        uint jour;
        uint heure;
        uint minute;
        uint seconde;

        public Exercice1(uint a, uint m, uint d, uint h, uint min, uint s){
            annee = a;
            mois = m;
            jour = d;
            heure = h;
            minute = min;
            seconde = s;
        }

        public Exercice1(DateTime date){
            annee = (uint) date.Year;
            mois = (uint) date.Month;
            jour = (uint) date.Day;
            heure = (uint) date.Hour;
            minute = (uint) date.Minute;
            seconde = (uint) date.Second;
        }

        public void afficher() {
            Console.WriteLine("{0}/{1}/{2} {3}:{4}:{5} ",
                annee,
                mois,
                jour,
                heure,
                minute,
                seconde
            );
        }
    }
}
