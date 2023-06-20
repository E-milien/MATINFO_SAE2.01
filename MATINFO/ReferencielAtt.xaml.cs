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
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielAtt : Window
    {
        AjtAttribution ajouter = new AjtAttribution();

        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach(Attribution att in gestionAttribution.LesAttribution)
            {
                att.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielAtt()
        {
            InitializeComponent();
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dgAttribution.SelectedIndex >= 0)
            {
                Attribution a = (Attribution)dgAttribution.SelectedItem;
                a.Delete();
                gestionAttribution.LesAttribution.Remove(a);
                dgAttribution.SelectedIndex = 0;
            }
        }

        private void btAjouter_Click(object sender, RoutedEventArgs e)
        {
            ajouter.ShowDialog();
        }
    }
}
