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
        private int tempindex;

        public MainForm()
        {
            InitializeComponent();
            CustomizeDes();
            Createdb();
        }
        private void Createdb()
        {
            for(int i=0; i<10; i++)
            {
                dtgv.Rows.Add(new object[] { "194357734", "Trần Đức Thông", "Nam", "2001", "0866086426", "Hà Tĩnh" });
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
            foreach(Control previousBut in panMenu.Controls)
            {
                if(previousBut.GetType()== typeof(Button))
                {
                    previousBut.BackColor = Color.FromArgb(255, 255, 255);
                    previousBut.ForeColor = Color.FromArgb(0, 117, 214);
                    previousBut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
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
    }
}
