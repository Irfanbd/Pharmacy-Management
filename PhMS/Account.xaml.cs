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
    /// Interaction logic for Account.xaml
    /// </summary>
    public partial class Account : Window
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            String bill, edate, mid, mname,cname,rdname,ta;
            bill = txt_bill.Text;
            edate = edat.SelectedDate.Value.ToShortDateString();
            mid = txt_mid.Text;
            mname = txt_mname.Text;
            cname = txt_cname.Text;
            rdname = txt_rdname.Text;
            ta = txt_ta.Text;

            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("insert into account(bill, edate, mid, mname,cname,rdname,ta) values(@a,@b,@c,@d,@e,@f,@g)", sqlcon);

            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = bill;
            cmd.Parameters.Add("@b", SqlDbType.Date).Value = edate;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = mid;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = mname;  
            cmd.Parameters.Add("@e", SqlDbType.VarChar).Value = cname;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = rdname;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = ta;
            
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Bill Added");
            sqlcon.Close();

        }

        private void btn_src(object sender, RoutedEventArgs e)
        {
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.account where bill='" + txt_bill.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                txt_details.Text = "Bill No          : " + read[0].ToString();
                txt_details.Text += "\nDate          : " + read[1].ToString();
                txt_details.Text += "\nMedicine ID   : " + read[2].ToString();
                txt_details.Text += "\nCompany Name : " + read[3].ToString();

                txt_details.Text += "\nReferred Doctor name : " + read[5].ToString();

                txt_details.Text += "\nTotal taka" + read[6].ToString();
             
            }
            sqlcon.Close();
        
        }

        private void cv(object sender, RoutedEventArgs e)
        {
            clear();
        }
        void clear()
        {
            txt_bill.Clear();
            txt_mid.Clear();
            txt_mname.Clear();
            txt_cname.Clear();
            txt_rdname.Clear();
            txt_ta.Clear();
        }

        private void calcu(object sender, RoutedEventArgs e)
        {
            Calculator mx = new Calculator();
            mx.Show();
        }
    }
}
