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

        const double TAUX_DIRECTEUR = 0.05;
        double dette = 0;
        double tauxInteret; //pourcentage
        bool canLoan = true; //ceci decide quoi faire lors d'un retrait
        DateTime dateLimitePourPayer;
        int nbAmmendes = 0;//continuer indefiniment pour faire payer le client d'avantage


        //constructor
        public Loan(Client client, double solde, double margeCredit, string typeCompte){
            setTauxInteret(client, solde, margeCredit, typeCompte);
            addDeuxSemainesDateLimite();
        }


        //getters setters
        public double getDette() => dette;
        public double getTauxInteret() => tauxInteret;
        public bool getCanLoan() => canLoan;
        public DateTime getLimitePourPayer() => dateLimitePourPayer;

        public void setDette(double dette) {
            
            this.dette = dette;
        }

        public void setCanLoan() => canLoan = true;
        
        public void setTauxInteret(Client client, double solde, double margeCredit, string typeCompte){
            if(margeCredit == 0) throw new Exception("Quelqu'un sans marge de credit ne peut faire un pret");

            if (client.getHasCriminalRecord() && !client.getIsEmployed()) 
                tauxInteret += 0.7;
            else if(client.getHasCriminalRecord() || !client.getIsEmployed()) 
                tauxInteret += 0.9;

            if(typeCompte.Equals("etudiant"))
                tauxInteret += 1.0;

            if(solde/margeCredit >= 0.25) //si le solde est a 25% de la capacite de la marge de credit
                tauxInteret += 0.25;
            else if(solde/margeCredit >= 0.60) //si le solde est a 60% de la capacite de la marge de credit
                tauxInteret += 0.75;
            else if(solde/margeCredit >= 0.85) //si le solde est a 85% de la capacite de la marge de credit
                tauxInteret += 1.0;
        }

        //TODO:
        public bool enRetard() {
            //up tauxInteret, ++nb ammendes et reset temps limite pour +2 semaines
            if(DateTime.Now > dateLimitePourPayer) {
                addDeuxSemainesDateLimite();
                return true;
            }
            return false;
        }

        //methods
        public void addDeuxSemainesDateLimite() {//nouvelle limite de +2 semaines
            //now + 2 semaines
            dateLimitePourPayer.Add(TimeSpan.FromDays(14));
        }
    }
}
