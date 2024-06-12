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
    /// Логика взаимодействия для SpisokAbitRedact.xaml
    /// </summary>
    public partial class SpisokAbitRedact : Window
    {
        public SpisokAbitRedact()
        {
            InitializeComponent();
            DGExamsAb.ItemsSource = VoltptDBEntities.GetContext().Exams.ToList();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ApplicationExams applicationExams = new ApplicationExams();
            applicationExams.Show();
            this.Close();
        }

        private void OutClick(object sender, RoutedEventArgs e)
        {
            ChoiceMenu choicemenu = new ChoiceMenu();
            choicemenu.Show();
            this.Close();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            Exams selectexam = (Exams)DGExamsAb.SelectedItem;

            if (selectexam == null)
            {
                MessageBox.Show("Выберите заявку абитуриента");
            }
            else
            {
                List<Exams> u = VoltptDBEntities.GetContext().Exams.Where(us => us.idExams == selectexam.idExams).ToList();
                VoltptDBEntities.GetContext().Exams.Remove(u[0]);
                VoltptDBEntities.GetContext().SaveChanges();

                DGExamsAb.ItemsSource = null;
                DGExamsAb.ItemsSource = VoltptDBEntities.GetContext().Exams.ToList();
            }
        }

    }
}
