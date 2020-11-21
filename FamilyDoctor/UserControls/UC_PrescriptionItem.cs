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
        }
        private void UC_PrescriptionItem_Load(object sender, EventArgs e)
        {
            txtTen.Focus();
            loadAutoCompleteMedName();
        }
        /// <summary>
        /// Lấy dữ liệu từ frmAddPrescription để làm data cho suggess textbox
        /// </summary>
        private void loadAutoCompleteMedName()
        {
            AutoCompleteStringCollection auto= new AutoCompleteStringCollection();
            foreach (Medicine_DTO m in frmAddPrescription.lstMedicine)
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
                //this.Parent.Controls.Add(this);
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
                in frmAddPrescription.lstMedicine)
                if (m.Med_name == txtTen.Text.Trim())
                    return m.Med_id;

            return "";
        }
        /// <summary>
        /// Trả về giá trị thuốc cần tìm
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
            /*
            - Kiểm tra, nếu mã thuốc đang tồn tại trong frmAddPrescription.lstMedicine 
             + kiểm tra mã thuốc đang tồn tại trong frmAddPrescription.lstPrescription thì thông báo là mã thuốc ko được trùng trong 1 toa thuốc
             + nếu ko tồn tại thì lưu mã thuốc vào med_id trong usercontrol này, chuyển giá trị textbox thành tên thuốc 

            - Nếu mã chưa tồn tại trong lstMedicine thì hiện hộp thoại thêm tên thuốc để add vào database, add vào lstMedicine, thay đổi med_id trong usercontrol này.
             */

            foreach (Medicine_DTO m in frmAddPrescription.lstMedicine)
            {
                string med_id = txtTen.Text.Trim();
                if (m.Med_id == med_id)
                {
                    foreach (Prescription_DTO p in frmAddPrescription.lstPrescription)
                    {
                        if(p.Med_id == med_id)
                        {
                            MessageBox.Show("Mã thuốc đã tồn tại trong đơn thuốc này.", "Thêm thất bại");
                            txtTen.Text = "";
                            txtTen.Focus();
                            return;
                        }
                    }

                    this.med_id = med_id;
                    txtTen.Text = m.Med_name;
                    return;
                }
            }
            // ra khỏi vòng lặp kiểm tra mà còn chạy chứng tỏ mã thuốc ko tồn tại trong lstMedicine
            if(med_id == "")
            {
                UC_AddMedicine uc = new UC_AddMedicine(txtTen.Text.Trim());
                frmAdd f = new frmAdd("Thêm thuốc mới",uc);

                if (uc.med_name != "")
                {
                    // Thêm thuốc vào database thành công
                    this.med_id = txtTen.Text.Trim();
                    txtTen.Text = uc.med_name;
                }
            }
        }
    }
}
