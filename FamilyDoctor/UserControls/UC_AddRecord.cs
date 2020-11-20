using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.global;
using DTO;
using BLL;

namespace GUI.UserControls
{
    public partial class UC_AddRecord : UserControl
    {
        public UC_AddRecord(int pat_id, string pat_name)
        {
            InitializeComponent();

            txtPat_id.Text = pat_id.ToString();
            txtBenhNhan.Text = pat_name;
        }

        private void UC_AddRecord_Load(object sender, EventArgs e)
        {
            txtBacSi.Text = GlobalVariable.curentDoctor.Doc_fullname;

            txtDiagnostic.Focus();

            loadCboExamType();
        }
        private void loadCboExamType()
        {
            List<ExamType_DTO> lst = ExamType_BLL.getExamType();
            foreach(ExamType_DTO e in lst)
                cboExamType.Items.Add(e);

            cboExamType.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtDiagnostic.Text.Trim() == "")
            {
                MessageBox.Show("Kết quả chẩn đoán không được để trống, vui lòng nhập nội dung.", "Thêm bệnh án thất bại");
                txtDiagnostic.Text = "";
                txtDiagnostic.Focus();
            }
            else
            {
                ExamType_DTO a = (ExamType_DTO)cboExamType.SelectedItem;
                
                DialogResult result = MessageBox.Show("Phí khám bệnh: "+ a.Exam_type_price, "Xác nhận thanh toán", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    //...
                }
            }
        }
    }
}
