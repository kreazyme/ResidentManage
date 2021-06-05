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

namespace PBLnh2
{
    public partial class Relative : Form
    {
        private string _cmnd;
        private int _SHK;
        public Relative()
        {
            InitializeComponent();
            LoadDG();
        }
        public Relative(string str)
        {
            _cmnd = str;
            InitializeComponent();
            LoadDG();
        }
        private void LoadDG()
        {
            _SHK = Convert.ToInt32(BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd).SoSHK);
            int n = Convert.ToInt32(BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd).IDQuanhe);
            foreach (Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.GetNKbySHK(_SHK.ToString()))
            {
                string QHChuho = BLL.BLL_Chuho.Instance.GetQhbyID(n);
                string _gender = "Nam";
                if(i.Gender == false)
                {
                    _gender = "Nữ";
                }
                dtgv.Rows.Add(i.Name, i.dob.Value.Year, _gender, QHChuho);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Relative_DoubleClick(object sender, EventArgs e)
        {
        }

        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            int m =0;
            string _name = dtgv.Rows[dtgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
            foreach(Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.GetNKbySHK(_SHK.ToString()))
            {
                if(i.Name == _name)
                {
                    m = i.CMND;
                }
            }
            ViewPersion f = new ViewPersion(m.ToString());
            f.Show();
        }
    }
}
 