using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    class GlobalVriables
    {
        public static string id;
        public static int p = 0;
        public static int x,inventory;
        public static int total(int i)
        {
            p = p + i;
            return p;
        }
    }
}
