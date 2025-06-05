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
        public string Nom;
        public Pions Pion;
        private int position;
        private string _proprietes; // = List<CasePropriete>;
        private int _solde;

        public int Position 
        {
            get { return position; } 
            private set { position = value; } 
        }

        public int  Solde
        {
            get { return _solde; }

            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("ceci sera remplace par une exception lus tard");
                }
                else
                {
                    _solde = value;
                }
                    
            }
        }
  
        //pas fini faut trouver comment foutre (CasePropriete[]) en lecture seule
        public string Proprietes
        {
            get { return _proprietes; }
            set { 
                  _proprietes = value;
                }
        }
        //-----------------------------------------------------------

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