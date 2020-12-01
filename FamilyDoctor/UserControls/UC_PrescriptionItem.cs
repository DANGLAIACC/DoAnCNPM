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
        private frmAddRecord frm;
        //private string med_id;
        public Prescription_DTO prescription = new Prescription_DTO(0, "", 0, 0, 0, "");

        public UC_PrescriptionItem(frmAddRecord frm, int stt)
        {
            InitializeComponent();
            this.frm = frm;
            lblSTT.Text = stt.ToString("00");
        }
        private void UC_PrescriptionItem_Load(object sender, EventArgs e)
        {
            loadAutoCompleteMedName(txtTen, frmAddRecord.lstMedicineSuggest);

            txtTen.Text = getMedNameById(prescription.Med_name);
            txtSang.Text = prescription.Pre_morning.ToString();
            txtTrua.Text = prescription.Pre_middle.ToString();
            txtToi.Text = prescription.Pre_afternoon.ToString();
            txtNote.Text = prescription.Pre_note;

            txtTen.Focus();
        }

        private string getMedNameById(string med_id)
        {
            foreach (Medicine_DTO m in frmAddRecord.lstAllMedicine)
                if (m.Med_id == med_id)
                    return med_id;
            return "";
        }

        /// <summary>
        /// Lấy dữ liệu từ frmAddPrescription để làm data cho suggess textbox
        /// </summary>
        private void loadAutoCompleteMedName(TextBox txt, List<Medicine_DTO> lst)
        {

            AutoCompleteStringCollection auto= new AutoCompleteStringCollection();
            foreach (Medicine_DTO m in lst)
                auto.Add(m.Med_id);

            txtTen.AutoCompleteCustomSource = auto;
        }

        private void lblSTT_DoubleClick(object sender, EventArgs e)
        {
            if (Parent.Controls.Count == 1)
            {
                txtTen.Text = txtSang.Text = txtTrua.Text = txtToi.Text = txtNote.Text = "";
                txtTen.Enabled = true;
                txtTen.Focus();

                return;
            }
            // Thay đổi lstSuggest
            frmAddRecord.lstMedicineSuggest.Add(new Medicine_DTO(prescription.Med_id, txtTen.Text));

            Parent.Controls.Remove(this);
            frm.refreshSerial();

            frmAlert f = new frmAlert();
            f.showAlert("Đã xóa đơn thuốc.", frmAlert.enmType.Info);
        }

        /// <summary>
        /// Kiểm tra dữ liệu trong user control hợp lệ
        /// Tên thuốc không rỗng 
        /// Liều dùng không rỗng (sáng, trưa, tối có giá trị
        /// </summary>
        /// <returns>true nếu hợp lệ</returns>
        public bool isUcValid()
        {
            int sang = Int32.Parse(txtSang.Text != "" ? txtSang.Text : "0"),
                trua = Int32.Parse(txtTrua.Text != "" ? txtTrua.Text : "0"),
                toi = Int32.Parse(txtToi.Text != "" ? txtToi.Text : "0");

            prescription.Pre_afternoon = toi;
            prescription.Pre_morning = sang;
            prescription.Pre_middle = trua;
            prescription.Pre_note = txtNote.Text;

            return txtTen.Text.Trim() != "" && (sang+trua+toi > 0);
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
             foreach(Medicine_DTO m in frmAddRecord.lstMedicineSuggest)
                if (med_id == m.Med_id)
                {
                    prescription.Med_id = med_id;
                    txtTen.Text = m.Med_name;
                    frmAddRecord.lstMedicineSuggest.Remove(m);
                    prescription.Med_name = m.Med_name;
                    txtTen.Enabled = false;
                    return;
                }

            // Mã thuốc chưa tồn tại trong Danh sách thuốc có sẵn

            frmAlert frmAlert2 = new frmAlert();
            frmAlert2.showAlert(
                "Mã thuốc chưa tồn tại.",
                frmAlert.enmType.Warning);

            UC_AddMedicine uc = new UC_AddMedicine(med_id,"");
            frmAdd f = new frmAdd("Thêm thuốc mới", uc);

            f.ShowDialog(this);

            if (uc.m.Med_name != "")
            {
                // Thêm thuốc vào database thành công
                prescription.Med_id = med_id;
                txtTen.Text = uc.m.Med_name;
            }

        }

        private void txtNote_Leave(object sender, EventArgs e)
        {
            int sang = Int32.Parse(txtSang.Text != "" ? txtSang.Text : "0"),
                trua = Int32.Parse(txtTrua.Text != "" ? txtTrua.Text : "0"),
                toi = Int32.Parse(txtToi.Text != "" ? txtToi.Text : "0");

            if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên thuốc không được để trống");
                txtTen.Focus();
            }
            else if (sang + trua + toi == 0)
            {
                MessageBox.Show("Chưa nhập liều dùng thuốc");
                txtSang.Focus();
            }
            else
            {
                prescription.Pre_afternoon = toi;
                prescription.Pre_morning = sang;
                prescription.Pre_middle = trua;
                prescription.Pre_note = txtNote.Text;
                frm.addNewPrescription();
            }
        }

        private void txtTen_Enter(object sender, EventArgs e)
        {

        }
    }
}
