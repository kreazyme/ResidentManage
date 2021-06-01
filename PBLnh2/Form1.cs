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
    public partial class NewAcc : Form
    {
        public NewAcc()
        {
            InitializeComponent();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewAcc_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtpw.Clear();
            txtrepw.Clear();
            txtID.Focus();
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập Tên người dùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtpw.Text ==string.Empty || txtrepw.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(txtpw.Text != txtrepw.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Clear();
                txtpw.Clear();
                txtrepw.Clear();
                txtID.Focus();
                return;
            }
            Dangnhap dn = new Dangnhap();
            dn.ID = Convert.ToInt32(txtID.Text.Trim());
            dn.PW = txtpw.Text.Trim();
            dn.Nguoitruycap = "1";
            if(BLL.BLL_Login.AddUser(dn) == true)
            {
                MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Đã có lỗi khi tạo tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //FormClosed();
            this.Close();
        }
    }
}
