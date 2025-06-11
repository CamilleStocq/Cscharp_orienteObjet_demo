using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_heritage
{
    internal class Forme
    {
        private int _borderWidth;
        public string Color { get; set; } // auto propriété pour évité variable public


        public int BorderWidth
        {
           protected get
            {
                return _borderWidth;
            }
            set
            {
                _borderWidth = (value < 0) ? -value : value; // = à ca if (value < 0) value value                                                _rayon = value;
            }
        }

        public Forme(string color, int borderWidth)
        {
            Color = color;
            BorderWidth = borderWidth;
        }
    }
}
