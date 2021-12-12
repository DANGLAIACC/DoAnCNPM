using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.global;
using GUI.Forms;
using GUI.Reports;

namespace GUI.UserControls
{
    public partial class UC_Analytic : UserControl
    {
        List<DTO.Analytic_DTO> lst = new List<DTO.Analytic_DTO>();
        public UC_Analytic()
        {
            InitializeComponent();
        }

        private void UC_Analytic_Load(object sender, EventArgs e)
        {
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            dtpStart.MaxDate = DateTime.Now;
            dtpEnd.MaxDate = DateTime.Now;
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được nhỏ hơn ngày kết thúc.", "Lỗi lọc data");
                return;
            }
            grvLstRecord.Rows.Clear();
            lst = Record_BLL.getRecordByDate(List.curentDoctor.Doc_usr, dtpStart.Value.ToString("MM/dd/yyyy"), dtpEnd.Value.ToString("MM/dd/yyyy"));

            if(lst != null)
                foreach (DTO.Analytic_DTO a in lst)
                    grvLstRecord.Rows.Add(new string[] {
                        a.Rec_id,
                        a.Pat_fullname,
                        a.Rec_date,
                        a.Exam_type_price.ToString("#,##0")
                    }); 
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (lst.Count == 0)
            {
                frmAlert f1 = new frmAlert();
                f1.showAlert("Không có bệnh án nào", frmAlert.enmType.Warning);
                return;
            }
            
            frmAnalytic f = new frmAnalytic(List.curentDoctor.Doc_fullname.ToUpper(),
                Function.getDatetime(DateTime.Now),
                dtpStart.Value.ToString("dd/MM/yyyy"), dtpEnd.Value.ToString("dd/MM/yyyy"), lst);
            f.Show();
        }
    }
}
