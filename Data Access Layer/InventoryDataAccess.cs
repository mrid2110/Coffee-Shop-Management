using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class InventoryDataAccess
    {
        DataAccess da;
        public InventoryDataAccess()
        {
            da = new DataAccess();
        }

        public List<Inventory> GetInventoryData()
        {
            da = new DataAccess();
            string sql = "SELECT * FROM Inventories;";
            SqlDataReader reader = da.GetData(sql);
            List<Inventory> list = new List<Inventory>();
            while (reader.Read())
            {
                Inventory i = new Inventory();
                i.InventoryId = (int)reader["InventoryId"];
                i.InventoryName = reader["InventoryName"].ToString();
                i.Amount = (int)reader["Amount"];
                i.Month = reader["Month"].ToString();
                i.Price = (int)reader["Price"];
                list.Add(i);
            }
            return list;
        }

        public int AddInventory(Inventory i)
        {
            da = new DataAccess();
            string sql = "INSERT INTO Inventories(InventoryName,Amount,Month,Price) VALUES('" + i.InventoryName + "','"+i.Amount+"','" + i.Month + "','"+i.Price+"')";
            return da.Execute(sql);
        }

        public int DeleteInventory(int id)
        {
            da = new DataAccess();
            string sql = "DELETE FROM Inventories WHERE InventoryId='" + id + "';";
            return da.Execute(sql);
        }

        public int EditInventory(int id, string n, int amount, string month, int price)
        {
            da = new DataAccess();
            string sql = "UPDATE Inventories SET InventoryName='" + n + "' , Amount='" + amount + "',Month='" + month + "',Price='" + price + "' WHERE InventoryId='" + id + "'";
            return da.Execute(sql);
        }

        public int SubInventory(int id, int amount)
        {
            da = new DataAccess();
            string sql = "UPDATE Inventories SET  Amount='" + amount + "' WHERE InventoryId='" + id + "'";
            return da.Execute(sql);
        }

        public int AdInventory(int id, int amount,int p)
        {
            da = new DataAccess();
            string sql = "UPDATE Inventories SET  Amount='" + amount + "', Price='"+p+"' WHERE InventoryId='" + id + "'";
            return da.Execute(sql);
        }

        public List<string> GetInventoryName()
        {
            da = new DataAccess();
            string sql = "SELECT InventoryName FROM Inventories;";
            SqlDataReader reader = da.GetData(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string str = reader["InventoryName"].ToString();
                list.Add(str);
            }
            return list;
        }
    }
}
