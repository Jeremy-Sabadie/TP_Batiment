using TP_Batiment;
//BatimentB1 créé avec le construvteur par défault de la classe Batiment:
Batiment B1 = new Batiment("Adresse du B1");
//Batiment B2 créé avec leconstructeur1 de la classe Batiment:
Batiment B2 = new Batiment("32 Avenue de la Réublique");
//Affichage à laide de la méthode ToString de l'objet B1
Console.WriteLine("Bâtimentn°1:");
B1.ToString();
Console.WriteLine("Bâtimentn°2:");
B1.ToString();
//création de l'objet M1 avec le constructeur:
Maison M1 = new Maison("20 place du général de Gaulle", 4);
//Affichage de la maison M1:
Console.WriteLine("Maison n°1");
M1.ToString();
