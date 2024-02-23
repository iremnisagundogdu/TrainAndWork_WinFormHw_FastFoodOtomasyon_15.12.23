using KFC.DataManager.Concrete;
using KFC.Model;
using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class MainScreen : Form
    {

        OrderProductCrud orderProductCrud = new OrderProductCrud();
        CurrentOrderCrud currentOrderCrud = new CurrentOrderCrud();
        Order order;
        OrderCrud orderCrud = new OrderCrud();
        EmployeeCrud employeeCrud = new EmployeeCrud();
        public static int _SelectedId;
        public static List<Product> productsToOrder;
        public MainScreen()
        {
            InitializeComponent();
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            order = new Order();
            orderCrud.AddByEmployeeId(order, Login.employeeId);
            getOrder(order.Id);
            ChangeSize();
        }
        private void ChangeSize()
        {
            int formHeight = panel1.Height;
            int formWidth = panel1.Width;
            dataGridView1.Size = new System.Drawing.Size(formWidth / 2, formHeight);
            dataGridView1.Location = new Point(0, 0);
            //yukarıdaki butonlar
            burgerBtn_1.Size = new System.Drawing.Size((formWidth / 6) - 40, formHeight / 9);
            burgerBtn_1.Location = new Point((formWidth / 2) + 20, formHeight / 35);
            Souce_3.Size = new System.Drawing.Size((formWidth / 6) - 40, formHeight / 9);
            Souce_3.Location = new Point(((4 * formWidth) / 6) + 30, formHeight / 35);
            productBtn_0.Size = new System.Drawing.Size((formWidth / 6) - 40, formHeight / 9);
            productBtn_0.Location = new Point(((5 * formWidth) / 6) + 30, formHeight / 35);
            Sides_4.Size = new System.Drawing.Size((formWidth / 6) - 40, formHeight / 9);
            Sides_4.Location = new Point((formWidth / 2) + 20, formHeight / 5);
            drink_2.Size = new System.Drawing.Size((formWidth / 6) - 40, formHeight / 9);
            drink_2.Location = new Point(((5 * formWidth) / 6) + 30, formHeight / 5);
            Console.WriteLine(formHeight);
            //Aşağı kısım
            ProductCancel.Size = new System.Drawing.Size((formWidth / 6), formHeight / 5);
            ProductCancel.Location = new Point(formWidth - (formWidth / 6), formHeight / 2);
            OrderCreate.Size = new System.Drawing.Size((formWidth / 6), formHeight / 5);
            OrderCreate.Location = new Point(formWidth - ((2 * formWidth) / 6), (3 * formHeight) / 4);
            OrderCancel.Size = new System.Drawing.Size((formWidth / 6), formHeight / 5);
            OrderCancel.Location = new Point(formWidth - ((3 * formWidth) / 6), formHeight / 2);
            TakeAwayCb.Location = new Point((9 * formWidth) / 10, formHeight - (formHeight / 13));
        }
        public void getOrder(int orderId)
        {
            var orderDetails = orderProductCrud.GetAllByOrderId(orderId);

            List<Product> products = new List<Product>();
            List<OrderDetailViewModel> orderDetailList = new List<OrderDetailViewModel>();
            OrderDetailViewModel orderDetailViewModel;

            foreach (var orderDetail in orderDetails)
            {
                if (orderDetail.Type == "M")
                {
                    var Menuproducts = new MenuCrud().GetByTypeId(orderDetail.TypeId);
                    products.AddRange(Menuproducts);
                }
                else if (orderDetail.Type == "P")
                {
                    var product = new ProductCrud().GetByTypeId(orderDetail.TypeId);
                    products.Add(product);
                }
            }
            foreach (var item in products)
            {
                orderDetailViewModel = new OrderDetailViewModel();
                orderDetailViewModel.Name = item.Name;
                orderDetailViewModel.Price = item.Price;
                orderDetailViewModel.Quantity = 1;
                orderDetailList.Add(orderDetailViewModel);
            }
            productsToOrder = products;
            dataGridView1.DataSource = orderDetailList;
        }

        private void MainScreen_SizeChanged(object sender, EventArgs e)
        {
            ChangeSize();
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void MainScreen_Activated(object sender, EventArgs e)
        {
            if (order != null)
            {
                getOrder(order.Id);
            }
        }
        private void getProductsByCategory(object sender)
        {
            Button btn = (Button)sender;
            int id = Convert.ToInt32(btn.Name.Split('_')[1]);
            ProductForm productForm = new ProductForm(id, order.Id);
            productForm.Show();
            //this.Hide();
        }
        private void burgerBtn_1_Click(object sender, EventArgs e)
        {
            getProductsByCategory(sender);
        }

        private void Souce_3_Click(object sender, EventArgs e)
        {
            getProductsByCategory(sender);
        }

        private void productBtn_0_Click(object sender, EventArgs e)
        {
            getProductsByCategory(sender);
        }

        private void Sides_4_Click(object sender, EventArgs e)
        {
            getProductsByCategory(sender);
        }

        private void drink_2_Click(object sender, EventArgs e)
        {
            getProductsByCategory(sender);
        }

        private void ProductCancel_Click(object sender, EventArgs e)
        {
            if (_SelectedId != null && order != null)
            {
                orderProductCrud.DeleteBySelectedId(_SelectedId, order.Id);
                getOrder(order.Id);
            }
        }

        private void OrderCancel_Click(object sender, EventArgs e)
        {
            if (order != null)
            {
                orderProductCrud.DeleteAll(order.Id);
                getOrder(order.Id);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _SelectedId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        }

        private void OrderCreate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows != null && dataGridView1.Rows.Count > 0)
            {
                List<CurrentOrder> currentOrderList = new List<CurrentOrder>();
                order.IsStatus = false;
                if (TakeAwayCb.Checked)
                {
                    order.IsTakeAway = true;
                }
                orderCrud.Update(order, order.Id);
                CurrentOrder currentOrder = new CurrentOrder();
                currentOrder.OrderId = order.Id;
                currentOrder.IsReady = false;
                currentOrder.EmployeeName = employeeCrud.GetById(Login.employeeId).Name;
                currentOrder.ProductList = productsToOrder;
                order = new Order();
                orderCrud.AddByEmployeeId(order, Login.employeeId);
                getOrder(order.Id);
                TakeAwayCb.Checked = false;


                currentOrderList.Add(currentOrder);
                TCPConnection.TcpSendData(currentOrderList);
            }
            else
            {
                MessageBox.Show("Lütfen ürün Ekleyiniz");
            }
        }
    }
}


