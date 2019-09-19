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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "aajj";
            lblHolaAmigos.FontSize = 32;
            lblHolaAmigos.Foreground = Brushes.Aqua;
        }

        private void Btnboton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "Adios Amigos!";
            lblHolaAmigos.FontSize = 29;
            lblHolaAmigos.Foreground = Brushes.Aqua;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lblHolaAmigos.Text = "grr";
            lblHolaAmigos.FontSize = 25;
            lblHolaAmigos.Foreground = Brushes.Aqua;
        }
    }
}
