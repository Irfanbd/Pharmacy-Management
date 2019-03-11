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
    /// Interaction logic for regi.xaml
    /// </summary>
    public partial class regi : Window
    {
        public regi()
        {
            InitializeComponent();
        }

        private void btn_crt(object sender, RoutedEventArgs e)
        {
            string fullname, username, email, password;

            fullname = txt_fullname.Text;
            username = txtusername.Text;
            email = txtemail.Text;
            password = pbpass.Password;
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into phms(fullname,username,email,password) values(@a,@b,@c,@d)", sqlcon);
            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = fullname;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = email;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = password;
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Account Created Successfully");
            sqlcon.Close();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            clear();
        }
        void clear()
        {
            txt_fullname.Clear();
            txtusername.Clear();
                txtemail.Clear();
            pbpass.Clear();
        }

        
    }
}
