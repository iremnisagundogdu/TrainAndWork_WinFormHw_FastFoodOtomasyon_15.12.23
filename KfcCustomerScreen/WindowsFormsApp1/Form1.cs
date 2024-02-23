using KFCKitchen.Model;
using KFCKitchen.TCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomerScreenForm : Form
    {
        System.Windows.Forms.Button ButtonCard;

        public CustomerScreenForm()
        {
            InitializeComponent();
        }

        private void CustomerScreenForm_Load(object sender, EventArgs e)
        {
            TCPConnection.JsonGetData(this);
            orderCards();
        }
        private void CustomerScreenForm_SizeChanged(object sender, EventArgs e)
        {
            int windowWidth = panel1.Width;
            int panel1Height = panel1.Height;

            int label1Width = label1.Width;
            int label2Width = label2.Width;
            int panelHazırlanıyorWidth = panelHazırlanıyor.Width;
            int panelHazırWidth = panelHazır.Width;

            int label1x = ((windowWidth / 4) - label1Width / 2);
            int label2x = ((3 * windowWidth / 4) - label2Width / 2);

            label1.Location = new Point(label1x, 20);
            label2.Location = new Point(label2x, 20);
            pictureBox2.Size = new Size(3 * windowWidth / 10, 3 * windowWidth / 10);

            int panel2loca = panel2.Location.Y;
            int kfcPictureHeight = pictureBox1.Height;
            pictureBox1.Location = new Point(40, panel2loca - 20 - kfcPictureHeight);

            int burgerPictureWidth = pictureBox2.Width;
            int burgerPictureHeight = pictureBox2.Height;
            pictureBox2.Location = new Point(windowWidth - 40 - burgerPictureWidth, panel2loca - 20 - burgerPictureHeight);

            panelHazırlanıyor.Location = new Point(windowWidth / 4 - panelHazırlanıyorWidth / 2, panel1Height);
            panelHazır.Location = new Point((3 * windowWidth / 4) - panelHazırlanıyorWidth / 2, panel1Height);

        }

        private void CustomerScreenForm_Activated(object sender, EventArgs e)
        {
            if (TCPConnection.currentOrdersFromTcp.Count != 0)
            {
                loop1();
                orderCards();
            }
        }


        List<int> dynamicRight = new List<int>();
        List<int> dynamicLeft = new List<int>();



        public void loop1()
        {

            int aifdi = 0;

            foreach (var order in TCPConnection.currentOrdersFromTcp)
            {
                if (order.IsReady == false)
                {
                    dynamicLeft.Add(order.OrderId);
                }
            }


            foreach (var order in dynamicLeft)
            {
                CurrentOrder currentOrder = TCPConnection.currentOrdersFromTcp.FirstOrDefault(x => x.OrderId == order);

                if (currentOrder != null && currentOrder.IsReady == false)
                {
                    aifdi = order;
                    dynamicRight.Add(order);
                }
            }
            dynamicLeft.Remove(aifdi);
            TCPConnection.currentOrdersFromTcp.Clear();

        }




        public void orderCards()
        {
            int xStart = 20;
            int yStart = 20;
            int y1Start = 20;

            Label label1;
            Label label2;

            panelHazır.Controls.Clear();

            foreach (var order in dynamicLeft)
            {
                label1 = new Label()
                {
                    Name = $"Product_{order}",
                    Text = $"{order}",
                    Location = new Point(xStart, yStart),
                    Size = new System.Drawing.Size(50, 15),
                    Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                };
                yStart += 30;
                panelHazır.Controls.Add(label1);
            }

            panelHazırlanıyor.Controls.Clear();

            foreach (var order in dynamicRight)
            {
                label2 = new Label()
                {
                    Name = $"Product_{order}",
                    Text = $"{order}",
                    Location = new Point(xStart, y1Start),
                    Size = new System.Drawing.Size(50, 15),
                    Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                };
                y1Start += 30;
                panelHazırlanıyor.Controls.Add(label2);
            }



            //if (ısActive && order.IsReady)
            //{
            //    label1 = new Label()
            //    {
            //        Name = $"Product_{order.Id}",
            //        Text = $"{order.OrderId}",
            //        Location = new Point(xStart, yStart),
            //        Size = new System.Drawing.Size(50, 15),
            //        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
            //    };
            //    yStart += 30;
            //    panelHazır.Controls.Add(label1);
            //}
            //else
            //{
            //    label2 = new Label()
            //    {
            //        Name = $"Product_{order.Id}",
            //        Text = $"{order.OrderId}",
            //        Location = new Point(xStart, y1Start),
            //        Size = new System.Drawing.Size(50, 15),
            //        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
            //    };
            //    y1Start += 30;
            //    dynamicArray.Add(order.OrderId);
            //    panelHazırlanıyor.Controls.Add(label2);
            //}

        }
    }
}
