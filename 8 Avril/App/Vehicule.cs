using System;

namespace Exercice2
{
    class Vehicule
    {
        private bool ceDeplace;
        private uint vitesse;
        private uint prix;

        public Vehicule(bool ceDeplace, uint vitesse, uint prix)
        {
            this.ceDeplace = ceDeplace;
            this.vitesse = vitesse;
            this.prix = prix;
        }

        public bool getCeDeplace() => ceDeplace;
        public uint getVitesse() => vitesse;
        public uint getPrix() => prix;

        public void setVitesse(uint vitesse) => this.vitesse = vitesse;
        public void setPrix(uint prix) => this.prix = prix;

        public void Deplacer()
        {
            setVitesse(vitesse++);
        }
    }
}
