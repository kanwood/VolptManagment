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

namespace VolptManagment
{
    /// <summary>
    /// Логика взаимодействия для CheckDocuments.xaml
    /// </summary>
    public partial class CheckDocuments : Window
    {
        public CheckDocuments()
        {
            InitializeComponent();
            DGCheckDocuments.ItemsSource = VoltptDBEntities.GetContext().Applications.ToList();
        }

        private void EditStatus_Click(object sender, RoutedEventArgs e)
        {
            RedactStatus redactStatus = new RedactStatus((sender as Button).DataContext as Applications);
            redactStatus.Show();
            this.Close();
        }

        private void SpecialButton1_Click(object sender, RoutedEventArgs e)
        {
            ChoiceMenu choicemenu = new ChoiceMenu();
            choicemenu.Show();
            this.Close();
        }


    }
}
