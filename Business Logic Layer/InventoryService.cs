using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business_Logic_Layer
{
    public class InventoryService
    {
        InventoryDataAccess ida;
        public InventoryService()
        {
            ida = new InventoryDataAccess();
        }

        public int AddInventory(string iname, int amount, string month, int p)
        {
            Inventory i = new Inventory() { InventoryName = iname, Amount = amount, Month = month, Price = p };
            return ida.AddInventory(i);
        }

        public int DeleteInventory(int id)
        {
            return ida.DeleteInventory(id);
        }

        public int EditInventory(int id, string iname, int amount, string month, int p)
        {
            return ida.EditInventory(id, iname, amount, month, p);
        }

        public int SubInventory(int id, int amount)
        {
            return ida.SubInventory(id, amount);
        }

        public int AdInventory(int id, int amount,int p)
        {
            return ida.AdInventory(id, amount,p);
        }

        public List<Inventory> GetInventoryData()
        {
            return ida.GetInventoryData();
        }

        public List<string> GetInventoryName()
        {
            return ida.GetInventoryName();
        }
    }
}
