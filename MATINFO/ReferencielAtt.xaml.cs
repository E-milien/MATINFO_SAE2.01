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
    public partial class ReferencielAtt : Window
    {
        AjtAttribution ajouter = new AjtAttribution();


        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielAtt()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            gestionAttribution.LesAttribution.Remove((Attribution)dgAttribution.SelectedItem);
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            ajouter.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dgAttribution.UpdateLayout();
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
