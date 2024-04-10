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

namespace Laba_5._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (red.IsChecked == true)
            {
                pen.Color = Color.FromRgb(255, 0, 0);
            }
            else if (green.IsChecked == true)
            {
                pen.Color = Color.FromRgb(0, 255, 0);
            }
            else if (blue.IsChecked == true)
            {
                pen.Color = Color.FromRgb(0, 0, 255);
            }
        }

        private void pai(object sender, RoutedEventArgs e)
        {
            if (paint.IsChecked == true)
            {
                red.IsEnabled = true;
                green.IsEnabled = true;
                blue.IsEnabled = true;
                RadioButton_Click(null, null);
            }
            else if (change.IsChecked == true)
            {
                penik.EditingMode = InkCanvasEditingMode.Select;
            }
            else if (clear.IsChecked == true)
            {
                red.IsEnabled = false;
                green.IsEnabled = false;
                blue.IsEnabled = false;
                pen.Color = Color.FromRgb(255, 255, 255);
            }
        }

        private void Value(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (length != null)
            {
                length.Text = Math.Round(one.Value).ToString();
                pen.Width = one.Value;
                pen.Height = one.Value;
            }
        }
    }

}
