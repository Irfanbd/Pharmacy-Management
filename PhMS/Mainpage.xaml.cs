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
    /// Interaction logic for Mainpage.xaml
    /// </summary>
    public partial class Mainpage : Window
    {
        public Mainpage()
        {
            InitializeComponent();
        }

        private void btn_medi(object sender, RoutedEventArgs e)
        {
            Medicine cx = new Medicine();
            cx.Show();
            this.Close();
        }

        private void satffp_btn(object sender, RoutedEventArgs e)
        {
            Staff bx = new Staff();
            bx.Show();
            this.Close();
        }

        private void btn_company(object sender, RoutedEventArgs e)
        {
            Company mx = new Company();
            mx.Show();
            this.Close();
        }
    }
}
