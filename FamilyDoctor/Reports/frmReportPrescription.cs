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

namespace GUI.Reports
{
    public partial class frmReportPrescription : Form
    {
        Prescription p;
        string Rec_id;
        public frmReportPrescription(string Rec_id, string Rec_date, string Rec_diagnostic, string Pat_fullname, string Pat_age, string Pat_address, string Pat_gender, string Doc_fullname)
        {
            InitializeComponent();
            this.Rec_id = Rec_id;
            p = new Prescription();

            p.SetParameterValue("Rec_id", Rec_id);
            p.SetParameterValue("Rec_date", Rec_date);
            p.SetParameterValue("Rec_diagnostic", Rec_diagnostic);
            p.SetParameterValue("Pat_fullname", Pat_fullname);
            p.SetParameterValue("Pat_age", Pat_age);
            p.SetParameterValue("Pat_address", Pat_address);
            p.SetParameterValue("Pat_gender", Pat_gender);
            p.SetParameterValue("Doc_fullname", Doc_fullname);

            CrystalReport.ReportSource = p;
        }

        private void frmReportPrescription_Load(object sender, EventArgs e)
        {
            List<Prescription_DTO> lst 
                = Prescription_BLL.getPrescriptionByRecId(Int32.Parse(Rec_id));

            p.SetDataSource(lst);
        }
    }
}
