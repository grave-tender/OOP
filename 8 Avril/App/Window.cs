using System;

namespace Exercice1
{
    class Window
    {
        protected uint haut;
        protected uint bas;

        protected Window(uint haut, uint bas)
        {
            this.haut = haut;
            this.bas = bas;
        }

        public uint getHaut() => haut;
        public uint getBas() => bas;

        public void setHaut(uint haut) => this.haut = haut;
        public void setBas(uint bas) => this.bas = bas;

        //Dessiner
        public void Desinner() => Console.WriteLine($"je dessine une window de haut:{haut} et bas: {bas}");
    }
}
