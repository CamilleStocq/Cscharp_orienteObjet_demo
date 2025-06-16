using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Virtual_Override
{
    internal class Swimming : Animal
    {
        public Swimming(string name) : base(name)
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("En agitant ses nageoires, ");
            base.SeDeplacer();
        }
    }
}
