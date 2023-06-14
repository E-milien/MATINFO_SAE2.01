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

    public partial class Connexion : Window
    {
        private void Connexion_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
        public Connexion()
        {
            InitializeComponent();
            usernameTextBox.Focus();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            if (username == "admin" && password == "admin")
            {
                Hide();
            }
            else
            {
                usernameTextBox.BorderBrush = Brushes.Red;
                passwordBox.BorderBrush = Brushes.Red;
                MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.","Attention",MessageBoxButton.OK,MessageBoxImage.Warning);
            }
        }

        private void usernameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            usernameTextBox.BorderBrush = Brushes.Black;
            passwordBox.BorderBrush = Brushes.Black;
        }

    }
}
