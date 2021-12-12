using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.global;

namespace GUI.Reports
{
    public partial class frmAnalytic : Form
    {
        string Doc_fullname, Rec_date, Start, End;
        List<DTO.Analytic_DTO> lst;

        public frmAnalytic(string Doc_fullname, string Rec_date, string Start, string End, List<DTO.Analytic_DTO> lst)
        {
            InitializeComponent();

            this.Doc_fullname = Doc_fullname; 
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
            double tong = 0;
            foreach(DTO.Analytic_DTO a in lst)
                tong += a.Exam_type_price;

            p.SetParameterValue("Doc_fullname", Doc_fullname); 
            p.SetParameterValue("Rec_date", Rec_date);
            p.SetParameterValue("Start", Start);
            p.SetParameterValue("End", End);
            p.SetParameterValue("SumPrice", tong.ToString("#,##0"));

            Function f = new Function();
            string text = f.ConvertMoney2Text(tong);

            p.SetParameterValue("SumPriceText", char.ToUpper(text[1])+text.Substring(2));
            p.SetParameterValue("CountRec_id", lst.Count.ToString("#,##0"));

        }
    }
}
