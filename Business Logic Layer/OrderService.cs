using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business_Logic_Layer
{
    public class OrderService
    {
        OrderDataAccess oda;
        public OrderService()
        {
            oda = new OrderDataAccess();
        }

        public int AddOrder(string ename, int id, int t, string month)
        {
            Order o = new Order() { EName = ename, EId = id, Total = t, Month=month };
            return oda.AddOrder(o);
        }

        public int DeleteOrder(int dorder)
        {
            return oda.DeleteOrder(dorder);
        }

        public List<Order> GetOrderData()
        {
            return oda.GetOrderData();
        }
    }
}
