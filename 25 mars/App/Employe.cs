using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Employe
    {
        // On va traiter un employe
        string nom;
        string prenom;
        string adresse;
        string telephone;
        string dateDeNaissance;

        //1er constructeur
        public Employe(string nom, string prenom, string adresse, string telephone, string dateDeNaissance)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.dateDeNaissance = dateDeNaissance;
        }

        //2eme constructeur, le constructeur peut aussi ne pas avoir de params
        public Employe(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        //les getters setters doivent aussi etre publiques
        public string Nom { get; set; }

        public string getNom() { return nom; }
        public string Prenom { get; set; }

        public string getPrenom() { return prenom; }


    }
}
