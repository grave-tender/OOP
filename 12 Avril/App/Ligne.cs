using System;

namespace Exercice4
{
    class Ligne : Plan {
        public int posX;

        public Ligne(){ }

        public Ligne(int posX){
            this.posX = posX;
        }

        public Ligne(int posX, int posY) : base(posX, posY){
            this.posX = posX;
        }

        public Ligne(int posX, int posY, int posZ) : base(posX, posY, posZ){
            this.posX = posX;
        }
    }
}