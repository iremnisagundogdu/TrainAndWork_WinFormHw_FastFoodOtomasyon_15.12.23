using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFCKitchen.Model
{
    public class CurrentOrder
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string EmployeeName { get; set; }
        public List<Product> ProductList { get; set; }
        public bool IsReady { get; set; }
        public bool IsStatus { get; set; }
    }
}
