using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace MATINFO
{
    public class Categorie
    {
        private string nom;

        public Categorie(string nom)
        {
            this.Nom = nom;
        }

        public string Nom { get => nom; set => nom = value; }

    }
}
