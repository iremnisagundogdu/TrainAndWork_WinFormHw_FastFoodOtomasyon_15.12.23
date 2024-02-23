using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
       // Id /  Name / Password /
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public List<Order> OrderList { get; set; }
    }
}
