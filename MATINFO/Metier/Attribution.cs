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
        private DateTime dateAtttribut;
        private string commentaire;

        public Attribution()
        {
        }

        public Attribution(DateTime dateAtttribut, string commentaire)
        {
            Commentaire = commentaire;
            DateAtttribut = dateAtttribut;
        }

        public Attribution(int idMateriel, int idPersonnel, DateTime dateAtttribut, string commentaire)
        {
            this.IdMateriel = idMateriel;
            this.IdPersonnel = idPersonnel;
            this.DateAtttribut = dateAtttribut;
            this.Commentaire = commentaire;
        }

        public Attribution(Materiel unMateriel, Personnel unPersonnel,DateTime dateAtttribut, string commentaire)
        {
            this.unMateriel = unMateriel;
            this.UnPersonnel = unPersonnel;
            this.DateAtttribut = dateAtttribut;
            this.Commentaire = commentaire;
        }

        public Materiel UnMateriel { get => unMateriel; set => unMateriel = value; }
        public Personnel UnPersonnel { get => unPersonnel; set => unPersonnel = value; }
        public string Commentaire { get => commentaire; set => commentaire = value; }
        public DateTime DateAtttribut { get => dateAtttribut; set => dateAtttribut = value; }
        public int IdMateriel { get => idMateriel; set => idMateriel = value; }
        public int IdPersonnel { get => idPersonnel; set => idPersonnel = value; }

        public void Create()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into attributions (idenseignant, dateatttribut, idmateriel, commentaire) values ('{this.IdPersonnel}', '{this.DateAtttribut.Date.ToString()}', '{this.IdMateriel}, '{this.Commentaire}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM attributions WHERE idenseignant = {this.idPersonnel} AND dateatttribut = {this.DateAtttribut.Date.ToString()} AND idmateriel = {this.IdMateriel}" ;
            accesBD.GetData(sql);
        }

        public ObservableCollection<Attribution> FindAll()
        {
            ObservableCollection<Attribution> lesAttribution = new ObservableCollection<Attribution>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idmateriel, idenseignant, dateatttribut, commentaire from attributions ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Attribution e = new Attribution(int.Parse(row["idmateriel"].ToString()), int.Parse(row["idenseignant"].ToString()), DateTime.Parse(row["dateatttribut"].ToString()), (String)row["commentaire"]);
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
