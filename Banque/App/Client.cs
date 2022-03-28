using System;
using System.Text.RegularExpressions;

namespace App
{
    public class Client
    {
        //attributs:
        string nom;
        string prenom;
        string telephone;
        DateTime naissance;
        double salaireAnnuel;
        bool hasCriminalRecord;
        bool isEmployed;
        bool isBanned;
        bool isClientMort = false;
        DateTime dateMortDuClient;

        //constructeur
        public Client(
            string nom,
            string prenom,
            DateTime naissance,
            string telephone,
            double salaireAnnuel,
            bool isEmployed,
            bool hasCriminalRecord,
            bool isBanned
        ) {
            setNom(nom);
            setPrenom(prenom);
            this.naissance = naissance; //day month year
            if(getAge() < 18) throw new Exception("Le client doit etre un adulte (18 ans)");
            setTelephone(telephone);
            if (salaireAnnuel <= 0) throw new Exception("Le salaire annuel ne peut etre negatif");
            this.salaireAnnuel = salaireAnnuel;//can be both jobless and have a salary and vice versa
            this.isEmployed = isEmployed;
            this.hasCriminalRecord = hasCriminalRecord;

            if (isBanned) throw new Exception("Nous refusons les personnes qui ont déjà été bannies au par avant");
        }

        //getters setters
        public string getNom() => nom;
        public string getPrenom() => prenom;
        public DateTime getNaissance() => naissance;
        public string getTelephone() => telephone;
        public double getSalaireAnnuel() => salaireAnnuel;
        public bool getHasCriminalRecord() => hasCriminalRecord;
        public bool getIsEmployed() => isEmployed;
        public bool getIsBanned() => isBanned;
        public bool getIsClientMort() => isClientMort;
        public DateTime getDateMortClient() { if (!isClientMort) throw new Exception("Client isn't dead"); return dateMortDuClient; }

        public void setNom(string nom)
        {
            if (isNomValide(nom))
                this.nom = nom;
            else
                throw new Exception("Nom doit etre [A-Z,a-z] seulement");
        }

        public void setPrenom(string prenom)
        {
            if (isNomValide(prenom))
                this.prenom = prenom;
            else
                throw new Exception("Prenom doit etre [A-Z,a-z] seulement");
        }

        public void setTelephone(string telephone)
        {
            long justNumbers = long.Parse(Regex.Replace(telephone, "[^0-9]", ""));
            if (Math.Floor(Math.Log10(justNumbers)) == 10) throw new Exception("This phone number has to be 10 digits long.");
            string formattedTelephone = String.Format("{0:(###)###-####}", justNumbers);
            this.telephone = formattedTelephone;
        }

        public void setIsEmployed(bool isEmployed) => this.isEmployed = isEmployed;

        //TODO: rerun interest check on loans cuz the person may have been cleared/forgiven/declared guilty
        //cannot do this without heritance
        public void setHasCriminalRecord(bool criminalRecord) => this.hasCriminalRecord = criminalRecord;

        //methods
        bool isNomValide(string nom)
        {
            return Regex.IsMatch(nom, @"^[a-zA-Z]+$");;
        }

        public void Ban()
        {
            isBanned = true;
        }

        public void DeclarerLeClientMort()
        {
            isClientMort = true;
            dateMortDuClient = DateTime.Now;
        }

        public void DeclarerLeClientMort(DateTime date)
        {
            isClientMort = true;
            dateMortDuClient = date;
        }

        public int getAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - naissance.Year;
            if (naissance.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
