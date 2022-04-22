using System;

namespace Exercice4
{
    class Plan : TroisD {
        public int posY;

        public Plan() { }

        public Plan(int posX, int posY){
            this.posY = posY;
        }

        public Plan(int posX, int posY, int posZ) : base(posX, posY, posZ) {
            this.posY = posY;
        }
    }
}