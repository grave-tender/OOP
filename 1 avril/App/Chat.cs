using System;

namespace CatProject
{
    class Chat
    {
        int nbDePattes = 4;
        bool aUneQueue = true;
        string nom;
        DateTime dateDeNaissance;

        public Chat(string nom, DateTime dateDeNaissance){
            this.nom = nom;
            this.dateDeNaissance = dateDeNaissance;
        }

        public Chat(string nom, DateTime dateDeNaissance, int nbDePattes, bool aUneQueue){
            this.nbDePattes = nbDePattes;
            this.aUneQueue = aUneQueue;
            this.nom = nom;
            this.dateDeNaissance = dateDeNaissance;
        }

        public void setNbPattes(int nbPattes){
            if (nbPattes > 4 || nbPattes < 0) throw new ArgumentException($"what the fuck un chat avec ${nbPattes} pattes??");

            this.nbDePattes = nbPattes;
        }

        public void setAUneQueue(bool aUneQueue){
            if ( this.aUneQueue && !aUneQueue) throw new ArgumentException("how did ur cat gain a tail?");

            this.aUneQueue = false;
        }

        public void setNom(string nom) => this.nom = nom;

        public string getNom() => nom;
        public DateTime getDateDeNaissance() => dateDeNaissance;
        public int getNbPattes() => nbDePattes;
        public bool getAUneQueue() => aUneQueue;

        //methods
        public string whatDoesTheCatSay() => "miau";
    }
}
