using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielMat : Window
    {
        List<Materiel> listeMat = new List<Materiel>();
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Materiel mat in gestionAttribution.LesMateriel)
            {
                mat.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielMat()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Materiel m = (Materiel)dgMateriel.SelectedItem;
            m.Delete();
            gestionAttribution.Remove(m);
            dgMateriel.SelectedIndex = 0;
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Materiel materiel = new Materiel();
            materiel.IdCategorie = ((Categorie)lvCategorie.SelectedItem).Idcategorie;
            listeMat.Add(materiel);
            gestionAttribution.LesMateriel.Insert(0, materiel);
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            if (listeMat.Count > 0)
            {
                foreach (Materiel materiel in listeMat)
                {
                    materiel.Create();
                }
                listeMat = new List<Materiel>();
            }
        }
    }
}
