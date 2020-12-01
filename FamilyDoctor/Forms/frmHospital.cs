using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.global;
using GUI.Reports;

namespace GUI.Forms
{
    public partial class frmHospital : Form
    {
        private Record_DTO record;
        private Patient_DTO patient;
        
        public frmHospital(Record_DTO record)
        {
            InitializeComponent();
            this.record = record; 

            lblHospital.Text = record.Hospital;
        }
        private void frmHospital_Load(object sender, EventArgs e)
        {
            patient = Patient_BLL.getPatientByRecId(record.Rec_id.ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(txtBieuHien.Text.Trim()=="" || txtChanDoan.Text.Trim() == "" || txtLyDo.Text.Trim() == "" || txtThuocDangDung.Text.Trim() == "")
            {
                frmAlert f = new frmAlert();
                f.showAlert("Các trường không được trống", frmAlert.enmType.Error);

                return;
            }
            Hide();

            frmReportGioiThieuNhapVien f2 = new frmReportGioiThieuNhapVien(Function.getDatetime(record.Rec_date), record.Rec_id.ToString(), record.Hospital, patient.Pat_fullname, (DateTime.Now.Year - patient.Pat_dob.Year).ToString(), patient.Pat_address, patient.Pat_gender?"Nam":"Nữ", txtBieuHien.Text, txtChanDoan.Text, "Không", txtLyDo.Text, DateTime.Now.ToString("hh:mm:ss dd/MM/yyyy"), "Bác sĩ CKII. "+List.curentDoctor.Doc_fullname.ToUpper());
            f2.ShowDialog();
            Close();
        }

    }
}
