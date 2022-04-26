using System;

namespace Exercice1{
    class Rectangle : IForme
    {
        public int nbCotes = 4;

        public Rectangle(){

        }

        public void Colorier()
        {
            Console.WriteLine("je colorie le rectangle");
        }

        public void Dessiner()
        {
            Console.WriteLine("je dessine le rectangle");
        }
    }
}