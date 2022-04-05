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
            NavigationService.Navigate(new reg.регистрация());
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new reg.avtorizacia());
        }

        private void pamatnikcprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.pamatnici());
        }

        private void gravirovcaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.gravirovca());
        }

        private void ogradaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.ograda());
        }

        private void grobprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.grob());
        }

        private void krestprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.crest());
        }

        private void venokbprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.venok());
        }

        private void tablickaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.tab());
        }

        private void odegdaprosmotrButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.odegda());
        }

        private void pamatnikcButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new tovars.pamatnici());
        }

        private void GravirovkaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.gravirovca());
        }

        private void OgradaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.ograda());
        }

        private void GrobButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.grob());
        }

        private void KrestButton_Click(object sender, RoutedEventArgs e)
        {

            NavigationService.Navigate(new tovars.crest());
        }

        private void VenkiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.venok());
        }

        private void tablicckiButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.tab());
        }

        private void odegdaButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.odegda());
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
