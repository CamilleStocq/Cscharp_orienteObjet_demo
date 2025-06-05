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
        private int _position;
        private int _solde;

        private List<CasePropriete> _proprietes;

        public int Positon
        {
            get => _position;
        }

        public int Solde
        {
            get;
            private set;
        }

        public CasePropriete[] Proprietes
        {
            get => _proprietes.ToArray();
        }

        public Joueur(string nom, Pion pion)
        {
            Nom = nom;
            Pion = pion;
            _solde = 1500;
            _position = 0;
            _proprietes = new List<CasePropriete>();
        }

        public void EtrePaye (int montant)
        {
            _solde += montant ;
        }

        public void Payer (int montant)
        {
            if (_solde >= montant)
            {
                _solde -= montant;
            }
            else
            {
                Console.WriteLine($"{Nom}, tu n'as pas assez d'agent pour payer{montant} ");
            }
        }

        public void AjouterPropriete (CasePropriete propriete)
        {
            if(propriete.Proprietaire == acheteur)
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
    }

}