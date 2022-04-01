using System;

namespace CatProject
{
    class MonChat : Chat
    {
        int nbHeuresDodo;
        bool isCatHugable;
        bool estNourrie;
        //constructeurs
        public MonChat(string nom, DateTime dateDeNaissance, int nbDePattes, bool aUneQueue, int nbHeuresDodo, bool isCatHugable)
            : base(nom, dateDeNaissance, nbDePattes, aUneQueue)
        {
            this.nbHeuresDodo = nbHeuresDodo;
            this.isCatHugable = isCatHugable;
        }

        public MonChat(string nom, DateTime dateDeNaissance, int nbHeuresDodo, bool isCatHugable)
            : base(nom, DateTime.Now)
        {
            this.nbHeuresDodo = nbHeuresDodo;
            this.isCatHugable = isCatHugable;
        }

        //getters
        public void setNbHeuresDodo(int nbHeuresDodo) => this.nbHeuresDodo = nbHeuresDodo;
        public void setEstNourrie(bool estNourrie) => this.estNourrie = estNourrie;
        public void setIsCatHugable(bool isCatHugable) => this.isCatHugable = isCatHugable;

        //setters
        public int getNbHeuresDodo() => this.nbHeuresDodo;
        public bool getEstNourrie() => this.estNourrie;
        public bool getIsCatHugable() => this.isCatHugable;

        //methods
        public void hug(){
            if(!isCatHugable || !estNourrie || nbHeuresDodo < 10) throw new Exception("wanna die?");

            Console.WriteLine("purrs");
        }
    }
}
