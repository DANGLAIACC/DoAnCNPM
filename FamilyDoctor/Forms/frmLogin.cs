using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;

namespace FamilyDoctor.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //using (Form_Dashboard fd = new Form_Dashboard())
            //{
            //    fd.ShowDialog();
            //}
            Form_Dashboard f = new Form_Dashboard();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }
    }
}
