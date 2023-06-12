using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        private DateTime dateatttribut;
        private string commentaire;

        public Attribution()
        {
        }

        public Attribution(Materiel unMateriel, Personnel unPersonnel,DateTime date, string commentaire)
        {
            this.unMateriel = unMateriel;
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

        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> lesAttribution = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select dateatttribut, commentaire from attribution ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(DateTime.Parse(row["date"].ToString()), (String)row["commentaire"]);
                    lesAttribution.Add(e);
                }
            }
            return lesAttribution;
        }

        public ObservableCollection<Attribution> FindBySelection(string criteres)
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
