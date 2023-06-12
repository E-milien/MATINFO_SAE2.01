using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class Materiel : Crud<Materiel>
    {
        private Categorie laCategorie;
        private int idmateriel;
        private string codebarre;
        private string nommateriel;
        private string referencemateriel;

        public Materiel()
        {
        }

        public Materiel(int idmateriel, string codebarre, string nommateriel, string referencemateriel)
        {
            Idmateriel= idmateriel;
            Codebarre = codebarre;
            Nommateriel = nommateriel;
            Referencemateriel = referencemateriel;
        }

        public int Idmateriel { get => idmateriel; set => idmateriel = value; }
        public string Codebarre { get => codebarre; set => codebarre = value; }
        public string Nommateriel { get => nommateriel; set => nommateriel = value; }
        public string Referencemateriel { get => referencemateriel; set => referencemateriel = value; }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Materiel> FindAll()
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Materiel> FindBySelection(string criteres)
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
