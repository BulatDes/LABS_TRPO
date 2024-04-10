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

namespace Laba_11._2
{
    /// <summary>
    /// Логика взаимодействия для Stacks.xaml
    /// </summary>
    public partial class Stacks : UserControl
    {
        int rotate = 0;
        public Stacks()
        {
            InitializeComponent();
        }
        private void btnright_Click(object sender, RoutedEventArgs e)
        {
            rotate -= 90;
            image.RenderTransform = new RotateTransform(rotate);
        }

        private void btnleft_Click(object sender, RoutedEventArgs e)
        {
            rotate += 90;
            image.RenderTransform = new RotateTransform(rotate);
        }
    }
}
