using System;
using exo_Monopoly.Enums;

namespace exo_Monopoly
{
    internal class CasePropriete : Case
    {
        private string _nom;
        private Couleurs _couleur;
        private int _prix;
        private bool _estHypotequee;
        private Joueur? _proprietaire;
        public string Acheteur { get; private set; }

        //public string Nom // propiété
        //{
        //    get { return _nom; } // recoit l'info
        //    private set { _nom = value; } // renvoit l'info

        //}

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
        public CasePropriete(string nom, Couleurs couleur, int prix) : base(nom) 
        {
            //Nom = nom;
            Couleur = couleur;
            Prix = prix;
            _estHypotequee = false;
            Proprietaire = null;
        }

        private void Acheter(Joueur acheteur)
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
        public override void Activer(Joueur visiteur)
        {
            if (Proprietaire is null)
            {
                if (visiteur.Solde >= Prix)
                {
                    Acheter(visiteur);
                }  
            }
            else if (Proprietaire != visiteur) 
            {
                Sejourner(visiteur);
            }
        }

        private void Sejourner(Joueur visiteur) // division entiere
        {
            if (visiteur != Proprietaire)
           {
                //le solde du joueur - 1/4 du prix de la case                
                int droitSejour= this.Prix/4  ;
                visiteur.Payer(droitSejour);
                Proprietaire.EtrePaye(droitSejour);
            }

        }

    }
}
