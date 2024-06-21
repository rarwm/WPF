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

namespace zadanie_2itog
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SmallTextBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox1.Clear();
            SmallTextBox1.Clear();
            SmallTextBox2.Clear();
            SmallTextBox3.Clear();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedItem = (ComboBoxItem)ComboBox.SelectedItem;
            var fontFamily = new FontFamily(selectedItem.FontFamily.ToString());
            var fontSize = double.Parse(selectedItem.FontSize.ToString());
            var foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedItem.Tag.ToString()));

            TextBox1.FontFamily = fontFamily;
            TextBox1.FontSize = fontSize;
            TextBox1.Foreground = foreground;

            SmallTextBox1.FontFamily = fontFamily;
            SmallTextBox1.Foreground = foreground;

            SmallTextBox2.FontFamily = fontFamily;
            SmallTextBox2.Foreground = foreground;

            SmallTextBox3.FontFamily = fontFamily;
            SmallTextBox3.Foreground = foreground;
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                string text = textBox.Text;

                SmallTextBox1.Text = text;
                SmallTextBox2.Text = text;
                SmallTextBox3.Text = text;
            }

        }

        private void SmallTextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SmallTextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
