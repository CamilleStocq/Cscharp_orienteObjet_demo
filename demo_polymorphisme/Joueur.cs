using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_polymorphisme
{
    internal class Joueur
    {
        private List<InventaireItem> _inventaire;

        public InventaireItem[] InventaireItems 
        { 
            get
            {
                return _inventaire.ToArray(); // pas de set car si on en met un c'est pour dire de changer tout l'inventaire d'un coup mais n veut pas ca donc pas de set
            }
        } 
        public int Solde { get;set; }
        
        public Joueur()
        {
            Solde = 1000;
            _inventaire = new List<InventaireItem>();
        }

        public void Loot (InventaireItem objet)
        {
            _inventaire.Add(objet);
        }

        public bool JeterObjet(InventaireItem objet)
        {
           return _inventaire.Remove(objet); 
        }
         
    }
}
