using System;

namespace Exercice4
{
    class Point : Ligne {
        public Point(int x) : base(x) { }

        public Point(int x, int y) : base(x, y) { }

        public Point(int x, int y, int z) : base(x, y, z) { }

        public void deplacer(int x){
            posX += x;
        }

        public void deplacer(int x, int y){
            deplacer(x);
            posY += y;
        }

        public void deplacer(int x, int y, int z){
            deplacer(x, y);
            posZ += z;
        }
    }
}