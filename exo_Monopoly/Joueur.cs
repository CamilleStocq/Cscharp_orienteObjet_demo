using exo_Monopoly.Enums;
using exo_Monopoly;
using System;
using System.Reflection.Metadata;

namespace exo_Monopoly
{
    internal class Joueur
    {
        public string Nom;
        public Pions Pion;
        private int _position;
        private int _solde;

        private List<CasePropriete> _proprietes = new();

        public int Position
        {
            get { return _position; }
            set  { _position = value; }
        }

        public int Solde
        {
            get { return _solde; }
            private set { _solde = value; }
        }

        public List<CasePropriete> Proprietes
        {
            get { return _proprietes; } 
            set { _proprietes = value; }
        }

        public Joueur(string nom, Pions pion)
        {
            Nom = nom;
            Pion = pion;
            Solde = 1500;
            Position = 0;
            Proprietes = new List<CasePropriete>();
        }

        public void EtrePaye(int montant)
        {
            if (montant > 0)
            {
                Solde += montant;
            }
        }

        public void AjouterPropriete(CasePropriete propriete)
        {
            if (propriete != null && propriete.Proprietaire==this)
            {
                _proprietes.Add(propriete);
            }
        }

        public bool Avancer()
        {
            int[] resultatDe = De.Lancer(2);

            int somme = resultatDe[0] + resultatDe[1];
            _position += somme;

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

        public void Payer(int prix)
        {
            if (Solde >= prix && prix >0)
            {
                Solde -= prix;
            }
            else
            {
                Console.WriteLine($"{Nom}, tu n'as pas assez d'agent pour payer {prix}. ");
            }
        }
    }
}