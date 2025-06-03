using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXO1_jeu.models
{
    internal class De
    {
        public static int valeurMin = 1;
        public static int valeurMax = 6;
        public static int nbDes = 2;

        public Random rng = new Random();

        public int[] Lancer(int nbDes)
        {
            int[] resultat = new int[nbDes];
            for (int i = 0; i < nbDes; i++)
            {
                resultat[i] = rng.Next(valeurMin);
            }
            return resultat;
        }
    }
}
