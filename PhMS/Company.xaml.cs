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
    /// Interaction logic for Company.xaml
    /// </summary>
    public partial class Company : Window
    {
        public Company()
        {
            InitializeComponent();
        }

        private void click(object sender, RoutedEventArgs e)
        {
            string cname, cid, cs;

            cname = txtcn.Text;
            cid = txtcid.Text;
            cs = txtcs.Text;
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into company(cname,cid,cs) values(@a,@b,@c)", sqlcon);
            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = cname;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = cid;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = cs;
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Company Added");
            sqlcon.Close();
        }

        private void btn_search(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.company where cname='" + txtcn.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                txt_details.Text = "Company Name : " + read[0].ToString();
                txt_details.Text += "\nCompany Id : " + read[1].ToString();
                txt_details.Text += "\nCopany Salesman : " + read[2].ToString();
                
            }
            sqlcon.Close();
        }
    }
}
