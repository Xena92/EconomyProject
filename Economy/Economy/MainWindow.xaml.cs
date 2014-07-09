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
            InitializeComponent();

            _controller = new EconomyController();
        }

        private void TextBox_Indkomst_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            
            string textValue = textBox.Text;
        }

        private void Gem_Indkomst(object sender, RoutedEventArgs e) {
            _controller.AddToIndkomstList();
        }

        private void TextBox_Navn(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.SetName(textBox.Text);
        }

        private void GemOgAfslut(object sender, RoutedEventArgs e) {
            _controller.txt.WriteToFile();
            this.Close();
        }

        private void TextBox_Indkomst_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void TextBox_Diverse_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void TextBox_Transport_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.comment = textBox.Text;
        }

        private void TextBox_Transport_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void Gem_Transport(object sender, RoutedEventArgs e) {
            _controller.AddToTransportList();
        }

        private void TextBox_Diverse_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.comment = textBox.Text;
        }

        private void Gem_Diverse(object sender, RoutedEventArgs e) {
            _controller.AddToDiverseList();
        }

        private void TextBox_Regninger_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.comment = textBox.Text;
        }

        private void TextBox_Regninger_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void Gem_Regninger(object sender, RoutedEventArgs e) {
            _controller.AddToRegningerList();
        }

        private void TextBox_Faste_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.comment = textBox.Text;
        }

        private void TextBox_Faste_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void Gem_Faste(object sender, RoutedEventArgs e) {
            _controller.AddToFasteList();
        }

        private void TextBox_Maned_Ar(object sender, TextChangedEventArgs e) {

            if (!_controller.lockDate) {
                var textBox = sender as TextBox;

                _controller.SetDate(textBox.Text);
            }
            else
                MessageBox.Show("Nix pille!");
        }

        private void TextBox_Mad_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.comment = textBox.Text;
        }

        private void TextBox_Mad_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.amount = decimal.Parse(textBox.Text);
        }

        private void Gem_Mad(object sender, RoutedEventArgs e) {
            _controller.AddToMadList();
        }

        private void Button_GemForPerson(object sender, RoutedEventArgs e) {
            if (_controller.CheckNameAndDate()) {
                _controller.AddPerson();
                _controller.lockDate = true;

                MessageBox.Show("Husk at skrive et nyt navn øverst");
            }
            else
                MessageBox.Show("Du mangler at udfylde navn og/eller dato");

        }
    }
}
