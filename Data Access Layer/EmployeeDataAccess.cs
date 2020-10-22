using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class EmployeeDataAccess
    {
        DataAccess da;
        public EmployeeDataAccess()
        {
            da = new DataAccess();
        }

        public List<Employee> GetEmployeeData()
        {
            string sql = "SELECT * FROM Employees;";
            SqlDataReader reader = da.GetData(sql);
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                Employee e = new Employee();
                e.EId = (int)reader["EId"];
                e.EName = reader["EName"].ToString();
                e.Password = reader["Password"].ToString();
                e.DOB = reader["DOB"].ToString();
                e.Address = reader["Address"].ToString();
                e.Phone = reader["Phone"].ToString();
                e.BloodGroup = reader["BloodGroup"].ToString();
                e.Designation = reader["Designation"].ToString();
                list.Add(e);
            }
            return list;
        }

        public int AddEmployee(Employee e)
        {
            string sql = "INSERT INTO Employees(EName,Password,DOB,Address,Phone,BloodGroup,Designation) VALUES('" + e.EName + "','" + e.Password + "','" + e.DOB + "','" + e.Address + "','" + e.Phone + "','" + e.BloodGroup + "','"+e.Designation+"')";
            return da.Execute(sql);
        }

        public int DeleteEmployee(int de)
        {
            string sql = "DELETE FROM Employees WHERE EId='" + de + "';";
            return da.Execute(sql);
        }

        public int EditEmployee(int id, string en, string dob, string ad, string p, string bg, string password)
        {
            string sql = "UPDATE Employees SET EName='" + en + "' , DOB='" + dob + "',Address='" + ad + "',Phone='"+p+"',BloodGroup='"+bg+"',Password='"+ password + "' WHERE EId='" + id + "'";
            return da.Execute(sql);
        }
    }
}
