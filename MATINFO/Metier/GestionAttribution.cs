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
        public GestionAttribution()
        {
            LesCategorie = new ObservableCollection<Categorie>();
            LesMateriel = new ObservableCollection<Materiel>();
            LesMateriel.Add(new Materiel("Mac"));
            LesMateriel.Add(new Materiel("HP"));
            LesPersonnel = new ObservableCollection<Personnel>();
        }

        public ObservableCollection<Materiel> LesMateriel { get => lesMateriel; set => lesMateriel = value; }
        public ObservableCollection<Personnel> LesPersonnel { get => lesPersonnel; set => lesPersonnel = value; }
        internal ObservableCollection<Categorie> LesCategorie { get => lesCategorie; set => lesCategorie = value; }
    }
}
