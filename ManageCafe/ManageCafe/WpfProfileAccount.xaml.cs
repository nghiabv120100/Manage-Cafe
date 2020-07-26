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
    /// Interaction logic for WpfProfileAccount.xaml
    /// </summary>
    public partial class WpfProfileAccount : Window
    {
        public WpfProfileAccount()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            {
                btnUpdate_Click(sender, e);
            }
            if(e.Key==Key.Escape)
            {
                btnExit_Click(sender, e);
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
