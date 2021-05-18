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
            if(txtpw.Text != txtrepw.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng khớp!");
                txtID.Clear();
                txtpw.Clear();
                txtrepw.Clear();
                txtID.Focus();
            }
        }
    }
}
