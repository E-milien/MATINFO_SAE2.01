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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Referenciel materiel = new Referenciel();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void btCategorie_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btMat_Click(object sender, RoutedEventArgs e)
        {
            materiel.txTitre.Text = "Materiels";
            materiel.ShowDialog();
        }

        private void btPersonnel_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btAttribution_Click(object sender, RoutedEventArgs e)
        {
        }

        
    }
}
