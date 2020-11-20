using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.global;

namespace GUI.UserControls
{
    public partial class UC_AddRecord : UserControl
    {
        public UC_AddRecord()
        {
            InitializeComponent();
        }

        private void UC_AddRecord_Load(object sender, EventArgs e)
        {
            txtBacSi.Text = GlobalVariable.curentDoctor.Doc_fullname;
        }
    }
}
