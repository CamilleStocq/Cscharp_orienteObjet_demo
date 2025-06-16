using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_abstract
{
    internal class Mesanges : Oiseaux
    {
        public Mesanges(string name) : base(name)
        {
        }

        public override void Crier()
        {
           
            Console.WriteLine("Cui! Cui!");
        }
    }
}
