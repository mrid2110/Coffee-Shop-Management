using CoffeeShop.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business_Logic_Layer
{
    public class EmployeeService
    {
        EmployeeDataAccess eda;

        public EmployeeService()
        {
            eda = new EmployeeDataAccess();
        }

        public int AddEmployee(string name, string pass, string dob, string address, string phone, string bloodgroup, string designation)
        {
            Employee e = new Employee() { EName = name, Password=pass, DOB = dob, Address = address, Phone = phone, BloodGroup = bloodgroup, Designation = designation };
            return eda.AddEmployee(e);
        }

        public int DeleteEmployee(int id)
        {
            return eda.DeleteEmployee(id);
        }

        public int EditEmployee(int id, string en, string dob, string ad, string p, string bg, string password)
        {
            return eda.EditEmployee(id, en, dob, ad, p, bg, password);
        }
    }
}
