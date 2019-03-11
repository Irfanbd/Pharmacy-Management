﻿using System;
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
    }
}
