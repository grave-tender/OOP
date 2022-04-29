namespace Exercice4
{
    class Stonks : Share_FNB
    {
        private string symbole;
        private decimal prix;

        public string Symbole {
            get => symbole;
            set => symbole = value;
        }

        public decimal Prix {
            get => prix;
            set => prix = value;
        }
    }
}