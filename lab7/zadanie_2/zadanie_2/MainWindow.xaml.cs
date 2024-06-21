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

namespace zadanie_2
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

        private void buttonrun_MouseEnter(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            double newX = random.Next(0, (int)(ActualWidth - buttonrun.Width));
            double newY = random.Next(0, (int)(ActualHeight - buttonrun.Height));

            buttonrun.Margin = new Thickness(newX, newY, 0, 0);
        }

        private void buttonrun_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
