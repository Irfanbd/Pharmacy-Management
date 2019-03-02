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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace PhMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void wxit_btn(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    System.Environment.Exit(0);
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Are you sure?", "Exit");
                    break;


            }
        }

        private void admin_btn(object sender, RoutedEventArgs e)
        {
            Dashboard bw = new Dashboard();
            bw.Show();
        }

        private void Staff_btn_Click(object sender, RoutedEventArgs e)
        {
            Dashboard bw = new Dashboard();
            bw.Show();
        }

        private void time(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();
        }
        private int increment = 0;
        private void dtTicker(object sender,EventArgs e )
        {
            increment++;
            timer.Content = increment.ToString();
        }
    }
}
