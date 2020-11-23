using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Forms;
using DTO;
using BLL;

namespace GUI.UserControls
{
    public partial class UC_AddPatient : UserControl
    {
        public Patient_DTO p;
        int pat_id;
        public UC_AddPatient(int pat_id)
        {
            this.pat_id = pat_id;
            InitializeComponent();
        }

        private void UC_AddPatient_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
        }

        private void tglGender_CheckedChanged(object sender, EventArgs e)
        {
            lblGender.Text = tglGender.Checked ? "Nam" : "Nữ";
        }

        private void dtpTuoi_ValueChanged(object sender, EventArgs e)
        {
            lblTuoi.Text = (DateTime.Now.Year - dtpTuoi.Value.Year).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTen.Text = txtPhone2.Text = txtPhone1.Text = txtDiaChi.Text = txtTienSu.Text = "";
            txtTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "")
            {
                frmAlert f = new frmAlert();
                f.showAlert("Tên bị trống", frmAlert.enmType.Error);

                txtTen.Focus();
                return;
            }

            p = new Patient_DTO(pat_id,
                txtTen.Text.Trim(),
                tglGender.Checked,
                dtpTuoi.Value,
                txtDiaChi.Text.Trim(),
                txtPhone1.Text.Trim(),
                txtPhone2.Text.Trim(),
                txtTienSu.Text.Trim());

            if(Patient_BLL.addPatient(p))
            {
                frmAlert f = new frmAlert();
                f.showAlert("Thêm thành công", frmAlert.enmType.Success);

                ((Form)this.TopLevelControl).Close();
            }
            else
            {
                frmAlert f = new frmAlert();
                f.showAlert("Thêm thất bại", frmAlert.enmType.Error);
            }
        }
    }
}
