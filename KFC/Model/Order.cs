using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    // Id / EmployeeId  / TotalPrice / IsStatus / IsDelete / OrderPrepareTime /
    public class Order
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderPrepareTime { get; set; } 
        public double TotalPrice { get; set; } 
        public bool IsStatus { get; set; } = true;
        public bool IsDelete { get; set; }
        public bool IsTakeAway { get; set; }
        public List<OrderProduct> OrderProductList { get; set; }
    }
}
