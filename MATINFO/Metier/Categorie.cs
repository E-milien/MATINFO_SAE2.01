using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public Categorie(int idcategorie, string nomcategorie)
        {
            this.Idcategorie = idcategorie;
            this.Nomcategorie = nomcategorie;
        }

        public int Idcategorie { get => idcategorie; set => idcategorie = value; }
        public string Nomcategorie { get => nomcategorie; set => nomcategorie = value; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Categorie> FindAll()
        {
            throw new NotImplementedException();
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
