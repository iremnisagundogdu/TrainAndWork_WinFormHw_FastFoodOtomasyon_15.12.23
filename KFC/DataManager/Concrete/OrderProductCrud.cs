using KFC.Context;
using KFC.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC.DataManager.Concrete
{
    
    public class OrderProductCrud
    {
        private readonly DataContext db;

        public OrderProductCrud()
        {
            db = new DataContext();
        }
        public void AddOrderProduct(OrderProduct orderProduct)
        {
            db.OrderProducts.Add(orderProduct);
            db.SaveChanges();


        }
        public List<OrderProduct> GetAllByOrderId(int orderId)
        {
                return db.OrderProducts.Where(x => x.OrderId == orderId).ToList();
        }
        public void DeleteBySelectedId(int productId,int orderId)
        {
            OrderProduct orderProduct=db.OrderProducts.FirstOrDefault(x => x.TypeId == productId && x.OrderId == orderId);
            if (orderProduct!=null)
            {

            db.OrderProducts.Remove(orderProduct); db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Menü İçeriği Silinemez İşlem iptal edilmelidir.");
            }
        }
        public void DeleteAll(int orderId)
        {
            List<OrderProduct> orderProduct = db.OrderProducts.Where(x =>x.OrderId == orderId).ToList();
            if (orderProduct != null)
            {
                db.OrderProducts.RemoveRange(orderProduct); db.SaveChanges();
            }
        }
    }
}
