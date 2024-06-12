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
using VolptManagment.БазаДанных;
using static System.Net.Mime.MediaTypeNames;

namespace VolptManagment
{
    /// <summary>
    /// Логика взаимодействия для RedactStatus.xaml
    /// </summary>
    public partial class RedactStatus : Window
    {

        private Applications _currentAppications = new Applications();

        public RedactStatus(Applications selectedAppications)
        {
            InitializeComponent();
            if (selectedAppications != null) 
                _currentAppications = selectedAppications;
            StatusCB.ItemsSource = VoltptDBEntities.GetContext().ExamsOrg.ToList();
        }

        private void SaveChStatus_Click(object sender, RoutedEventArgs e)
        {
            VoltptDBEntities.GetContext().Applications.Add(new Applications() { statusA = StatusCB.Text }); ; ; ;
            VoltptDBEntities.GetContext().SaveChanges();
            MessageBox.Show("Статус был изменён.");
            MenuAdmin adminmenu = new MenuAdmin();
            adminmenu.Show();
            this.Close();
        }

        private void CheckDoc_Click(object sender, RoutedEventArgs e)
        {
            CheckDocuments checkDocuments = new CheckDocuments();
            checkDocuments.Show();
            this.Close();
        }

        private void StatusCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
