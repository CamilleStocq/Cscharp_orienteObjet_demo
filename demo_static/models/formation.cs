using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_static.models
{
    internal class formation
    {
        public static string centre;
        public string nom;

        public List<string> eleves;

        public void Decrire()
        {
            Console.WriteLine($"La formation est dénommé {nom}, et voici les eleves : ");
            foreach (string eleve in eleves)
            {
                Console.WriteLine($"\t - {eleve}");
            }

        }

        public void Description()
        {
            Console.WriteLine($"Regroupe l'ensemble des formations de {centre}");
        }
    }

}
