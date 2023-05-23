using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    internal class Categorie
    {
        private string nom;

        public Categorie(string nom)
        {
            this.nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }
    }
}
