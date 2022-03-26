using System;

namespace App
{
    //TODO: ristourne
    class CompteBanquaire
    {
        //attributs:
        Client client;
        double solde;
        string status = "closed";
        string typeDeCompte; //etudiant, epargne
        Transaction[] transactions;
        Loan loan;//this may not need to be a list, the loans interest can decrease the balance's value past the credit margin
        double margeCredit;

        //constructor
        public CompteBanquaire(Client client, string typeCompte, double solde){
            this.client = client;
            if(solde<0) throw new Exception("La somme initialle ne peut etre en dessous zero");
            this.solde = solde;
            status = "active";
            DateOuverture = DateTime.Now;
            margeCredit = determinerMargeCredit(client, solde);
        }

        //getters setters
        public DateTime DateOuverture { get; }
        public DateTime DateFermeture { get; set; }
        public string getTypeDeCompte() => typeDeCompte;
        public Client getClient() => client;
        public string getStatus() => status;
        public double getMargeCredit() => margeCredit;
        public Loan getLoans() => loan;
        public Transaction[] getTransactions() => transactions;
        
        public void setTypeCompte(string type) {
            if(!type.Equals("etudiant") && !type.Equals("epargne"))
                throw new Exception("Ce type de compte n'existe pas");
        }
        //methods
        //TODO: finir cette methode
        public int determinerMargeCredit(Client client, double solde){
            return 50;
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
