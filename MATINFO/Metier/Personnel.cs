using System;
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
            DataAccess accesBD = new DataAccess();
            string sql = $"insert into enseignant (idenseignant, email, nomenseignant, prenomenseignant) values (nextval('enseignant_idenseignant_seq'::regclass), '{this.Emailpersonnel}', '{this.Nompersonnel}', '{this.Prenompersonnel}')";
            DataTable datas = accesBD.GetData(sql);
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Personnel> FindAll()
        {
            ObservableCollection<Personnel> lesPersonnel = new ObservableCollection<Personnel>();
            DataAccess accesBD = new DataAccess();
            String requete = "select idenseignant, email, nomenseignant, prenomenseignant from enseignant ;";
            DataTable datas = accesBD.GetData(requete);
            if (datas != null)
            {
                foreach (DataRow row in datas.Rows)
                {
                    Personnel e = new Personnel(int.Parse(row["idenseignant"].ToString()),(String)row["email"], (String)row["nomenseignant"], (String)row["prenomenseignant"]);
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
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
