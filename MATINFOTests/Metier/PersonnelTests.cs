using Microsoft.VisualStudio.TestTools.UnitTesting;
using MATINFO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;

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
            Assert.AreEqual(personnelImport, personnel1, "Le personnel envoyé n'a pas été envoyé a la base de données");

        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ReadTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateTest()
        {
            Assert.Fail();
        }
    }
}