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

namespace pohoroneimagazin.ocna.tovars.korzina
{
    /// <summary>
    /// Логика взаимодействия для Korzina.xaml
    /// </summary>
    public partial class Korzina : Page
    {
        public Korzina()
        {
            InitializeComponent();
        }

        private void oplata1Button_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService.Navigate(new korzina.оплата());
           oplata1 op1 = new oplata1 ();
            op1.Show();
        }
    }
}
