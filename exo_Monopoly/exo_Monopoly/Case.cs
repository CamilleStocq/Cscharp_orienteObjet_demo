using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal abstract class Case
    {
        private List<Joueur> _visiteurs;


        public int Position{  get; set; }

        public string Nom
        {
            get { return Nom; }
            private set { Nom = value; }
        }
        public Joueur[] Visiteur
        {
            get { return _visiteurs.ToArray(); }
        }
        public Case(string nom)
        {
            Nom = nom;
            _visiteurs = new List<Joueur>();
        }

        public void AjouterVisiteur (Joueur visiteur)
        {
            if (_visiteurs.Contains(visiteur)) return;  //Message d'exception
            _visiteurs.Add(visiteur);
        }

        public void RetirerVisiteur (Joueur visiteur)
        {
            if (!_visiteurs.Remove(visiteur)) return;
        }

        public abstract void Activer(Joueur visiteur);
    }
}
