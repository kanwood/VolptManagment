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
    /// Логика взаимодействия для AddSpec.xaml
    /// </summary>
    public partial class AddSpec : Window
    {
        public AddSpec()
        {
            InitializeComponent();
        }

        private void SaveChSpec_Click(object sender, RoutedEventArgs e)
        {
            VoltptDBEntities.GetContext().Specializations.Add(new Specializations() { nameSpec = nameSpecTB.Text, numberSpec = int.Parse(numberSpecTB.Text), ratingSpec = int.Parse(ratingSpecTB.Text) });; ; ; ;
            VoltptDBEntities.GetContext().SaveChanges();
            MessageBox.Show("Новая специальность добавлена успешно!");
            Newspec newspec = new Newspec();
            newspec.Show();
            this.Close();
        }
    }
}
