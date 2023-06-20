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
    public partial class ReferencielPer : Window
    {
        List<Personnel> personnels = new List<Personnel>();
        public GestionAttribution gestionAttribution { get; set; }
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach (Personnel per in gestionAttribution.LesPersonnel)
            {
                per.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielPer(GestionAttribution gestion)
        {
            InitializeComponent();

            gestionAttribution = gestion;
            DataContext = this;
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dgPersonnel.SelectedIndex >= 0)
            {
                string txt = "";
                Personnel p = (Personnel)dgPersonnel.SelectedItem;
                foreach(Attribution att in gestionAttribution.LesAttribution)
                {
                    txt += att.UnMateriel.Nommateriel+ " ";
                }
                if (MessageBox.Show($"Est vous sur de supprimer {p.Prenompersonnel} {p.Nompersonnel} ? \n Cela va supprimer les attribution avec les materiel : {txt} ", "Attention", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                { 
                    p.Delete();
                    gestionAttribution.Remove(p);
                    dgPersonnel.SelectedIndex = 0;
                }
            }
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Personnel p = new Personnel("","","");
            personnels.Add(p);
            gestionAttribution.LesPersonnel.Insert(0,p);
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            if (personnels.Count > 0)
            {
                foreach (Personnel personnel in personnels)
                {
                    personnel.Create();
                }
                personnels = new List<Personnel>();
            }
            gestionAttribution.Refresh();
        }
    }
}
