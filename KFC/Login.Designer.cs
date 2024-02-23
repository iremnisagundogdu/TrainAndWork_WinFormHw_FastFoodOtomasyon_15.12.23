namespace KFC
{
    partial class Login
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sifreGiris_txt = new System.Windows.Forms.TextBox();
            this.emailGiris_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailGiris_lbl = new System.Windows.Forms.Label();
            this.giris_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.marketYonetim_lbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 365);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.groupBox1.Controls.Add(this.sifreGiris_txt);
            this.groupBox1.Controls.Add(this.emailGiris_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.emailGiris_lbl);
            this.groupBox1.Controls.Add(this.giris_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(194, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 325);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Girişi";
            // 
            // sifreGiris_txt
            // 
            this.sifreGiris_txt.Location = new System.Drawing.Point(32, 141);
            this.sifreGiris_txt.Name = "sifreGiris_txt";
            this.sifreGiris_txt.Size = new System.Drawing.Size(290, 31);
            this.sifreGiris_txt.TabIndex = 4;
            this.sifreGiris_txt.UseSystemPasswordChar = true;
            // 
            // emailGiris_txt
            // 
            this.emailGiris_txt.Location = new System.Drawing.Point(32, 73);
            this.emailGiris_txt.Name = "emailGiris_txt";
            this.emailGiris_txt.Size = new System.Drawing.Size(290, 31);
            this.emailGiris_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre";
            // 
            // emailGiris_lbl
            // 
            this.emailGiris_lbl.AutoSize = true;
            this.emailGiris_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailGiris_lbl.Location = new System.Drawing.Point(28, 50);
            this.emailGiris_lbl.Name = "emailGiris_lbl";
            this.emailGiris_lbl.Size = new System.Drawing.Size(106, 20);
            this.emailGiris_lbl.TabIndex = 1;
            this.emailGiris_lbl.Text = "Kullanıcı Adı";
            // 
            // giris_btn
            // 
            this.giris_btn.BackColor = System.Drawing.Color.Khaki;
            this.giris_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.giris_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.giris_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.giris_btn.Location = new System.Drawing.Point(89, 226);
            this.giris_btn.Name = "giris_btn";
            this.giris_btn.Size = new System.Drawing.Size(186, 58);
            this.giris_btn.TabIndex = 0;
            this.giris_btn.Text = "Giriş";
            this.giris_btn.UseVisualStyleBackColor = false;
            this.giris_btn.Click += new System.EventHandler(this.giris_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.marketYonetim_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 85);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // marketYonetim_lbl
            // 
            this.marketYonetim_lbl.AutoSize = true;
            this.marketYonetim_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.marketYonetim_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.marketYonetim_lbl.Location = new System.Drawing.Point(197, 33);
            this.marketYonetim_lbl.Name = "marketYonetim_lbl";
            this.marketYonetim_lbl.Size = new System.Drawing.Size(376, 37);
            this.marketYonetim_lbl.TabIndex = 0;
            this.marketYonetim_lbl.Text = "Market Yönetim Sistemi";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sifreGiris_txt;
        private System.Windows.Forms.TextBox emailGiris_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailGiris_lbl;
        private System.Windows.Forms.Button giris_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label marketYonetim_lbl;
    }
}

