using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using PBLnh2.DAL;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBLnh2
{
    public partial class MainForm : Form
    {
        private int Permisson = 2;
        private Button currentBut;
        public MainForm(int n)
        {
            InitializeComponent();
            CustomizeDes();
            Resettxt();
            Createdb();
            Permisson = n;
            //_login = lg;
        }
        //private Login _login;
        public MainForm()
        {
            InitializeComponent();
            CustomizeDes();
            Resettxt();
            Createdb();
        }
        private void Resettxt()
        {
            txtSearchContext.Text = "Nhập để tìm kiếm";
            txtSearchContext.ForeColor = System.Drawing.Color.FromArgb(110, 173, 255);
        }
        private void Createdb()
        {
            Console.WriteLine("a");
            dtgv.Rows.Clear();
            string Gioitinh = string.Empty;
            foreach(Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.GetThongtinnhankhaus())
            {
                
                if(i.Gender == true)
                {
                    Gioitinh = "Nam";
                }
                else
                {
                    Gioitinh = "Nữ";
                }
                dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
            }
        }
        private void CustomizeDes()
        {
            panSearch.Visible = false;
            panSort.Visible = false;
        }
        private void Dispanel()
        {
            if(panSort.Visible == true)
            {
                panSort.Visible = false;
            }
            if (panSearch.Visible == true)
            {
                panSearch.Visible = false;
            }
        }
        private void Activpanel(Panel submen)
        {
            if(submen.Visible == false)
            {
                Dispanel();
                submen.Visible = true;
            }
            else
            {
                submen.Visible = false;
            }
        }
        private void ActiveBut(object btnSender)
        {
            Resettxt();
            //Dispanel();
            if (btnSender != null)
            {
                if(currentBut != (Button)btnSender)
                {
                    DisBut();
                    Color color = ColorTranslator.FromHtml("#21cf15");
                    currentBut = (Button)btnSender;
                    //currentBut.BackColor = color;
                    currentBut.Font = new System.Drawing.Font("Segoe UI", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisBut()
        {
            foreach(Control previousBut in panSearch.Controls) 
            {
                previousBut.BackColor = Color.FromArgb(255, 255, 255);
                previousBut.ForeColor = Color.FromArgb(0, 117, 214);
                previousBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            foreach (Control previousBut in panSort.Controls)
            {
                previousBut.BackColor = Color.FromArgb(255, 255, 255);
                previousBut.ForeColor = Color.FromArgb(0, 117, 214);
                previousBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            foreach (Control previousBut in panMenu.Controls)
            {
                if(previousBut.GetType()== typeof(Button))
                {
                    previousBut.BackColor = Color.FromArgb(255, 255, 255);
                    previousBut.ForeColor = Color.FromArgb(0, 117, 214);
                    previousBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
            Resettxt();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Activpanel(panSort);
            ActiveBut(sender);
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
            dtgv.Rows.Clear();
            foreach(Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.SortbyName())
            {
                string Gioitinh = "Nữ";
                if (i.Gender == true)
                {
                    Gioitinh = "Nam";
                }
                dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
            }
        }

        private void btnSortCMND_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            foreach (Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.SortbyCMND())
            {
                string Gioitinh = "Nữ";
                if (i.Gender == true)
                {
                    Gioitinh = "Nam";
                }
                dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
            }
            ActiveBut(sender);
            Dispanel();
        }

        private void btnSortAge_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            foreach (Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.SortbyAge())
            {
                string Gioitinh = "Nữ";
                if (i.Gender == true)
                {
                    Gioitinh = "Nam";
                }
                dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
            }
            ActiveBut(sender);
            Dispanel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Permisson == 1)
            {
                MessageBox.Show("Bạn phải có quyền cao hơn mới có thể thêm được nhân khẩu vào cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ActiveBut(sender);
                Dispanel();
                ViewPersion f = new ViewPersion("null", 0);
                f.Show();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (Permisson == 1)
            {
                MessageBox.Show("Bạn phải có quyền cao hơn mới có thể chỉnh sửa được nhân khẩu trên cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ActiveBut(sender);
                Dispanel();
                if (dtgv.SelectedRows.Count > 0)
                {
                    int index = dtgv.CurrentCell.RowIndex;
                    int _cmnd = Convert.ToInt32(dtgv.Rows[index].Cells[0].Value.ToString());
                    ViewPersion frm = new ViewPersion( _cmnd.ToString(), 3);
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn người dân muốn chỉnh sửa thông tin", "Thông báo");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Permisson == 1)
            {
                MessageBox.Show("Bạn phải có quyền cao hơn mới có thể xoá được nhân khẩu khỏi cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                ActiveBut(sender);
                Dispanel();
                if (dtgv.SelectedRows.Count > 0)
                {
                    int index = dtgv.CurrentCell.RowIndex;
                    string str = dtgv.Rows[index].Cells[1].Value.ToString();
                    int _cmnd = Convert.ToInt32(dtgv.Rows[index].Cells[0].Value.ToString());
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xoá " + str + " ra khỏi cơ sở dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        dtgv.Rows.RemoveAt(dtgv.SelectedRows[0].Index);
                        BLL.BLL_Thongtinhankhau.Instance.DelNK(_cmnd);
                        MessageBox.Show("Đã xoá thành công " + str + " ra khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã huỷ lệnh xoá", "Thông báo");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn người muốn xoá ra khỏi cơ sở dữ liệu!", "Thông báo");
                }
            }
            }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Activpanel(panSearch);
            ActiveBut(sender);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            if(txtSearchContext.Text == "Nhập để tìm kiếm")
            {
                MessageBox.Show("Bạn chưa nhập vào tên cần tìm!", "Thông báo");
                Resettxt();
                return;
            }
            else
            {

                List<Thongtinnhankhau> ls = BLL.BLL_Thongtinhankhau.Instance.GetNKbyTen(txtSearchContext.Text);
                if(ls == null)
                {
                    MessageBox.Show("Không thể tìm thấy người tên " + txtSearchContext.Text, "Thông báo");
                }
                else
                {   dtgv.Rows.Clear();
                    foreach (Thongtinnhankhau i in ls)
                    {
                        string Gioitinh = "Nữ";
                        if (i.Gender == true)
                        {
                            Gioitinh = "Nam";
                        }
                        dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
                    }
                }
            }
            ActiveBut(sender);
            Dispanel();
        }

        private void btnSearchCMND_Click(object sender, EventArgs e)
        {
            if (txtSearchContext.Text == "Nhập để tìm kiếm")
            {
                MessageBox.Show("Bạn chưa nhập vào số CMND cần tìm!", "Thông báo");
                Resettxt();
                return;
            }
            else
            {

                Thongtinnhankhau tn = BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(txtSearchContext.Text);
                if (tn == null)
                {
                    MessageBox.Show("Không thể tìm thấy người có số CMND " + txtSearchContext.Text, "Thông báo");
                }
                else
                {
                    ViewPersion frm = new ViewPersion(txtSearchContext.Text, 4);
                    frm.Show();
                }
            }
            ActiveBut(sender);
            Dispanel();
        }

        private void txtSearchContext_TextChanged(object sender, EventArgs e)
        {
            txtSearchContext.ForeColor = System.Drawing.Color.FromArgb(0, 117, 214);
        }

        private void txtSearchContext_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearchContext.Text = string.Empty;
        }

        private void dtgv_DoubleClick(object sender, EventArgs e)
        {
            int _cmnd = Convert.ToInt32(dtgv.Rows[dtgv.CurrentCell.RowIndex].Cells[0].Value.ToString());
            string str = _cmnd.ToString();
            if(Permisson == 1)
            {
                str =  _cmnd.ToString();
            }
            ViewPersion f = new ViewPersion(str, 2);
            f.Sender = new ViewPersion.SendMessage(Createdb);
            f.Show();
        }

        private void butSearchFamily_Click(object sender, EventArgs e)
        {
            dtgv.Rows.Clear();
            foreach(Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.Instance.ListChuho())
            {
                string Gioitinh = "Nữ";
                if (i.Gender == true)
                {
                    Gioitinh = "Nam";
                }
                dtgv.Rows.Add(i.CMND.ToString(), i.Name, Gioitinh, i.dob.Value.Year.ToString(), i.SDT, i.Diachi);
            }
            ActiveBut(sender);
            Dispanel();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Createdb();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //_login.Show();
            //this.Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_login.ShowDialog();
        }
    }
}
