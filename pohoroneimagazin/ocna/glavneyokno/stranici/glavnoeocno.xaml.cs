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

namespace pohoroneimagazin.ocna.glavneyokno.stranici
{
    /// <summary>
    /// Логика взаимодействия для glavnoeocno.xaml
    /// </summary>
    public partial class glavnoeocno : Page
    {
        public glavnoeocno()
        {
            InitializeComponent();
        }

        private void registraciaButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void pamatnikcprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.pamatnici1());
        }

        private void gravirovcaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.gravirovca1());
        }

        private void ogradaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.ograda1());
        }

        private void grobprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.grob1());
        }

        private void krestprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.crest1());
        }

        private void venokbprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.venoc1());
        }

        private void tablickaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.tab1());
        }

        private void odegdaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.odegda1());
        }

        private void pamatnikcButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new tovars.pamatnici1());
        }

        private void GravirovkaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.gravirovca1());
        }

        private void OgradaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.ograda1());
        }

        private void GrobButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.grob1());
        }

        private void KrestButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new tovars.crest1());
        }

        private void VenkiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.venoc1());
        }

        private void tablicckiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.tab1());
        }

        private void odegdaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.odegda1());
        }

        private void korzinaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.korzina.Korzina());
        }

        private void ocompaniiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ocompanii.ocompani1());
        }

        private void adresaaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new adres.adres ());
        }

        private void uslugiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new uslugi.Glavnaustranitsauslug());
        }
    }
}
