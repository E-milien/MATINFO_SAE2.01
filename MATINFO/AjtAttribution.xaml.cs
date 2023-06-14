﻿using System;
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
            Attribution a = new Attribution(gestionAttribution.SearchMat((Materiel)lvMat.SelectedItem), gestionAttribution.SearchPer((Personnel)lvPer.SelectedItem), (DateTime)dpDate.DisplayDate, (string)tbCom.Text);
            a.UnMateriel = (Materiel)lvMat.SelectedItem;
            a.UnPersonnel = (Personnel)lvPer.SelectedItem;
            a.Create();
            gestionAttribution.LesAttribution.Insert(0,a);
            await Task.Delay(1000);
            Hide();
        }
    }
}
