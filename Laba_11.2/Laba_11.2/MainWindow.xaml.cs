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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            two.image.Source = new BitmapImage(new Uri("https://upload.wikimedia.org/wikipedia/commons/8/88/%D0%9E%D0%B7%D0%B5%D1%80%D0%BE_%D0%A8%D0%B0%D0%B9%D1%82%D0%B0%D0%BD.jpg"));
            two.text.Text = "https://upload.wikimedia.org/wikipedia/commons/8/88/%D0%9E%D0%B7%D0%B5%D1%80%D0%BE_%D0%A8%D0%B0%D0%B9%D1%82%D0%B0%D0%BD.jpg";

            three.image.Source = new BitmapImage(new Uri("https://gotonature.ru/uploads/posts/2019-02/1549623882_don.jpg"));
            three.text.Text = "https://gotonature.ru/uploads/posts/2019-02/1549623882_don.jpg";

            four.image.Source = new BitmapImage(new Uri("https://b1.vpoxod.ru/ckeditor/1d/8f/28/149695.jpg"));
            four.text.Text = "https://b1.vpoxod.ru/ckeditor/1d/8f/28/149695.jpg";

            five.image.Source = new BitmapImage(new Uri("https://www.shkolazhizni.ru/img/content/i245/245789_or.jpg"));
            five.text.Text = "https://www.shkolazhizni.ru/img/content/i245/245789_or.jpg";

            six.image.Source = new BitmapImage(new Uri("https://lesprominform.ru/media/jarticles/1_lesa_raznye.jpg"));
            six.text.Text = "https://lesprominform.ru/media/jarticles/1_lesa_raznye.jpg";
        }
    }
}
