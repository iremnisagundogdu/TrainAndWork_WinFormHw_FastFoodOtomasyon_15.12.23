using KFCKitchen.Model;
using KFCKitchen.TCP;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace KFCKitchen
{
    public partial class Form1 : Form
    {
        System.Windows.Forms.Button ButtonCard;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TCPConnection.JsonGetData(this);

            if (TCPConnection.currentOrdersFromTcp.Count != 0)
            {
                orderCards();
            }
        }
        public void orderCards()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int x = 15;
            int step = 220;
            int panelWidth = panel1.Width - xStart;
            int ItemGbCount = (panelWidth - ((panelWidth - xStart) % step)) / step;
            foreach (var order in TCPConnection.currentOrdersFromTcp)
            {
                if (i == ItemGbCount)
                {
                    yStart += 160;
                    i = 0;
                }

                ButtonCard = new System.Windows.Forms.Button()
                {
                    Name = $"OrderGb_{order.OrderId}",
                    Size = new Size(200, 150),
                    BackColor = Color.White,
                    FlatStyle = FlatStyle.Popup,
                    Location = new Point(xStart + (step * i), yStart)
                };
                Label User = new Label()
                {
                    Name = $"Product_{order.OrderId}",
                    Text = $" {order.OrderId} - {order.EmployeeName}",
                    Location = new Point(5, 130),
                    Size = new System.Drawing.Size(140, 15),
                    Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                };
                string statu;
                if (!order.IsReady)
                {
                    statu = "Hazırlanıyor";
                }
                else
                {
                    statu = "Hazır";
                }

                foreach (var product in order.ProductList)
                {
                    ButtonCard.Controls.Add(new Label()
                    {
                        Name = $"Product_{product.Id}",
                        Text = $" {product.Name} - {product.Price}",
                        Location = new Point(5, 5 + x),
                        Size = new System.Drawing.Size(185, 15),
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                    });
                    x += 15;
                }
                ButtonCard.Controls.Add(User);
                ButtonCard.Click += ButtonCard_Click;

                foreach (Control control in ButtonCard.Controls)
                {
                    if (control is Label)
                    {
                        control.Enabled = false;
                    }
                }
                panel1.Controls.Add(ButtonCard);
                x = 15;
                i++;
            }
        }


        private void ButtonCard_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;

            if (btn.BackColor != Color.Yellow)
            {
                List<CurrentOrder> currentOrderList = new List<CurrentOrder>();
                btn.BackColor = Color.Yellow;
                int orderId = Convert.ToInt32(btn.Name.Split('_')[1]);
                CurrentOrder selectedOrder = TCPConnection.currentOrdersFromTcp.FirstOrDefault(x => x.OrderId == orderId);
                selectedOrder.IsReady = false;
                currentOrderList.Add(selectedOrder);
                TCPConnection.TcpSendData(currentOrderList);


                Label label = new Label()
                {
                    Text = "Hazırlanıyor",
                    Location = new Point(120, 120),
                    Size = new System.Drawing.Size(70, 15),
                    Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                };
                btn.Controls.Add(label);



                orderCards();
            }
            else
            {
                List<CurrentOrder> currentOrderList = new List<CurrentOrder>();
                btn.BackColor = Color.Red;
                panel1.Controls.Remove(btn);
                int orderId = Convert.ToInt32(btn.Name.Split('_')[1]);
                CurrentOrder selectedOrder = TCPConnection.currentOrdersFromTcp.FirstOrDefault(x => x.OrderId == orderId);
                selectedOrder.IsReady = true;
                object tagObject = ((Button)sender).Tag;
                currentOrderList.Add(selectedOrder);
                TCPConnection.TcpSendData(currentOrderList);
                panel1.Controls.Remove(btn);
                TCPConnection.currentOrdersFromTcp.Remove(selectedOrder);
                panel1.Controls.Clear();
                orderCards();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (TCPConnection.currentOrdersFromTcp.Count != 0)
            {
                orderCards();
            }
        }
    }
}
