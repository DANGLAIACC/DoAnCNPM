using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.UserControls;
using DTO;
using BLL;
using GUI.global;
using GUI.Reports;


namespace GUI.Forms
{
    public partial class frmAddRecord : Form
    {
        public static List<Medicine_DTO> lstMedicineSuggest =
            new List<Medicine_DTO>();

        public static List<Medicine_DTO> lstAllMedicine;

        public static List<Prescription_DTO> lstPrescription = new List<Prescription_DTO>();

        private List<ExamType_DTO> lstComboExamType;
        private Patient_DTO patient;

        public frmAddRecord(Patient_DTO patient)
        {
            InitializeComponent();
            lstAllMedicine = lstMedicineSuggest = Medicine_BLL.getMedicine();

            this.patient = patient;
            lblPat_id.Text = patient.Pat_id.ToString();
            lblPat_name.Text = patient.Pat_fullname;
        }
        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            loadCboExamType();
            addNewPrescription();
        }
        /// <summary>
        /// Dùng để refresh lại số thứ tự của thuốc sau khi xóa hoặc thêm
        /// Còn để xóa các thuốc ko hợp lệ
        /// </summary>
        public void refreshSerial()
        {
            int i = pnPrescritionItems.Controls.Count - 1;
            foreach (UC_PrescriptionItem u in pnPrescritionItems.Controls)
                u.lblSTT.Text = (i-- + 1).ToString("00");
        }

        private void loadCboExamType()
        {
            lstComboExamType = ExamType_BLL.getExamType();
            foreach (ExamType_DTO e in lstComboExamType)
                cboExamType.Items.Add(e);

            cboExamType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void addNewPrescription(UC_PrescriptionItem u)
        {
            u.Dock = DockStyle.Top;
            pnPrescritionItems.Controls.Add(u);

            u.BringToFront();
        }
        public void addNewPrescription()
        {
            UC_PrescriptionItem u = new UC_PrescriptionItem(this, pnPrescritionItems.Controls.Count + 1);

            u.Dock = DockStyle.Top;
            pnPrescritionItems.Controls.Add(u);

            u.BringToFront();

            // Thêm focus tự nhiên hiện 1 thông báo
            u.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xóa tất cả các phần thuốc đã liệt kê??", "Xác nhận nhập lại", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                pnPrescritionItems.Controls.Clear();
                addNewPrescription();

                cboExamType.SelectedIndex = 0;
                txtHospital.Text = txtRec_diagnostic.Text = txtRec_note.Text = "";
                txtRec_diagnostic.Focus();
            }
        }

        private void btnThem_Click(object sender,
            EventArgs e)
        {
            // Kiểm tra txt chẩn đoán không được trống
            if (txtRec_diagnostic.Text.Trim() == "")
            {
                MessageBox.Show("Kết quả chẩn đoán không được để trống, vui lòng nhập nội dung.", "Thêm bệnh án thất bại");
                txtRec_diagnostic.Text = "";
                txtRec_diagnostic.Focus();

                return;
            }

            ExamType_DTO a = (ExamType_DTO)cboExamType.SelectedItem;

            DialogResult result = MessageBox.Show("Phí khám bệnh: " + a.Exam_type_price, "Xác nhận thanh toán", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Record_DTO r = new Record_DTO(0, DateTime.Now, patient.Pat_id, List.curentDoctor.Doc_usr, txtRec_diagnostic.Text, txtHospital.Text, cboExamType.SelectedIndex, txtRec_note.Text);

                string rec_id = Record_BLL.addRecord(r);

                if (rec_id != "")
                {
                    frmAlert f = new frmAlert();
                    f.showAlert("Thêm bệnh án thành công", frmAlert.enmType.Success);
                }

                if (cboExamType.SelectedIndex == 0)
                {
                    List<Prescription_DTO> lst=new List<Prescription_DTO>();
                    // cboExamtype chọn 0 = có thêm đơn thuốc
                    foreach (UC_PrescriptionItem u in pnPrescritionItems.Controls)
                        if (u.isUcValid())
                        {
                            Prescription_BLL.addPrescription(rec_id, u.prescription);
                            lst.Add(u.prescription);
                            Console.WriteLine(lst[0].Med_name);
                        }

                    Hide();

                    frmReportPrescription f2 = new frmReportPrescription(rec_id, Function.getDatetime(DateTime.Now), txtRec_diagnostic.Text, patient.Pat_fullname, (DateTime.Now.Year - patient.Pat_dob.Year).ToString(), patient.Pat_address, patient.Pat_gender ? "Nam" : "Nữ", "BS CKII. "+List.curentDoctor.Doc_fullname.ToUpper(), lst);
                    f2.ShowDialog(this);

                    Close();
                }
            }

        }

        private void cboExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnPrescritionItems.Visible = (sender as ComboBox).SelectedIndex == 0;
        }
    }
}
