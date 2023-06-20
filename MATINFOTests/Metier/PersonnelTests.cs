using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Net.PeerToPeer.Collaboration;

namespace MATINFO.Tests
{
    [TestClass()]
    public class PersonnelTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            Personnel personnel1 = new Personnel("pierre@mail.fr", "Pierre", "Durant");
            personnel1.Create();
            DataAccess accesBD = new DataAccess();
            String requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            DataTable datas = accesBD.GetData(requete);
            DataRow row = datas.Rows[0];
            Personnel personnelImport = new Personnel((String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
            Assert.AreEqual(personnelImport.Idpersonnel, personnel1.Idpersonnel, "Le personnel envoyé n'a pas été envoyé a la base de données");

        }

        [TestMethod()]
        public void DeleteTest()
        {
            Personnel personnel = new Personnel("fauxMail@email.com", "PauxPrenom", "FauxNom");
            DataAccess accesBD = new DataAccess();
            String requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            DataTable datas = accesBD.GetData(requete);
            DataRow row = datas.Rows[0];
            Personnel personnelImport = new Personnel(int.Parse(row["idpersonnel"].ToString()), (String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
            personnelImport.Delete();
            requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            datas = accesBD.GetData(requete);
            if (datas != null)
            {
                row = datas.Rows[0];
                personnel = new Personnel((String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
            }
            Assert.AreNotEqual(personnel.Idpersonnel, personnelImport.Idpersonnel,"Suppression non reussi du personnelImport");
        }

        [TestMethod()]
        public void ReadTest()
        {
            Personnel personnel1 = new Personnel("pierre@mail.fr", "Pierre", "Durant");
            personnel1.Create();

            personnel1.Read();
            Personnel personnel2 = personnel1;
            Assert.AreEqual(personnel2, personnel1, "Le personnel envoyé n'a pas été envoyé a la base de données");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Personnel personnel = new Personnel("fauxMail@email.com", "PauxPrenom", "FauxNom");
            personnel.Create();
            DataAccess accesBD = new DataAccess();
            String requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            DataTable datas = accesBD.GetData(requete);
            DataRow row = datas.Rows[0];
            Personnel personnelImport = new Personnel(int.Parse(row["idpersonnel"].ToString()), "email@email.fr", "Kilian", "Mbappe");
            personnelImport.Update();
            requete = "select idpersonnel, emailpersonnel, nompersonnel, prenompersonnel from personnel ;";
            datas = accesBD.GetData(requete);
            if (datas != null)
            {
                row = datas.Rows[0];
                personnel = new Personnel(int.Parse(row["idpersonnel"].ToString()), (String)row["emailpersonnel"], (String)row["nompersonnel"], (String)row["prenompersonnel"]);
            }
            Assert.AreEqual(personnelImport.Emailpersonnel, personnel.Emailpersonnel, "Modification non envoyé");
        }
    }
}