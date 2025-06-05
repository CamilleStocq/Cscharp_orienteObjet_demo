using exo_Monopoly.Enums;

namespace exo_Monopoly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre nom");
            string userName = Console.ReadLine();

            //Pions p = Pions.Dino;
            Console.WriteLine($"Creation d'un joueur. Choisir un pion: ");
            string[] pionNames = Enum.GetNames<Pions>();

            foreach (string pionName in pionNames)
            {
                Console.WriteLine($"\t- {pionName}");
            }

            Console.WriteLine($"Quel pion choisissez vous ? ");
            string userInput = Console.ReadLine();

            Pions choice = Enum.Parse<Pions>(userInput);

            Joueur j1 = new Joueur()
            {
                nom = userName,
                pion = choice
            };

            Console.WriteLine($"Le joueur {j1.nom} avec le pion {j1.pion} se trouve à la case {j1.position}.");

            bool isDouble = j1.Avancer();
            if (isDouble)
            {
                Console.WriteLine("Vous avez obtenu un double !!! Relancer le dé.");
            }

            Console.WriteLine($"Le joueur {j1.nom} avec le pion {j1.pion} se trouve à la case {j1.position}.");


        }
    }
}