using ManageCafe.DAO;
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

namespace ManageCafe
{
    /// <summary>
    /// Interaction logic for WpfLogin.xaml
    /// </summary>
    public partial class WpfLogin : Window
    {
        public WpfLogin()
        {
            InitializeComponent();
            txtUsername.Text = "K9";
            txtPassword.Text = "1";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (Login(username,password))
            {
                WpfMain wpf = new WpfMain();
                this.Hide();
                wpf.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("User name or password incorrect");
            }
            

        }
        private bool Login(string username,string password)
        {
            return AccountDAO.Instance.Login(username,password);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result;
            result=MessageBox.Show("Are you sure you want to exit ?","Warning",MessageBoxButton.YesNoCancel);
            if (result != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }    
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            {
                Button_Click(sender, e);
            }
            if(e.Key==Key.Escape)
            {
                Button_Click_1(sender, e);
            }
        }
    }
}
