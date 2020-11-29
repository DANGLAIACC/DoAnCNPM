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
    public partial class UC_Patient : UserControl
    {
        public UC_Patient()
        {
            InitializeComponent();

            grvLstBenhNhan.Columns[0].FillWeight = 40;
             
            grvLstBenhNhan.Columns[2].Width =
                grvLstBenhNhan.Columns[3].Width =
                grvLstBenhNhan.Columns[4].Width = 80; 
        }
        private void UC_Patient_Load(object sender, EventArgs e)
        {
            List.lstPatient = Patient_BLL.getPatient();

            loadLstPatientToGrv(List.lstPatient);
        }
        private void loadLstPatientToGrv(List<Patient_DTO> lst)
        {
            grvLstBenhNhan.Rows.Clear();
            foreach (Patient_DTO p in lst)
            {
                grvLstBenhNhan.Rows.Add(p.ToArrString());
            }
        }

        private void grvLstBenhNhan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmRecord f = new frmRecord(List.lstPatient[e.RowIndex]);
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            UC_AddPatient u = new UC_AddPatient(List.lstPatient[List.lstPatient.Count - 1].Pat_id + 1);
            frmAdd f = new frmAdd("Thêm bệnh nhân mới", u);
            f.ShowDialog();

            if (u.p != null)
            {
                List.lstPatient.Add(u.p);
                loadLstPatientToGrv(List.lstPatient);
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text == "")
                loadLstPatientToGrv(List.lstPatient);
            else
            {
                grvLstBenhNhan.Rows.Clear();

                if (btnTra.Text == "Tra theo tên")
                {
                    // filter by ID
                    foreach (Patient_DTO p in List.lstPatient)
                        if (p.Pat_id.ToString().IndexOf(txtFilter.Text) > -1)
                            grvLstBenhNhan.Rows.Add(p.ToArrString());
                }
                else
                {
                    // filter by name
                    foreach (Patient_DTO p in List.lstPatient)
                        if (p.Pat_fullname.ToLower().IndexOf(txtFilter.Text.ToLower()) > -1)
                            grvLstBenhNhan.Rows.Add(p.ToArrString());
                }
            }
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";

            if (btnTra.Text == "Tra theo tên")
            {
                txtFilter.PlaceholderText = "Nhập tên cần tìm";
                btnTra.Text = "Tra Mã Hồ sơ";
                txtFilter.Focus();
            }
            else
            {
                txtFilter.PlaceholderText = "Nhập mã bệnh nhân";
                btnTra.Text = "Tra theo tên";
                txtFilter.Focus();
            }
        }

    }
}
