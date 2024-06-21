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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp56
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DoubleAnimationUsingPath animation = new DoubleAnimationUsingPath();
            animation.PathGeometry = (PathGeometry)this.Resources["CarouselPath"];
            animation.Duration = TimeSpan.FromSeconds(10);
            animation.Source = PathAnimationSource.X;
            animation.RepeatBehavior = RepeatBehavior.Forever;

            foreach (Viewbox item in canvas.Children)
            {
                item.BeginAnimation(Canvas.LeftProperty, animation);
            }
        }
    }
}