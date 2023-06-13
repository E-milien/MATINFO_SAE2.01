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
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MATINFO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ReferencielMat materiel = new ReferencielMat();
        ReferencielCat categorie = new ReferencielCat();
        ReferencielPer personnel = new ReferencielPer();
        ReferencielAtt attribution = new ReferencielAtt();
        Connexion login = new Connexion();

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        public MainWindow()
        {
            login.ShowDialog();
            InitializeComponent();
            Maj();
        }


        private void btCategorie_Click(object sender, RoutedEventArgs e)
        {
            categorie.ShowDialog();
        }

        private void btMat_Click(object sender, RoutedEventArgs e)
        {
            materiel.ShowDialog();
        }

        private void btPersonnel_Click(object sender, RoutedEventArgs e)
        {
            personnel.ShowDialog();
        }

        private void btAttribution_Click(object sender, RoutedEventArgs e)
        {
            attribution.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lvAttribution.UpdateLayout();
        }

        public void Maj()
        {
            ObservableCollection<Materiel> materiels= new ObservableCollection<Materiel>();
            ObservableCollection<Attribution> attributions = new ObservableCollection<Attribution>();
            foreach(Materiel tmpMat in gestionAttribution.LesMateriel)
            {
                materiels.Add(new Materiel((Categorie)gestionAttribution.SearchCat(tmpMat.IdCategorie), tmpMat.Idmateriel, tmpMat.Codebarre, tmpMat.Nommateriel,tmpMat.Referencemateriel));
            }
            gestionAttribution.LesMateriel = materiels;
            foreach (Attribution tmpAtt in gestionAttribution.LesAttribution)
            {
                attributions.Add(new Attribution((Materiel)gestionAttribution.SearchMat(tmpAtt.IdMateriel),(Personnel)gestionAttribution.SearchPer(tmpAtt.IdPersonnel),tmpAtt.DateAtttribut,tmpAtt.Commentaire));
            }
            gestionAttribution.LesAttribution = attributions;
        }
    }
}
