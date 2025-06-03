using EXO1_jeu.Enums;

namespace EXO1_jeu
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            //bool aFaitunDouble = pionNames.Avancer()
            //{
            //    if (aFaitunDouble)
            //    {
            //        Console.WriteLine("");
            //    }
            //    else
            //    {
            //        Console.WriteLine("");
            //    }

            //}
        }
    }
}