using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get
            {
                if (instance==null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private AccountDAO() { }
        
        public bool Login(string username,string password)
        {
            string query = $"Exec USP_Login @username=N'{username}' , @password=N'{password}'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            return table.Rows.Count>0;
        }
    }
}
