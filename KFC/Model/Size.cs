using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
        // Size - Id /Name / PriceChanges /
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PriceDifference { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
