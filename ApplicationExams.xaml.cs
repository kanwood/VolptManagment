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

    public partial class ApplicationExams : Window
    {
        public ApplicationExams()
        {
            InitializeComponent();
            DGExamsSubject.ItemsSource = VoltptDBEntities.GetContext().ExamsOrg.ToList();
            DGExamstime.ItemsSource = VoltptDBEntities.GetContext().ExamsOrg.ToList();
        }


        private void SaveChApplicationExams_Click(object sender, RoutedEventArgs e)
        {
            VoltptDBEntities.GetContext().Exams.Add(new Exams() { nameE = NameEAppTB.Text, surnameE = SurnameEAppTB.Text, patronymicE = PatronymicEAppTB.Text, schoolsubject = SchoolSubcjectEAppTB.Text, dateE = DateTime.Parse(DateEAppTB.Text) }); ; ; ;
            VoltptDBEntities.GetContext().SaveChanges();
            MessageBox.Show("Поздравляем! Вы успешно зарегистрировались на вступительный экзамен! С собой нужно иметь паспорт и черную геливую ручку!");
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void SaveChApplicationExams_Click(object sender, object e)
        {

        }
    }
}
