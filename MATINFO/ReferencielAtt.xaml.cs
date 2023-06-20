using System;
using System.Collections.Generic;
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
using static System.Collections.Specialized.BitVector32;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielAtt : Window
    {
        AjtAttribution ajouter;
        public GestionAttribution gestionAttribution { get; set; }

        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach(Attribution att in gestionAttribution.LesAttribution)
            {
                att.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielAtt(GestionAttribution gestion)
        {
            InitializeComponent();
            gestionAttribution = gestion;
            DataContext = this;
            ajouter = new AjtAttribution(gestionAttribution);
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dgAttribution.SelectedIndex >= 0)
            {
                Attribution a = (Attribution)dgAttribution.SelectedItem;
                if (MessageBox.Show($"Est vous sur de supprimer l'attriution de {a.UnPersonnel.Prenompersonnel} {a.UnPersonnel.Nompersonnel} au materiel {a.UnMateriel.Nommateriel}" +
                    $"?", "Attention", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    a.Delete();
                    gestionAttribution.LesAttribution.Remove(a);
                    dgAttribution.SelectedIndex = 0;
                }
            }
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            ajouter.ShowDialog();
        }
    }
}
