using RailWayWpfApp.Data;
using RailWayWpfApp.Models;
using RailWayWpfApp.Sevices;
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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        RailWayDB db = new RailWayDB();
        public Register()
        {
            InitializeComponent();
        }


        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Registratsiya registratsiya = new Registratsiya();

            int maxId = db.Registratsiyas.Count( );

            registratsiya.RegistratsiyaId = maxId + 1;
            registratsiya.Email = tbEmailOrPhone.Text;
            registratsiya.Password = tbPassword.Text;
            registratsiya.RepeatPassword = tbRepeatPassword.Text;

            if(registratsiya.Email.EndsWith("@gmail.com") && registratsiya.Password == registratsiya.RepeatPassword)
            {   
                RegisterUser registerUser = new RegisterUser();
                registerUser.Add(registratsiya);


                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Email yoki Parol xato kiritildi !");
            }

        }

        private void btnRoyxatdanOtganmisiz_Click(object sender, RoutedEventArgs e)
        {
            Loginxaml loginxaml = new Loginxaml();
            loginxaml.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Loginxaml loginxaml = new Loginxaml();
            loginxaml.Show();
        }
    }
}
        