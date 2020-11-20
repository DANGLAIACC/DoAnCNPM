using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frmAdd: Form
    {
        public frmAdd(string title, UserControl u)
        {
            InitializeComponent();
            lblTitle.Text = title;

            u.Dock = DockStyle.Fill;
            pnMain.Controls.Clear();
            pnMain.Controls.Add(u);
        }
    }
}
