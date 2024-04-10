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

namespace Laba_3
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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Blue);
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.White);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программу разработал студент ГАПОУ СО ЕКТС ", "О разработчике");
        }

        private void ColorBlue_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Меняет цвет фона на Синий";
        }

        private void Clean_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Меняет цвет фона на Белый";
        }

        private void Close_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Завершает работу программы";
        }

        private void AboutProgrammer_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Выводит информацию о Разработчике";
        }

        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Здесь можно выбрать элементы меню";
        }

        private void GraphRed_Click(object sender, RoutedEventArgs e)
        {
            GraphicsRedactor w = new GraphicsRedactor();
            w.ShowDialog();
        }

        private void GraphRed_MouseEnter(object sender, MouseEventArgs e)
        {
            Status.Text = "Открывает Графический редактор";
        }
    }
}
