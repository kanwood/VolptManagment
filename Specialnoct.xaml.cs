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
    /// Логика взаимодействия для Specialnoct.xaml
    /// </summary>
    public partial class Specialnoct : Window
    {
        public Specialnoct()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void SpisokAbiturientov_Click(object sender, RoutedEventArgs e)
        {
            SpisokAbiturients spisokAbiturients = new SpisokAbiturients();
            spisokAbiturients.Show();
            this.Close();
        }

        private void OnlineApplication_Click(object sender, RoutedEventArgs e)
        {
            OnlineApplicaton onlineApplicaton = new OnlineApplicaton();
            onlineApplicaton.Show();
            this.Close();
        }
    }
}
