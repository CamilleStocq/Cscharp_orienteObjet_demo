namespace demo_indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //création du personnage en faisant reference à la class personage
            personage MatouCar = new personage()
            {
                Nom = "MatouCar",
                Taille = 12
            };

            // ajout de l'equipement
            Equipement CrocketDistrib = new Equipement()
            {
                Nom = "Krokettor",
                Couleur= "Rose",
                Puissance = 2
            };

            Equipement Santiac = new Equipement()
            {
                Nom = "Bottes enchantées",
                Couleur = "Violet",
                Puissance = 6
            };

            Equipement Fleuret = new Equipement()
            {
                Nom = "ExCatlibur",
                Couleur = "Or",
                Puissance = 30
            };

            // on associe ensuite l'équipement à notre perso
            //version classique
            //if (MatouCar.Equipements is null) MatouCar.Equipements = new List<Equipement>();

            //MatouCar.Equipements.Add( CrocketDistrib );
            //MatouCar.Equipements.Add ( Santiac );
            //MatouCar.Equipements.Add(Fleuret );

            ////affichage dans la console
            //Console.WriteLine($"Mon personnage {MatouCar.Nom} possède :");
            //foreach(Equipement item in MatouCar.Equipements)
            //{
            //    Console.WriteLine($"Equipement : {item.Nom} - Couleur : {item.Couleur} - Puissance {item.Puissance}");
            //}

            //avec indexeur
            MatouCar["Crocket Distributor"] = CrocketDistrib;
            MatouCar["Santiac"] = Santiac;
            MatouCar["ExCatlibur"] = Fleuret;

            MatouCar["Santiac"].Couleur = "Violet";

        }
    }
}
