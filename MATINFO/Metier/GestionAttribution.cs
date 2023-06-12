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
            Materiel m = new Materiel();
            Personnel p = new Personnel();
            Attribution a = new Attribution();
            LesCategorie = c.FindAll();
            LesMateriel = m.FindAll();
            LesPersonnel = p.FindAll();
            LesAttribution = a.FindAll();
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
