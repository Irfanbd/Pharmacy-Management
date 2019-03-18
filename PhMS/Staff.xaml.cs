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
    /// Interaction logic for Staff.xaml
    /// </summary>
    public partial class Staff : Window
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            string sname, sid, ssalary;

            sname = txtstaff.Text;
            sid = txtid.Text;
            ssalary = txtsalary.Text;
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into staff(sname,sid,ssalary) values(@a,@b,@c)", sqlcon);
            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = sname;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = sid;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = ssalary;
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Staff Added");
            sqlcon.Close();
        }

        private void btn(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.staff where sid='" + txtid.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                txt_details.Text = "Staff Name : " + read[0].ToString();
                txt_details.Text += "\nStaff Id : " + read[1].ToString();
                txt_details.Text += "\nStaff Salary : " + read[2].ToString();

            }
            sqlcon.Close();
        }

        private void dd(object sender, RoutedEventArgs e)
        {
            clear();

        }
        void clear()
        {
            txtstaff.Clear();
                txtid.Clear();
            txtsalary.Clear();
        }

        private void hpg(object sender, RoutedEventArgs e)
        {
            MainWindow mx = new MainWindow();
            mx.Show();
            this.Close();
        }

        private void gdf(object sender, RoutedEventArgs e)
        {
            Mainpage mx = new Mainpage();
            mx.Show();
            this.Close();
        }

        private void deletej(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);


            
            string commandstring = "delete from dbo.staff where sid='" + txtid.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            sqlcon.Open();
            int rows = sqlcmd.ExecuteNonQuery();
            sqlcon.Close();

            if (rows > 0)
                MessageBox.Show("Information Has Deleted.");
        }
    }
}
