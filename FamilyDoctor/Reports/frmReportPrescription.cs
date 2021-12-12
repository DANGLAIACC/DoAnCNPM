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
        string Rec_id, Rec_date, Rec_diagnostic, Pat_fullname, Pat_age, Pat_address, Pat_gender, Doc_fullname;

        List<Prescription_DTO> lst;

        public frmReportPrescription(string Rec_id, string Rec_date, string Rec_diagnostic, string Pat_fullname, string Pat_age, string Pat_address, string Pat_gender, string Doc_fullname, List<Prescription_DTO> lst)
        {
            InitializeComponent(); 
            this.Rec_id = Rec_id;
            this.Rec_date = Rec_date;
            this.Rec_diagnostic = Rec_diagnostic;
            this.Pat_fullname = Pat_fullname;
            this.Pat_age = Pat_age;
            this.Pat_address = Pat_address;
            this.Pat_gender = Pat_gender;
            this.Doc_fullname = Doc_fullname;
            this.lst = lst;
        }

        private void frmReportPrescription_Load(object sender, EventArgs e)
        {
            Prescription p = new Prescription();

            CrystalReportViewer.ReportSource = p;

            p.SetDataSource(lst);

            p.SetParameterValue("Rec_id", Rec_id);
            p.SetParameterValue("Rec_date", Rec_date);
            p.SetParameterValue("Rec_diagnostic", Rec_diagnostic);
            p.SetParameterValue("Pat_fullname", Pat_fullname);
            p.SetParameterValue("Pat_age", Pat_age);
            p.SetParameterValue("Pat_address", Pat_address);
            p.SetParameterValue("Pat_gender", Pat_gender);
            p.SetParameterValue("Doc_fullname", Doc_fullname);
        }
    }
}
