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

namespace pohoroneimagazin.ocna.uslugi
{
    /// <summary>
    /// Логика взаимодействия для Glavnaustranitsauslug.xaml
    /// </summary>
    public partial class Glavnaustranitsauslug : Page
    {
        public Glavnaustranitsauslug()
        {
            InitializeComponent();
        }

        private void podrobnie5Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.pamatnici1());
        }

        private void Grob6Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.gravirovca1());
        }

        private void podrobnie8Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.kremacia.krema());
        }

        private void podrobnie8Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.kremacia.krema());
        }

        private void podrobnie1Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.perevozkatela.perevozka());
        }

        private void podrobnie2Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new bumaga.bumaga());
        }

        private void vaborrazmerov3Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.omov.omenie());
        }

        private void podrobnie7Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.bog.bog1());
        }

        private void podrobnie4Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.pogrebeni.pogreb1());
        }
    }
    }

