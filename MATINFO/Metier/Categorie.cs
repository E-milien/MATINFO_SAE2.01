﻿using System;
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
            string sql = $"insert into categorie_materiel (idcategorie, nomcategorie) values (nextval('categorie_materiel_idcategorie_seq'::regclass), '{this.Nomcategorie}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM catcategorie_materielegorie WHERE idcategorie = {this.Idcategorie}";
            accesBD.GetData(sql);
        }

        public ObservableCollection<Categorie> FindAll()
        {
            ObservableCollection<Categorie> lesCategorie = new ObservableCollection<Categorie>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idcategorie, nomcategorie from categorie_materiel ;";
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
            DataAccess accesBD = new DataAccess();
            string sql = $"UPDATE categorie_materiel SET nomcategorie = '{this.Nomcategorie}' WHERE idcategorie = {this.Idcategorie}";
            DataTable datas = accesBD.GetData(sql);
        }
    }
}
