using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCafe.DTO
{
    public class TableFood
    {
        private int iD;
        private string name;
        private int status; //0 unoccupied, 1 Occupied

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
        public int Status { get => status; set => status = value; }

        public TableFood(int iD,string name,int status)
        {
            this.ID = iD;
            this.Name = name;
            this.Status = status;
        }
        public TableFood(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = (string)row["Name"];
            this.Status = (int)row["Status"];
        }

    }
}
