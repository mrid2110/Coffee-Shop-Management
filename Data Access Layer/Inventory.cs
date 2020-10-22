using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class Inventory
    {
        public int InventoryId { set; get; }
        public string InventoryName { set; get; }
        public int Amount { set; get; }
        public string Month { set; get; }
        public int Price { set; get; }
    }
}
