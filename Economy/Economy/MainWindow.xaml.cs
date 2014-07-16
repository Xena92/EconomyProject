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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Economy.Controller;

namespace Economy {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private EconomyController _controller;

        public MainWindow() {

            _controller = new EconomyController();
            DatePerson datePersonWindow = new DatePerson(_controller, this);
            
            datePersonWindow.Topmost = true;
            datePersonWindow.Show();
            this.IsEnabled = false;

            InitializeComponent();

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            int index = DropDown.SelectedIndex;

            _controller.amount = decimal.Parse(AmountBox.Text);
            _controller.comment = CommentBox.Text;
            //Do check
            switch (index)
            {
                case 0:
                    _controller.AddToIndkomstList();
                    break;
                case 1:
                    _controller.AddToMadList();
                    break;
                case 2:
                    _controller.AddToTransportList();
                    break;
                case 3:
                    _controller.AddToDiverseList();
                    break;
                case 4:
                    _controller.AddToRegningerList();
                    break;
                case 5:
                    _controller.AddToFasteList();
                    break;
            }

            CommentBox.Text = string.Empty;
            AmountBox.Text = string.Empty;
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            _controller.txt.WriteToFile();
            this.Close();
        }

        private void NewPerson_Click(object sender, RoutedEventArgs e)
        {
            DatePerson datePersonWindow = new DatePerson(_controller, this);

            datePersonWindow.Topmost = true;
            datePersonWindow.Show();
        }
    }
}
