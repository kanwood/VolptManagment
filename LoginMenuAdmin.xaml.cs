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
    /// Логика взаимодействия для LoginMenuAdmin.xaml
    /// </summary>
    public partial class LoginMenuAdmin : Window
    {
        private const string CorrectPassword1 = "admin";
        public LoginMenuAdmin()
        {
            InitializeComponent();
        }

        private void MenuAdminButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPB.Password == CorrectPassword1)
            {
                MenuAdmin menuadmin = new MenuAdmin();
                menuadmin.Show();
                this.Close();
            }
            else
            {

                MessageBox.Show("Неправильный пароль. Попробуйте еще раз");
            }
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            ChoiceMenu menu = new ChoiceMenu();
            menu.Show();
            this.Close();
        }

    }
}