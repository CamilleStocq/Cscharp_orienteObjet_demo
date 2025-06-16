using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_Virtual_Override
{
    internal class Walking : Animal
    {
        public Walking(string name) : base(name)
        {
        }

        public override void SeDeplacer()
        {
            Console.WriteLine("En mettant une patte devant l'autre, ");
            base.SeDeplacer();
        }
    }
}
