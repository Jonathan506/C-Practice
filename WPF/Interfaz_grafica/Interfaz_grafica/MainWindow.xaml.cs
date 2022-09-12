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

namespace Interfaz_grafica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid myGrid = new Grid();

            this.Content = myGrid;

            Button miBoton = new Button();
            myGrid.Children.Add(miBoton);

            WrapPanel miWrap = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();

            txt1.Background = Brushes.White;
            txt3.Foreground = Brushes.White;

            txt1.Text = "Submit";
            txt2.Text = "Enviar";
            txt3.Text = "Entrar";

            miWrap.Children.Add(txt1);
            miWrap.Children.Add(txt2);
            miWrap.Children.Add(txt3);

            miBoton.Content = miWrap;

            miBoton.Width = 200;
            miBoton.Height = 100;
            miBoton.Background = Brushes.Red;
            miBoton.FontSize= 15;

            //txt1.Foreground.Freeze;
        }
    }
}
