using KFC.Context;
using KFC.DataManager.Interface;
using KFC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.DataManager.Concrete
{
    public class CategoryCrud : ICrud<Category>
    {
        DataContext db = new DataContext();
        public bool Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetById(int id)
        {
            var category = db.Categories.Find(id);
            if (category != null)
            {
                return category;
            }
            return null;
        }

        public bool Update(Category entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
