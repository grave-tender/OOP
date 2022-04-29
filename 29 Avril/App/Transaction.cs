using System;

namespace Exercice4{
    class Transaction : ITransaction
    {
        uint id;
        string detailsTransaction;
        double montant;

        public void RetournerDetailsTransaction() => Console.WriteLine(detailsTransaction);

        public double retournerMontant() => montant;
    }
}