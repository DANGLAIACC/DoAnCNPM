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
        private string med_id;
        public UC_PrescriptionItem(frmAddPrescription frm)
        {
            InitializeComponent();
            this.frm = frm;
            lblSTT.Text = 
                (frm.pnPrescritionItems.Controls.Count+1)
                .ToString("00");

            txtTen.Focus();
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
            }
        }

        public string getNameMedicine()
        {
            return txtTen.Text.Trim();
        }
        public string getMedIdByName()
        {
            string med_name = txtTen.Text.Trim();

            foreach (Medicine_DTO m 
                in frmAddPrescription.lstMedicineSuggest)
                if (m.Med_name == txtTen.Text.Trim())
                    return m.Med_id;

            return "";
        }
        /// <summary>
        /// Trả về giá trị thuốc của usercontrol này
        /// </summary>
        /// <returns></returns>
        public Prescription_DTO getValue(int rec_id)
        {
            return new Prescription_DTO(
                rec_id, med_id,
                Int32.Parse(txtSang.Text),
                Int32.Parse(txtTrua.Text),
                Int32.Parse(txtToi.Text),
                txtNote.Text);
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
                if(med_id == u.med_id)
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
                    this.med_id = med_id;
                    txtTen.Text = m.Med_name;
                    return;
                }

            // Mã thuốc chưa tồn tại trong Danh sách thuốc có sẵn

            frmAlert frmAlert2 = new frmAlert();
            frmAlert2.showAlert(
                "Mã thuốc chưa tồn tại.",
                frmAlert.enmType.Warning);

            UC_AddMedicine uc = new UC_AddMedicine(med_id);
            frmAdd f = new frmAdd("Thêm thuốc mới", uc);
            f.TopMost = true;
            f.ShowDialog();

            if (uc.med_name != "")
            {
                // Thêm thuốc vào database thành công
                txtTen.Text = uc.med_name;
            }

        }
    }
}
