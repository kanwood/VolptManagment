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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MainwindowButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Special_Selected(object sender, RoutedEventArgs e)
        {
            Specialnoct specialnoct = new Specialnoct();
            specialnoct.Show();
            this.Close();
        }

        private void Exam_Selected(object sender, RoutedEventArgs e)
        {
            ExamsPage examsPage = new ExamsPage();
            examsPage.Show();
            this.Close();
        }

        private void Rating_Selected(object sender, RoutedEventArgs e)
        {
            RatingSpecPage ratingSpecPage = new RatingSpecPage();
            ratingSpecPage.Show();
            this.Close();
        }

        private void OutBack_Selected(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow2 = new MainWindow();
            mainWindow2.Show();
            this.Close();
        }
    }
}
