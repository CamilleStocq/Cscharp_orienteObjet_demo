using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Virtual_Override
{
    internal class Animal
    {
        public string Name { get; private set; }

        public Animal (string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"notre animal se nomme {Name}";
        }

        public virtual void SeDeplacer()
        {
            Console.WriteLine($"{Name} se déplace.");
        }
    }
}
