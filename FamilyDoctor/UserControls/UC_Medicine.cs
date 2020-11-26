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
    public partial class UC_Medicine : UserControl
    {
        private List<Medicine_DTO> lstMedicine = new List<Medicine_DTO>();
        public UC_Medicine()
        {
            InitializeComponent();
        }

        private void UC_Medicine_Load(object sender, EventArgs e)
        {
            if (lstMedicine.Count == 0)
                lstMedicine = Medicine_BLL.getMedicine();

            loadLstMedicineToGrv(lstMedicine);

            grvLstThuoc.Columns[0].Width = 100;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            UC_AddMedicine u = new UC_AddMedicine("", "");
            frmAdd f = new frmAdd("Thêm thuốc mới", u);
            f.ShowDialog();

            if (u.m.Med_name != "")
            {
                lstMedicine.Add(u.m);
                grvLstThuoc.Rows.Add(u.m.ToArrString());
            }
        }

        private void loadLstMedicineToGrv(List<Medicine_DTO> lst)
        {
            grvLstThuoc.Rows.Clear();
            foreach (Medicine_DTO m in lst)
            {
                grvLstThuoc.Rows.Add(m.ToArrString());
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                loadLstMedicineToGrv(lstMedicine);
            else
            {
                grvLstThuoc.Rows.Clear();
                // filter by ID
                string filter = txtFilter.Text.Trim();
                foreach (Medicine_DTO m in lstMedicine)
                    if (m.Med_id.IndexOf(filter) > -1 || m.Med_name.IndexOf(filter) > -1)
                        grvLstThuoc.Rows.Add(m.ToArrString());

            }
        }

        private void grvLstThuoc_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // double click vào chỉ có sửa thuốc chứ ko thêm thuốc
            string oldMed_name = lstMedicine[e.RowIndex].Med_name;
            UC_AddMedicine u = new UC_AddMedicine(lstMedicine[e.RowIndex].Med_id, oldMed_name);

            frmAdd f = new frmAdd("Sửa thuốc", u);
            f.ShowDialog();

            // cập nhật lại tên thuốc ở lst và gridview
            if (u.m.Med_name != oldMed_name)
            {
                lstMedicine[e.RowIndex].Med_name = u.m.Med_name;
                grvLstThuoc.Rows[e.RowIndex].Cells[1].Value = u.m.Med_name;
            }
        }
    }
}
