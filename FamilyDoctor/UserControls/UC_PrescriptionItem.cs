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
        //private string med_id;
        public Prescription_DTO prescription = new Prescription_DTO(0, "", 0, 0, 0, "");

        public UC_PrescriptionItem(frmAddPrescription frm, int stt)
        {
            InitializeComponent();
            this.frm = frm;
            lblSTT.Text = stt.ToString("00");

            txtTen.Focus();
        }

        public UC_PrescriptionItem(frmAddPrescription frm, int stt, Prescription_DTO pre)
        {
            InitializeComponent();
            this.frm = frm;
            lblSTT.Text = stt.ToString("00");
            prescription = pre;

            txtTen.Text = getMedNameById(pre.Med_id);

            txtSang.Text = pre.Pre_morning.ToString();
            txtTrua.Text = pre.Pre_middle.ToString();
            txtToi.Text = pre.Pre_afternoon.ToString();
            txtNote.Text = pre.Pre_note;
        }

        private string getMedNameById(string med_id)
        {
            foreach (Medicine_DTO m in frmAddPrescription.lstAllMedicine)
                if (m.Med_id == med_id)
                    return med_id;
            return "";
        }

        private void UC_PrescriptionItem_Load(object sender, EventArgs e)
        {
            loadAutoCompleteMedName();
        }
        /// <summary>
        /// Lấy dữ liệu từ frmAddPrescription để làm data cho suggess textbox
        /// </summary>
        private void loadAutoCompleteMedName()
        {

            AutoCompleteStringCollection auto= new AutoCompleteStringCollection();
            foreach (Medicine_DTO m in frmAddPrescription.lstMedicineSuggest)
                auto.Add(m.Med_id);

            txtTen.AutoCompleteCustomSource = auto;
        }

        private void lblSTT_DoubleClick(object sender, EventArgs e)
        {
            frmAddPrescription.lstMedicineSuggest.Add(new Medicine_DTO(prescription.Med_id, txtTen.Text));

            Parent.Controls.Remove(this);
            
            frmAlert f = new frmAlert();
            f.showAlert("Đã xóa đơn thuốc.", frmAlert.enmType.Info);
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
                    prescription.Pre_afternoon = Int32.Parse(txtToi.Text==""?"0":txtToi.Text);
                    prescription.Pre_morning = Int32.Parse(txtSang.Text == "" ? "0" : txtSang.Text);
                    prescription.Pre_middle = Int32.Parse(txtTrua.Text == "" ? "0" : txtTrua.Text);
                    prescription.Pre_note = txtNote.Text;

                    frm.addNewPrescription();
                }
            }
        }

        public string getNameMedicine()
        {
            return txtTen.Text.Trim();
        }
        /// <summary>
        /// Kiểm tra dữ liệu trong user control hợp lệ
        /// Tên thuốc không rỗng 
        /// Liều dùng không rỗng (sáng, trưa, tối có giá trị
        /// </summary>
        /// <returns>true nếu hợp lệ</returns>
        public bool isUcValid()
        {
            return txtTen.Text.Trim() != "" &&
                (txtSang.Text != "" || txtTrua.Text != "" || txtToi.Text != "");
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
        
        private void txtTen_Leave(object sender, EventArgs e)
        {
            string med_id = txtTen.Text.Trim();

            if(med_id == "")
            {
                frmAlert frmAlert = new frmAlert();
                frmAlert.showAlert(
                    "Tên thuốc bị trống",
                    frmAlert.enmType.Error);

                txtTen.Text = "";
                txtTen.Focus();
                return;
            }

             // Kiểm tra mã thuốc chưa tồn tại ở các uc_item trước đó
             foreach (UC_PrescriptionItem u in frm.pnPrescritionItems.Controls)
                if(med_id == u.prescription.Med_id)
                {
                    frmAlert frmAlert = new frmAlert();
                    frmAlert.showAlert(
                        "Mã thuốc đã tồn tại",
                        frmAlert.enmType.Error);

                    txtTen.SelectAll();
                    txtTen.Focus();

                    return;
                }

             // Mã thuốc mới hoàn toàn, bắt đầu thay bằng tên và gán vào med_id
             foreach(Medicine_DTO m in frmAddPrescription.lstMedicineSuggest)
                if (med_id == m.Med_id)
                {
                    prescription.Med_id = med_id;
                    txtTen.Text = m.Med_name;
                    frmAddPrescription.lstMedicineSuggest.Remove(m);
                    txtTen.Enabled = false;
                    return;
                }

            // Mã thuốc chưa tồn tại trong Danh sách thuốc có sẵn

            frmAlert frmAlert2 = new frmAlert();
            frmAlert2.showAlert(
                "Mã thuốc chưa tồn tại.",
                frmAlert.enmType.Warning);

            UC_AddMedicine uc = new UC_AddMedicine(med_id);
            frmAdd f = new frmAdd("Thêm thuốc mới", uc);

            f.ShowDialog(this);

            if (uc.med_name != "")
            {
                // Thêm thuốc vào database thành công
                prescription.Med_id = med_id;
                txtTen.Text = uc.med_name;
            }

        }
    }
}
