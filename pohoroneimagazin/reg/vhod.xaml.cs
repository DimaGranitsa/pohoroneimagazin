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
using System.Windows.Shapes;
using pohoroneimagazin.bd;

namespace pohoroneimagazin.reg
{
    /// <summary>
    /// Логика взаимодействия для vhod.xaml
    /// </summary>
    public partial class vhod : Page
    {
        public vhod()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, RoutedEventArgs e)
        {
            reg reg = new reg();
            reg.Show();
        }

        private void vhodButton_Click(object sender, RoutedEventArgs e)
        {
            var a = DataBaseMethods.Authorizations().Where(z => z.login == txtUsername.Text && z.password == txtpassword.Password).FirstOrDefault();
            if (a != null)
            {
                //var b = a.name.FirstOrDefault();
                if (a.login == txtUsername.Text)
                {
                    MessageBox.Show($"Добро пожаловать {a.login}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
NavigationService.Navigate(new ocna.glavneyokno.stranici.glavnoeocno());
                }
            }
            else
            {
                if (a.password == txtpassword.Password)
                {
                    MessageBox.Show($"Логин и пароль не верный!", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }




        }

        private void bezvvoda_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ocna.uslugi.Glavnaustranitsauslug());
        }
    }
    
}
