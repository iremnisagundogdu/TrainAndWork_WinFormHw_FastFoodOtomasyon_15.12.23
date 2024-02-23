using KFC.DataManager.Concrete;
using KFC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KFC
{
    public partial class Login : Form
    {
        EmployeeCrud employeeCrud = new EmployeeCrud();
        public static int employeeId;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            WindowChanged();
        }




        private void WindowChanged()
        {
            int formWidth = (panel1.Width / 2) - (marketYonetim_lbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (marketYonetim_lbl.Height / 2);
            marketYonetim_lbl.Location = new Point(formWidth, formHeight);

            int formPanel2Width = (panel2.Width / 2) - (groupBox1.Width / 2);
            int formPanel2Height = (panel2.Height / 2) - (groupBox1.Height / 2);
            groupBox1.Location = new Point(formPanel2Width, formPanel2Height);
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            WindowChanged();
        }

        private void giris_btn_Click(object sender, EventArgs e)
        {
            Employee employee = employeeCrud.GetAll().FirstOrDefault(x => x.Name == emailGiris_txt.Text && x.Password == sifreGiris_txt.Text);

            if (employee != null)
            {
                employeeId = employee.Id;
                MainScreen mainScreen = new MainScreen();
                mainScreen.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı Veya Parola");
            }
        }
    }
}
