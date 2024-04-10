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

namespace Laba_7._2
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

        /*private void Button_Run(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            DoubleAnimation x = new DoubleAnimation()
            {
                To = random.Next((int)(Width - but.Width)),
                Duration = TimeSpan.FromMilliseconds(0)
            };
            DoubleAnimation y = new DoubleAnimation()
            {
                To = random.Next((int)(Height - but.Height)),
                Duration = TimeSpan.FromMilliseconds(0)
            };
            but.BeginAnimation(Canvas.LeftProperty, x);
            but.BeginAnimation(Canvas.TopProperty, y);
        }*/

        private void but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("HOW????!!!!","Attention",MessageBoxButton.OK,MessageBoxImage.Asterisk);
        }
    }
}
