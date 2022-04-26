using System;

namespace Exercice3{
    abstract public class Animal{
        private bool male;

        public Animal() { }

        public Animal(bool male) => this.male = male;

        public bool Male{
            get { return male; }
            set { this.male = value; }
        }
    }
}