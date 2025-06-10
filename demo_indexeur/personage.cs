using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_indexeur
{
    internal class personage
    {
        public string Nom
        {
            get; set;
        }

        public int Taille
        {
            get; set;
        }

        private Dictionary<string, Equipement> _equipements;

        public Equipement this[string key]
        { 
             get
            {
                if (_equipements.ContainsKey(key)) return _equipements[key];
                else return null;
            }

            set
            {
                if (_equipements is null) _equipements = new Dictionary<string, Equipement>();
                _equipements[key] = value;
            }
        }
    }
}
