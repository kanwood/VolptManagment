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

    public partial class Newspec : Window
    {
        public Newspec()
        {
            InitializeComponent();
            DGAddRatingSpec.ItemsSource = VoltptDBEntities.GetContext().Specializations.ToList();
        }

        private void AddSpec_Click(object sender, RoutedEventArgs e)
        {
            AddSpec addspec = new AddSpec();
            addspec.Show();
            this.Close();
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            ChoiceMenu choicemenu = new ChoiceMenu();
            choicemenu.Show();
            this.Close();
        }
    }
}
