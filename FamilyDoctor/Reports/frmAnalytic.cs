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

namespace GUI.Reports
{
    public partial class frmAnalytic : Form
    {
        string Doc_fullname, Pat_fullname, Rec_date, Start, End;
        List<Prescription_DTO> lst;

        public frmAnalytic(string Doc_fullname, string Pat_fullname, string Rec_date, string Start, string End, List<Prescription_DTO> lst)
        {
            InitializeComponent();

            this.Doc_fullname = Doc_fullname;
            this.Pat_fullname = Pat_fullname;
            this.Rec_date = Rec_date;
            this.Start = Start;
            this.End = End;

            this.lst = lst;
        }

        private void frmReportPrescription_Load(object sender, EventArgs e)
        {
            Analytic p = new Analytic();

            CrystalReportViewer.ReportSource = p;

            p.SetDataSource(lst);

            p.SetParameterValue("Doc_fullname", Doc_fullname);
            p.SetParameterValue("Pat_fullname", Pat_fullname);
            p.SetParameterValue("Rec_date", Rec_date);
            p.SetParameterValue("Start", Start);
            p.SetParameterValue("End", End);
        }
    }
}
