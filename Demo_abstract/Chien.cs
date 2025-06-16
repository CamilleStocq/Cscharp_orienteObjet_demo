using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_abstract
{
    internal class Chien : Animal
    {
        public Chien(string name) : base(name)
        {
        }

        public override void Crier()
        {
            Console.WriteLine("Wouaf !! Wouaf !!!");
        }
    }
}
