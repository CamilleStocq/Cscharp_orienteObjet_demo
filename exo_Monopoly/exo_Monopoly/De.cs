using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal static class De
    {
        private static int _valeurMin = 1; // _ pour le nom des private, Maj pour les publics
        private static int _valeurMax = 6;
        public static int nbDes = 2;
        public static Random rng = new Random();

        public static int ValeurMin // valeur min du dé
        {
            get { return _valeurMin; }
            set
            {
                if (value > 0) 
                {
                    _valeurMin = value;
                    if (value >= ValeurMax)
                        ValeurMax = _valeurMin + 1;
                }
            }
        }

        public static int ValeurMax // valeur max du dé 
        {
            get { return _valeurMax; }
            set
            {
                if (value > 1)
                {
                    _valeurMax = value;
                    if (value >= ValeurMin)
                        ValeurMin = _valeurMax - 1;
                }
            }
        }
        
        public static int[] Lancer(int nbDes)
        {
            int[] resultat = new int[nbDes];

            for (int i = 0; i < nbDes; i++)
            {
                resultat[i] = rng.Next(_valeurMin, ValeurMax + 1);
            }

            return resultat;
        }

    }
}
