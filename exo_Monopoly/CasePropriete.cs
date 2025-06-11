using System;
using exo_Monopoly.Enums;

namespace exo_Monopoly
{
    internal class CasePropriete
    {
        private string _nom;
        private Couleurs _couleur;
        private int _prix;
        private bool _estHypotequee;
        private Joueur? _proprietaire;
        public string Acheteur { get; private set; }

        public string Nom // propiété
        {
            get { return _nom; } // recoit l'info
            private set { _nom = value; } // renvoit l'info

        }

        public Couleurs Couleur
        {
            get { return _couleur; }
            private set { _couleur = value; }
        }

        public int Prix
        {
            get { return _prix; }
            private set {if (value > 0) _prix = value; }
        }

        public bool EstHypotequee
        {
            get { return _estHypotequee; }
        }

        public Joueur? Proprietaire
        {
            get { return _proprietaire; }
            private set { _proprietaire = value; }
        }


        // ca c'est un constructeur, on le nomme pareil que la class et on lui donne des propriétées
        public CasePropriete(string nom, Couleurs couleur, int prix)
        {
            Nom = nom;
            Couleur = couleur;
            Prix = prix;
            _estHypotequee = false;
            Proprietaire = null;
        }

        public void Acheter(Joueur acheteur)
        {
            if (acheteur.Solde >= Prix && Proprietaire == null)
            {
                int SoldeFinal = acheteur.Solde - Prix; // calcul du solde du joueur apres achat
                acheteur.Payer(Prix);

                if (SoldeFinal == acheteur.Solde) // le joueur est proprietaire
                {
                    Proprietaire = acheteur;
                    Console.WriteLine("bravo vous etes propriétaire");
                }
            }
        }
    }
}
