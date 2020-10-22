using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    class DataAccess
    {
        SqlConnection con;
        SqlCommand command;
        public DataAccess()
        {
            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["CoffeeShop"].ConnectionString);
            this.con.Open();
        }

        public SqlDataReader GetData(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteReader();
        }

        public int Execute(string sql)
        {
            command = new SqlCommand(sql, con);
            return command.ExecuteNonQuery();
        }
    }
}
