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
    /// Логика взаимодействия для SpisokAbiturients.xaml
    /// </summary>
    public partial class SpisokAbiturients : Window
    {
        public SpisokAbiturients()
        {
            InitializeComponent();
            DGSpisokAbiturients.ItemsSource = VoltptDBEntities.GetContext().Applications.ToList();
        }

        private void SpecialButton1_Click(object sender, RoutedEventArgs e)
        {
            Specialnoct specialnoct = new Specialnoct();
            specialnoct.Show();
            this.Close();
        }
    }
}
