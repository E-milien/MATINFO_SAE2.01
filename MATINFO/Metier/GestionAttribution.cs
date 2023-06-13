using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MATINFO
{
    public class GestionAttribution
    {
        public ObservableCollection<Categorie> LesCategorie { get; set; }
        public ObservableCollection<Materiel> LesMateriel { get; set; }
        public ObservableCollection<Personnel> LesPersonnel { get; set; }
        public ObservableCollection<Attribution> LesAttribution { get; set; }
        public GestionAttribution()
        {
            Categorie c = new Categorie();
            LesCategorie = c.FindAll();
            Materiel m = new Materiel();
            LesMateriel = m.FindAll();
            Personnel p = new Personnel();
            LesPersonnel = p.FindAll();
            Attribution a = new Attribution();
            LesAttribution = a.FindAll();
        }
        public void Maj()
        {

        }

        public Materiel SearchMat(int idMat)
        {
            foreach(Materiel mat in LesMateriel)
            {
                if(mat.Idmateriel==idMat)
                    return mat;
            }
            throw new Exception();
        }

        public Personnel SearchPer(int idPer)
        {
            foreach (Personnel per in LesPersonnel)
            {
                if (per.Idpersonnel == idPer)
                    return per;
            }
            throw new Exception();
        }

        public Categorie SearchCat(int idCat)
        {
            foreach (Categorie cat in LesCategorie)
            {
                if (cat.Idcategorie == idCat)
                    return cat;
            }
            throw new Exception();
        }


        public void Remove(Categorie categorie)
        {
            LesCategorie.Remove(categorie);
        }
        public void Remove(Materiel materiel)
        {
            LesMateriel.Remove(materiel);
        }
        public void Remove(Personnel personnel)
        {
            LesPersonnel.Remove(personnel);
        }

        public void Remove(Attribution attribution)
        {
            LesAttribution.Remove(attribution);
        }
    }
}
