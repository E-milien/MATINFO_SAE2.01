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
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielPer()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Personnel p = (Personnel)dgPersonnel.SelectedItem;
            p.Delete();
            gestionAttribution.Remove(p);
            dgPersonnel.SelectedIndex= 0;
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            Personnel p = new Personnel("","","");
            personnels.Add(p);
            gestionAttribution.LesPersonnel.Insert(0,p);
        }

        private void btOK_Click(object sender, RoutedEventArgs e)
        {
            foreach(Personnel personnel in personnels) 
            {
                personnel.Create();
            }
            personnels = new List<Personnel>();
        }
    }
}
