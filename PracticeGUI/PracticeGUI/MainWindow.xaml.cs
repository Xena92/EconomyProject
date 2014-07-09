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

namespace PracticeGUI {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Comment(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
        }

        private void Price(object sender, TextChangedEventArgs e) {
            TextBox textBox = sender as TextBox;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e) {
            CheckBox checkBox = sender as CheckBox;

            if (checkBox.IsEnabled) {
                Console.WriteLine("You pressed the checkbox");
            }
        }

        private void Save(object sender, RoutedEventArgs e) {

        }

        private void SaceAndQuit(object sender, RoutedEventArgs e) {

        }
    }
}
