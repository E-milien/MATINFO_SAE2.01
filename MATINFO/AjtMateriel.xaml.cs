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
    /// Logique d'interaction pour AjtMateriel.xaml
    /// </summary>
    public partial class AjtMateriel : Window
    {
        public GestionAttribution gestionAttribution { get; set; }
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public AjtMateriel(GestionAttribution gestion)
        {
            InitializeComponent();
            gestionAttribution = gestion;
            DataContext = this;
            tbRefe.Text = "";
            tbCB.Text = "";
            tbNom.Text = "";
        }

        public async void btEnregistrer_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(tbCB.Text) || String.IsNullOrEmpty(tbNom.Text) || String.IsNullOrEmpty(tbRefe.Text))
            {
                MessageBox.Show("Les Nom ou le code barre ou la référence du matériel est vide ou non vallable","Attention",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                Materiel m = new Materiel(gestionAttribution.SearchCat((Categorie)lvCat.SelectedItem), tbCB.Text, tbNom.Text, tbRefe.Text);
                m.LaCategorie = (Categorie)lvCat.SelectedItem;
                m.Create();
                gestionAttribution.LesMateriel.Insert(0, m);
            }
            await Task.Delay(1000);
            gestionAttribution.Refresh();
            Hide();
        }
    }
}
