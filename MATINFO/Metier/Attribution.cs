﻿using System;
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
            string sql = $"insert into est_attribue (idpersonnel, idmateriel, dateattribution, commentaireattribution) values ('{this.IdPersonnel}', '{this.IdMateriel}, '{this.DateAtttribut.Date.ToString()}', '{this.Commentaire}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM est_attribue WHERE idpersonnel = {this.idPersonnel} AND dateattribution = {this.DateAtttribut.Date.ToString()} AND idmateriel = {this.IdMateriel}" ;
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
                    Attribution e = new Attribution(int.Parse(row["idmateriel"].ToString()), int.Parse(row["idenseignant"].ToString()), DateTime.Parse(row["dateattribution"].ToString()), (String)row["commentaireattribution"]);
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
            string sql = $"UPDATE est_attribue SET dateattribution = '{this.DateAtttribut.ToString("yyyy-MM-dd")}', dateattribution = '{this.Commentaire}' WHERE idmateriel = {this.IdMateriel} AND idpersonnel = {this.IdPersonnel}";
            DataTable datas = accesBD.GetData(sql);
        }
    }
}
