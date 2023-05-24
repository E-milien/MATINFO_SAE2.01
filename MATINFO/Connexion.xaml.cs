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
    /// Logique d'interaction pour Connexion.xaml
    /// </summary>
    public partial class Connexion : Window
    {

        private void Modale_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            if (username == "admin" && password == "admin")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
            }
        }
    }
}
