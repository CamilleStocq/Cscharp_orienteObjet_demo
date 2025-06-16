using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_abstract
{
    internal class Pigeons : Oiseaux
    {
        public Pigeons(string name) : base(name)
        {
        }

        public override void Crier()
        {
            Console.WriteLine("Rouu! Rouu!");
        }
    }
}
