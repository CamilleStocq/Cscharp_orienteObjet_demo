using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_abstract
{
    internal abstract class Animal
    {
        public string Name { get; private set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Crier();
        
    }
}
