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
    /// Interaction logic for SelectedSemester.xaml
    /// </summary>
    public partial class SelectedSemester : Window
    {
        private AppDbContext _context;
        public SelectedSemester(string SemesterName)
        {
            InitializeComponent();
            _context = new AppDbContext();
            var classes = _context.Classes.ToList();
            ListClasses.ItemsSource = classes;
        }

        private void BtnAddClasse_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
