using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class OrderDataAccess
    {
        DataAccess da;
        public OrderDataAccess()
        {
            da = new DataAccess();
        }

        public List<Order> GetOrderData()
        {
            string sql = "SELECT * FROM OrderList;";
            SqlDataReader reader = da.GetData(sql);
            List<Order> list = new List<Order>();
            while (reader.Read())
            {
                Order o = new Order();
                o.OId = (int)reader["OId"];
                o.EName = reader["EName"].ToString();
                o.EId = (int)reader["EId"];
                o.Total = (int)reader["Total"];
                o.Month = reader["Month"].ToString();
                list.Add(o);
            }
            return list;
        }


        public int AddOrder(Order o)
        {
            string sql = "INSERT INTO OrderList(EName,EId,Total,Month) VALUES('" + o.EName + "','" + o.EId + "','" + o.Total + "','"+o.Month+"')";
            return da.Execute(sql);
        }

        public int DeleteOrder(int dorder)
        {
            string sql = "DELETE FROM OrderList WHERE OId='" + dorder + "';";
            return da.Execute(sql);
        }
    }
}
