using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Personnel
    {
        private string nom;

        public Personnel(string nom)
        {
            this.Nom = nom;
        }
        public string Nom { get => nom; set => nom = value; }
    }
}
