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
    public partial class ViewPersion : Form
    {
        private static string _cmnd;
        public ViewPersion()
        {
            InitializeComponent();
        }
        public ViewPersion(string str) : this()
        {
            _cmnd = str;
            LoadDB();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDB()
        {
            Thongtinnhankhau tn = BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd);
            txtCMND.Text = _cmnd.ToString();
            txtAdd.Text = tn.Diachi;
            txtDantoc.Text = tn.Dantoc;
            if(tn.Gender == false)
            {
                txtGender.Text = "Nam";
            }
            else
            {
                txtGender.Text = "Nữ";
            }
            txtJob.Text = tn.NgheNghiep;
            txtName.Text = tn.Name;
            txtQQ.Text = tn.NguyenQuan;
            txtSHK.Text = tn.SoSHK.ToString();
            txtSDT.Text = tn.SDT;
            
        }
        private void label15_Click(object sender, EventArgs e)
        {
  
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string str = BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd).Name;
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xoá " + str + " ra khỏi cơ sở dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                BLL.BLL_Thongtinhankhau.Instance.DelNK(Convert.ToInt32(_cmnd));
                MessageBox.Show("Đã xoá thành công" + str + " ra khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Không xoá", "Thông báo");
                return;
            }
        }
    }
}
