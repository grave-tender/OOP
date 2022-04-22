using System;
using Exercice1;

namespace Exercice3{
    class Employe : Personne{
        public string Travail;

        public Employe(string Nom, DateTime DateNaissance, string Travail) : base(Nom, DateNaissance) {
            this.Travail = Travail;
        }

        public Employe(Personne p, string Travail) : base(p.Nom, p.DateNaissance) {
            this.Travail = Travail;

        }
        
        public override void EcrireDansConsole() => Console.WriteLine("hi mom");
    }
}