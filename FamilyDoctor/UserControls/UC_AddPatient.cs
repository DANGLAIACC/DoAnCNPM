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
        /// <summary>
        /// Dùng cho thêm bệnh nhân
        /// </summary>
        /// <param name="pat_id">Mã bệnh nhân mới</param>
        public UC_AddPatient(int pat_id)
        {
            InitializeComponent();
            this.pat_id = pat_id;
        }
        /// <summary>
        /// Dùng cho sửa bệnh nhân
        /// </summary>
        /// <param name="p">bệnh nhân được sửa</param>
        public UC_AddPatient(Patient_DTO p, string pat_id)
        { 
            InitializeComponent();
            btnThem.Text = "Lưu";
            btnClear.Visible = false;

            txtTen.Text = p.Pat_fullname;
            dtpTuoi.Value = p.Pat_dob;
            txtPhone1.Text = p.Pat_phone1;
            txtPhone2.Text = p.Pat_phone2;
            txtDiaChi.Text = p.Pat_address;
            txtTienSu.Text = p.Pat_anamnesis;
            tglGender.Checked = p.Pat_gender;

            this.p = p;
            this.pat_id = Int32.Parse(pat_id);
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

            if(btnThem.Text == "Thêm")
            {
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
            else
            {// Lưu
                if (Patient_BLL.updatePatient(p))
                {
                    frmAlert f = new frmAlert();
                    f.showAlert("Lưu thành công", frmAlert.enmType.Success);

                    ((Form)this.TopLevelControl).Close();
                }
                else
                {
                    frmAlert f = new frmAlert();
                    f.showAlert("Lưu thất bại", frmAlert.enmType.Error);
                }
            }
        }
    }
}
