using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_Monopoly
{
    internal class CasePropriete
    {
        private string _name;
        private string _color;
        private int _price;
        private bool _estHypotequee;
        private Joueur _proprietaire;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool estHypotequee
        {
            get { return _estHypotequee; }
            set { _estHypotequee = value; }
        }

        public Joueur Proprietaire
        {
            get { return _proprietaire; }
            set { _proprietaire = value; }
        }


        public void string Acheter
        { 
            get 
            {
                ; 
            } 
            set 
            { 
                ; 
            } 
        }
    }
}
