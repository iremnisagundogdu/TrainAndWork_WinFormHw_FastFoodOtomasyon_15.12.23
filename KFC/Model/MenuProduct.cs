using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    // ProductMenu - Id / MenuId / ProductId /
    public class MenuProduct
    {
        public int Id { get; set; }
        public int MenuId { get; set; }
        public int ProductId { get; set; }
        public Menu Menu { get; set; }
        public Product Product { get; set; }
    }
}
