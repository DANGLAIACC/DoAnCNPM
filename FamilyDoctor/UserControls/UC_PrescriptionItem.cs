using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using GUI.Forms;

namespace GUI.UserControls
{
    public partial class UC_PrescriptionItem : UserControl
    {
        public Prescription_DTO values;
        public UC_PrescriptionItem(int stt)
        {
            InitializeComponent(); 
            lblThuTu.Text = stt.ToString("00");
        }

        private void lblThuTu_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa loại thuốc thứ: " + lblThuTu.Text);
            this.Parent.Controls.Remove(this);
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                values = new Prescription_DTO(1234, "Mã thuốc", 
                    Int32.Parse(txtSang.Text),
                    Int32.Parse(txtTrua.Text),
                    Int32.Parse(txtToi.Text),
                    txtNote.Text);

                frmAddPrescription.lstPrescription.Add(values);

            }
        }
    }
}
