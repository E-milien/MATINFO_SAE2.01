using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MATINFO
{
    public class Attribution : Crud<Attribution>
    {
        private Materiel unMateriel;
        private Personnel unPersonnel;
        private DateTime date;
        private string commentaire;

        public Attribution(Materiel unMateriel, Personnel unPersonnel,DateTime date, string commentaire)
        {
            this.UnPersonnel = unPersonnel;
            this.Date = date;
            this.Commentaire = commentaire;

        }

        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
        public Personnel UnPersonnel { get => unPersonnel; set => unPersonnel = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public DateTime Date { get => date; set => date = value; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
