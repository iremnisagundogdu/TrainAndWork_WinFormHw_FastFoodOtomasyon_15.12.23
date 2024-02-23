namespace WindowsFormsApp1
{
    partial class CustomerScreenForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelHazırlanıyor = new System.Windows.Forms.Panel();
            this.panelHazır = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(43, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Siparişiniz Hazırlanıyor-Your Order is Preparing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(718, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(537, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Siparişiniz Hazır - Your Order is Ready";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1292, 80);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 516);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1292, 35);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Kfc_logo;
            this.pictureBox1.Location = new System.Drawing.Point(75, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Burger;
            this.pictureBox2.Location = new System.Drawing.Point(1097, 311);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(167, 168);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panelHazırlanıyor
            // 
            this.panelHazırlanıyor.Location = new System.Drawing.Point(191, 81);
            this.panelHazırlanıyor.Name = "panelHazırlanıyor";
            this.panelHazırlanıyor.Size = new System.Drawing.Size(300, 435);
            this.panelHazırlanıyor.TabIndex = 4;
            // 
            // panelHazır
            // 
            this.panelHazır.BackColor = System.Drawing.Color.Transparent;
            this.panelHazır.Location = new System.Drawing.Point(791, 81);
            this.panelHazır.Name = "panelHazır";
            this.panelHazır.Size = new System.Drawing.Size(300, 435);
            this.panelHazır.TabIndex = 5;
            // 
            // CustomerScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 551);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelHazır);
            this.Controls.Add(this.panelHazırlanıyor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerScreenForm";
            this.Text = "Customer Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CustomerScreenForm_Activated);
            this.Load += new System.EventHandler(this.CustomerScreenForm_Load);
            this.SizeChanged += new System.EventHandler(this.CustomerScreenForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelHazırlanıyor;
        private System.Windows.Forms.Panel panelHazır;
    }
}

