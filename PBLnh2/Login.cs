using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLnh2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCreate_Click(object sender, EventArgs e)
        {
            NewAcc n = new NewAcc();
            n.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if(txtID.Text == txtpw.Text)
            {
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin ddăng nhập, hãy thử lại");
                txtID.Clear();
                txtpw.Clear();
                txtID.Focus();
            }
        }

        private void txtCreate_Click_1(object sender, EventArgs e)
        {
            NewAcc n = new NewAcc();
            n.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtpw.Clear();
            txtID.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
