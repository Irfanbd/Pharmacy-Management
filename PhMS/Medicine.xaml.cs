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
    /// Interaction logic for Medicine.xaml
    /// </summary>
    public partial class Medicine : Window
    {
        public Medicine()
        {
            InitializeComponent();
        }

        private void btn_save(object sender, RoutedEventArgs e)
        {
            string mid,mname,gn,cn,edate,pprice,sprice,sa,mc,sn,mobile;

            mid = txt_id.Text;
            mname = txt_name.Text;
            gn = txt_gname.Text;
            cn = txt_cname.Text;
            edate = date.SelectedDate.Value.ToShortDateString();
            pprice = txt_ppeice.Text;
            sprice = txt_sprice.Text;
            sa = txt_sadvice.Text;
            mc = txt_mcountry.Text;
            sn = txt_sname.Text;
            mobile = txt_mnumber.Text;
            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);

            SqlCommand cmd = new SqlCommand("insert into medicine(mid,mname,gn,cn,edate,pprice,sprice,sa,mc,sn,mobile) values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k)", sqlcon);
            cmd.Parameters.Add("@a", SqlDbType.VarChar).Value = mid;
            cmd.Parameters.Add("@b", SqlDbType.VarChar).Value = mname;
            cmd.Parameters.Add("@c", SqlDbType.VarChar).Value = gn;
            cmd.Parameters.Add("@d", SqlDbType.VarChar).Value = cn;
            cmd.Parameters.Add("@e", SqlDbType.Date).Value = edate;
            cmd.Parameters.Add("@f", SqlDbType.VarChar).Value = pprice;
            cmd.Parameters.Add("@g", SqlDbType.VarChar).Value = sprice;
            cmd.Parameters.Add("@h", SqlDbType.VarChar).Value = sa;
            cmd.Parameters.Add("@i", SqlDbType.VarChar).Value = mc;
            cmd.Parameters.Add("@j", SqlDbType.VarChar).Value = sn;
            cmd.Parameters.Add("@k", SqlDbType.VarChar).Value = mobile;
            sqlcon.Open();
            int rows = cmd.ExecuteNonQuery();
            if (rows > 0)
                MessageBox.Show("Medicine Added");
            sqlcon.Close();
        }

        private void btn_src(object sender, RoutedEventArgs e)
        {

            string connectionstring = @"Data Source=DESKTOP-M4UMV3O;Initial Catalog=fall16;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(connectionstring);
            sqlcon.Open();
            string commandstring = "select * from dbo.medicine where mid='" + txt_id.Text + "'";
            SqlCommand sqlcmd = new SqlCommand(commandstring, sqlcon);
            SqlDataReader read = sqlcmd.ExecuteReader();

            while (read.Read())
            {
                txt_details.Text = "Medicine Id : " + read[0].ToString();
                txt_details.Text += "\nMedicine Name : " + read[1].ToString();
                txt_details.Text += "\nGroup Name : " + read[2].ToString();
                txt_details.Text += "\nCompany Name : " + read[3].ToString();
               
                txt_details.Text += "\nPurchase price : " + read[5].ToString();
               
                txt_details.Text += "\nSale Price: " + read[6].ToString();
                txt_details.Text += "\nStorage Advice : " + read[7].ToString();
                txt_details.Text += "\nManufacturer Country: " + read[8].ToString();
                txt_details.Text += "\nSupplier Name: " + read[9].ToString();
                txt_details.Text += "\nMobile Number: " + read[10].ToString();
            }
            sqlcon.Close();
        }
    }
}
