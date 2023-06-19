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

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielMat : Window
    {
        AjtMateriel ajouter = new AjtMateriel();

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
            ajouter.ShowDialog();
        }

        private void lvCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            dgMateriel.Items.Filter = FiltreMateriel;

        }

        public bool FiltreMateriel(object obj)
        {
            Materiel mat = (Materiel)obj;
            return lvCategorie.SelectedItems.Contains(mat.LaCategorie);
        }
    }
}
