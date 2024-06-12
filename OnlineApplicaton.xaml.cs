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
    public partial class OnlineApplicaton : Window
    {

        private Applications _currentAppliations = new Applications();
        public OnlineApplicaton()
        {
            InitializeComponent();
            DGSpecialization.ItemsSource = VoltptDBEntities.GetContext().Specializations.ToList();


            DataContext = _currentAppliations;
        }

        private void SaveChOnlineApplication_Click(object sender, RoutedEventArgs e)
        {
            VoltptDBEntities.GetContext().Applications.Add(new Applications() { nameA = NameAppTB.Text, surnameA = SurnameAppTB.Text, patronymicA = PatronymicAppTB.Text, avgRating = int.Parse(AvgRatingAppTB.Text), nameSpecial = SpecAppTB.Text, passport = Int64.Parse(PassportAppTB.Text), phonenumber = Int64.Parse(NumberphoneAppTB.Text) });; ; ;
            VoltptDBEntities.GetContext().SaveChanges();
            MessageBox.Show("Онлайн заявка зарегистрирована успешно!");
            SpisokAbiturients spisokAbiturients = new SpisokAbiturients();
            spisokAbiturients.Show();
            this.Close();
        }
    }
}
