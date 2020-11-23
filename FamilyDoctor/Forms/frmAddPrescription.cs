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

namespace GUI.Forms
{
    public partial class frmAddPrescription: Form
    {
        //public List<Prescription_DTO> lstPrescription2 = new List<Prescription_DTO>();
        // lstMedicine phải public để các ucitem có thể đọc được điền vào suggest

        public static List<Medicine_DTO> lstMedicineSuggest = 
            new List<Medicine_DTO>();

        public static List<Medicine_DTO> lstAllMedicine;

        public static List<Prescription_DTO> lstPrescription = new List<Prescription_DTO>();

        public frmAddPrescription()
        {
            InitializeComponent();
            lstAllMedicine = lstMedicineSuggest = Medicine_BLL.getMedicine();
        }
        private void frmAddPrescription_Load(object sender, EventArgs e)
        {
            loadCboExamType();
            addNewPrescription(new UC_PrescriptionItem(this, lstPrescription.Count));
        }

        public void refreshPnPrescriptionItems()
        {
            int totalUC = pnPrescritionItems.Controls.Count;

            for(int i = 0; i < totalUC; i++)
            {
                UC_PrescriptionItem thisUC = (UC_PrescriptionItem)pnPrescritionItems.Controls[0];

                Prescription_DTO thisPre = thisUC.prescription;

                addNewPrescription(new UC_PrescriptionItem(this, i + 1, thisPre));
                //pnPrescritionItems.Controls.RemoveAt(0);
            }
        }

        private void loadCboExamType()
        {
            List<ExamType_DTO> lst = ExamType_BLL.getExamType();
            foreach (ExamType_DTO e in lst)
                cboExamType.Items.Add(e);

            cboExamType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addNewPrescription(UC_PrescriptionItem u)
        {
            u.Dock = DockStyle.Top;
            pnPrescritionItems.Controls.Add(u);
            pnPrescritionItems.Controls.SetChildIndex(u, pnPrescritionItems.Controls.Count);

            u.BringToFront();
        }
        public void addNewPrescription()
        {
            UC_PrescriptionItem u = new UC_PrescriptionItem(this, pnPrescritionItems.Controls.Count+1);

            u.Dock = DockStyle.Top;
            pnPrescritionItems.Controls.Add(u);
            pnPrescritionItems.Controls.SetChildIndex(u, pnPrescritionItems.Controls.Count);

            u.BringToFront();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Xóa tất cả các phần thuốc đã liệt kê??", "Xác nhận nhập lại", MessageBoxButtons.OKCancel);
            //if (result == DialogResult.OK)
            //{
            //    pnPrescritionItems.Controls.Clear();
            //    addNewPrescription(new UC_PrescriptionItem(this, lstPrescription.Count));

            //    cboExamType.SelectedIndex = 0;
            //    txtHospital.Text = txtRec_diagnostic.Text = txtRec_note.Text = "";
            //    txtRec_diagnostic.Focus();
            //}


            // ngày 23 tháng 11, thay thế bằng refresh để test sau khi xóa 1 item
            refreshPnPrescriptionItems();
        }

        private void btnThem_Click(object sender,
            EventArgs e)
        {
            if (txtRec_diagnostic.Text.Trim() == "")
            {
                MessageBox.Show("Kết quả chẩn đoán không được để trống, vui lòng nhập nội dung.", "Thêm bệnh án thất bại");
                txtRec_diagnostic.Text = "";
                txtRec_diagnostic.Focus();
            }
            else
            {
                ExamType_DTO a = (ExamType_DTO)cboExamType.SelectedItem;

                DialogResult result = MessageBox.Show("Phí khám bệnh: " + a.Exam_type_price, "Xác nhận thanh toán", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    //...
                }
            }


            UC_PrescriptionItem first 
                = (UC_PrescriptionItem) pnPrescritionItems.Controls[0];

            // Xử lý chuyển đơn thuốc sang mã thuốc, tạo mã thuốc mới nếu cần
            Console.WriteLine("Tên thuốc [0]: "+ first.getNameMedicine());
            
            if (first.getNameMedicine() != "")
            {
                foreach(UC_PrescriptionItem u in pnPrescritionItems.Controls)
                {
                    //u.getValue();
                }
            }
            else
            {
                MessageBox.Show("Chưa thêm tên thuốc và hướng dẫn sử dụng.", "Thêm thất bại");
            }

            
            foreach(UC_PrescriptionItem u in pnPrescritionItems.Controls)
            {
                //if (u.isUcValid())
                //{
                //    lstResult.Add(u.getValue(1234,getMedIdByName());
                //}
            }


        }
        /// <summary>
        /// Tìm kiếm mã thuốc thông qua tên thuốc
        /// </summary>
        /// <param name="med_name">Tên thuốc</param>
        /// <returns></returns>
        private string getMedIdByName(string med_name)
        {
            foreach(Medicine_DTO m in lstMedicineSuggest)
                if(m.Med_name == med_name)
                    return m.Med_id;
            return "";
        }

        private void cboExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnPrescritionItems.Visible = (sender as ComboBox).Text == "Có kê toa";
        }
    }
}
