using KFC.DataManager.Concrete;
using KFC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private readonly ProductCrud productCrud = new ProductCrud();
        private readonly OrderProductCrud orderProductCrud = new OrderProductCrud();
        private readonly MenuCrud menuCrud = new MenuCrud();
        private readonly SizeCrud sizeCrud = new SizeCrud();
        private GroupBox ItemGb;
        private PictureBox ItemImgPB;
        private Label ItemLbl;
        private Label PriceLbl;
        private ComboBox ComboBoxPr;
        private Button ItemDetailBtn;
        private int _categoryId;
        private int _orderId;
        private string folder;
        public ProductForm(int categoryId, int orderId)
        {
            InitializeComponent();
            this._categoryId = categoryId;
            this._orderId = orderId;
        }
        private void _headerCenter()
        {
            int formWidth = (panel1.Width / 2) - (product_lbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (product_lbl.Height / 2);
            product_lbl.Location = new Point(formWidth, formHeight);
        }
        private void ItemDetailBtn_Click1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] name = btn.Name.Split('_');
            int typeId = Convert.ToInt32(name[1]);
            string type = _categoryId == 1 ? "M" : "P";
            OrderProduct orderProduct = new OrderProduct()
            {
                TypeId = typeId,
                Type = type,
                Quantity = 1,
                OrderId = _orderId,

            };
            orderProductCrud.AddOrderProduct(orderProduct);

        }
        public void ItemListingIntoPanel(int categoryId)
        {
            folder = (categoryId == 1) ? "menuImages" : "productImage";

            var products = productCrud.GetAll(categoryId);
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int step = 170;
            int panelWidth = panel2.Width - xStart;
            int ItemGbCount = (panelWidth - ((panelWidth - xStart) % step)) / step;
            string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "KFC-MAIN", "KFC", "Resources", folder);

            if (categoryId == 1)
            {
                var menus = menuCrud.GetAll();
                foreach (var product in menus)
                {
                    if (i == ItemGbCount)
                    {
                        yStart += step + 130;
                        i = 0;
                    }

                    ItemGb = new GroupBox()
                    {
                        Name = $"UserGb_{product.Id}",
                        Text = product.Name,
                        Size = new System.Drawing.Size(150, 325),
                        BackColor = Color.White,
                        Location = new Point(xStart + (step * i), yStart)
                    };

                    ItemImgPB = new PictureBox()
                    {
                        Name = $"ItemImgPB_{product.Id}",
                        ImageLocation = Path.Combine(FilePath, product.Image),
                        Size = new System.Drawing.Size(120, 100),
                        Location = new Point(15, 25),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    ItemLbl = new Label()
                    {
                        Name = $"ItemName_{product.Id}",
                        Text = $"Item Adı: {product.Name}",
                        Location = new Point(15, 130),
                        Size = new System.Drawing.Size(115, 50),
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                    };

                    PriceLbl = new Label()
                    {
                        Name = $"ItemPrice_{product.Id}",
                        Text = $"Fiyat: {product.Price}",
                        Location = new Point(15, 180),
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                    };

                    ComboBoxPr = new ComboBox()
                    {
                        Name = $"ItemCategory_{product.Id}",
                        Location = new Point(15, 250),
                        DataSource = sizeCrud.GetAll(),
                        DisplayMember = "Name",
                        ValueMember = "Id"
                    };

                    ItemDetailBtn = new Button()
                    {
                        Name = $"ItemDetailBn_{product.Id}",
                        Text = "Sepete Ekle",
                        Location = new Point(15, 275),
                        Size = new System.Drawing.Size(120, 40),
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.DarkOliveGreen,
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 162),
                        Enabled = true,
                    };
                    ItemDetailBtn.Click += ItemDetailBtn_Click;
                    ItemGb.Controls.Add(ComboBoxPr);
                    ItemGb.Controls.Add(PriceLbl);
                    ItemGb.Controls.Add(ItemLbl);
                    ItemGb.Controls.Add(ItemDetailBtn);
                    ItemGb.Controls.Add(ItemImgPB);
                    panel2.Controls.Add(ItemGb);

                    i++;
                }
            }
            else
            {
                foreach (var product in products)
                {
                    if (i == ItemGbCount)
                    {
                        yStart += step + 130;
                        i = 0;
                    }

                    ItemGb = new GroupBox()
                    {
                        Name = $"UserGb_{product.Id}",
                        Text = product.Name,
                        Size = new System.Drawing.Size(150, 325),
                        BackColor = Color.White,
                        Location = new Point(xStart + (step * i), yStart)
                    };

                    ItemImgPB = new PictureBox()
                    {
                        Name = $"UserImgPB_{product.Id}",
                        ImageLocation = Path.Combine(FilePath, product.Image),
                        Size = new System.Drawing.Size(120, 100),
                        Location = new Point(15, 25),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    ItemLbl = new Label()
                    {
                        Name = $"UserName_{product.Id}",
                        Text = $"Ürün Adı: {product.Name}",
                        Location = new Point(15, 130),
                        Size = new System.Drawing.Size(115, 50),
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                    };

                    PriceLbl = new Label()
                    {
                        Name = $"UserPrice_{product.Id}",
                        Text = $"Fiyat: {product.Price}",
                        Location = new Point(15, 180),
                        Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 162)
                    };

                    ComboBoxPr = new ComboBox()
                    {
                        Name = $"ProductCategory_{product.Id}",
                        Location = new Point(15, 250),
                        DataSource = sizeCrud.GetAll(),
                        DisplayMember = "Name",
                        ValueMember = "Id"
                    };

                    ItemDetailBtn = new Button()
                    {
                        Name = $"UserDetailBn_{product.Id}",
                        Text = "Sepete Ekle",
                        Location = new Point(15, 275),
                        Size = new System.Drawing.Size(120, 40),
                        FlatStyle = FlatStyle.Popup,
                        BackColor = Color.DarkOliveGreen,
                        ForeColor = Color.White,
                        Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 162),
                        Enabled = true,
                    };
                    ItemDetailBtn.Click += ItemDetailBtn_Click1;
                    ItemGb.Controls.Add(ComboBoxPr);
                    ItemGb.Controls.Add(PriceLbl);
                    ItemGb.Controls.Add(ItemLbl);
                    ItemGb.Controls.Add(ItemDetailBtn);
                    ItemGb.Controls.Add(ItemImgPB);
                    panel2.Controls.Add(ItemGb);

                    i++;
                }
            }
        }
        private void ItemDetailBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] name = btn.Name.Split('_');
            int typeId = Convert.ToInt32(name[1]);
            string type = _categoryId == 1 ? "M" : "P";
            OrderProduct orderProduct = new OrderProduct()
            {
                TypeId = typeId,
                Type = type,
                OrderId = _orderId,
                Quantity = 1
            };

            orderProductCrud.AddOrderProduct(orderProduct);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            _headerCenter();
            ItemListingIntoPanel(_categoryId);
        }

        private void ProductForm_SizeChanged(object sender, EventArgs e)
        {
            _headerCenter();
            panel2.Controls.Clear();
            ItemListingIntoPanel(_categoryId);
        }
    }
}
