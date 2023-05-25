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
    /// Logique d'interaction pour AjtAttribution.xaml
    /// </summary>
    public partial class AjtAttribution : Window
    {
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public AjtAttribution()
        {
            InitializeComponent();
            dpDate.SelectedDate = DateTime.Now;
        }

        public async void btEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            gestionAttribution.LesAttribution.Insert(0, new Attribution((Categorie)lvCat.SelectedItem,(Materiel)lvMat.SelectedItem,(Personnel)lvPer.SelectedItem,(DateTime)dpDate.DisplayDate,(string)tbCom.Text));
            await Task.Delay(1000);
            
            Hide();
        }
    }
}
