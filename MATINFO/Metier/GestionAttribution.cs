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
        private ObservableCollection<Categorie> lesCategorie;
        private ObservableCollection<Materiel> lesMateriel;
        private ObservableCollection<Personnel> lesPersonnel;
        private ObservableCollection<Attribution> lesAttribution;
        public GestionAttribution()
        {
            LesCategorie = new ObservableCollection<Categorie>();
            LesCategorie.Add(new Categorie("Apple"));
            LesCategorie.Add(new Categorie("Windows"));
            LesMateriel = new ObservableCollection<Materiel>();
            LesMateriel.Add(new Materiel("Mac"));
            LesMateriel.Add(new Materiel("HP"));
            LesPersonnel = new ObservableCollection<Personnel>();
            LesPersonnel.Add(new Personnel("Jean"));
            LesPersonnel.Add(new Personnel("Francois"));
            LesAttribution = new ObservableCollection<Attribution>();
            LesAttribution.Add(new Attribution(new Categorie("apple"), new Materiel("mac m1"), new Personnel("Quentin"),new DateTime(2020,05,11), "sah"));
            LesAttribution.Add(new Attribution(new Categorie("windows"), new Materiel("hp"), new Personnel("hugo"), new DateTime(2019, 05, 11), "wesh"));
        }

        public ObservableCollection<Materiel> LesMateriel { get => lesMateriel; set => lesMateriel = value; }
        public ObservableCollection<Personnel> LesPersonnel { get => lesPersonnel; set => lesPersonnel = value; }
        public ObservableCollection<Attribution> LesAttribution { get => lesAttribution; set => lesAttribution = value; }
        internal ObservableCollection<Categorie> LesCategorie { get => lesCategorie; set => lesCategorie = value; }

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
