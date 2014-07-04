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
        private string _indkomstBelob;

        public MainWindow() {
            InitializeComponent();

            _controller = new EconomyController();
        }

        private void TextBox_Indkomst_Kommentar(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            
            string textValue = textBox.Text;
        }

        private void Gem_Indkomst(object sender, RoutedEventArgs e) {
            
        }

        private void TextBox_Navn(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _controller.name = textBox.Text;
        }

        private void GemOgAfslut(object sender, RoutedEventArgs e) {
            Console.WriteLine(_controller.name);
        }

        private void TextBox_Indkomst_Belob(object sender, TextChangedEventArgs e) {
            var textBox = sender as TextBox;

            _indkomstBelob = textBox.Text;
        }

        private void CheckBox_Indkomst(object sender, RoutedEventArgs e) {

        }

        private void TextBox_Diverse_Belob(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Transport_Kommentar(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Transport_Belob(object sender, TextChangedEventArgs e) {

        }

        private void CheckBox_Transport(object sender, RoutedEventArgs e) {

        }

        private void Gem_Transport(object sender, RoutedEventArgs e) {

        }

        private void TextBox_Diverse_Kommentar(object sender, TextChangedEventArgs e) {

        }

        private void CheckBox_Diverse(object sender, RoutedEventArgs e) {

        }

        private void Gem_Diverse(object sender, RoutedEventArgs e) {

        }

        private void TextBox_Regninger_Kommentar(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Regninger_Belob(object sender, TextChangedEventArgs e) {

        }

        private void CheckBox_Regninger(object sender, RoutedEventArgs e) {

        }

        private void Gem_Regninger(object sender, RoutedEventArgs e) {

        }

        private void TextBox_Faste_Kommentar(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Faste_Belob(object sender, TextChangedEventArgs e) {

        }

        private void CheckBox_Faste(object sender, RoutedEventArgs e) {

        }

        private void Gem_Faste(object sender, RoutedEventArgs e) {

        }

        private void TextBox_Maned_Ar(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Mad_Kommentar(object sender, TextChangedEventArgs e) {

        }

        private void TextBox_Mad_Belob(object sender, TextChangedEventArgs e) {

        }

        private void CheckBox_Mad(object sender, RoutedEventArgs e) {

        }

        private void Gem_Mad(object sender, RoutedEventArgs e) {

        }

    }
}
