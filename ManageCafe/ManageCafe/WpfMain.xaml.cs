using ManageCafe.DAO;
using ManageCafe.DTO;
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
    /// Interaction logic for WpfMainr.xaml
    /// </summary>
    public partial class WpfMain : Window
    {
        public WpfMain()
        {
            InitializeComponent();
            LoadTableFood();
        }
        #region ToolUpDown
        private int _numValue = 0;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }

        public void NumberUpDown()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }

        #endregion

        #region Method
        private void LoadTableFood()
        {
            List<TableFood> lstTable = new List<TableFood>();
            DataTable dataTable = new DataTable();
            dataTable = TableDAO.Instance.GetDataTable();
            foreach (DataRow item in dataTable.Rows)
            {
                TableFood tableFood = new TableFood(item);
                lstTable.Add(tableFood);
                string status = (tableFood.Status == 1) ? "Occupied" : "Unoccupied";
                Button btn = new Button() { Width = 100, Height = 100,Content=tableFood.Name + "\n" + status };
                pnlTable.Children.Add(btn);
            }

        }
        #endregion

        #region Event
        private void mnuProfile_Click(object sender, RoutedEventArgs e)
        {
            WpfProfileAccount wpf = new WpfProfileAccount();
            wpf.Show();
        }

        private void mnuAdmin_Click(object sender, RoutedEventArgs e)
        {
            WpfAdmin wpf = new WpfAdmin();
            wpf.Show();
        }
        #endregion

    }
}
