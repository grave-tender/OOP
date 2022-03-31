using System;
using System.Collections.Generic;

namespace App
{
    //TODO: ristourne -- fuck that
    class CompteBanquaire
    {
        //attributs:
        Client client;
        double solde;
        string status = "closed";
        string typeCompte; //etudiant, epargne
        double margeCredit;
        List<Transaction> transactions = new List<Transaction>();
        Loan loan = null; //no loan upon opening an account

        //constructor
        public CompteBanquaire(Client client, string typeCompte, double solde){
            this.client = client;
            if(solde<0) throw new Exception("La somme initialle ne peut etre en dessous zero");
            this.solde = solde;
            status = "active";
            DateOuverture = DateTime.Now;
            setTypeCompte(typeCompte);
            //si le client est un etudiant, la marge de credit initiale maximum est 300$, sinnon 1000$
            determinerMargeCredit(client, solde, typeCompte, (typeCompte.Equals("student"))? 1000: 300);

            // loan = new Loan(client, solde, margeCredit, typeCompte);
        }

        //getters setters
        public DateTime DateOuverture { get; }
        public DateTime DateFermeture { get; set; }
        public string getTypeDeCompte() => typeCompte;
        public Client getClient() => client;
        public string getStatus() => status;
        public double getMargeCredit() => margeCredit;
        public Loan getLoans() => loan;
        public List<Transaction> getTransactions() => transactions;
        
        //methods
        void setTypeCompte(string type) {
            if(!type.Equals("etudiant") && !type.Equals("epargne"))
                throw new Exception("Ce type de compte n'existe pas");
            
            if(type.Equals("etudiant") && client.getAge() > 24) throw new Exception("Vous ne pouvez pas avoir un compte etudiant si vous avez au dela de 24 ans");
            this.typeCompte = type;
        }
        
        public void determinerMargeCredit(Client client, double solde, string typeCompte, double margeCredit){
            if (client.getHasCriminalRecord() && !client.getIsEmployed()) margeCredit *= 0.7;
            else if(client.getHasCriminalRecord() || !client.getIsEmployed()) margeCredit *= 0.9;

            //limite de credit d'un etudiant de 1000$
            if(typeCompte.Equals("etudiant")) margeCredit = (margeCredit < 1000)? margeCredit: 1000;

            //bonus paliers de somme dans compte
            double soldeArrondi = Math.Floor(solde / 10000.0) * 10000.0;
            if(soldeArrondi%10000 == 0) margeCredit += soldeArrondi * 0.1;

            if(margeCredit < 0 ) margeCredit = 0;
        }

        public void FermerCompte(){
            DateFermeture = DateTime.Now;
            status = "closed";
        }

        public void BanCompte(){
            this.FermerCompte();
            if(solde>0) //saisir les economies, mais ce rappeller des dettes.
                solde = 0;
            client.Ban();
        }

        public double Solde(){
            return solde;
        }

        public int Retrait(int somme) {
            if(client.getIsBanned()) throw new Exception("Le client de ce compte a ete bani");
            if(solde < 0) throw new Exception($"Vous n'avez pas assez de fonds pour retirer {somme}$");
            if((solde-somme) < (solde-margeCredit))
                throw new Exception($"votre marge de credit de {margeCredit}$ vous empeche de pouvoir retirer d'avantage");
            //TODO: seulement retirer si un Loan le permet
            if(solde < 0){
                if(!loan.getCanLoan()) throw new Exception("tu ne peut emprunter de l'argent, marge de credit depasee");

                if((solde-somme) >= (margeCredit*-1)) throw new Exception($"cette transaction n'a pas ete effectuee car vous depassez de {(solde-somme)-(margeCredit*-1)}$ votre marge de credit");

                //loan & history
                
            } 


            solde -= somme;
            //TODO: si la somme retraire mets le solde en negatif, creer un nouveau loan.
            //TODO: check if changement de palier

            //TODO: ajouter a l'historique des transactions
            return somme;
        }

        public void Depot(int somme) {
            solde += somme;
            //TODO: ajouter a l'historique des transactions
            //TODO: check if changement de palier
        }
    }
}
