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
    internal class SizeCrud : ICrud<Size>
    {
        DataContext db =new DataContext();
        public bool Add(Size entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Size> GetAll()
        {
            return db.Sizes.ToList();
        }

        public Size GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Size entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
