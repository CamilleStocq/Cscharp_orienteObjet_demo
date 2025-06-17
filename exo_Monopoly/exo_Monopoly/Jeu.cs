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

        

        public Joueur[] Joueurs
        {
            get {return _joueurs.ToArray();} // .ToArray permet de transformer une liste en tableau
        }

        public Case[] Plateau
        { 
            get{return _plateau.ToArray();}
        }

        public Case this[int numeroCase]
        { 
            get 
            {
                numeroCase %= _plateau.Count; // pour empecher de depasser le nombre de cases disponible sur la plateau et recommencer au debut (pour faire une boucle, comme dans le vrai jeu
                return _plateau[numeroCase]; 
            }   
        }

        public Joueur? this[Pions pion] // ? pour dire qu'il y a une possibilité de nullable 
        {
            //verifie quel pion est associé à quel joueur
            get
            {
                foreach (Joueur j in _joueurs)
                {
                    if (j.Pion == pion) return j;
                }
                return null;
                        
            }
        }
        public Jeu(Case[] casePlateau) // constructeur pour definir l'ensemble des cases du plateau
        {
            //_plateau = new List<Case>(casePlateau);
            _joueurs = new List<Joueur>();
        }

        public void AjouterJoueur (string nom, Pions pion)
        {
            foreach (Joueur j in _joueurs)
            {
                if (j.Pion == pion)
                {
                    Console.WriteLine($"Le pion {pion} est deja prit.");
                    return;
                }
            }
            _joueurs.Add(new Joueur(nom, pion));
        }

    }
}
