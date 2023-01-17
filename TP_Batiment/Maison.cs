namespace TP_Batiment
{//Classe Maison qui hérite de la classe Batiment:
    internal class Maison : Batiment
    {//Attribut NbRoom spécifique à la classe enfant Maison:
        private int nbPieces;
        public Maison(string Adress, int nbPieces)//constructeur classe (enfant)
            : base(Adress)//constructeur classe^parente déjà typé dans la classe parente.
        {

        }
        //Accesseur de l'attribut NbRoom:
        public int NbRoom1 { get => nbPieces; set => nbPieces = value; }

    }
}
