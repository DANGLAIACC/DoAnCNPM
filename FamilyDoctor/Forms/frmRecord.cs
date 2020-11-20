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

namespace GUI.Forms
{
    public partial class frmRecord : Form
    { 
        private Patient_DTO patient;
        public frmRecord(Patient_DTO patient)
        {
            InitializeComponent();
            this.patient = patient;
        }

        private void frmRecord_Load(object sender, EventArgs e)
        {
            grvLstRecord.Columns[0].Width = 150;
            grvLstRecord.Columns[1].Width = 250;
            grvLstRecord.Columns[2].Width = 250;

            lblName.Text = patient.Pat_fullname;
            lblAge.Text = (DateTime.Now.Year - patient.Pat_dob.Year).ToString();
            lblGender.Text = patient.Pat_gender.ToString();
            lblPhone.Text = patient.Pat_phone1;

            List<Record_DTO> lstRecord = Record_BLL.getRecordByPatId(patient.Pat_id);
            if(lstRecord!=null)
                foreach (Record_DTO r in lstRecord)
                {
                    grvLstRecord.Rows.Add(new string[] {
                        r.Rec_id.ToString(),
                        r.Rec_date.ToString("HH:mm:ss dd/MM/yyyy"),
                        r.Doc_fullname,
                        r.Rec_diagnostic
                    });
                }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
