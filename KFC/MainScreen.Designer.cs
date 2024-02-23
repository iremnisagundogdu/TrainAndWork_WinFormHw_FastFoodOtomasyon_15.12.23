namespace KFC
{
    partial class MainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderCancel = new System.Windows.Forms.Button();
            this.OrderCreate = new System.Windows.Forms.Button();
            this.ProductCancel = new System.Windows.Forms.Button();
            this.TakeAwayCb = new System.Windows.Forms.CheckBox();
            this.drink_2 = new System.Windows.Forms.Button();
            this.Sides_4 = new System.Windows.Forms.Button();
            this.productBtn_0 = new System.Windows.Forms.Button();
            this.Souce_3 = new System.Windows.Forms.Button();
            this.burgerBtn_1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.OrderCancel);
            this.panel1.Controls.Add(this.OrderCreate);
            this.panel1.Controls.Add(this.ProductCancel);
            this.panel1.Controls.Add(this.TakeAwayCb);
            this.panel1.Controls.Add(this.drink_2);
            this.panel1.Controls.Add(this.Sides_4);
            this.panel1.Controls.Add(this.productBtn_0);
            this.panel1.Controls.Add(this.Souce_3);
            this.panel1.Controls.Add(this.burgerBtn_1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 539);
            this.panel1.TabIndex = 3;
            // 
            // OrderCancel
            // 
            this.OrderCancel.BackColor = System.Drawing.Color.Crimson;
            this.OrderCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrderCancel.Location = new System.Drawing.Point(362, 149);
            this.OrderCancel.Name = "OrderCancel";
            this.OrderCancel.Size = new System.Drawing.Size(133, 44);
            this.OrderCancel.TabIndex = 9;
            this.OrderCancel.Text = "İşlem İptal";
            this.OrderCancel.UseVisualStyleBackColor = false;
            this.OrderCancel.Click += new System.EventHandler(this.OrderCancel_Click);
            // 
            // OrderCreate
            // 
            this.OrderCreate.BackColor = System.Drawing.Color.LimeGreen;
            this.OrderCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.OrderCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OrderCreate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderCreate.Location = new System.Drawing.Point(501, 149);
            this.OrderCreate.Name = "OrderCreate";
            this.OrderCreate.Size = new System.Drawing.Size(230, 44);
            this.OrderCreate.TabIndex = 8;
            this.OrderCreate.Text = "Sipariş Onayla";
            this.OrderCreate.UseVisualStyleBackColor = false;
            this.OrderCreate.Click += new System.EventHandler(this.OrderCreate_Click);
            // 
            // ProductCancel
            // 
            this.ProductCancel.BackColor = System.Drawing.Color.Gold;
            this.ProductCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ProductCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ProductCancel.Location = new System.Drawing.Point(517, 75);
            this.ProductCancel.Name = "ProductCancel";
            this.ProductCancel.Size = new System.Drawing.Size(75, 68);
            this.ProductCancel.TabIndex = 7;
            this.ProductCancel.Text = "Ürün İptal";
            this.ProductCancel.UseVisualStyleBackColor = false;
            this.ProductCancel.Click += new System.EventHandler(this.ProductCancel_Click);
            // 
            // TakeAwayCb
            // 
            this.TakeAwayCb.AutoSize = true;
            this.TakeAwayCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TakeAwayCb.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.TakeAwayCb.Location = new System.Drawing.Point(617, 199);
            this.TakeAwayCb.Name = "TakeAwayCb";
            this.TakeAwayCb.Size = new System.Drawing.Size(114, 24);
            this.TakeAwayCb.TabIndex = 6;
            this.TakeAwayCb.Text = "Take Away";
            this.TakeAwayCb.UseVisualStyleBackColor = true;
            // 
            // drink_2
            // 
            this.drink_2.BackColor = System.Drawing.Color.SkyBlue;
            this.drink_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.drink_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drink_2.Location = new System.Drawing.Point(598, 79);
            this.drink_2.Name = "drink_2";
            this.drink_2.Size = new System.Drawing.Size(133, 64);
            this.drink_2.TabIndex = 5;
            this.drink_2.Text = "İçecekler";
            this.drink_2.UseVisualStyleBackColor = false;
            this.drink_2.Click += new System.EventHandler(this.drink_2_Click);
            // 
            // Sides_4
            // 
            this.Sides_4.BackColor = System.Drawing.Color.LemonChiffon;
            this.Sides_4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sides_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sides_4.Location = new System.Drawing.Point(362, 75);
            this.Sides_4.Name = "Sides_4";
            this.Sides_4.Size = new System.Drawing.Size(150, 68);
            this.Sides_4.TabIndex = 4;
            this.Sides_4.Text = "Yan Ürünler";
            this.Sides_4.UseVisualStyleBackColor = false;
            this.Sides_4.Click += new System.EventHandler(this.Sides_4_Click);
            // 
            // productBtn_0
            // 
            this.productBtn_0.BackColor = System.Drawing.Color.Teal;
            this.productBtn_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.productBtn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productBtn_0.Location = new System.Drawing.Point(598, 14);
            this.productBtn_0.Name = "productBtn_0";
            this.productBtn_0.Size = new System.Drawing.Size(133, 59);
            this.productBtn_0.TabIndex = 3;
            this.productBtn_0.Text = "Tek Ürünler";
            this.productBtn_0.UseVisualStyleBackColor = false;
            this.productBtn_0.Click += new System.EventHandler(this.productBtn_0_Click);
            // 
            // Souce_3
            // 
            this.Souce_3.BackColor = System.Drawing.Color.Salmon;
            this.Souce_3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Souce_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Souce_3.Location = new System.Drawing.Point(480, 14);
            this.Souce_3.Name = "Souce_3";
            this.Souce_3.Size = new System.Drawing.Size(112, 59);
            this.Souce_3.TabIndex = 2;
            this.Souce_3.Text = "Soslar";
            this.Souce_3.UseVisualStyleBackColor = false;
            this.Souce_3.Click += new System.EventHandler(this.Souce_3_Click);
            // 
            // burgerBtn_1
            // 
            this.burgerBtn_1.BackColor = System.Drawing.Color.Firebrick;
            this.burgerBtn_1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.burgerBtn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.burgerBtn_1.Location = new System.Drawing.Point(362, 14);
            this.burgerBtn_1.Name = "burgerBtn_1";
            this.burgerBtn_1.Size = new System.Drawing.Size(112, 59);
            this.burgerBtn_1.TabIndex = 1;
            this.burgerBtn_1.Text = "Menuler";
            this.burgerBtn_1.UseVisualStyleBackColor = false;
            this.burgerBtn_1.Click += new System.EventHandler(this.burgerBtn_1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(169, 179);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 539);
            this.Controls.Add(this.panel1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainScreen_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.SizeChanged += new System.EventHandler(this.MainScreen_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button OrderCancel;
        private System.Windows.Forms.Button OrderCreate;
        private System.Windows.Forms.Button ProductCancel;
        private System.Windows.Forms.CheckBox TakeAwayCb;
        private System.Windows.Forms.Button drink_2;
        private System.Windows.Forms.Button Sides_4;
        private System.Windows.Forms.Button productBtn_0;
        private System.Windows.Forms.Button Souce_3;
        private System.Windows.Forms.Button burgerBtn_1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}