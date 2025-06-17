using demo_interface_exceptions_délégués.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_interface_exceptions_délégués.Models
{
    public class Poule : IPoule
    {
        private Tuple<int, int> _emplacement;
        private readonly string _name;
       public string Name 
        {
            get
            {
                return _name;
            }
        }

        public Poule (string nomDeLaPoule)
        {
            _name = nomDeLaPoule;
            _emplacement = new Tuple<int, int> (0, 0 );
        }

        public Tuple <int,int> Avancer(int distance, Enums direction)
        {
            switch (direction) 
            {
                case Enums.Avant:
                    _emplacement.x += 

                case Enums.Arriere:
                    break;

                case Enums.Avant:
                    break;

                case Enums.Arriere:

            }
        
        }
    }
}
