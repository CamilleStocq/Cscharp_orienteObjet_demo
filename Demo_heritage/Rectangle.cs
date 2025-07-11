﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_heritage
{
    internal class Rectangle : Forme
    {
		private int _largeur;
		private int _longueur;

		public int Largeur
		{
			get { return _largeur; }
			set 
			{
                if ( value > _longueur)
                {
					_largeur = _longueur;
					_longueur = value;
                }
				else
				{
					_largeur = value;
				}
					_largeur = value; 
			}
		}

		public int Longueur
		{
			get { return _longueur; }
			set
			{
                if (value > _largeur)
                {
                    _longueur = _largeur;
                    _largeur = value;
                }
                else
                {
                    _longueur = value;
                }
            }
		}
        public Rectangle(string color, int borderWidth, int largeur, int longueur) : base (color, borderWidth)
        {
            Largeur = largeur;
			Longueur = longueur;
        }
    }
}
