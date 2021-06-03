using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PBLnh2.DAL;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBLnh2.BLL;

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

        private bool CheckLogin()
        {
            Dangnhap login = BLL_Login.GetUserbyID(txtID.Text);
            if (login == null)
                return false;
            if (login.PW.Trim() == txtpw.Text)
            { 
                return true;
            }
            else return false;
        }

        
        private void txtLogin_Click(object sender, EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập Tên người dùng","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtpw.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập Mật khẩu", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(CheckLogin())
            {
                MainForm f = new MainForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập, hãy thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
