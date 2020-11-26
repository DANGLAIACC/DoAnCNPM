using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUI.global;
using System.Windows.Forms;
using GUI.Forms;
using DTO;
using BLL;

namespace GUI.UserControls
{
    public partial class UC_AddMedicine : UserControl
    {
        public Medicine_DTO m;
        // Sửa, thêm thuốc
        public UC_AddMedicine(string med_id, string med_name)
        {
            InitializeComponent();
            txtMedId.Text = med_id;
            txtMedName.Text = med_name;
            m = new Medicine_DTO(med_id, med_name);
        }
        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {
            // Nếu mã thuốc được truyền vào thì disable medId đi.
            if (txtMedId.Text != "")
            {
                txtMedId.Enabled = false;
                btnThem.Text = "Lưu";
            }
            txtMedName.SelectAll();
            Function.styleButtonEnter(btnThem);
            Function.styleButtonEnter(btnClear);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMedName.Text = "";
            if (txtMedId.Enabled)
            {
                txtMedId.Text = "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string med_id = txtMedId.Text.Trim(), med_name = txtMedName.Text.Trim();
            if (med_id == "" || med_name == "")
            {
                frmAlert f2 = new frmAlert();
                f2.showAlert("Mã hoặc tên bị trống.", frmAlert.enmType.Error);

                return;
            }

            if (btnThem.Text == "Thêm" && Medicine_BLL.addMedicine(new Medicine_DTO(med_id, med_name)))
            {
                frmAlert f3 = new frmAlert();
                f3.showAlert("Thêm thành công.", frmAlert.enmType.Success);

                m.Med_name = med_name;
                m.Med_id = txtMedId.Text;
                // đóng frmAdd
                ((Form)this.TopLevelControl).Close();

                return;
            }

            if (btnThem.Text == "Lưu" && Medicine_BLL.updateMedicine(new Medicine_DTO(med_id, med_name)))
            {
                frmAlert f1 = new frmAlert();
                f1.showAlert("Lưu thành công.", frmAlert.enmType.Success);

                m.Med_name = med_name;
                m.Med_id = txtMedId.Text;
                // đóng frmAdd
                ((Form)this.TopLevelControl).Close();

                return;
            }

            frmAlert fAlert = new frmAlert();
            fAlert.showAlert(btnThem.Text + " thất bại.", frmAlert.enmType.Warning);

            txtMedName.Focus();
        }

        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnClear.PerformClick();
            }
        }
    }
}
