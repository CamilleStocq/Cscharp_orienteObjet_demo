using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_interface_exceptions_délégués.interfaces
{

    //defini actions et propriétés obligatoire d'une poule
    internal interface IPoule
    {
        //propriétés

        string Name { get; }

        //Méthodes
       Tuple <int, int> Avancer(int distance, Enums direction);
        
    }
}
