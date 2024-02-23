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
    public class OrderCrud : ICrud<Order>
    {
         DataContext db=new DataContext();
        public bool Add(Order entity)
        {
            throw new NotImplementedException();

        }
        public bool AddByEmployeeId(Order entity, int employeeId)
        {
            entity.OrderPrepareTime = DateTime.Now;
            entity.EmployeeId = employeeId;
            
            db.Orders.Add(entity);
            db.SaveChanges();
            return true;
        }
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity, int id)
        {
            Order order= db.Orders.Find(entity.Id);
            order.EmployeeId = entity.Id;
            order.TotalPrice = entity.TotalPrice;
            order.IsTakeAway = entity.IsTakeAway;
            order.OrderPrepareTime= DateTime.Now;
            order.EmployeeId =Login.employeeId;
            order.IsDelete = entity.IsDelete;
            db.SaveChanges();
            return true;
        }
    }
}
