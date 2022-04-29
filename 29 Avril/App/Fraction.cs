using System;

namespace Exercice6 {
    class Fraction {
        public int num, denom;

        public Fraction(int num, int denom){
            if (denom == 0 ) throw new ArgumentException("lol ya dumb");
            this.num = num;
            this.denom = denom;
        }

        public static Fraction operator +(Fraction a, Fraction b) =>
            new Fraction(a.num * b.denom + a.denom*b.num, a.denom * b.denom);

        public static Fraction operator -(Fraction a, Fraction b) =>
            new Fraction(a.num * b.denom - a.denom*b.num, a.denom * b.denom);

        public static Fraction operator *(Fraction a, Fraction b) =>
            new Fraction(a.num * b.num, a.denom * b.denom);
    }
}