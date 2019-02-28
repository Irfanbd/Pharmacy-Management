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

namespace PhMS
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        

        private void login_btn(object sender, RoutedEventArgs e)
        {
            Mainpage bw = new Mainpage();
            if (username.Text == "irfan" && password.Password == "1234")
            {
                bw.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Wrong username or password", "Login");
                username.Text = "";
                password.Password = "";
            }
            
            
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
