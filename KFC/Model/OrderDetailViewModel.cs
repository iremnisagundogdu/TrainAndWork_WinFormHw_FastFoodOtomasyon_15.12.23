using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    internal class OrderDetailViewModel
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
