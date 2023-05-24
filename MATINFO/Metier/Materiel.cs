using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Materiel
    {
        private string nom;

        public Materiel(string nom)
        {
            this.Nom = nom;
        }
        public string Nom { get => nom; set => nom = value; }
    }
}
