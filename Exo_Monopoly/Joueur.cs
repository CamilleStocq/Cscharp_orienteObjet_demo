using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXO1_jeu.models;

namespace Exo_Monopoly
{
    internal class Joueur
    {
        public string nom;
        public string pions;
        public int position;


        public bool Avancer()
        {
            int[] resultat = De.Lancer(2);

            int somme = resultat[0] + resultat[1];
            position += somme;

            Console.WriteLine($"");
            Console.WriteLine($"");

            return resultat[0] == resultat[1];

        }
    }

}
