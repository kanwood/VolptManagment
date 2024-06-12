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
    /// Логика взаимодействия для LoginMenuRedact.xaml
    /// </summary>
    public partial class LoginMenuRedact : Window
    {
        private const string CorrectPassword = "redact";
        public LoginMenuRedact()
        {
            InitializeComponent();
        }


        private void MenuRedactButton_Click(object sender, RoutedEventArgs e)
        {
            if (PasswordPB.Password == CorrectPassword)
            {
                MenuRedact menuRedact = new MenuRedact();
                menuRedact.Show();
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
