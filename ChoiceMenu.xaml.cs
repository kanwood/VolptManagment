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

namespace VolptManagment
{
    /// <summary>
    /// Логика взаимодействия для ChoiceMenu.xaml
    /// </summary>
    public partial class ChoiceMenu : Window
    {
        public ChoiceMenu()
        {
            InitializeComponent();
        }

        private void AdminMenuButton_Click(object sender, RoutedEventArgs e)
        {
            LoginMenuAdmin loginMenuAdmin = new LoginMenuAdmin();
            loginMenuAdmin.Show();
            this.Close();
        }


        private void RedactMenuButton_Click(object sender, RoutedEventArgs e)
        {
            LoginMenuRedact loginMenuRedact = new LoginMenuRedact();
            loginMenuRedact.Show();
            this.Close();
        }

        private void AbiturientMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

    }
}
