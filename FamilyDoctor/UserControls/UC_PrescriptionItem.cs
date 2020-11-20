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
        private frmAddPrescription frm;
        public UC_PrescriptionItem(frmAddPrescription frm)
        {
            InitializeComponent();
            this.frm = frm;
            lblSTT.Text = 
                (frm.pnPrescritionItems.Controls.Count+1)
                .ToString("00");
        }

        private void lblSTT_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa loại thuốc thứ: " + lblSTT.Text);
            this.Parent.Controls.Remove(this);
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Tên thuốc không được để trống");
                    txtTen.Focus();
                }
                else if(txtSang.Text == "" && txtTrua.Text == "" && txtToi.Text == "")
                {
                    MessageBox.Show("Liều dùng thuốc không được để trống");
                    txtSang.Focus();
                }
                else
                {
                    frm.addNewPrescription();
                }
                //this.Parent.Controls.Add(this);
            }
        }

        private void UC_PrescriptionItem_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }
        public string getNameMedicine()
        {
            return txtTen.Text;
        }
        public Prescription_DTO getValue()
        {
            return new Prescription_DTO(
                1234, "MaThuoc",
                Int32.Parse(txtSang.Text),
                Int32.Parse(txtTrua.Text),
                Int32.Parse(txtToi.Text),
                txtNote.Text);
        }
        /// <summary>
        /// Chỉ cho nhập số vào textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSang_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
