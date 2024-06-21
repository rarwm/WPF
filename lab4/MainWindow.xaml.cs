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

namespace WpfAppjjjjjj
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SliderMultiplier.ValueChanged += (sender, e) =>
            {
                SliderFontSize.Value = SliderFontSize.Minimum + (SliderFontSize.Maximum - SliderFontSize.Minimum) * SliderMultiplier.Value / 100;
                SliderFontSize2.Value = SliderFontSize2.Minimum + (SliderFontSize2.Maximum - SliderFontSize2.Minimum) * SliderMultiplier.Value / 100;
            };
        }
    }
}
