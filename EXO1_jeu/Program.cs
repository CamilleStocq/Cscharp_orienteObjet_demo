using System;
using EXO1_jeu.models;

namespace EXO1_jeu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int entier = random.Next();
            int entierUnChiffre = random.Next(10);
            int mois = random.Next(1, 7);

            Pions mesPions = new Pions()
            {
                pions = new List<string>(["Voitures","Cuirasse","Chien","Chapeau","Fer","Dino","DeACoudre","Brouette","Chaussure"])
            };
        }
    }
}
