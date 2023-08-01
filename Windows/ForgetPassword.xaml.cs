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
    /// Interaction logic for ForgetPassword.xaml
    /// </summary>
    public partial class ForgetPassword : Window
    {
        RailWayDB db = new RailWayDB();
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void btnForgetPassword(object sender, RoutedEventArgs e)
        {
            if(db.Logins.Any(user => user.Email == tbEmailOrPhone.Text)) 
            { 
                var user = db.Logins.First(user => user.Email == tbEmailOrPhone.Text);

                MessageBox.Show($"Sizning parolingiz : {user.Password}");
            }
            else
            {
                MessageBox.Show("Bunday email mavjud emas !");
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Loginxaml loginxaml = new Loginxaml();
            loginxaml.Show();
        }

        private void btnRegister_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}
