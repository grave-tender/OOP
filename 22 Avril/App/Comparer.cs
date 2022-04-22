using System;
using System.Collections.Generic;
using Exercice1;

namespace Exercice2{
    class Comparer
    {
        public static int Compare(Personne? x, Personne? y){
            if(x == null){
                Console.WriteLine("x est null");
                return 0;
            }
            if(y == null){
                Console.WriteLine("y est null");
                return 0;
            }

            if(x.Nom.Equals(y.Nom) && x.DateNaissance == y.DateNaissance) return 1;
            return 0;
        }
    }
}