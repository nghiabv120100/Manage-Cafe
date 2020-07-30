using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ManageCafe.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance 
        { 
            get
            {
                if (instance==null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
            private set => instance = value; 
        }
        private TableDAO() { }

        public DataTable GetDataTable()
        {
            string query = "Select * from dbo.TableFood";
            DataTable data = new DataTable();
            return DataProvider.Instance.ExecuteQuery(query);

        }
    }
}
