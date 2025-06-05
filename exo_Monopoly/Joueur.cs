using exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal class Joueur
    {
        public string nom;
        public Pions pion;
        private int position = 0;

        public int positon
        {
            get => position;
        }

        public int Solde
        {
            get;
            private set;
        }

        public bool Avancer()
        {
            int[] resultatDe = De.Lancer(2);

            int somme = resultatDe[0] + resultatDe[1];
            position += somme;

            if (resultatDe[0] == resultatDe[1])
            {
                Console.WriteLine("Vous avez obtenu un double !!! Relancer le dé.");
            }
            else
            {
                Console.WriteLine($"le total du lancer est {somme}, vous pouvez donc avancer de {somme} cases. ");
            }

            return resultatDe[0] == resultatDe[1];

        }
    }

}