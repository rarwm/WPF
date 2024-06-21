using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _4
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
        private void cmbColor_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("0"); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Black;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Red;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Green;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Blue;
        }
        

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double size = e.NewValue;
            if (change_color != null)
            {
                change_color.Width = size;
                change_color.Height = size;
            }

        }

        private void designRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.White;
        }

        private void deleteRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void deleteRadioButton_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }

        private void drawRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Red;
        }

        private void change_color_AttributeChanged(object sender, PropertyDataChangedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            change_color.Color = Colors.Yellow;
        }
    }
}
