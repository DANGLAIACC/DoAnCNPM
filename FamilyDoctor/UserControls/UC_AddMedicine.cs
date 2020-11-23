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
        public string med_name="";
        public UC_AddMedicine(string med_id)
        {
            InitializeComponent();
            txtMedId.Text = med_id;

            Function.styleButtonEnter(btnThem);
            Function.styleButtonEnter(btnClear);

        }
        private void UC_AddMedicine_Load(object sender, EventArgs e)
        {
            // Nếu mã thuốc được truyền vào thì disable medId đi.
           txtMedId.Enabled = txtMedId.Text == "";
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
                frmAlert fAlert = new frmAlert();
                fAlert.showAlert("Mã hoặc tên bị trống.", frmAlert.enmType.Error);

                return;
            }

            if (Medicine_BLL.addMedicine(new Medicine_DTO(med_id, med_name)))
            {

                frmAlert fAlert = new frmAlert();
                fAlert.showAlert("Thêm thành công.", frmAlert.enmType.Success);

                this.med_name = med_name;
                // đóng frmAdd
                ((Form)this.TopLevelControl).Close();
            }
            else
            {

                frmAlert fAlert = new frmAlert();
                fAlert.showAlert("Thêm thất bại.", frmAlert.enmType.Warning);

                txtMedName.Focus();
            }
        }

        private void txtMedName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnThem.PerformClick();
            }
            else if(e.KeyCode == Keys.Escape)
            {
                btnClear.PerformClick();
            }
        }
    }
}
