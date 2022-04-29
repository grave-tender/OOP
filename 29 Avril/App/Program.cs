using System;
using Exercice4;
using Exercice6;
using static System.Console;

namespace App
{
    class Program
    {
        static void Main(string[] args) 
        {
            Stonks AMZNS = new();
            Fond AMZNF = new();
            AMZNS.Symbole = "AMZN";
            AMZNS.Prix = 2451;
            AMZNF.Symbole = "AMZN";
            AMZNF.Prix = 2451;

            
            Stonks GOOGS = new();
            Fond GOOGF = new();
            GOOGS.Symbole = "GOOG";
            GOOGS.Prix = 2307;
            GOOGF.Symbole = "GOOG";
            GOOGF.Prix = 2307;

            Stonks APPLS = new();
            Fond APPLF = new();
            APPLS.Symbole = "APPL";
            APPLS.Prix = 159;
            APPLF.Symbole = "APPL";
            APPLF.Prix = 159;
            
            Stonks TSLAS = new();
            Fond TSLAF = new();
            TSLAS.Symbole = "TSLA";
            TSLAS.Prix = 884;
            TSLAF.Symbole = "TSLA";
            TSLAF.Prix = 884;

            Stonks COSTS = new();
            Fond COSTF = new();
            COSTS.Symbole = "COST";
            COSTS.Prix = 538;
            COSTF.Symbole = "COST";
            COSTF.Prix = 538;


            Fraction f1 = new(1,2);
            Fraction f2 = new(1,2);
            Fraction f3 = f1 + f2;
            WriteLine(f3.num + " " + f3.denom);
        }
    }
}
