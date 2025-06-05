using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exo_Monopoly.couleurs;
using exo_Monopoly.Pions;

namespace exo_Monopoly
{
    internal static class CasePropriete
    {
        private string _nom;
        private Couleurs _couleur;
        private int _prix;
        private bool _estHypotequee;
        private Joueur _proprietaire;

        public string Nom
        {
            get { return _nom; }           
        }

        public Couleurs Couleurs
        {
            get { return _couleur; }
        }

        public int Prix
        {
            get { return _prix; }
        }

        public bool EstHypotequee
        {
            get { return _estHypotequee; }
        }

        public Joueur Proprietaire
        {
            get { return _proprietaire; }
        }

        // ca c'est un constructeur, on le nomme pareil que la class et on lui donne des propriétées
        public CasePropriete(string nom, Couleurs couleur, int prix)
        {
            _nom = nom;
            _couleur = couleur;
            _prix = prix;
            _estHypotequee = false;
            _proprietaire = null;
        }

        public void Acheter
        {
            if (acheteur.Solde >= _prix)
            {
                Console.WriteLine("bravo vous etes propriétaire");
            acheteur.Solde -= _prix;
            _proprietaire = acheteur
            }
        }
    }
}