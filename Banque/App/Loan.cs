using System;

namespace App
{
    class Loan
    {
        //un loan est une transaction dans le negatif du solde.
        //think how a loan is repaid, will it get paid as a deposit comes in or will it have an option to be paid individually? or both?
        //TODO: think, is there one big loan or many little loans, doesn't it just stack after the balance has reached 0?
        //the dead cannot take a loan

        //determine interest based on age, criminal record and if hes banned

        double some = 0;
        double tauxInteret;
        bool canLoan = true;
        DateTime limitePourPayer;



        

        //constructor
        public Loan(Client client, double solde, double margeCredit, string typeCompte){

        }

        //getters setters
        public double getSome() => some;
        public double getTauxInteret() => tauxInteret;
        public bool getCanLoan() => canLoan;
        public DateTime getLimitePourPayer() => limitePourPayer;

        public void setSome(double some) => this.some = some;

        public void setCanLoan() => canLoan = true;
        
        public void setTauxInteret(){

        }

        public void setLimitePourPayer() {//new limit
            //up tauxInteret

        }

        //methods
    }
}
