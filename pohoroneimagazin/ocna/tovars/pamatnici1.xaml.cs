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

namespace pohoroneimagazin.ocna.tovars
{
    /// <summary>
    /// Логика взаимодействия для pamatnici1.xaml
    /// </summary>
    public partial class pamatnici1 : Page
    {
        public pamatnici1()
        {
            InitializeComponent();
        }

        public TextBlock TB
        {
            get { return tb1; }
            set { tb1 = value; }
        }
        public ImageBrush IM 
        {
            get { return pfmatnic1; }
            set { pfmatnic1 = value; }
        }
        public TextBlock TB1
        {
            get { return tb2; }
            set { tb2 = value; }
        }
        public ImageBrush IM1
        {
            get { return pfmatnic2; }
            set { pfmatnic2 = value; }
        }

        private void karzina1Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void karzina2Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void karzina3Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void karzina4Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void karzina5Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void karzina6Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void karzina7Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
