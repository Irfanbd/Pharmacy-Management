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
using System.Data;
using System.Data.SqlClient;

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
            /*if (username.Text == "" && password.Password == "")
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
            */
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True");
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                    sqlcon.Open();
                string commandstring = "select COUNT(1) from phms WHERE username=@username AND password=@password";
                SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.Parameters.AddWithValue("@username", username.Text);
                sqlcmd.Parameters.AddWithValue("@password", password.Password);
                int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
                if (count == 1)
                {
                    Mainpage ad = new Mainpage();
                    ad.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password Not Matched Try Again");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
