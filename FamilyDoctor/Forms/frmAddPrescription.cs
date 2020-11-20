using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using DTO;

namespace GUI.Forms
{
    public partial class frmAddPrescription: Form
    {
        public static List<Prescription_DTO> lstPrescription = new List<Prescription_DTO>();

        public frmAddPrescription()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void refreshPnPrescription(Panel pn)
        {
            for(int i=0;i<=lstPrescription.Count;i++)
            {
                UC_PrescriptionItem u =
                        new UC_PrescriptionItem(i++);
                u.Dock = DockStyle.Bottom;
                pn.Controls.Add(u);
            }

        }
        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            refreshPnPrescription(pnPrescritionItems);
        }
    }
}
