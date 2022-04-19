using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
            oplata1 op1 = new oplata1();
            op1.Show();
        }

        private void udalit1Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void udalit2Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void udalit3Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void udalit4Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            //pamatnici1 fr = (pamatnici1)Application.Current.FindResource();
            Page fr = new pamatnici1();
            if (fr != null)
            {
                pamatnici1 f1 = (pamatnici1)fr;
                la1.Text = f1.TB.Text;
            }
            if (fr != null)
            {
                pamatnici1 f2 = (pamatnici1)fr;
                IM1.ImageSource = f2.IM.ImageSource;
            }


            if (fr != null)
            {
                pamatnici1 f1 = (pamatnici1)fr;
                la2.Text = f1.TB1.Text;
            }
            if (fr != null)
            {
                pamatnici1 f2 = (pamatnici1)fr;
                IM2.ImageSource = f2.IM1.ImageSource;
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            IM1.ImageSource = null;
            la1.Text = null;
            IM2.ImageSource = null;
            la2.Text = null;
        }
    }
}
