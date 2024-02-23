using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Model
{
    //  Menu - Id / Name  / Price /  Image / TotalMenuTime /
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public DateTime TotalMenuTime { get; set; }
        public List<MenuProduct> MenuProductList { get; set; }
    }
}
