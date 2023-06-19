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
        private int idMateriel;
        private int idPersonnel;
        private Materiel unMateriel;
        private Personnel unPersonnel;
        private DateTime dateAttribut;
        private string commentaire;

        public Attribution()
        {
        }

        public Attribution(DateTime dateAttribut, string commentaire)
        {
            Commentaire = commentaire;
            DateAttribut = dateAttribut;
        }

        public Attribution(int idMateriel, int idPersonnel, DateTime dateAttribut, string commentaire)
        {
            this.IdMateriel = idMateriel;
            this.IdPersonnel = idPersonnel;
            this.DateAttribut = dateAttribut;
            this.Commentaire = commentaire;
        }

        public Attribution(Materiel unMateriel, Personnel unPersonnel,DateTime dateAttribut, string commentaire)
        {
            this.unMateriel = unMateriel;
            this.UnPersonnel = unPersonnel;
            this.DateAttribut = dateAttribut;
            this.Commentaire = commentaire;
        }

        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
        public Personnel UnPersonnel { get => unPersonnel; set => unPersonnel = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public DateTime DateAttribut { get => dateAttribut; set => dateAttribut = value; }
        public int IdMateriel { get => idMateriel; set => idMateriel = value; }
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }

        public void Create()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into est_attribue (idpersonnel, idmateriel, dateattribution, commentaireattribution) values ({this.IdPersonnel}, {this.IdMateriel}, '{this.DateAttribut.ToString("yyyy-MM-dd")}', '{this.Commentaire}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM est_attribue WHERE idpersonnel = {this.idPersonnel} AND idmateriel = {this.IdMateriel} AND dateattribution = '{this.DateAttribut.ToString("yyyy-MM-dd")}'";
            accesBD.GetData(sql);
        }

        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> lesAttribution = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idpersonnel, idmateriel, dateattribution, commentaireattribution from est_attribue ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(int.Parse(row["idmateriel"].ToString()), int.Parse(row["idpersonnel"].ToString()), DateTime.Parse(row["dateattribution"].ToString()), (String)row["commentaireattribution"]);
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
            DataAccess accesBD = new DataAccess();
            string sql = $"UPDATE est_attribue SET dateattribution = '{this.DateAttribut.ToString("yyyy-MM-dd")}', commentaireattribution = '{this.Commentaire}' WHERE idmateriel = {this.IdMateriel} AND idpersonnel = {this.IdPersonnel}";
            DataTable datas = accesBD.GetData(sql);
        }
    }
}
