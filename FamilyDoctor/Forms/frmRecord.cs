using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Reports;

namespace GUI.Forms
{
    public partial class frmRecord : Form
    {
        private Patient_DTO patient;
        private List<Record_DTO> lstRecord;
        public frmRecord(Patient_DTO patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            lblTitle.Text = "Xem hồ sơ bệnh án số " + patient.Pat_id;

            grvLstRecord.Columns[0].Width = 150;
            grvLstRecord.Columns[1].Width = 250;
            grvLstRecord.Columns[2].Width = 250;

            lblName.Text = patient.Pat_fullname;
            lblAge.Text = (DateTime.Now.Year - patient.Pat_dob.Year).ToString();
            lblPhone.Text = patient.Pat_phone1;

            lstRecord = Record_BLL.getRecordByPatId(patient.Pat_id);
            if (lstRecord != null && lstRecord.Count>0)
            {
                foreach (Record_DTO r in lstRecord)
                    grvLstRecord.Rows.Add(r.ToArrayString());

                // Chọn dòng thứ 0 ngay khi load
                grvLstRecord.Rows[0].Selected = true;
                grvLstRecord_CellClick(sender, new DataGridViewCellEventArgs(0, 0));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemBenhAn_Click(object sender, EventArgs e)
        {
            frmAddRecord f = new frmAddRecord(patient.Pat_id, patient.Pat_fullname);
            f.ShowDialog();
        }

        private void grvLstRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string exa_result = lstRecord[e.RowIndex].Exa_result;
            if (exa_result == null)
                lblExa_result.Text = "Không yêu cầu xét nghiệm";
            else
                lblExa_result.Text = exa_result == "" ? "Đang đợi kết quả xét nghiệm" : exa_result;
        }

        private void lblExa_result_DoubleClick(object sender, EventArgs e)
        {
            // chặn trường hợp mới đầu nhấn ko có text
            if (lblExa_result.Text == "Không yêu cầu xét nghiệm")
            {
                frmAlert f1 = new frmAlert();
                f1.showAlert("Không yêu cầu kết quả xét nghiệm.", frmAlert.enmType.Error);
            }
            else
            {
                string rec_id = grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[0].Value.ToString().Substring(0,6);
                frmExaminationResult f2 = new frmExaminationResult(rec_id);
                f2.ShowDialog();

                Examination_DTO e1 = Examination_BLL.getExaminationDetailById(rec_id);
                lblExa_result.Text = e1.Exa_result == "" ? "Đang đợi kết quả xét nghiệm" : e1.Exa_result;

            }
        }

        private void grvLstRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[0].Value.ToString().Substring(0, 6));

            frmReportPrescription f = new frmReportPrescription(
                grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[0].Value.ToString().Substring(0, 6),
                grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[1].Value.ToString(),
                grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[3].Value.ToString(),
                lblName.Text,
                lblAge.Text,
                "Địa chỉ tạm",
                "Giới tính",
                grvLstRecord.Rows[grvLstRecord.CurrentCell.RowIndex].Cells[2].Value.ToString()
                );
            f.ShowDialog();
        }
    }
}
