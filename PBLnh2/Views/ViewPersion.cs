using System;
using System.Collections.Generic;
using System.ComponentModel;
using PBLnh2.DAL;
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
        private string _cmnd;
        private int Permission = 2;
        private bool Editmode = false;
        public delegate void SendMessage();
        public SendMessage Sender { get; set; }
        //delegate khai báo ở đây

        public ViewPersion()
        {
            InitializeComponent();
        }
        public ViewPersion(string str, int n) : this()
        {
            Permission = n;
            _cmnd = str;
            if (Permission == 0)
            {
                ActiEdit();
                return;
            }
            else if (Permission == 1)
            {
                //LoadDB();
                btnDel.ForeColor = System.Drawing.Color.Silver;
                btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
                Editmode = false;
                //return;
            }

            else if (Permission == 3)
            {
                //LoadDB();
                ActiEdit();
                //return;
            }

            LoadDB();
        }
        private void ActiEdit()
        {
            btnView.Text = "Lưu chỉnh sửa";
            btnDel.ForeColor = System.Drawing.Color.Silver;
            btnDel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            Editmode = true;
            txtAdd.ReadOnly = false;
            txtCMND.ReadOnly = false;
            txtQH.ReadOnly = false;
            txtDantoc.ReadOnly = false;
            txtdate.ReadOnly = false;
            txtGender.ReadOnly = false;
            txtJob.ReadOnly = false;
            txtmonth.ReadOnly = false;
            txtName.ReadOnly = false;
            txtQQ.ReadOnly = false;
            txtSDT.ReadOnly = false;
            txtSHK.ReadOnly = false;
            txtYear.ReadOnly = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadDB()
        {
            if (Editmode == true)
            {
                btnView.Text = "Lưu thay đổi";
                this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
                btnDel.ForeColor = System.Drawing.Color.LightGray;
            }
                Thongtinnhankhau tn = BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd);

                txtCMND.Text = _cmnd.ToString();
                txtAdd.Text = tn.Diachi;
                txtQH.Text = BLL.BLL_Chuho.Instance.GetQhbyID(Convert.ToInt32(tn.IDQuanhe));
                txtDantoc.Text = tn.Dantoc;
                if (tn.Gender == false)
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
                txtdate.Text = tn.dob.Value.Day.ToString();
                txtmonth.Text = tn.dob.Value.Month.ToString();
                txtYear.Text = tn.dob.Value.Year.ToString();

        }
        private void label15_Click(object sender, EventArgs e)
        {
  
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(Permission == 1)
            {
                MessageBox.Show("Bạn phải có quyền cao hơn mới có thể thực hiện chức năng xoá trên cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            else
            {
                if (Editmode == false)
                {
                    Thongtinnhankhau tn = BLL.BLL_Thongtinhankhau.GetTTNKbyCMND(_cmnd);
                    string str = tn.Name;
                    if (BLL.BLL_Thongtinhankhau.Instance.CounNK(Convert.ToInt32(tn.SoSHK)) == 1);
                    {
                        str = "hộ gia đình " + str;
                    }
                    DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xoá " + str + " ra khỏi cơ sở dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dlr == DialogResult.Yes)
                    {
                        BLL.BLL_Thongtinhankhau.Instance.DelNK(Convert.ToInt32(_cmnd));
                        MessageBox.Show("Đã xoá thành công " + str + " ra khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK);
                        Sender();
                        this.Close();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã huỷ lệnh xoá", "Thông báo");
                        return;
                    }
                }
                else
                {
                    return;
                }
            }
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if(Editmode == true)
            {
                if(txtQH.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập quan hệ với chủ hộ", "Thông báo");
                    txtQH.Focus();
                    return;
                }
                if (txtCMND.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập số CMND", "Thông báo");
                    txtCMND.Focus();
                    return;
                }
                if (txtDantoc.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập dân tộc", "Thông báo");
                    txtDantoc.Focus();
                    return;
                }
                if (txtGender.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập giới tính", "Thông báo");
                    txtGender.Focus();
                    return;
                }
                if (txtGender.Text != "Nam" && txtGender.Text != "Nữ")
                {
                    MessageBox.Show("Giới tính không phù hợp", "Thông báo");
                    txtGender.Focus();
                    return;
                }
                if (txtName.Text == string.Empty)
                {
                    MessageBox.Show("Bạn chưa nhập họ và tên", "Thông báo");
                    txtName.Focus();
                    return;
                }
                if (txtmonth.Text == string.Empty || txtdate.Text == string.Empty || txtYear.Text == string.Empty)
                {
                    txtdate.Focus();
                    MessageBox.Show("Bạn chưa ngày tháng năm sinh", "Thông báo");
                    return;
                }
                if (txtSHK.Text == string.Empty)
                {
                    txtSHK.Focus();
                    MessageBox.Show("Bạn chưa nhập số Hộ khẩu", "Thông báo");
                    return;
                }
                if (txtAdd.Text == string.Empty)
                {
                    txtAdd.Focus();
                    MessageBox.Show("Bạn chưa nhập địa chỉ");
                    return;
                }
                Thongtinnhankhau tn = new Thongtinnhankhau();
                try
                {
                    tn.CMND = Convert.ToInt32(txtCMND.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Bạn chưa nhập đúng số CMND", "Thông báo");
                    txtCMND.Focus();
                    return;
                }
                tn.Dantoc = txtDantoc.Text;
                tn.Diachi = txtAdd.Text;
                tn.Name = txtName.Text;
                
                tn.IDQuanhe = BLL.BLL_Chuho.Instance.GetIDbyName(txtQH.Text);
                try
                {
                    tn.SoSHK = Convert.ToInt32(txtSHK.Text);
                }
                catch
                {
                    MessageBox.Show("Bạn chưa nhập đúng số SHK", "Thông báo");
                    txtSHK.Focus();
                    return;
                }
                tn.NgheNghiep = txtJob.Text;
                tn.NguyenQuan = txtQQ.Text;
                if(txtSDT.Text != string.Empty)
                {
                    tn.SDT = txtSDT.Text;
                    try
                    {
                        int temp = Convert.ToInt32(tn.SDT);
                        if (tn.SDT.Length != 10)
                        {
                            MessageBox.Show("Số điện thoại phải có 10 chữ số!!", "Thông báo");
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Bạn chưa nhập đúng số điện thoại", "Thông báo");
                        txtSDT.Focus();
                        tn.SDT = string.Empty;
                        return;
                    }
                }
                try
                {
                    DateTime dt = new DateTime(Convert.ToInt32(txtYear.Text), Convert.ToInt32(txtmonth.Text), Convert.ToInt32(txtdate.Text));
                    tn.dob = dt;
                }
                catch (Exception )
                {
                    MessageBox.Show("Bạn chưa nhập đúng ngày tháng năm sinh", "Thông báo");
                    txtdate.Focus();
                    return;
                }
                if (txtGender.Text == "Nam")
                {
                    tn.Gender = true;
                }
                else tn.Gender = false;
               if(BLL.BLL_Thongtinhankhau.Instance.CheckCMND(tn.CMND) == false)
                {
                    if(tn.IDQuanhe == 1)
                    {
                        if (BLL.BLL_DSHokhau.Instance.CheckChuho(Convert.ToInt32(tn.SoSHK)))
                        {
                            MessageBox.Show("Số sổ hộ khẩu không đúng hoặc quan hệ với chủ hộ không đúng \n Mỗi hộ chỉ tồn tại 1 chủ hộ!", "Thông báo");
                        }
                    }
                    if (BLL.BLL_Thongtinhankhau.AddNhankhau(tn) == true)
                    {
                        MessageBox.Show("Đã thêm thành công " + tn.Name + " vào cơ sở dữ liệu!", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    if(BLL.BLL_Thongtinhankhau.Instance.UpdateNK(tn) == true)
                    {
                        MessageBox.Show("Đã cập nhật thành công " + tn.Name + " vào cơ sở dữ liệu!", "Thông báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                Relative frm = new Relative(_cmnd, Permission);
                frm.Show(); 
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if(Permission == 1)
            {
                MessageBox.Show("Bạn phải có quyền cao hơn mới có thể chỉnh sửa nhân khẩu trên cơ sở dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }
            ActiEdit();
        }

        private void txtCMND_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewPersion_Load(object sender, EventArgs e)
        {

        }
    }
}
