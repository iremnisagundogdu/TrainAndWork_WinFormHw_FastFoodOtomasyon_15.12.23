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
    public class EmployeeCrud : ICrud<Employee>
    {
        DataContext db = new DataContext();
        public bool Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return db.Employees.FirstOrDefault(x => x.Id == id);
        }

        public bool Update(Employee entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
