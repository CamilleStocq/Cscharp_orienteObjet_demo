using exo_Monopoly.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal class Jeu
    {
        private List<Joueur> _joueurs;
        private List<CasePropriete> _plateau;

        public List<Joueur> Joueurs
        {
            get { return _joueurs; }
            private set { _joueurs = value; }
        }

        public List<CasePropriete> Plateau
        { 
            get { return _plateau; } 
            private set { _plateau = value; }
        }

        public void AjouterJoueur (string nom, Pions pion)
        {
            //if ()
        }
    }
}
