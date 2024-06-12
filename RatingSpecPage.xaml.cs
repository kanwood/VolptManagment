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
    /// Логика взаимодействия для RatingSpecPage.xaml
    /// </summary>
    public partial class RatingSpecPage : Window
    {
        public RatingSpecPage()
        {
            InitializeComponent();
            DGRatingSpec.ItemsSource = VoltptDBEntities.GetContext().Specializations.ToList();

        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            ChoiceMenu choiceMenu = new ChoiceMenu();
            choiceMenu.Show();
            this.Close();
        }
    }
}
