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

namespace Notosorus_V2.View
{
    /// <summary>
    /// Interaction logic for CreateSemester.xaml
    /// </summary>
    public partial class CreateSemester : Window
    {
        private AppDbContext _context;

        public CreateSemester()
        {
            InitializeComponent();
            _context = new AppDbContext();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNameSemester.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de semestre.");
            }
            else
            {
                var semester = new Model.Semester { Name = txtNameSemester.Text };
                _context.Semesters.Add(semester);
                _context.SaveChanges();

                MessageBox.Show("Semestre ajouté !");

                MainWindow main = new MainWindow();
                main.Show();
                Close();
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
