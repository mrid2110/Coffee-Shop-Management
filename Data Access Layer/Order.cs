using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class Order
    {
        public int OId { set; get; }
        public string EName { set; get; }
        public int EId { set; get; }
        public int Total { set; get; }
        public string Month { set; get; }
    }
}
