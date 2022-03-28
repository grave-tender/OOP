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
        double tauxInteret; //pourcentage
        bool canLoan = true; //ceci decide quoi faire lors d'un retrait
        DateTime dateLimitePourPayer;
        int nbAmmendes = 0;//continuer indefiniment pour faire payer le client d'avantage



        

        //constructor
        public Loan(Client client, double solde, double margeCredit, string typeCompte){
            setLimitePourPayer();
        }

        //getters setters
        public double getSome() => some;
        public double getTauxInteret() => tauxInteret;
        public bool getCanLoan() => canLoan;
        public DateTime getLimitePourPayer() => dateLimitePourPayer;

        public void setSome(double some) => this.some = some;

        public void setCanLoan() => canLoan = true;
        
        public void setTauxInteret(){

        }

        public void setLimitePourPayer() {//new limit
            //up tauxInteret, ++nb ammendes et reset temps limite pour +2 semaines

        }

        //methods
    }
}
