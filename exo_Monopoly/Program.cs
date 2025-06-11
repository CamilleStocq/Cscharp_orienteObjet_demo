using exo_Monopoly.Enums;

namespace exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom");
            string userName = Console.ReadLine();

            Console.WriteLine($"Creation d'un joueur. Choisir un pion: ");
            string[] pionNames = Enum.GetNames<Pions>();

            foreach (string pionName in pionNames) // choix du pion
            {
                Console.WriteLine($"\t- {pionName}");
            }

            Console.WriteLine($"Quel pion choisissez vous ? ");
            string userInput = Console.ReadLine();

            Pions choice = Enum.Parse<Pions>(userInput); // associe le pion et le joueur (recoit les deux infos)

            Joueur j1 = new Joueur(userName, choice);  

            Console.WriteLine($"Le joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}."); 

            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine("Vous avez obtenu un double !!! Relancer le dé.");
            }

            Console.WriteLine($"Le joueur {j1.Nom} avec le pion {j1.Pion} se trouve à la case {j1.Position}.");

            CasePropriete[] cases =
            {
                new CasePropriete("Building", Couleurs.Rouge, 20),
                new CasePropriete("Mairie", Couleurs.BleuCiel, 17),
                new CasePropriete("Villa", Couleurs.Violet, 45),
                new CasePropriete("Parc", Couleurs.Vert, 23),
                new CasePropriete("Ecole", Couleurs.Marron, 26),
            };

            Jeu monopoly = new Jeu(cases);

            Console.WriteLine($"Votre plateau compte {monopoly.Plateau.Length} cases.");

        }
    }
}