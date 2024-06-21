using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double initialScale = 1; // Исходный масштаб
        private double currentAngle = 0; // Текущий угол поворота
        private double lastScale = 0;

        public MainWindow()
        {
            InitializeComponent();

            myCanvas1.MouseLeftButtonUp += MyCanvas_MouseLeftButtonUp;
            myCanvas1.MouseEnter += MyCanvas_MouseEnter;
            myCanvas1.MouseLeave += MyCanvas_MouseLeave;
            myCanvas2.MouseLeftButtonUp += MyCanvas_MouseLeftButtonUp;
            myCanvas2.MouseEnter += MyCanvas_MouseEnter;
            myCanvas2.MouseLeave += MyCanvas_MouseLeave;

            myCanvas3.MouseLeftButtonUp += MyCanvas_MouseLeftButtonUp;
            myCanvas3.MouseEnter += MyCanvas_MouseEnter;
            myCanvas3.MouseLeave += MyCanvas_MouseLeave;

        }

        private void MyCanvas_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Canvas canvas = (Canvas)sender;
            
               
            // Поворот Canvas
            canvas.RenderTransformOrigin = new Point(0.5, 0.5);
            currentAngle += 20;

            if (currentAngle >= 360)
            {
                currentAngle -= 360;
            }
            DoubleAnimation animation = new DoubleAnimation
            {
                From = currentAngle - 20,
                To = currentAngle,
                Duration = TimeSpan.FromMilliseconds(200)
            };
            canvas.RenderTransform = new RotateTransform();
            canvas.RenderTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
            if (canvas.RenderTransform is TransformGroup transformGroup)
            {
                ScaleTransform scaleTransform = transformGroup.Children[0] as ScaleTransform;
                scaleTransform.ScaleX = lastScale;
                scaleTransform.ScaleY = lastScale;
            }
        }

        private void MyCanvas_MouseEnter(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;

            // Увеличиваем размер Canvas
            if (canvas.RenderTransform is TransformGroup transformGroup)
            {
                // Проверяем, есть ли уже ScaleTransform
                ScaleTransform scaleTransform = transformGroup.Children[0] as ScaleTransform;
                if (scaleTransform == null)
                {
                    // Создаем ScaleTransform, если его нет
                    scaleTransform = new ScaleTransform(1.2, 1.2);
                    transformGroup.Children.Add(scaleTransform);
                }
                else
                {
                    // Увеличиваем масштаб
                    scaleTransform.ScaleX *= 1.2;
                    scaleTransform.ScaleY *= 1.2;
                    lastScale= scaleTransform.ScaleX;
                }
            }
            else
            {
                // Создаем TransformGroup, если его нет
                TransformGroup transformGroup1 = new TransformGroup();
                ScaleTransform scaleTransform = new ScaleTransform(1.2, 1.2);
                transformGroup1.Children.Add(scaleTransform);
                canvas.RenderTransform = transformGroup1;
            }
        }


        private void MyCanvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Canvas canvas = (Canvas)sender;

            // Восстанавливаем исходный размер
            if (canvas.RenderTransform is TransformGroup transformGroup &&
                transformGroup.Children.Count > 0 &&
                transformGroup.Children[0] is ScaleTransform scaleTransform)
            {
                scaleTransform.ScaleX = initialScale;
                scaleTransform.ScaleY = initialScale;
                lastScale = scaleTransform.ScaleX;
            }
        }
    }
}
