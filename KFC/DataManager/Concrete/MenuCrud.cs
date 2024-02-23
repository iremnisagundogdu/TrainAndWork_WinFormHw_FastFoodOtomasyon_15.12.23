using KFC.Context;
using KFC.Model;
using System.Collections.Generic;
using System.Linq;

namespace KFC.DataManager.Concrete
{
    public class MenuCrud
    {
        private readonly DataContext db;

        public MenuCrud()
        {
            db = new DataContext();
        }

        public List<Menu> GetAll()
        {
            return db.Menus.ToList();
        }
        public List<Product> GetByTypeId(int typeId)
        {
            var menuProducts=db.MenuProducts.Where(x=>x.MenuId == typeId).ToList();
            List<Product> products = new List<Product>();

            foreach (var item in  menuProducts)
            {
                Product product=db.Products.Where(x => x.Id == item.ProductId).FirstOrDefault();
                products.Add(product);
            }
            return products;
        }
        }
    }
