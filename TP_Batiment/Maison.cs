namespace TP_Batiment
{//Classe Maison qui hérite de la classe Batiment:
    internal class Maison : Batiment
    {//Attribut NbRoom spécifique à la classe enfant Maison:
        private int nbPieces;

        //Accesseur de l'attribut NbIeces:
        public int NbPieces { get => nbPieces; set => nbPieces = value; }

        public Maison(string Adress, int nbPieces)//constructeur classe (enfant)
            : base(Adress)//constructeur classe^parente déjà typé dans la classe parente.
        {
            NbPieces = nbPieces;
        }

        public void ToString()
        {
            Console.WriteLine($"adresse:{Adress}");
            Console.WriteLine($"nombre de pièces:{NbPieces}");
        }
    }
}
