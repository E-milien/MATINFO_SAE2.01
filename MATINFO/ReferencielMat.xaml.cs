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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using static System.Collections.Specialized.BitVector32;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielMat : Window
    {
        AjtMateriel ajouter;
        public GestionAttribution gestionAttribution { get; set; }

        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Materiel mat in gestionAttribution.LesMateriel)
            {
                mat.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielMat(GestionAttribution gestion)
        {
            InitializeComponent();
            dgMateriel.ItemsSource = null;
            gestionAttribution = gestion;
            DataContext = this;
            ajouter = new AjtMateriel(gestionAttribution);
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dgMateriel.SelectedIndex>=0)
            {
                string txt = "";
                Materiel m = (Materiel)dgMateriel.SelectedItem;
                foreach(Attribution att in gestionAttribution.LesAttribution)
                {
                    txt += att.UnPersonnel.Nompersonnel + " ";
                }
                    if (MessageBox.Show($"Est vous sur de supprimer {m.Nommateriel} ? \n Cela va supprimer les attribution lier avec ces personne: {txt}", "Attention", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    m.Delete();
                    gestionAttribution.Remove(m);
                    dgMateriel.SelectedIndex = 0;
                }
            }
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            ajouter.ShowDialog();
        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvCategorie.SelectedItems == null)
                dgMateriel.ItemsSource = null;
            else
            {
                dgMateriel.ItemsSource = gestionAttribution.LesMateriel;
                dgMateriel.Items.Filter = FiltreMateriel;
            }
        }

        public bool FiltreMateriel(object obj)
        {
            Materiel mat = (Materiel)obj;
            return lvCategorie.SelectedItems.Contains(mat.LaCategorie);
        }
    }
}
