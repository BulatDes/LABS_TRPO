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
using System.Windows.Shapes;

namespace Laba_3
{
    /// <summary>
    /// Логика взаимодействия для GraphicsRedactor.xaml
    /// </summary>
    public partial class GraphicsRedactor : Window
    {
        public GraphicsRedactor()
        {
            InitializeComponent();
        }

        private void brushSize_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (canvasink != null)
            {
                canvasink.DefaultDrawingAttributes.Height = brushSize.Value;
                canvasink.DefaultDrawingAttributes.Width = brushSize.Value;
            }
        }

        private void RbtnsChk(object sender, RoutedEventArgs e)
        {
            /*if(canvasink != null)
            {

                if ((bool)drawRdb.IsChecked)
                {
                    canvasink.EditingMode = InkCanvasEditingMode.Ink;
                }
                else if ((bool)redRdb.IsChecked)
                {
                    canvasink.EditingMode = InkCanvasEditingMode.Select;
                }
                else if((bool)delRdb.IsChecked)
                {
                    canvasink.EditingMode = InkCanvasEditingMode.EraseByStroke;
                }
                else
                {

                    canvasink.EditingMode = InkCanvasEditingMode.EraseByPoint;
                }
            }*/
            
        }

        private void colorchanged(object sender, SelectionChangedEventArgs e)
        {
           /* if(canvasink != null)
            {
                switch (ColorCmbx.SelectedIndex)
                {
                    case 0:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Black;
                            break;
                        }
                    case 1:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Red;
                            break;
                        }
                    case 4:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Blue;
                            break;
                        }
                    case 2:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Yellow;
                            break;
                        }
                    case 3:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Green;
                            break;
                        }
                    default:
                        {
                            canvasink.DefaultDrawingAttributes.Color = Colors.Black;
                            break;
                        }
                }
            }*/
        }
    }
}
