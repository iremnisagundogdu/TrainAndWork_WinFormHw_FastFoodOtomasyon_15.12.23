using KFC.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.Context
{
    public class DataContext :DbContext
    {
        public DataContext() : base("DbConnection") { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<MenuProduct> MenuProducts { get; set; }
        public DbSet<CurrentOrder> CurrentOrders { get; set; }

    }
}
