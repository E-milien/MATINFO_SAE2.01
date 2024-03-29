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
using static System.Collections.Specialized.BitVector32;

namespace MATINFO
{
    /// <summary>
    /// Logique d'interaction pour Referenciel.xaml
    /// </summary>
    public partial class ReferencielCat : Window
    {
        List<Categorie> listeCategorie = new List<Categorie>();
        public GestionAttribution gestionAttribution { get; set; }
        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            foreach(Categorie cat in gestionAttribution.LesCategorie)
            {
                cat.Update();
            }
            e.Cancel = true;
            this.Hide();
        }
        public ReferencielCat(GestionAttribution gestion)
        {
            InitializeComponent();
            gestionAttribution = gestion;
            DataContext = this;
        }

        private void btSupprimer_Click(object sender, RoutedEventArgs e)
        {
            if (dgCategorie.SelectedIndex >= 0)
            {
                string txtMat = "";
                string txtAtt = "";
                Categorie c = (Categorie)dgCategorie.SelectedItem;
                foreach(Materiel mat in gestionAttribution.LesMateriel)
                {
                    if (c.Idcategorie == mat.IdCategorie)
                    {
                        txtMat += mat.Nommateriel + " ";
                        foreach(Attribution att in gestionAttribution.LesAttribution)
                        {
                            if(mat.Idmateriel==att.IdMateriel)
                            {
                                txtAtt += att.UnPersonnel.Nompersonnel + " ";
                            }

                        }
                    }
                }

                if (MessageBox.Show($"Est vous sur de supprimer {c.Nomcategorie} ? \nCela va supprimer les materiels : {txtMat}. " +
                    $"\nEt les attribution : {txtAtt}.", "Attention", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    c.Delete();
                    gestionAttribution.Remove(c);
                    dgCategorie.SelectedIndex = 0;
                }
            }
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
        }
    }
}
