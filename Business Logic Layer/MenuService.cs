using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business_Logic_Layer
{
    public class MenuService
    {
        MenuDataAccess mda;
        public MenuService()
        {
            mda = new MenuDataAccess();
        }

        public int AddMenu(string iname, string q, string p)
        {
            ItemMenu m = new ItemMenu() { ItemName = iname, Quantity = q, Price = p };
            return mda.AddMenu(m);
        }

        public int DeleteMenu(int id)
        {
            return mda.DeleteMenu(id);
        }

        public int EditMenu(int id,string iname,string q,string p)
        {
            return mda.EditMenu(id,iname,q,p);
        }

        public List<string> GetMenuName()
        {
            return mda.GetMenuName();
        }
    }
}
