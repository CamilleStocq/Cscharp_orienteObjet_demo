﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_proprietes
{
    internal class Personne
    {
        private string _nom;

        public string Nom
        {
            get
            {
                return _nom.Substring(0, 1).ToUpper() + _nom.Substring(1).ToLower();
            }

            set
            {
                value = value.Trim();
                if (value.Length > 2)
                {
                    _nom = value;
                }
            }
        }


        private string _prenom;
        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;

            }

        }

        public string NomComplet
        {
            get
            {
                return $"{Nom} {Prenom}";
            }
        }

        private DateOnly _dateNaissance;

        public DateOnly DateNaissance
        {
            set
            {
                _dateNaissance = value;
            }
        }

        public int Age
        {
            get
            {
                int age = DateTime.Now.Year - _dateNaissance.Year;

                if (DateTime.Now.Month < _dateNaissance.Month) age--;
                return age;
            }
        }

        public void HB()
        {
            if (DateTime.Now.Day == _dateNaissance.Day && DateTime.Now.Month == _dateNaissance.Month)
            {
                Console.WriteLine("Joyeux anniversaire !!!!");
            }
            else
            {
                Console.WriteLine("c'est pas ton anniversaire :'(");
            }
        }
    }
}
