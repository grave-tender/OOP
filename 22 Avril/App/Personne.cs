using System;
using System.Collections.Generic;

namespace Exercice1
{
    public class Personne : object {
        public string? Nom;
        public DateTime DateNaissance;
        public static List<Personne> Enfants = new();

        public Personne(string Nom, DateTime DateNaissance){
            this.Nom = Nom;
            this.DateNaissance = DateNaissance;
        }

        private Personne(Personne p1, Personne p2){
            this.Nom = p1.Nom + " " + p2.Nom;
            this.DateNaissance = DateTime.Now;
        }

        public virtual void EcrireDansConsole() => Console.WriteLine("hi");

        public static void Procreer(Personne p1, Personne p2) => Enfants.Add(new Personne(p1, p2));

        public override string ToString() => "hi: " + base.ToString();
    }
}