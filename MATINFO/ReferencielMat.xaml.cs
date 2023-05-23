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

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielMat : Window
    {
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielMat()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            gestionAttribution.Remove((Materiel)dgMateriel.SelectedItem);
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
