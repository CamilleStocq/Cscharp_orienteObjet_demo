using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_heritage
{
    internal class Cercle : Forme
    {
		private int _rayon;

		public int Rayon
		{
			get { return _rayon; }
			set 
			{
				if (value < 0) value = -value;
				_rayon = value;
				
			}
		}

	}
}
