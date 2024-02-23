using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    // Product - Id / Name / Desc / Price / Stock / SizeId  / Image / Time / CategoryId /
    public class Product
    {
        public int Id { get; set; }
        public int SizeId { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public DateTime PrepareTime { get; set; }
    }
}
