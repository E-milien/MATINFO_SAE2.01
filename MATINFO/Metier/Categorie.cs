using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Categorie : Crud<Categorie>
    {
        private int idcategorie;
        private string nomcategorie;

        public Categorie()
        {
        }

        public Categorie(string nomcategorie)
        {
            this.Nomcategorie = nomcategorie;
        }
        public Categorie(int idcategorie, string nomcategorie)
        {
            this.Idcategorie= idcategorie;
            this.Nomcategorie = nomcategorie;
        }

        public int Idcategorie { get => idcategorie; set => idcategorie = value; }
        public string Nomcategorie { get => nomcategorie; set => nomcategorie = value; }

        public void Create()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into categorie (idcategorie, nomcategorie) values (nextval('categorie_idcategorie_seq'::regclass), '{this.Nomcategorie}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Categorie> FindAll()
        {
            ObservableCollection<Categorie> lesCategorie = new ObservableCollection<Categorie>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idcategorie, nomcategorie from categorie ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Categorie e = new Categorie(int.Parse(row["idcategorie"].ToString()), (String)row["nomcategorie"]);
                    lesCategorie.Add(e);
                }
            }
            return lesCategorie;
        }

        public ObservableCollection<Categorie> FindBySelection(string criteres)
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
