namespace TP_Batiment
{
    //Attributs de la classe:
    internal class Batiment
    {
        private string Adress;
        //Constructeur1:
        public Batiment(string adress)
        {
            Adress = adress;
        }
        //Constructeur par défault:
        public Batiment()
        {

        }
        //Accesseur:
        public string Adress1 { get => Adress; set => Adress = value; }
    }
}
