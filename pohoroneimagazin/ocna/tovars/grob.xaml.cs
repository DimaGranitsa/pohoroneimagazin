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

namespace pohoroneimagazin.ocna.tovars
{
    /// <summary>
    /// Логика взаимодействия для grob.xaml
    /// </summary>
    public partial class grob : Page
    {
        public grob()
        {
            InitializeComponent();
        }

        private void podrobnie1Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.grob1());
        }

        private void podrobnie2Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.Grob2());
        }

        private void podrobnie3Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.Grob3());
        }

        private void podrobnie4Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.grob4());
        }

        private void podrobnie5Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.grob5());
        }

        private void podrobnie6Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tovars.graob1.Grob6());
        }
    }
}
