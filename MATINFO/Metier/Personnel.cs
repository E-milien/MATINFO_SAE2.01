﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Personnel : Crud<Personnel>
    {
        private int idpersonnel;
        private string emailpersonnel;
        private string nompersonnel;
        private string prenompersonnel;

        public Personnel()
        {
        }

        public Personnel(string emailpersonnel, string nompersonnel, string prenompersonnel)
        {
            Emailpersonnel = emailpersonnel;
            Nompersonnel = nompersonnel;
            Prenompersonnel = prenompersonnel;
        }

        public Personnel(int idpersonnel, string emailpersonnel, string nompersonnel, string prenompersonnel)
        {
            Idpersonnel = idpersonnel;
            Emailpersonnel = emailpersonnel;
            Nompersonnel = nompersonnel;
            Prenompersonnel = prenompersonnel;
        }

        public int Idpersonnel { get => idpersonnel; set => idpersonnel = value; }
        public string Emailpersonnel { get => emailpersonnel; set => emailpersonnel = value; }
        public string Nompersonnel { get => nompersonnel; set => nompersonnel = value; }
        public string Prenompersonnel { get => prenompersonnel; set => prenompersonnel = value; }

        public void Create()
        {
            int id = 0;
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into personnel (idpersonnel, emailpersonnel, nompersonnel, prenompersonnel) values (nextval('personnel_idpersonnel_seq'::regclass), '{this.Emailpersonnel}', '{this.Nompersonnel}', '{this.Prenompersonnel}')";
            accesBD.GetData(sql);
            String requete = $"select idpersonnel from personnel where emailpersonnel = '{this.Emailpersonnel}' and nompersonnel = '{this.Nompersonnel}' and prenompersonnel = '{this.Prenompersonnel}';";
            DataTable datas = accesBD.GetData(requete);
            DataRow row = datas.Rows[0];
            this.Idpersonnel = int.Parse(row["idpersonnel"].ToString());
        }

        public void Delete()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"DELETE FROM est_attribue WHERE idpersonnel = {this.Idpersonnel}";
            accesBD.GetData(sql);
            sql = $"DELETE FROM personnel WHERE idpersonnel = {this.Idpersonnel}";
            accesBD.GetData(sql);
            
        }

        public ObservableCollection<Personnel> FindAll()
        {
            ObservableCollection<Personnel> lesPersonnel = new ObservableCollection<Personnel>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Personnel e = new Personnel(int.Parse(row["idpersonnel"].ToString()),(String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
                    lesPersonnel.Add(e);
                }
            }
            return lesPersonnel;
        }

        public ObservableCollection<Personnel> FindBySelection(string criteres)
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"select * FROM personnel WHERE idpersonnel = {this.Idpersonnel}";
            DataTable datas = accesBD.GetData(sql);
            if (datas != null)
            {
                DataRow row = datas.Rows[0];
                this.emailpersonnel = (String)row["emailpersonnel"];
                this.Nompersonnel = (String)row["nompersonnel"];
                this.Prenompersonnel=(String)row["prenompersonnel"];
            }
        }

        public void Update()
        {
            DataAccess accesBD = new DataAccess();
            string sql = $"UPDATE personnel SET emailpersonnel = '{this.Emailpersonnel}', nompersonnel = '{this.Nompersonnel}', prenompersonnel = '{this.Prenompersonnel}' WHERE idpersonnel = {this.Idpersonnel}";
            DataTable datas = accesBD.GetData(sql);
        }
    }
}
