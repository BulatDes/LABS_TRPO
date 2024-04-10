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

namespace Laba_6._1
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

        private void ComboBox_Selected(object sender, SelectionChangedEventArgs e)
        {
            if (text1 != null)
            {
                switch (sel.SelectedIndex)
                {
                    case 0: text1.FontSize = 12; text2.FontSize = 12; break;
                    case 1: text1.FontSize = 16; text2.FontSize = 16; break;
                    case 2: text1.FontSize = 20; text2.FontSize = 20; break;
                    case 3: text1.FontSize = 30; text2.FontSize = 30; break;
                }
            }
        }
    }
}
