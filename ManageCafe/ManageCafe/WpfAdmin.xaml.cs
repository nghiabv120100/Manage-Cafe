using ManageCafe.DAO;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for WpfAdmin.xaml
    /// </summary>
    public partial class WpfAdmin : Window
    {
        public WpfAdmin()
        {
            InitializeComponent();
            DisplayData();
        }
        private void DisplayData()
        {
            string query = "Exec dbo.GetAccount @username=N'K9'";
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            lsvAccount.ItemsSource = data.DefaultView;
        }
    }
}
