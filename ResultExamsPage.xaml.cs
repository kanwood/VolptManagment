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
    /// Логика взаимодействия для ResultExamsPage.xaml
    /// </summary>
    public partial class ResultExamsPage : Window
    {
        public ResultExamsPage()
        {
            InitializeComponent();
            DGResultExams.ItemsSource = VoltptDBEntities.GetContext().ResultExams.ToList();
        }

        private void ExamsPageButton_Click(object sender, RoutedEventArgs e)
        {
            ExamsPage examsPage = new ExamsPage();
            examsPage.Show();
            this.Close();
        }

    }
}
