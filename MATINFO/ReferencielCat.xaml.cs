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
    public partial class ReferencielCat : Window
    {
        List<Categorie> listeCategorie = new List<Categorie>();
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach(Categorie cat in gestionAttribution.LesCategorie)
            {
                cat.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielCat()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Categorie c = (Categorie)dgCategorie.SelectedItem;
            c.Delete();
            gestionAttribution.Remove(c);
            dgCategorie.SelectedIndex= 0;
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Categorie categorie = new Categorie("");
            listeCategorie.Add(categorie);
            gestionAttribution.LesCategorie.Insert(0, categorie);

        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            if (listeCategorie.Count >= 0)
            {
                foreach (Categorie cat in listeCategorie)
                {
                    cat.Create();
                }
                listeCategorie = new List<Categorie>();
            }
            gestionAttribution.Refresh();
        }
    }
}
