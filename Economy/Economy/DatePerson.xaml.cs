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
using Economy.Controller;

namespace Economy
{
    /// <summary>
    /// Interaction logic for DatePerson.xaml
    /// </summary>
    public partial class DatePerson : Window
    {
        private EconomyController _controller;
        private MainWindow _main;

        public DatePerson(EconomyController controller, MainWindow main)
        {
            _controller = controller;
            _main = main;

            InitializeComponent();

            ExpenseDate.Text = _controller.txt.date;
            ExpenseDate.IsEnabled = !_controller.lockDate;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.txt.date = ExpenseDate.Text;
            _controller.AddPerson(PersonName.Text);

            _main.IsEnabled = true;
            ExpenseDate.IsEnabled = false;
            this.Close();
        }

        
    }
}
