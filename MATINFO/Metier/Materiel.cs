using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Materiel : Crud<Materiel>
    {
        private int idCategorie;
        private Categorie laCategorie;
        private int idmateriel;
        private string codebarre;
        private string nommateriel;
        private string referencemateriel;

        public Materiel()
        {
        }

        public Materiel(string codebarre, string nommateriel, string referencemateriel)
        {
            Codebarre = codebarre;
            Nommateriel = nommateriel;
            Referencemateriel = referencemateriel;
        }

        public Materiel(int idCategorie, int idmateriel,string codebarre, string nommateriel, string referencemateriel)
        {

            IdCategorie = idCategorie;
            Idmateriel = idmateriel;
            Codebarre = codebarre;
            Nommateriel = nommateriel;
            Referencemateriel = referencemateriel;
        }

        public Materiel(int idCategorie, string codebarre, string nommateriel, string referencemateriel)
        {
            IdCategorie = idCategorie;
            Codebarre = codebarre;
            Nommateriel = nommateriel;
            Referencemateriel = referencemateriel;
        }
        public Materiel(Categorie laCategorie, string codebarre, string nommateriel, string referencemateriel)
        {
            LaCategorie = laCategorie;
            Codebarre = codebarre;
            Nommateriel = nommateriel;
            Referencemateriel = referencemateriel;
        }

        public int Idmateriel { get => idmateriel; set => idmateriel = value; }
        public string Codebarre { get => codebarre; set => codebarre = value; }
        public string Nommateriel { get => nommateriel; set => nommateriel = value; }
        public string Referencemateriel { get => referencemateriel; set => referencemateriel = value; }
        public int IdCategorie { get => idCategorie; set => idCategorie = value; }
        public Categorie LaCategorie { get => laCategorie; set => laCategorie = value; }

        public void Create()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into materiel (idmateriel, idcategorie, nommateriel, referenceconstructeurmateriel, codebarreinventaire) values (nextval('materiel_idmateriel_seq'::regclass), {this.idCategorie}, '{this.Nommateriel}', '{this.Referencemateriel}', '{this.Codebarre}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM est_attribue WHERE idmateriel = {this.Idmateriel}";
            accesBD.GetData(sql);
            sql = $"DELETE FROM materiel WHERE idmateriel = {this.Idmateriel}";
            accesBD.GetData(sql);
            
        }

        public ObservableCollection<Materiel> FindAll()
        {
            ObservableCollection<Materiel> lesMateriel = new ObservableCollection<Materiel>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idmateriel, idcategorie, nommateriel, referenceconstructeurmateriel, codebarreinventaire from materiel ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Materiel e = new Materiel(int.Parse(row["idcategorie"].ToString()), int.Parse(row["idmateriel"].ToString()), (String)row["codebarreinventaire"], (String)row["nommateriel"], (String)row["referenceconstructeurmateriel"]);
                    lesMateriel.Add(e);
                }
            }
            return lesMateriel;
        }

        public ObservableCollection<Personnel> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"select * FROM materiel WHERE idmateriel = {this.Idmateriel}";
            DataTable datas = accesBD.GetData(sql);
            if (datas != null)
            {
                DataRow row = datas.Rows[0];
                this.IdCategorie = int.Parse(row["idcategorie"].ToString());
                this.Codebarre = (String)row["codebarreinventaire"];
                this.Nommateriel = (String)row["nommateriel"];
                this.Referencemateriel = (String)row["referenceconstructeurmateriel"];
            }
        }

        public void Update()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"UPDATE materiel SET referenceconstructeurmateriel = '{this.Referencemateriel}', nommateriel = '{this.Nommateriel}', codebarreinventaire = '{this.Codebarre}' WHERE idmateriel = {this.Idmateriel}";
            DataTable datas = accesBD.GetData(sql);
        }

        ObservableCollection<Materiel> Crud<Materiel>.FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }
    }
}
