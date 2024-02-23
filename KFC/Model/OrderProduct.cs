using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    // OrderProduct - Id / OrderId / TypeId / Quantity / Type
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int TypeId { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
    }
}
