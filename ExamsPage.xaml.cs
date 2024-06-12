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
    /// Логика взаимодействия для ExamsPage.xaml
    /// </summary>
    public partial class ExamsPage : Window
    {
        public ExamsPage()
        {
            InitializeComponent();
        }



        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }


        private void ExamsApplicationButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationExams applicationExams = new ApplicationExams();
            applicationExams.Show();
            this.Close();
        }

        private void ResultExams_Click(object sender, RoutedEventArgs e)
        {
            ResultExamsPage resultExams = new ResultExamsPage();
            resultExams.Show();
            this.Close();
        }
    }
}
