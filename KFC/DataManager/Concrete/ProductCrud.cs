using KFC.Context;
using KFC.Model;
using System.Collections.Generic;
using System.Linq;

namespace KFC.DataManager.Concrete
{
    public class ProductCrud
    {
        private readonly DataContext db;

        public ProductCrud()
        {
            db = new DataContext();
        }

        public List<Product> GetAll(int categoryId)
        {
            if (categoryId > 0)
            {
                return db.Products.Where(x => x.CategoryId == categoryId).ToList();
            }
            else
            {
                return db.Products.ToList();
            }
        }
        public Product GetByTypeId(int typeId)
        {
            return db.Products.FirstOrDefault(p => p.Id == typeId);
        }
    }
}
