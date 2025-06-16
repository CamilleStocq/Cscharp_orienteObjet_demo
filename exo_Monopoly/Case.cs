using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal class Case
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
            get { return Visiteur.ToArray(); }
        }

        public void AjouterVisiteur (Joueur visiteur)
        {
            foreach (Joueur j in Visiteur)
            {
                if (visiteur.Position == this.Position)
                {
                    _visiteurs.Add(visiteur);
                }
            }
            return;
        }

        public void RetirerVisiteur (Joueur visiteur)
        {
            foreach (Joueur j in Visiteur)
            {
                if (visiteur.Position == this.Position)
                {
                    _visiteurs.Remove(visiteur);
                }
            }
            return;
        }

    }
}
