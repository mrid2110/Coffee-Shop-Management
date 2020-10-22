using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class MenuDataAccess
    {
        DataAccess da;
        public MenuDataAccess()
        {
            da = new DataAccess();
        }

        public List<ItemMenu> GetMenuData()
        {
            string sql = "SELECT * FROM Menu;";
            SqlDataReader reader = da.GetData(sql);
            List<ItemMenu> list = new List<ItemMenu>();
            while (reader.Read())
            {
                ItemMenu m = new ItemMenu();
                m.IId = (int)reader["IId"];
                m.ItemName = reader["ItemName"].ToString();
                m.Quantity = reader["Quantity"].ToString();
                m.Price = reader["Price"].ToString();
                list.Add(m);
            }
            return list;
        }

        public List<string> GetMenuName()
        {
            string sql = "SELECT DISTINCT ItemName FROM Menu;";
            SqlDataReader reader = da.GetData(sql);
            List<string> list = new List<string>();
            while (reader.Read())
            {
                string str = reader["ItemName"].ToString();
                list.Add(str);
            }
            return list;
        }

        public int AddMenu(ItemMenu m)
        {
            string sql = "INSERT INTO Menu(ItemName,Quantity,Price) VALUES('" + m.ItemName + "','" + m.Quantity + "','" + m.Price + "')";
            return da.Execute(sql);
        }

        public int DeleteMenu(int dm)
        {
            string sql = "DELETE FROM Menu WHERE IId='" + dm + "';";
            return da.Execute(sql);
        }

        public int EditMenu(int id, string iname, string q, string p)
        {
            string sql = "UPDATE Menu SET ItemName='" + iname + "' , Quantity='" + q + "',Price='" + p + "' WHERE IId='" + id + "'";
            return da.Execute(sql);
        }
    }
}
