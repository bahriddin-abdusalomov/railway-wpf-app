using RailWayWpfApp.Data;
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

namespace RailWayWpfApp.Windows
{
    /// <summary>
    /// Interaction logic for Loginxaml.xaml
    /// </summary>
    public partial class Loginxaml : Window
    {
        RailWayDB dB = new RailWayDB();

        public Loginxaml()
        {
            InitializeComponent();
        }


        private void Forget(object sender, RoutedEventArgs e)
        { 
            ForgetPassword forgetPassword = new ForgetPassword();
            forgetPassword.Show();
        }

        private void RegisterWindow(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
            
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (dB.Logins.Any(user => user.Password == tbPassword.Text && user.Email == tbEmailOrPhone.Text))
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Email yoki Parol xato kiritilgan !");
            }
        }
    }
}
