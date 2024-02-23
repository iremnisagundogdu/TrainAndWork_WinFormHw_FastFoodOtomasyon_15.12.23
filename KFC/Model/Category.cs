using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
        // Category - Id / Name / 
    public class Category
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public List<Product> ProductList { get; set; }

    }
}
