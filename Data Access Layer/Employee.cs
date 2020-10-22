using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Data_Access_Layer
{
    public class Employee
    {
        public int EId { get; set; }
        public string EName { get; set; }
        public string Password { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string BloodGroup { get; set; }
        public string Designation { get; set; }
        public int OId { get; set; }
    }
}
