﻿using System;
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

namespace StackPanel
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Se ha pulsado el botón 2");
            //MessageBox.Show("Se ha pulsado el botón 2");
        }

        //private void Panel_Click(object sender, RoutedEventArgs e)
        //{
        //    Console.WriteLine("Evento del StackPanel");
        //}

        private void Panel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Evento del panel preview");
        }
    }
}
