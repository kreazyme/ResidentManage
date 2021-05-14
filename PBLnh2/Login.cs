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
    }
}
