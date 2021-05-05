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

namespace pingpong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Canvas canvas = FindName("Canvas") as Canvas;
           

        }



        private void MouseUp(object sender, MouseButtonEventArgs e)
        {
            Rectangle rectangle = FindName("Rec") as Rectangle;

            double top = Canvas.GetTop(rectangle);
            Canvas.SetTop(rectangle, top - 20);

            Console.WriteLine("Hello");
        }
    }
}
