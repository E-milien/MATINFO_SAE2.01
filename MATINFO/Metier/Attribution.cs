using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MATINFO
{
    public class Attribution
    {
        private Categorie uneCategorie;
        private Materiel unMateriel;
        private Personnel unPersonnel;
        private DateTime date;
        private string commentaire;

        public Attribution(Categorie uneCategorie, Materiel unMateriel, Personnel unPersonnel,DateTime date, string commentaire)
        {
            this.UneCategorie = uneCategorie;
            this.UnMateriel = unMateriel;
            this.UnPersonnel = unPersonnel;
            this.Date = date;
            this.Commentaire = commentaire;
            
        }

        public Categorie UneCategorie { get => uneCategorie; set => uneCategorie = value; }
        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
        public Personnel UnPersonnel { get => unPersonnel; set => unPersonnel = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
