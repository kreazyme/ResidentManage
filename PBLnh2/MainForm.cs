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
    public partial class MainForm : Form
    {
        private Button currentBut;

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
            string Gioitinh = string.Empty;
            foreach(Thongtinnhankhau i in BLL.BLL_Thongtinhankhau.GetThongtinnhankhaus())
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
 
        }

        private void btnSortCMND_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
        }

        private void btnSortAge_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
            if(dtgv.SelectedRows.Count > 0)
            {
                int index = dtgv.CurrentCell.RowIndex;
                string str = dtgv.Rows[index].Cells[1].Value.ToString();
                int _cmnd = Convert.ToInt32(dtgv.Rows[index].Cells[0].Value.ToString());
                DialogResult dlr =  MessageBox.Show("Bạn có chắc chắn muốn xoá " + str + " ra khỏi cơ sở dữ liệu ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dlr == DialogResult.Yes)
                {
                    dtgv.Rows.RemoveAt(dtgv.SelectedRows[0].Index);
                    BLL.BLL_Thongtinhankhau.Instance.DelNK(_cmnd);
                    MessageBox.Show("Đã xoá thành công" + str + " ra khỏi cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không xoá", "Thông báo");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn người muốn xoá ra khỏi cơ sở dữ liệu!", "Thông báo");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Activpanel(panSearch);
            ActiveBut(sender);
        }

        private void btnSearchName_Click(object sender, EventArgs e)
        {
            ActiveBut(sender);
            Dispanel();
        }

        private void btnSearchCMND_Click(object sender, EventArgs e)
        {
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
            ViewPersion f = new ViewPersion(_cmnd.ToString());
            f.Show();
        }
    }
}
