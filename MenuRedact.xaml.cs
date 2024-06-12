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
    /// Логика взаимодействия для MenuRedact.xaml
    /// </summary>
    public partial class MenuRedact : Window
    {
        public MenuRedact()
        {
            InitializeComponent();
        }

        private void PanelAbiturient_Selected(object sender, RoutedEventArgs e)
        {
            CheckDocuments checkDocuments = new CheckDocuments();
            checkDocuments.Show();
            this.Close();
        }

        private void AbiturientExams_Selected(object sender, RoutedEventArgs e)
        {
            SpisokAbitRedact spisokAbitRedact = new SpisokAbitRedact();
            spisokAbitRedact.Show();
            this.Close();
        }

        private void NewSpec_Selected(object sender, RoutedEventArgs e)
        {
            Newspec newspec = new Newspec();
            newspec.Show();
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RatingSpec_Selected(object sender, RoutedEventArgs e)
        {
            RatingSpecPage ratingSpecPage = new RatingSpecPage();
            ratingSpecPage.Show();
            this.Close();
        }

        private void OutLobby_Selected(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
