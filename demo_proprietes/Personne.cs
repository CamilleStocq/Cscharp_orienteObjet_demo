using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_proprietes
{
    internal class Personne
    {
        private string _nom;

        public string Nom
        {
            get {
                return _nom.Substring(0, 1).ToUpper() + _nom.Substring(1).ToLower();
            }

            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _nom = value;
                }
            }
        }


        private string _prenom;
        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;

            }

        }
    }
}
