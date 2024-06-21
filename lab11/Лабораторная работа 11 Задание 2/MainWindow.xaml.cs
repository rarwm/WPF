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

namespace Задание_2_Лабораторная_работа_11
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
        private void btnLeft_Click(object sender, RoutedEventArgs e)
        {
            RotateImage(-90);
        }

        private void btnRight_Click(object sender, RoutedEventArgs e)
        {
            RotateImage(90);
        }

        private void RotateImage(double angle)
        {
            foreach (var item in LogicalTreeHelper.GetChildren(this))
            {
                if (item is Image image)
                {
                    RotateTransform rotateTransform = new RotateTransform(angle);
                    image.RenderTransform = rotateTransform;
                }
            }
        }

    }
}
