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

namespace GUI.UserControls
{
    public partial class UC_Examination : UserControl
    {
        private List<Examination_DTO> lstExamination = new List<Examination_DTO>();
        public UC_Examination()
        {
            InitializeComponent();
        }
        private void UC_Examination_Load(object sender, EventArgs e)
        {
            if (lstExamination.Count == 0)
                lstExamination = Examination_BLL.getExamination();

            loadLstExaminationToGrv(lstExamination);

            grvLstExamination.Columns[0].Width = grvLstExamination.Columns[1].Width = 100;
        }
        private void loadLstExaminationToGrv(List<Examination_DTO> lst)
        {
            grvLstExamination.Rows.Clear();
            foreach (Examination_DTO m in lst)
            {
                grvLstExamination.Rows.Add(m.ToArrString());
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                loadLstExaminationToGrv(lstExamination);
            else
            {
                grvLstExamination.Rows.Clear();
                // filter by ID
                string filter = txtFilter.Text.Trim();
                foreach (Examination_DTO m in lstExamination)
                    if (m.Rec_id.ToString().IndexOf(filter) > -1)
                        grvLstExamination.Rows.Add(m.ToArrString());
            }
        }

        private void grvLstExamination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Examination_DTO e2 = lstExamination[e.RowIndex];
            lblDoc_name.Text = e2.Doc_fullname;
            lblPat_name.Text = e2.Pat_fullname;
            lblRec_date.Text = e2.Rec_date.ToString("hh:mm:ss dd/MM/yyyy");
            lblRec_place.Text = e2.Exa_place;
        }
        private void grvLstThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Examination_DTO exa = lstExamination[e.RowIndex];
            frmExaminationResult f = new frmExaminationResult(exa);

            f.ShowDialog(this);
        }
    }
}
