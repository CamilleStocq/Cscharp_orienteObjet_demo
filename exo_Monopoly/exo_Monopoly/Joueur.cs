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
            if (montant > 0) // si le montant est supperieur à 0 il faut payer la somme
            {
                Solde += montant;
            }
        }

        public void AjouterPropriete(CasePropriete propriete)
        {
            if (propriete != null && propriete.Proprietaire==this) // pour voir si on peut acheter la case et qu'elle n'a pas deja un autre proprietaire
            {
                _proprietes.Add(propriete); // si elle n'appartient à personne on l'ajoute à sa collection
            }
        }

        public bool Avancer()
        {
            int[] resultatDe = De.Lancer(2); // on lance deux dés

            int somme = resultatDe[0] + resultatDe[1]; // on additionne le resultat des deux dés
            _position += somme;

            if (resultatDe[0] == resultatDe[1]) // si le dé 1 et le dé 2 on le meme chiffre on relance le dé
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
            if (Solde >= prix && prix >0) // vérifier qu'on a suffisement d'argent pour acheter 
            {
                Solde -= prix; // on enleve le prix de l'achat à notre argent total
            }
            else
            {
                Console.WriteLine($"{Nom}, tu n'as pas assez d'agent pour payer {prix}. ");
            }
        }

        public static Joueur operator + (Joueur left, int right) // surcharge d'operateur, on veut recuperer la somme et rajouter de largent au total
        {
            left.EtrePaye(right); //ca augmente deja le montant donc pas besoin de le remettre
            return left;
        }

        public static List<CasePropriete> operator + (Joueur left , CasePropriete right) // left = qui recoit, right = ce qu'on recoit
        {
            //right.Acheter(left);
            left.AjouterPropriete(right);
            return left.Proprietes;
            
        }
            
    }
}