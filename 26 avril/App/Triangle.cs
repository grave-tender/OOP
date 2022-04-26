using System;

namespace Exercice1{
    class Triangle : IForme
    {
        public int nbCotes = 3;

        public Triangle(){

        }

        public void Colorier()
        {
            Console.WriteLine("je colorie le trangle");
        }

        public void Dessiner()
        {
            Console.WriteLine("je dessine le trangle");
        }
    }
}