using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class ItemMenu
    {
        public int IId { set; get; }
        public string ItemName { set; get; }
        public string Quantity { set; get; }
        public string Price { set; get; }
    }
}
