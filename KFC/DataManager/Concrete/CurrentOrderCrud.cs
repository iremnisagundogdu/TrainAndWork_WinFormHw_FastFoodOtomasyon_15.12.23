using KFC.Context;
using KFC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KFC.DataManager.Concrete
{
    public class CurrentOrderCrud
    {
        DataContext db =new DataContext();
        public void Add(CurrentOrder order) { 
            db.CurrentOrders.Add(order);
            db.SaveChanges();
                }
        public List<CurrentOrder> GetAll(int orderId)
        {
            return db.CurrentOrders.Where(x=> x.OrderId==orderId).ToList();
        }
    }
}
