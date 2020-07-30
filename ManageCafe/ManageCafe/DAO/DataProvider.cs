using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ManageCafe.DAO
{
    public class DataProvider
    {
        string strConn = "Data Source=(local);Initial Catalog=ManageCafe;Integrated Security=True";
        private static DataProvider instance;

        public static DataProvider Instance 
        {
            get 
            { 
                if (instance == null)
                    instance = new DataProvider();
                return instance;
            }
            private set => instance = value; 
        }
        private DataProvider()
        { }
        public  DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            
            adapter.Fill(table);
            
            conn.Close();
            return table;

        }
        


    }
}
