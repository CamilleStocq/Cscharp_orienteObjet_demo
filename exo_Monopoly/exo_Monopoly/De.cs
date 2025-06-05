             using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal static class De
    {
        private static int valeurMin = 1;
        private static int valeurMax = 6;
        public static int nbDes = 2;
        public static Random rng = new Random();

        public static int ValeurMin
        {
            get { return valeurMin; }
            set
            {
                if (value > 0) 
                {
                    valeurMin = value;
                    if (value >= valeurMax)
                        valeurMax = valeurMin - 1;
                }
            }
        }

        public static int ValeurMax
        {
            get { return valeurMax; }
            set
            {
                if (value > 0)
                {
                    valeurMax = value;
                    if (value >= valeurMin)
                        valeurMin = valeurMax + 1;
                }
            }
        }
        


        public static int[] Lancer(int nbDes)
        {
            int[] resultat = new int[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
                resultat[i] = rng.Next(valeurMin, valeurMax + 1);
            }

            return resultat;
        }

    }
}
