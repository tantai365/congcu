using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string pass = "admin";
            if (user.Equals(txtUsername.Text) && pass.Equals(txtPassword.Text))
            {
                MessageBox.Show("Dang nhap thanh cong");
            }
            else
                MessageBox.Show("Sai tai khoan hoac mat khau");
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
