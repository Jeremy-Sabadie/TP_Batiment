namespace TP_Batiment
{
    internal class Batiment
    {
        //Attributs de la classe:
        private string _Adress;
        //Entier compteur d'instance:
        private int instanceCount;
        //Accesseurs des attributs:

        public int InstanceCount { get => instanceCount; set => instanceCount = value; }
        public string Adress { get => _Adress; set => _Adress = value; }

        //Constructeur1:
        public Batiment(string adress)
        {
            instanceCount += 1;

        }
        //Constructeur par défault:
        public Batiment()
        {
            instanceCount += 1;
        }
        public void ToString(Batiment batiment)
        {
            Console.WriteLine($"adresse:{batiment._Adress}");
        }



    }
}
