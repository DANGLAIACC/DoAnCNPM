using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Reports
{
    public partial class frmReportGioiThieuNhapVien : Form
    {
        public frmReportGioiThieuNhapVien(string Rec_date, string Rec_id, string Hospital, string Pat_fullname, string Pat_age, string Pat_address, string Pat_gender, string BieuHien, string Rec_diagnostic, string ThuocDangDung, string LyDo, string Rec_time, string Doc_fullname)
        {
            InitializeComponent();

            rpt.SetParameterValue("Rec_date", Rec_date);
            rpt.SetParameterValue("Rec_id", Rec_id);
            rpt.SetParameterValue("Hospital", Hospital);
            rpt.SetParameterValue("Pat_fullname", Pat_fullname);
            rpt.SetParameterValue("Pat_age", Pat_age);
            rpt.SetParameterValue("Pat_address", Pat_address);
            rpt.SetParameterValue("Pat_gender", Pat_gender);
            rpt.SetParameterValue("BieuHien", BieuHien);
            rpt.SetParameterValue("Rec_diagnostic", Rec_diagnostic);
            rpt.SetParameterValue("ThuocDangDung", ThuocDangDung);
            rpt.SetParameterValue("LyDo", LyDo);
            rpt.SetParameterValue("Rec_time", Rec_time);
            rpt.SetParameterValue("Doc_fullname", Doc_fullname);
        }
    }
}
