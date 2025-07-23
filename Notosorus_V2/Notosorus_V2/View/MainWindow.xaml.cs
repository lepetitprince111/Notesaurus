using Notosorus_V2.Model;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext _context;

        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            var semesters = _context.Semesters.ToList();

            ListSemester.ItemsSource = semesters;
        }

        private void BtnAddSemester_Click(object sender, RoutedEventArgs e)
        {
            CreateSemester createSemester = new CreateSemester();
            createSemester.Show();
            Close();
        }

        private void ListSemester_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (ListSemester.SelectedItem is Semester selected)
            {
                string SemesterName = selected.Name;
                SelectedSemester selectedSemester = new SelectedSemester(SemesterName);
                selectedSemester.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Erreur de selection");
            }
            
        }
    }
}
